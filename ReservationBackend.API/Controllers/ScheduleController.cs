using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReservationBackend.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReservationBackend.API.Models;
namespace ReservationBackend.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScheduleController : ControllerBase
    {
      

        private readonly ILogger<ScheduleController> _logger;
        private readonly IScheduleService _scheduleService;

        public ScheduleController(ILogger<ScheduleController> logger, IScheduleService scheduleService)
        {
            _logger = logger;
            _scheduleService = scheduleService;
        }


        [HttpPost]
        public ActionResult AddSchedule([FromBody] Schedule schedule)
        {

            return Ok(_scheduleService.AddSchedule(schedule.ProviderId, schedule.StartTime, schedule.EndTime));
        }


        [HttpGet]
        public ActionResult ListFreeTimeSlots()
        {

            return Ok(_scheduleService.ListFreeTimeSlots());
        }

        [HttpPut("{id}")]
        public ActionResult ReserveTimeSlot(int id)
        {
            _scheduleService.ReserveTimeSlot(id);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult ConfirmTimeSlot(int id)
        {
            _scheduleService.ConfirmTimeSlot(id);
            return Ok();
        }
    }
}
