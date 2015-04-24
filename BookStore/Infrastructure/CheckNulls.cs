using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http.Filters;
using System.Net.Http;

namespace BookStore.Infrastructure
{
    public class CheckNulls : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            if (actionExecutedContext.Response.StatusCode == HttpStatusCode.NotFound)
                actionExecutedContext.Response = 
                    actionExecutedContext.Request.CreateErrorResponse(HttpStatusCode.NotFound,
                    "No results found for the given query");

            base.OnActionExecuted(actionExecutedContext);
        }
    }
}