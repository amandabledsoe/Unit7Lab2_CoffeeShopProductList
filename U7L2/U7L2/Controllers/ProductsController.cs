using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using U7L2.Models;

namespace U7L2.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private CoffeeShopDbContext _coffeeShopDbContext;

        public ProductsController(ILogger<HomeController> logger, CoffeeShopDbContext newCoffeeShopDbContext)
        {
            _logger = logger;
            _coffeeShopDbContext = newCoffeeShopDbContext;
        }

        public ActionResult Index()
        {
            ProductsList theProductList = new ProductsList();
            List<Products> listOfItems = new List<Products>();
            foreach (var item in _coffeeShopDbContext.Products)
            {
                listOfItems.Add(item);
            }
            theProductList.ProductList = listOfItems;
            return View(theProductList);
        }

        public IActionResult Details(int ID)
        {
            Products targetProduct = null;
            foreach (var item in _coffeeShopDbContext.Products)
            {
                if (item.ID==ID)
                {
                    targetProduct = item;
                    break;
                }
            }
            if (targetProduct != null)
            {
                return View(targetProduct);
            }
            else
            {
                throw new Exception("Something went wrong with your code!");
            }

        }
    }
}
