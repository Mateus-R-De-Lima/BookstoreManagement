﻿using BookstoreManagement.Communication.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Communication.Models
{
    public class Book
    {
        public string Title { get; set; } = string.Empty;
        public GenderTypes Gender { get; set; } 
        public decimal Price { get; set; }
        public int Amount { get; set; }

    }
}
