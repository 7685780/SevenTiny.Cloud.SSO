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
    public class TenantController : ControllerBase
    {
        /// <summary>
        /// 新增租户
        /// </summary>
        /// <param name="tenant"></param>
        /// <returns></returns>
        public ActionResult<JsonResult> AddTenant([FromBody] TenantCredential tenant)
        {
            return null;
        }
    }
}