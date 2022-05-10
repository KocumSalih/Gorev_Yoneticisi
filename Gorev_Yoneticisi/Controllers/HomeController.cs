
using AutoMapper;
using Gorev_Yoneticisi.Models.Dal.Context;
using Gorev_Yoneticisi.Models.Dto;
using Gorev_Yoneticisi.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Gorev_Yoneticisi.Controllers
{
    public class HomeController : Controller
    {
        private Context _context;
        private IMapper _mapper;
        public HomeController(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetEvents()
        {
            var events = _context.Events.ToList();
            return Json(events);
        }
        [HttpPost]
        public JsonResult SaveEvent(EventViewDto e)
        {
            var status=false;
            if (e.EventId > 0)
            {
                var gorev = _context.Events.Where(t0=>t0.EventId==e.EventId).FirstOrDefault();
                if (gorev!=null)
                {
                    gorev.Title = e.Title;
                    gorev.Description = e.Description;
                    gorev.Start = e.Start;
                    gorev.End = e.End;
                    gorev.Color = e.Color;

                    _context.SaveChanges();
                    status = true;
                }
            }
            else
            {
                var myevent = _mapper.Map<Event>(e);
                _context.Events.Add(myevent);
                _context.SaveChanges();
                status = true;
            }
            return Json(new {isOk=status,View=e.View,Date=e.Date });
        }
        [HttpPost]
        public JsonResult DeleteEvent(IdViewDateDto idViewDto)
        {
            var status = false;
            var v = _context.Events.Where(a => a.EventId == idViewDto.Id).FirstOrDefault();
            if (v != null)
            {
                _context.Events.Remove(v);
                _context.SaveChanges();
                status = true;
            }
            return Json(new {isOk=status,View=idViewDto.View,Date=idViewDto.Date});
        }
    }
}
