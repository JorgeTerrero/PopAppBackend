using PopApp.Core.Entities.schedule;
using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Data.Interfaces
{
    /// <summary>
    /// Represent schedule freight.
    /// </summary>
    public interface IScheduleFreightService
    {
        /// <summary>
        /// Get all schedule freights
        /// </summary>
        /// <returns>List of schedule freight</returns>
        IEnumerable<ScheduleFreight> GetScheduleFreights();
        /// <summary>
        /// Get schedule freight
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A schedule freight</returns>
        ScheduleFreight GetScheduleFreight(int id);
        /// <summary>
        /// Create a schedule freight.
        /// </summary>
        /// <param name="scheduleFreight"></param>
        void CreateScheduleFreight(ScheduleFreight scheduleFreight);
        /// <summary>
        /// Update a schedule freight.
        /// </summary>
        /// <param name="scheduleFreight"></param>
        void UpdateScheduleFreight(ScheduleFreight scheduleFreight);
    }
}
