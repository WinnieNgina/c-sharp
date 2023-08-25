﻿namespace EcommerceUI.Models
{
    public class Product
    {
        public DateTime createdAt { get; set; }
        public DateTime ?updatedAt { get; set; }
        public string id { get; set; }
        public string userId { get; set; }
        public string productName { get; set; }
        public string imageUrl { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string categoryId { get; set; }
        public CategoryModel productCategory { get; set; }
    }

    public class CategoryModel
    {
        public DateTime createdAt { get; set; }
        public DateTime ?updatedAt { get; set; }
        public Guid id { get; set; }
        public string userId { get; set; }
        public string categoryName { get; set; }
        public List <Product> products { get; set; }
    }
}
