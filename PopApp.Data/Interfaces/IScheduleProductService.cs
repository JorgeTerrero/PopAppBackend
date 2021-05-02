using PopApp.Core.Entities.schedule;
using System.Collections.Generic;

namespace PopApp.Data.Interfaces
{
    /// <summary>
    /// Represent schedule product service.
    /// </summary>
    public interface IScheduleProductService
    {
        /// <summary>
        /// Get all schedule products.
        /// </summary>
        /// <returns>List a schedule products.</returns>
        IEnumerable<ScheduleProduct> GetScheduleProducts();
        /// <summary>
        /// Get schedule product.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A schedule product.</returns>
        ScheduleProduct GetScheduleProduct(int id);
        /// <summary>
        /// Create schedule product.
        /// </summary>
        /// <param name="scheduleProduct"></param>
        void CreateScheduleProduct(ScheduleProduct scheduleProduct);
        /// <summary>
        /// Update schedule product.
        /// </summary>
        /// <param name="scheduleProduct"></param>
        void UpdateScheduleProduct(ScheduleProduct scheduleProduct);
    }
}
