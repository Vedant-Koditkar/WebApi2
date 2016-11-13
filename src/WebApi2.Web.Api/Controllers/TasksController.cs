using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi2.Web.Api.Controllers
{
    public class TasksController : ApiController
    {
        [Route("api/tasks/{id:int}")]
        public string Get(int id)
        {
            return "In the Get(int id) overload id = " + id;
        }

        [Route("api/tasks/{tasknum:alpha}")]
        public string Get(string taskNum)
        {
            return "In the Get(string taskNum) overload taskNum = " + taskNum;
        }
    }
}
