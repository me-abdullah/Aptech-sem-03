using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Mvc;
using Class_10.Models;

public class ProductController : Controller
{
    private string connectionString = ConfigurationManager.ConnectionStrings["TestDbConnection"].ConnectionString;

    // GET: Product/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: Product/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Product product)
    {
        if (ModelState.IsValid)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Products (Name, Price) VALUES (@Name, @Price)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", product.Name);
                cmd.Parameters.AddWithValue("@Price", product.Price);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            return RedirectToAction("Index");
        }
        return View(product);
    }

    // GET: Product/Index
    public ActionResult Index()
    {
        var products = new List<Product>();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT Id, Name, Price FROM Products";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                products.Add(new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    Price = Convert.ToDecimal(reader["Price"])
                });
            }
            conn.Close();
        }

        return View(products);
    }
}
