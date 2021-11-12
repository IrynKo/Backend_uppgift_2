﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
     
        public decimal Price { get; set; }
        public string Image { get; set; }
       public int Quantity { get; set; }
    }
}
