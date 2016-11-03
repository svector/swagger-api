using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Model;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    public class MessageController : Controller
    {
         [HttpGet]
        public IEnumerable<Message> Get()
        {
            return new Message[] { new MessageAlpha(), new MessageAlpha() };
        }
        
       [HttpPost]
        public void Post([FromBody]MessageAlpha value)
        {
        }        
    }
}
