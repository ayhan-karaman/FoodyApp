using Foody.Business.Abstract;
using Foody.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Foody.Presentation.Controllers
{

    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var products = _productService.TGetAll();
            return View(products);
        }

        public IActionResult ProductListWithCategory()
        {
            var products = _productService.TProductListWithCategory();
            return View(products);
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            var values = _categoryService.TGetAll();
            ViewBag.Categories = new SelectList(values, "Id", "CategoryName");
            
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _productService.TInsert(product);
            return RedirectToAction("ProductListWithCategory");
        }

        public IActionResult DeleteProduct(int id)
        {
             _productService.TDelete(id);
             return RedirectToAction("ProductListWithCategory");
        }


        [HttpGet]
        public IActionResult EditProduct(int id)
        {
            var values = _categoryService.TGetAll();
            ViewBag.Categories = new SelectList(values, "Id", "CategoryName");
            var product = _productService.TGetById(id);
            return View(product);
        }

        public IActionResult EditProduct(Product product)
        {
            _productService.TUpdate(product);
            return RedirectToAction("ProductListWithCategory");
        }
    }
}