﻿using API.DTOs.User.GetUser;

namespace API.DTOs.Event.UpdateEvent
{
    public class UpdateEventResponse
    {
        public UpdateEventResponse(Data.Entities.Event request)
        {
            EventName = request.EventName;
            EventDescription = request.EventDescription;
            FirstClosingDate = request.FirstClosingDate.ToString("dd/MM/yyyy");
            LastClosingDate = request.LastClosingDate.ToString("dd/MM/yyyy");
            UserName = request.User.UserName;
            Faculty = request.User.Faculty;
        }

        public string EventName { get; set; }

        public string EventDescription { get; set; }

        public string FirstClosingDate { get; set; }

        public string LastClosingDate { get; set; }

        public string UserName { get; set; }

        public string Faculty { get; set; }
    }
}
