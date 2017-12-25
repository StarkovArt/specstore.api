using System;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using application.webApi.DataLayer.Entity;
using application.webApi.DataLayer.Repositories;
using System.Threading.Tasks;

namespace application.webApi.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductRepository _getProductRepository;
        
        public ProductsController(IProductRepository getProductRepository)
        {
            _getProductRepository = getProductRepository;
        }
        // GET: api/Products
        [Route("api/Products/{id}")]
        [ResponseType(typeof(Product))]
        public async Task<Product> GetProduct(int id)
        {
            var product = await _getProductRepository.Get(id);
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            return product;
        }

        // PUT: api/Products/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProduct(int id, Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.Id)
            {
                return BadRequest();
            }

            _getProductRepository.Update(product);

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Products
        [ResponseType(typeof(Product))]
        public IHttpActionResult PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _getProductRepository.Add(product);

            return CreatedAtRoute("DefaultApi", new { id = product.Id }, product);
        }

        // DELETE: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult DeleteProduct(int id)
        {
            _getProductRepository.Delete(id);

            return Ok(HttpStatusCode.OK);
        }
    }
}