using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FEWAdvUIApi.Controllers
{
    public class UsersController : ControllerBase
    {

        [ResponseCache(Location = ResponseCacheLocation.Client, Duration =150000)]
        [HttpHead("/users/emails/{email}")]
        public ActionResult UserExists(string email)
        {
            Thread.Sleep(1000);
            if(email.ToLower().Trim().EndsWith("@aol.com"))
            {
                return Ok();
            } else
            {
                return NotFound();
            }
        }

    }
}
