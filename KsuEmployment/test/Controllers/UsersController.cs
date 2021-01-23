using System.Web.Http;

namespace test.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("users")]
    public class UsersController : BaseKsuController
    {
        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        [Microsoft.AspNetCore.Mvc.Route("test")]
        public IHttpActionResult Test()
        {
            return Ok("Hello world");
        }
    }
}
