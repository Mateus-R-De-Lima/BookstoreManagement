﻿using BookstoreManagement.Communication.Models;

namespace BookstoreManagement.Communication.Responses
{
    public class ResponseBook : Book
    {
        public Guid Id { get; set; } = Guid.NewGuid();
    }
}
