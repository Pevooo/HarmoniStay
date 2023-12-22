using MainProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Security.Policy;

namespace MainProject.Pages
{
    public class EditEventModel : PageModel
    {
        public List<Facility> Facilities { set; get; }
        private readonly Context db;
        public EditEventModel(Context db)
        {
            this.db = db;
            Facilities = new List<Facility>();
           

        }
        public string EventName { get; set; }
        public string EventType { get; set; }
        public int EventId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        Facility fac { get; set; }
        string FacilityName { get; set; }
        public double fee { get; set; }
        public string Message { get; set; }
        public bool Error { get; set; }
        public Event curr {  get; set; }
        public void OnGet(int id)
        {
            if (HttpContext.Session.GetString("UserId") is null)
            {
                Response.Redirect("/", false, true);
                return;
            }
            var eventToEdit = db.Events.FirstOrDefault(x => x.EventID == id);
            curr = eventToEdit;
            Facilities=db.Facilities.ToList();
            EventName = eventToEdit.EventName;
            EventId = eventToEdit.EventID;
            EventType = eventToEdit.EventType;
            StartDate = eventToEdit.EventStart;
            EndDate = eventToEdit.EventEnd;
            fee = eventToEdit.EventFee;
            fac = eventToEdit.EventFacility;

        }
        public IActionResult OnPost(int id)
        {
            try
            {
                
                var eventToEdit = db.Events.FirstOrDefault(x => x.EventID == id);

                EventName = Request.Form["EventName"];
                StartDate = DateTime.Parse(Request.Form["startDate"]);
                EndDate = DateTime.Parse(Request.Form["endDate"]);
                EventType = Request.Form["EventType"];
                fee = double.Parse(Request.Form["EventFee"]);
                FacilityName = Request.Form["Facility"];
                var facilityId = db.Facilities.Where(x => x.FacilityName == FacilityName);
                fac = facilityId.FirstOrDefault();

                if (EndDate < StartDate)
                {
                    Error = true;
                    Message = "Invalid Dates";

                }
                else
                {
                    var invalidEvent = db.Events.Any(ev => StartDate < ev.EventEnd && EndDate > ev.EventStart);
                    if (!invalidEvent)
                    {
                        eventToEdit.EventName = EventName;
                        eventToEdit.EventStart = StartDate;
                        eventToEdit.EventEnd = EndDate;
                        eventToEdit.EventType = EventType;
                        eventToEdit.EventID = id;
                        eventToEdit.EventFee = fee;
                        eventToEdit.EventFacility = fac;
                        db.SaveChanges();
                    }
                    else
                    {
                        Error = true;
                        Message = $"Event edited";
                    }

                }
            }
            catch
            {
                Error = true;
            }

            return RedirectToPage("/Events");

        }
    }
}