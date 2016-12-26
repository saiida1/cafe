using System;
using cafe.Server.Scheduling;
using cafe.Shared;
using Microsoft.AspNetCore.Mvc;

namespace cafe.Server.Controllers
{
    [Route("api/[controller]")]
    public class SchedulerController : Controller
    {
        private readonly Scheduler _scheduler = StructureMapResolver.Container.GetInstance<Scheduler>();

        [HttpGet("status")]
        public SchedulerStatus GetStatus()
        {
            return _scheduler.CurrentStatus;
        }

        [HttpPut("pause")]
        public void Pause()
        {
            _scheduler.Pause();
        }
    }
}