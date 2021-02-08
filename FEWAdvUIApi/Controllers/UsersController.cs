using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FEWAdvUIApi.Controllers
{
    public class UsersController : ControllerBase
    {

        [HttpHead("/users/emails/{email}")]
        public ActionResult UserExists(string email)
        {
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
