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
    /// Represent schedule vessel service.
    /// </summary>
    public class ScheduleVesselService : IScheduleVesselService
    {
        #region Fields
        private readonly ScheduleContext _scheduleContext;
        #endregion

        #region Ctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="scheduleContext"></param>
        public ScheduleVesselService(ScheduleContext scheduleContext) 
        {
            _scheduleContext = scheduleContext;
        }
        #endregion

        #region Methods
        ///<inheritdoc/>
        public void CreateScheduleVessel(ScheduleVessel scheduleVessel)
        {
            if (scheduleVessel is null) throw new Exception("Schedule vessel hasn't set");
            _scheduleContext.ScheduleVessels.Add(scheduleVessel);
            _scheduleContext.SaveChanges();
        }

        ///<inheritdoc/>
        public ScheduleVessel GetScheduleVessel(int id)
        {
            if (id == 0) throw new Exception("Invalid schedule vessel id");
            var scheduleVessel =_scheduleContext.ScheduleVessels.FirstOrDefault(Schedule => Schedule.Id == id);
            if(scheduleVessel is null) throw new Exception("Invalid schedule vessel");
            return scheduleVessel;
        }

        ///<inheritdoc/>
        public IEnumerable<ScheduleVessel> GetScheduleVessels()
        {
            var scheduleVessels = _scheduleContext.ScheduleVessels.ToList();
            if (scheduleVessels is null) throw new Exception("There are no schedule vessels");
            return scheduleVessels;
        }

        ///<inheritdoc/>
        public void UpdateScheduleVessel(ScheduleVessel scheduleVessel)
        {
            if (scheduleVessel is null) throw new Exception("Schedule vessel hasn't set");
            _scheduleContext.ScheduleVessels.Update(scheduleVessel);
            _scheduleContext.SaveChanges();
        }
        #endregion
    }
}
