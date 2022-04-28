using AspDotNet.LabExercise1.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNet.LabExercise1.Controllers
{
    public class ProductController : Controller
    {

        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }
        public IActionResult List()
        {
            ViewData["ProductList"] = _productService.GetCatalog();
            ViewData["Grandtotal"] = _productService.GetGrandTotal();
            return View();
        }
    }
}
