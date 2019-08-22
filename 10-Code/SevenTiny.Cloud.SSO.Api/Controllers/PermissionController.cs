using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SevenTiny.Cloud.SSO.Core.Entity;

namespace SevenTiny.Cloud.SSO.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        public ActionResult<JsonResult> AddPermission([FromBody]Permission permission)
        {
            return null;
        }
    }
}