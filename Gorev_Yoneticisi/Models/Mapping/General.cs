using AutoMapper;
using Gorev_Yoneticisi.Models.Dto;
using Gorev_Yoneticisi.Models.Entities;

namespace Gorev_Yoneticisi.Models.Mapping
{
    public class General:Profile
    {
        public General()
        {
            CreateMap<EventViewDto, Event>();
            CreateMap<Event, EventViewDto>();
        }
    }
}
