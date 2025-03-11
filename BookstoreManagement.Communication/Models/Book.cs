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
        public string Gender { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Amount { get; set; }

    }
}
