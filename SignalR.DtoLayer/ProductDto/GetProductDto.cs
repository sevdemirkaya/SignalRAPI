﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.ProductDto
{
    public class GetProductDto
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }

        public required string Description { get; set; }

        public decimal Price { get; set; }

        public string? ImageURL { get; set; }


        public bool ProductStatus { get; set; }
    }
}
