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
    /// Represent schedule freight service.
    /// </summary>
    public class ScheduleFreightService : IScheduleFreightService
    {
        #region Fields
        private readonly ScheduleContext _scheduleContext;
        #endregion

        #region Ctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="scheduleContext"></param>
        public ScheduleFreightService(ScheduleContext scheduleContext)
        {
            _scheduleContext = scheduleContext;
        }
        #endregion

        #region Methods
        ///<inheritdoc/>
        public void CreateScheduleFreight(ScheduleFreight scheduleFreight)
        {
            if (scheduleFreight is null) throw new Exception("Schedule freight hasn't set");
            _scheduleContext.ScheduleFreights.Add(scheduleFreight);
            _scheduleContext.SaveChanges();
        }

        ///<inheritdoc/>
        public ScheduleFreight GetScheduleFreight(int id)
        {
            if (id == 0) throw new Exception("Invalid schedule freight id");
            var scheduleFreight = _scheduleContext.ScheduleFreights.FirstOrDefault(schedule => schedule.Id == id);
            if (scheduleFreight is null) throw new Exception("Invalid Schedule freight");
            return scheduleFreight;
        }

        ///<inheritdoc/>
        public IEnumerable<ScheduleFreight> GetScheduleFreights()
        {
            var scheduleFreights = _scheduleContext.ScheduleFreights.ToList();
            if (scheduleFreights is null) throw new Exception("There no are schedule freight active");
            return scheduleFreights;
        }

        ///<inheritdoc/>
        public void UpdateScheduleFreight(ScheduleFreight scheduleFreight)
        {
            if (scheduleFreight is null) throw new Exception("Schedule freight hasn't set");
            _scheduleContext.ScheduleFreights.Update(scheduleFreight);
            _scheduleContext.SaveChanges();
        }
        #endregion
    }
}
