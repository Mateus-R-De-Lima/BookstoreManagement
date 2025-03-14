﻿using BookstoreManagement.Communication.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreManagement.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {

        public abstract IActionResult GetAll();

        public abstract IActionResult Get(Guid id);      
       
        public abstract IActionResult Delete(Guid id);




        
    }
}
