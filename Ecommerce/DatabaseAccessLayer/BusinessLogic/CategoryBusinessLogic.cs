using DatabaseAccessLayer.EcommerceDBContext;
using DatabaseAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLayer.BusinessLogic
{
    public class CategoryBusinessLogic : ICategoryBusinessLogic
    {
        private readonly EcommerceContext econtext; //can only be only be instanciated in the constructor
        public CategoryBusinessLogic(EcommerceContext ecommerceContext)
        {
            econtext = ecommerceContext;
        }
        public Guid AddCategory(Category category)
        {
            econtext.Categories.Add(category);
            econtext.SaveChanges();
            return category.Id;
        }
        public List<Category> GetCategories()
        {
            return econtext.Categories.Include(x=>x.Products).ToList();
        }
        public Category? GetCategoryById(Guid id) 
        {
            return econtext.Categories.
                Include(x=> x.Products).
                FirstOrDefault(x=>x.Id == id);
        }
        public List<Category> SearchCategory(string searchvalue)
        {
            return econtext.Categories.Include(x => x.Products).Where(x => x.CategoryName.Contains(searchvalue)).ToList();
            //econtext.Categories - gives access to the database table
            //Include(x => x.Products) - gives us access to child (Access to referenced keys)
            //Where(x => x.CategoryName == searchvalue) - provides the link- filtration condition - gives access to all items
            //.First = gives access to the first item that meet the condition

        }
    }
}
