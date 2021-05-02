using PopApp.Core.Entities;
using PopApp.Core.Entities.schedule;
using PopApp.Core.Enums;
using PopApp.Core.Models;
using PopApp.Data.Interfaces;
using System;
using System.Linq;

namespace PopApp.Data.Services
{
    public class ScheduleService : IScheduleService
    {
        #region Fields
        private readonly IRepositoryManager _repositoryManager;
        private readonly IScheduleContainerService _scheduleContainerService;
        private readonly IScheduleFreightService _scheduleFreightService;
        private readonly IScheduleProductService _scheduleProductService;
        private readonly IScheduleVesselService _scheduleVesselService;
        #endregion

        #region Ctor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="repositoryManager"></param>
        /// <param name="scheduleContainerService"></param>
        /// <param name="scheduleFreightService"></param>
        /// <param name="scheduleProductService"></param>
        /// <param name="scheduleVesselService"></param>
        public ScheduleService(IRepositoryManager repositoryManager , 
            IScheduleContainerService scheduleContainerService , 
            IScheduleFreightService scheduleFreightService , 
            IScheduleProductService scheduleProductService,
            IScheduleVesselService scheduleVesselService)
        {
            _repositoryManager = repositoryManager;
            _scheduleContainerService = scheduleContainerService;
            _scheduleFreightService = scheduleFreightService;
            _scheduleProductService = scheduleProductService;
            _scheduleVesselService = scheduleVesselService;
        }
        #endregion

        #region Methods
        ///<inheritdoc/>
        public void RegisterScheduleOnBoard(ScheduleRequest scheduleRequest)
        {
            if (scheduleRequest is null) throw new Exception("the Resquest hasn't set");

            Schedule schedule = new Schedule 
            {
                IsActive = true,
                ScheduleDate = DateTime.Now,
            };

            _repositoryManager.Schedule.CreateSchedule(schedule);

            _repositoryManager.Save();

            _scheduleVesselService.CreateScheduleVessel(new ScheduleVessel { 
               VesselId = scheduleRequest.VesselId,
               ScheduleId = schedule.Id,
               VesselStatus = VesselStatus.InTransit,
               CreateAt = DateTime.Now
            });

            _scheduleContainerService.CreateScheduleContainer(new ScheduleContainer
            {
                ScheduleId = schedule.Id,
                CompanyId = scheduleRequest.CompanyId,
                FreightId = scheduleRequest.FreightId,
                Status = ContainerStatus.WaitingForRevision,
                CreatedAt = DateTime.Now,
            });

            _scheduleFreightService.CreateScheduleFreight(new ScheduleFreight
            {
                ScheduleId = schedule.Id,
                ContainerId = scheduleRequest.ContainerId,
                CreatedAt = DateTime.Now,
            });

            foreach (ProductScheduleModel product in scheduleRequest.Products)
            {
                 
                _scheduleProductService.CreateScheduleProduct(new ScheduleProduct
                {
                    ScheduleId = schedule.Id,
                    ProductId = product.ProductId,
                    freightId = scheduleRequest.FreightId,
                    Quantity = product.Quantity,
                    CreatedAt = DateTime.Now,
                });

            }  
        }

        ///<inheritdoc/>
        public int GetCompletedScheduleCount(DateTime searchByDate)
        {
            if (searchByDate == null) throw new Exception("Date hasn't set");
            int currentScheduleOnBoard = _repositoryManager.Schedule
                .GetSchedules(trackChange: false).Where(x => x.ScheduleDate == searchByDate).Count();
            return currentScheduleOnBoard;
        }

        ///<inheritdoc/>
        public int GetCurrentScheduleCount()
        {
            int currentScheduleOnBoard = _repositoryManager.Schedule
                .GetSchedules(trackChange: false).Where(x => x.ScheduleDate == DateTime.Now).Count();
            return currentScheduleOnBoard; 
        }
        #endregion
    }
}
