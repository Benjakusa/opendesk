using System.ComponentModel.Composition;
using System.Net;
using System.Web.Http;
using OpenDesk.ApiServer.Lib;
using OpenDesk.ApiServer.Responses;
using OpenDesk.Persistance;

namespace OpenDesk.ApiServer.Controllers
{
    [Export]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class LoginController : ApiController
    {
        private readonly IUserDao _userDao;

        [ImportingConstructor]
        public LoginController(IUserDao userDao)
        {
            _userDao = userDao;
        }

        //GET =>  http://localhost:8080/api/getToken/{pin}
        public OpenDeskApiLoginResponse GetLogin(string pin)
        {
            OpenDeskApiLoginResponse ret;

            if (!_userDao.GetIsUserExists(pin))
            {
                ret = new OpenDeskApiLoginResponse(null, null, HttpStatusCode.Unauthorized);
            }
            else
            {
                var user = _userDao.GetUserByPinCode(pin);
                ret = new OpenDeskApiLoginResponse(new Token(user.Id),
                                                user,
                                                HttpStatusCode.Accepted,
                                                true);
            }

            return ret;
        }
    }
}
