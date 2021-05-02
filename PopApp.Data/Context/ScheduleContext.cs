using Microsoft.EntityFrameworkCore;
using PopApp.Core.Entities.schedule;

namespace PopApp.Data.Context
{
    /// <summary>
    /// Represent dbcontext of schedule.
    /// </summary>
    public class ScheduleContext: DbContext
    {
        #region Ctor
        /// <param name="options">dbcontext param.</param>
        public ScheduleContext(DbContextOptions<ScheduleContext> options) : base(options) { }
        #endregion

        #region Dbset
        public DbSet<ScheduleVessel> ScheduleVessels { get; set; }
        public DbSet<ScheduleContainer> ScheduleContainers { get; set; }
        public DbSet<ScheduleFreight> ScheduleFreights { get; set; }
        public DbSet<ScheduleProduct> ScheduleProducts { get; set; }
        #endregion
    }
}
