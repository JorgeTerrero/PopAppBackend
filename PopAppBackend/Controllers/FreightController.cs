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
    [Route("api/freight")]
    [ApiController]
    public class FreightController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public FreightController(IRepositoryManager repositoryManager , IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetFreights()
        {
            try
            {
                var freigths = _repositoryManager.Freight.GetAllFreights(trackChange: false);
                var freigthsDto = _mapper.Map<IEnumerable<FreightDto>>(freigths);
                return Ok(freigthsDto);
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        [HttpGet("{id}")]
        public IActionResult GetFreight(int id)
        {
            try
            {
                var freigth = _repositoryManager.Freight.GetFreight(id, trackChange: false);
                var freightDto = _mapper.Map<FreightDto>(freigth);
                return Ok(freigth);
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult PostFreight([FromBody] FreightDto freightDto)
        {
            try
            {
                var freight = _mapper.Map<Freight>(freightDto);
                _repositoryManager.Freight.CreateFreight(freight);
                _repositoryManager.Save();
                return Ok();
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        [HttpPut]
        public IActionResult PutFreight([FromBody] FreightDto freightDto)
        {
            try
            {
                var freight = _mapper.Map<Freight>(freightDto);
                _repositoryManager.Freight.UpdateFreight(freight);
                _repositoryManager.Save();
                return Ok();
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
