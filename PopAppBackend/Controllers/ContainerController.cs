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
    [Route("api/container")]
    [ApiController]
    public class ContainerController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;

        public ContainerController(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetContainers()
        {
            try
            {
                var containers = _repositoryManager.Container.GetAllContainer(trackChange: false);
                var containerDto = _mapper.Map<ContainerDto>(containers);
                return Ok(containerDto);
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
        [HttpGet("{id}")]
        public IActionResult GetContainer(int id)
        {
            try
            {
                var container = _repositoryManager.Container.GetContainer(id , trackChange: false);
                var containerDto = _mapper.Map<ContainerDto>(container);
                return Ok(containerDto);
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult PostContainer([FromBody] ContainerDto containerDto)
        {
            try
            {
                var container = _mapper.Map<Container>(containerDto);
                _repositoryManager.Container.CreateContainer(container);
                _repositoryManager.Save();
                return Ok();
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult GetContainer([FromBody] ContainerDto containerDto)
        {
            try
            {
                var container = _mapper.Map<Container>(containerDto);
                _repositoryManager.Container.UpdateContainer(container);
                _repositoryManager.Save();
                return Ok();
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
