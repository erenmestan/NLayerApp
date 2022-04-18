using Microsoft.AspNetCore.Mvc;
using NLayer.Core.Services;

namespace NLayer.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _services;

        public ProductController(IProductService service)
        {
            _services=service;
        }

        public async Task<IActionResult> Index()
        {
            
            return View(await _services.GetProductsWithCategory());
        }
    }
}
