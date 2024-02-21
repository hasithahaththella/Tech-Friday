using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspNetWebApiDotNet45.Controllers
{
    public class SumController : ApiController
    {
       
        // POST: api/Sum
        public int Post([FromBody]int num1, int num2)
        {
            return num1 + num2;
        }
        
    }
}
