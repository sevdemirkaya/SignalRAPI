﻿namespace SignalR.EntityLayer.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }

        public required string Description { get; set;  }

        public decimal Price { get; set; }

        public string? ImageURL { get; set; }


        public bool ProductStatus { get; set; }
    }
}
