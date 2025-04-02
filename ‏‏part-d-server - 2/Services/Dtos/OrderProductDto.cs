﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Dtos
{
    public class OrderProductDto
    {
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int Count { get; set; } 
    }
}
