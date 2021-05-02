using PopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Data.Interfaces
{
    /// <summary>
    /// Represent schedule service.
    /// </summary>
    public interface IScheduleService
    {
        /// <summary>
        /// Register schedule on board
        /// </summary>
        /// <param name="scheduleRequest"></param>
        void RegisterScheduleOnBoard(ScheduleRequest scheduleRequest);
        /// <summary>
        /// Get CurrentSchedule count.
        /// </summary>
        /// <returns></returns>
        int GetCurrentScheduleCount();
        /// <summary>
        /// Get Completed schedule count.
        /// </summary>
        /// <param name="searchByDate"></param>
        /// <returns></returns>
        int GetCompletedScheduleCount(DateTime searchByDate);
    }
}
