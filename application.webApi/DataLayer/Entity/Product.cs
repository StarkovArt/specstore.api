﻿namespace application.webApi.DataLayer.Entity
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
