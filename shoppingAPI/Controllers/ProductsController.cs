using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using shoppingAPI.Data.Entity;
using shoppingAPI.Data.Repository;
using shoppingAPI.Model;
using System;
using System.Threading.Tasks;

namespace shoppingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowReact")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public ProductsController(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }
        
       [HttpGet]
        public async Task<ActionResult<ProductModels[]>> Get(bool includeSpecification = true)
         {
            try
            {
                var Products = await productRepository.GetAllProductAsync(includeSpecification);
                ProductModels[] productModels = mapper.Map<ProductModels[]>(Products);
                return productModels;
            }
            catch (Exception)
            {
                return this.StatusCode(500, "Database Failure");
            }
        }

        //http post bi loi cua xai duoc 
        [HttpPost]
        public async Task<ActionResult<ProductModels>> Post(ProductModels model, bool includeSpecification = true)
        {
            try
            {
                var ProductsExist = await productRepository.GetProductAsync(model.ProductName, includeSpecification);
                if (ProductsExist != null)
                {
                    return BadRequest("huehuehuehue");
                }

                var product = mapper.Map<Product>(model);
                productRepository.Add(product);
                if(await productRepository.SaveChangesAsync())
                {
                    return Created($"/api/product/{model.ProductName}", mapper.Map<ProductModels>(product));
                }
                return NotFound();
            }
            
            catch (Exception)
            {
                return this.StatusCode(500, "Error !! You're Baka");
            }
        }
            
    }
}