using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Http;

namespace OpenDesk.ApiServer.Lib
{
    public class OpenDeskApiController : ApiController
    {
        internal void ValidateToken()
        {
            var token = (string)ControllerContext.RouteData.Values["token"];
            if (!Token.ValidateToken(token))
            {
                throw new HttpResponseException(HttpStatusCode.Forbidden);
            }
        }
    }
}
