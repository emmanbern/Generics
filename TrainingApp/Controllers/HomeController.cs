using Interfaces.Service;
using System.Web.Mvc;

namespace TrainingApp.Controllers
{
    public class HomeController : BaseController
    {
        IProductService _productService;

        public HomeController() : base() { }

        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index()
        {
            var products = _productService.GetProductsActive();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}