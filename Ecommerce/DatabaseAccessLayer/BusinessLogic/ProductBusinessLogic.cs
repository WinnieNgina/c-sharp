using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseAccessLayer.EcommerceDBContext;
using DatabaseAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseAccessLayer.BusinessLogic
{
    public class ProductBusinessLogic : IProductBusinessLogic 
    {
        private readonly EcommerceContext econtexts;
        public ProductBusinessLogic(EcommerceContext ProductEcommerceContext)
        {
            econtexts = ProductEcommerceContext;
        }
        public Guid AddProduct(Product product) 
        {
            econtexts.Products.Add(product);
            econtexts.SaveChanges();
            return product.Id;
        }
        public List<Product> GetProducts() 
        {
            return econtexts.Products.Include(x=> x.ProductCategory).ToList();
        }
        public List<Product> SearchProduct (string searchvalue)
        {
            return econtexts.Products.Include(x => x.ProductCategory).Where(x => x.ProductName.Contains(searchvalue)).ToList();
        }
        public bool UpdateProduct (Product product)
        {
            econtexts.Products.Update(product);
            econtexts.SaveChanges();
            return true;
        } 
    }
}
