using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PopApp.Core.Dtos;
using PopApp.Core.Entities;
using PopApp.Data.Interfaces;

namespace PopAppBackend.Controllers
{
    [Route("api/vessel")]
    [ApiController]
    public class VesselController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public VesselController(IRepositoryManager repositoryManager  , IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetVessels()
        {
            try
            {
                var vessels = _repositoryManager.Vessel.GetAllVessel(trackChange: false);
                var vesselDto = _mapper.Map<IEnumerable<VesselDto>>(vessels);
                return Ok(vesselDto);
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetVessel(int id)
        {
            try
            {
                var vessel = _repositoryManager.Vessel.GetVessel(id, trackChange: false);
                var vesselDto = _mapper.Map<VesselDto>(vessel);
                return Ok(vesselDto);
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult PostVessel([FromBody] VesselDto vesselDto)
        {
            try
            {
                var vessel = _mapper.Map<Vessel>(vesselDto);
                _repositoryManager.Vessel.CreateVessel(vessel);
                _repositoryManager.Save();
                return Ok();
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult PutVessel([FromBody] VesselDto vesselDto)
        {
            try
            {
                var vessel = _mapper.Map<Vessel>(vesselDto);
                _repositoryManager.Vessel.UpdateVessel(vessel);
                _repositoryManager.Save();
                return Ok();
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }


    }
}
