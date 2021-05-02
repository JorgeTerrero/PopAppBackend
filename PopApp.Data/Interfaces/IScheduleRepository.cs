using PopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Data.Interfaces
{
    /// <summary>
    /// Represent schedule repository.
    /// </summary>
    public interface IScheduleRepository
    {
        /// <summary>
        /// Get all schedule.
        /// </summary>
        /// <param name="trackChange"></param>
        /// <returns>List schedules.</returns>
        IEnumerable<Schedule> GetSchedules(bool trackChange);
        /// <summary>
        /// Get schedule.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="trackChange"></param>
        /// <returns>A schedule.</returns>
        Schedule GetSchedule(int id, bool trackChange);
        /// <summary>
        /// Create schedule.
        /// </summary>
        /// <param name="schedule"></param>
        void CreateSchedule(Schedule schedule);
        /// <summary>
        /// Update schedule.
        /// </summary>
        /// <param name="schedule"></param>
        void UpdateSchedule(Schedule schedule);
    }
}
