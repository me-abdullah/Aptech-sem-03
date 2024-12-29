using Class_09.Models;
using System.Collections.Generic;
using System.Web.Mvc;

public class ProductsController : Controller
{
    // GET: api/products
    public JsonResult GetProducts()
    {
        var products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 750.00M },
            new Product { Id = 2, Name = "Tablet", Price = 300.00M },
            new Product { Id = 3, Name = "Smartphone", Price = 500.00M }
        };

        return Json(products, JsonRequestBehavior.AllowGet);
    }
}
