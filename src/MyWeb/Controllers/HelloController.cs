using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyWeb.Controllers {
    [Route("api/[controller]/[action]")]
    public class HelloController : ControllerBase {
        [HttpGet]
        public async Task<IActionResult> R1() {
            var handler = new HttpClientHandler {
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator,
                AllowAutoRedirect = false
            };

            var url = "https://expired.badssl.com";
            var client = new HttpClient(handler);
            var response = await client.GetAsync(url);

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> R2() {
            var handler = new HttpClientHandler {
            };

            var url = "https://expired.badssl.com";
            var client = new HttpClient(handler);
            var response = await client.GetAsync(url);

            return Ok();
        }
    }
}