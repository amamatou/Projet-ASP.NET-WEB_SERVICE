﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMania.Models.Dtos
{
    public class CartItemUpdateQtyDto
    {
        public int CartItemId { get; set; }

        public int Qty { get; set; }
    }
}
