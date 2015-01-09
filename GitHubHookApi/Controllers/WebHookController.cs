using LittleBits.CloudBitApiClient;
using System.Web.Http;

namespace GitHubHookApi.Controllers
{
    public class WebHookController : ApiController
    {
        [HttpPost]
        [Route("{accessToken}/{deviceId}")]
        public void Post(string accessToken, string deviceId)
        {
            Client
                .Authenticate(accessToken)
                .SetOutput(new DeviceOutputRequest
                {
                    DeviceId = deviceId,
                    DurationInMilliseconds = 5000,
                    Percent = 100
                });
        }
    }
}
