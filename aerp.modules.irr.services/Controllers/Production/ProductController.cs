

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace aerp.modules.irr.services.Controllers
{
	using System.Collections.Generic;
	using System.Web.Http;
	using entities.Production;
	using Microsoft.AspNet.Mvc;

	[Route("api/[controller]")]
    public class ProductController : ApiController
    {
		// GET: api/values
		[HttpGet]
		public IEnumerable<Product> Get()
		{
			return null;
		}

		[HttpGet]
		public IEnumerable<Product> GetByName(string Name)
		{
			return null;
		}

		// GET api/values/5
		[HttpGet()]
        public string Get(int id)
        {
            return "value";
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
