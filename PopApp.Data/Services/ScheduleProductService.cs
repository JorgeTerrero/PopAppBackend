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
    /// Represent schedule product service.
    /// </summary>
    public class ScheduleProductService : IScheduleProductService
    {
        #region Fields
        private readonly ScheduleContext _scheduleContext;
        #endregion

        #region Ctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="scheduleContext"></param>
        public ScheduleProductService(ScheduleContext scheduleContext)
        {
            _scheduleContext = scheduleContext;
        }
        #endregion

        #region Methods
        ///<inheritdoc/>
        public void CreateScheduleProduct(ScheduleProduct scheduleProduct)
        {
            if (scheduleProduct is null) throw new Exception("Schedule product hasn't set");
            _scheduleContext.ScheduleProducts.Add(scheduleProduct);
            _scheduleContext.SaveChanges();
        }

        ///<inheritdoc/>
        public ScheduleProduct GetScheduleProduct(int id)
        {
            if (id == 0) throw new Exception("Invalid schedule product id");
            var scheduleProduct = _scheduleContext.ScheduleProducts.FirstOrDefault(schedule => schedule.Id == id);
            if (scheduleProduct is null) throw new Exception("Invalid schedule product");
            return scheduleProduct;
        }

        ///<inheritdoc/>
        public IEnumerable<ScheduleProduct> GetScheduleProducts()
        {
            var scheduleProducts = _scheduleContext.ScheduleProducts.ToList();
            if (scheduleProducts is null) throw new Exception("There no are schedule product active");
            return scheduleProducts;
        }

        ///<inheritdoc/>
        public void UpdateScheduleProduct(ScheduleProduct scheduleProduct)
        {
            if (scheduleProduct is null) throw new Exception("Schedule product hasn't set");
            _scheduleContext.ScheduleProducts.Update(scheduleProduct);
            _scheduleContext.SaveChanges();
        }
        #endregion
    }
}
