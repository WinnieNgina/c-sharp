using DatabaseAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLayer.BusinessLogic
{
    public interface IProductBusinessLogic
    {
        Guid AddProduct(Product product);
        List<Product> GetProducts();
    }
}
