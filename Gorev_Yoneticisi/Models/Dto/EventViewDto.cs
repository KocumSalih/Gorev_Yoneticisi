using System;

namespace Gorev_Yoneticisi.Models.Dto
{
    public class EventViewDto
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public string Color { get; set; }
        public string View { get; set; }
        public string Date { get; set; }
    }
}
