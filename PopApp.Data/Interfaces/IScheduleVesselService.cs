using PopApp.Core.Entities.schedule;
using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Data.Interfaces
{
    /// <summary>
    /// Represent schedule vessel service.
    /// </summary>
    public interface IScheduleVesselService
    {
        /// <summary>
        /// Get all schedule vessel.
        /// </summary>
        /// <returns>List schedule vessel.</returns>
        IEnumerable<ScheduleVessel> GetScheduleVessels();
        /// <summary>
        /// Get schedule vessel.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A schedule vessel.</returns>
        ScheduleVessel GetScheduleVessel(int id);
        /// <summary>
        /// Create schedule vessel.
        /// </summary>
        /// <param name="scheduleVessel"></param>
        void CreateScheduleVessel(ScheduleVessel scheduleVessel);
        /// <summary>
        /// Update vessel schedule.
        /// </summary>
        /// <param name="scheduleVessel"></param>
        void UpdateScheduleVessel(ScheduleVessel scheduleVessel);
    }
}
