using Coffee.Services;
using Coffee.Web.Serialization;
using Coffee.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Coffee.web.Controllers
{
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly ILogger<ProductController> _logger;
		private readonly IProductService _productService;

		public ProductController(ILogger<ProductController> logger, IProductService productService)
		{
			_logger = logger;
			_productService = productService;

		}

		[HttpGet("/api/product")]
		public ActionResult GetProduct()
		{
			_logger.LogInformation("Getting all products");
			var products = _productService.GetAllProducts();
			return Ok(products);
		}

		[HttpPost("/api/product")]
		public ActionResult AddProduct([FromBody] ProductModel product)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}
			_logger.LogInformation("Adding product");
			var newProduct = ProductMapper.SerializeProductModel(product);
			var newProductResponse = _productService.CreateProduct(newProduct);
			return Ok(newProductResponse);
		}

	}
}
