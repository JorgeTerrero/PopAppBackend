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
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public ProductController(IRepositoryManager repositoryManager , IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetProduct()
        {
            try
            {
                var products = _repositoryManager.Product.GetAllProducts(trackChange: false);
                var productsDto = _mapper.Map<IEnumerable<ProductDto>>(products);
                return Ok(productsDto);
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            try
            {
                var product = _repositoryManager.Product.GetProduct(id, trackChange: false);
                var productDto = _mapper.Map<ProductDto>(product);
                return Ok(productDto);
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public IActionResult PostProduct([FromBody] ProductDto productDto)
        {
            try
            {
                var product = _mapper.Map<Product>(productDto);
                _repositoryManager.Product.CreateProduct(product);
                _repositoryManager.Save();
                return Ok();
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public IActionResult PutProduct([FromBody] ProductDto productDto)
        {
            try
            {
                var product = _mapper.Map<Product>(productDto);
                _repositoryManager.Product.UpdateProduct(product);
                _repositoryManager.Save();
                return Ok();
            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

       
    }
}
