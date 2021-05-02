using PopApp.Core.Entities.schedule;
using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Data.Interfaces
{
    /// <summary>
    /// Represent container service.
    /// </summary>
    public interface IScheduleContainerService
    {
        /// <summary>
        /// Get schedules containers 
        /// </summary>
        /// <returns>List of schedule container.</returns>
        IEnumerable<ScheduleContainer> GetScheduleContainers();
        /// <summary>
        /// Get schedule container.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A schedule container</returns>
        ScheduleContainer GetScheduleContainer(int id);
        /// <summary>
        /// Create schedule container.
        /// </summary>
        /// <param name="scheduleContainer"></param>
        void CreateScheduleContainer(ScheduleContainer scheduleContainer);
        /// <summary>
        /// Update schedule container.
        /// </summary>
        /// <param name="scheduleContainer"></param>
        void UpdateSchedule(ScheduleContainer scheduleContainer);
    }
}
