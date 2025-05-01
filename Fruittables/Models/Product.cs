﻿namespace Fruittables.Models
{
    public class Product:BaseEntity
    {
        public  string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Volume { get; set; }


        public string Description { get; set; }
        //relational
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public List<ProductImage> ProductImages { get; set; }

    }
}
