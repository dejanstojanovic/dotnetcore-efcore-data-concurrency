using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sample.Concurrency.Web.Api.Models;

namespace Sample.Concurrency.Web.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ProductViewModel>> Get()
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}")]
        public ProductEditModel Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public void Post([FromBody] ProductAddModel product)
        {
        }

        [HttpPut("{id}")]
        public void Patch(int id, [FromBody] ProductEditModel product)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
