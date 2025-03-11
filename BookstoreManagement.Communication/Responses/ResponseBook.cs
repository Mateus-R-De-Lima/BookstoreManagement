using BookstoreManagement.Communication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreManagement.Communication.Responses
{
    public class ResponseBook : Book
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
