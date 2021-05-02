using PopApp.Core.Entities;
using PopApp.Data.Context;
using PopApp.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PopApp.Data.Services
{
    /// <summary>
    /// Represent schedule repository.
    /// </summary>
    public class ScheduleRepository : PopAppRepositoryBase<Schedule>, IScheduleRepository
    {
        #region Ctors
        /// <summary>
        /// 
        /// </summary>
        /// <param name="popAppContext"></param>
        public ScheduleRepository(PopAppContext popAppContext) : base(popAppContext)
        {
        }
        #endregion

        #region Methods
        ///<inheritdoc/>
        public void CreateSchedule(Schedule schedule)
        {
            if (schedule is null) throw new Exception("Schedule wasn't set");
            Create(schedule);
        }

        ///<inheritdoc/>
        public Schedule GetSchedule(int id, bool trackChange)
        {
            if (id == 0) throw new Exception("Schedule identifier invalid");
            var schedule = FindByCondition(s => s.Id == id, trackChange).FirstOrDefault();
            if (schedule is null) throw new Exception("Schedule invalid");
            return schedule;
        }

        ///<inheritdoc/>
        public IEnumerable<Schedule> GetSchedules(bool trackChange)
        {
            var schedules = FindByCondition(schedule => schedule.IsActive == true, trackChange).ToList();
            if (schedules is null) throw new Exception("There are no schedule active");
            return schedules;
        }

        ///<inheritdoc/>
        public void UpdateSchedule(Schedule schedule)
        {
            if (schedule is null) throw new Exception("Schedule wasn't set");
            Update(schedule);
        }
        #endregion
    }
}
