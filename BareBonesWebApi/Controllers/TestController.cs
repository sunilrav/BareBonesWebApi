using System.Web.Http;

namespace BareBonesWebApi.Controllers
{
    public class TestController : ApiController
    {
        [Route("api/test")]
        public string Get()
        {
            return "Test";
        }
    }
}
