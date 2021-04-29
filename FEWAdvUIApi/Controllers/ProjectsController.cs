using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FEWAdvUIApi.Controllers
{
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        [HttpPost]
        public ActionResult<GetItemDetails> AddItem([FromBody] PostItemRequest request)
        {
            // validate, etc.

            var response = new GetItemDetails(
                    new Random().Next(100,int.MaxValue),
                    request.Item,
                    request.Project,
                    request.Completed,
                    request.assignedTo

                );

            return StatusCode(201, response);
        }
    }

    public record PostItemRequest( string Item,  string Project, bool Completed, string assignedTo);
    public record GetItemDetails(int Id, string Item,  string Project, bool Completed, string assignedTo);

}
/*
 * export interface HomeRepairModel {
  id: string;
  item: string;
  project?: string;
  completed: boolean;
  assignedTo: string;
}
*/