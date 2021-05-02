using PopApp.Core.Entities.schedule;
using PopApp.Data.Context;
using PopApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PopApp.Data.Services
{
    /// <summary>
    /// Represent schedule container service.
    /// </summary>
    public class ScheduleContainerService : IScheduleContainerService
    {
        #region Fields
        private readonly ScheduleContext _scheduleContext;
        #endregion

        #region Ctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="scheduleContext"></param>
        public ScheduleContainerService(ScheduleContext scheduleContext)
        {
            _scheduleContext = scheduleContext;
        }
        #endregion

        #region Methods
        ///<inheritdoc/>
        public void CreateScheduleContainer(ScheduleContainer scheduleContainer)
        {
            if (scheduleContainer is null) throw new Exception("Schedule container hasn't set");
            _scheduleContext.ScheduleContainers.Add(scheduleContainer);
            _scheduleContext.SaveChanges();
        }

        ///<inheritdoc/>
        public ScheduleContainer GetScheduleContainer(int id)
        {
            if (id == 0) throw new Exception("ScheduleContainer identifier invalid");
            var scheduleContainer = _scheduleContext.ScheduleContainers.FirstOrDefault(schedule => schedule.Id == id);
            if (scheduleContainer is null) throw new Exception("ScheduleContainer invalid");
            return scheduleContainer;
        }

        ///<inheritdoc/>
        public IEnumerable<ScheduleContainer> GetScheduleContainers()
        {
            var scheduleContainers = _scheduleContext.ScheduleContainers.ToList();
            if (scheduleContainers is null) throw new Exception("There no are schedule container active");
            return scheduleContainers;
        }

        ///<inheritdoc/>
        public void UpdateSchedule(ScheduleContainer scheduleContainer)
        {
            if (scheduleContainer is null) throw new Exception("Schedule container hasn't set");
            _scheduleContext.ScheduleContainers.Update(scheduleContainer);
            _scheduleContext.SaveChanges();
        }
        #endregion
    }
}
