using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using TypedHttpClientNamespace;

namespace HogwartsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HogwartsController : ControllerBase
    {
        private ITypedHttpClient _typedHttpClient;
        private readonly ILogger<HogwartsController> _logger;

        public HogwartsController(ILogger<HogwartsController> logger, ITypedHttpClient typedHttpClient)
        {
            _logger = logger;
            _typedHttpClient = typedHttpClient;
        }

        [Route("Students"), HttpGet]
        public async Task<HttpResponseMessage> Students()
        {
            return await _typedHttpClient.Execute("http://www.hogwarts.com/students", HttpMethod.Get);           
        }

        [Route("Student"), HttpGet]
        public async Task<HttpResponseMessage> Student(Guid studentId)
        {
            return await _typedHttpClient.Execute("http://www.hogwarts.com/students/" + studentId, HttpMethod.Get);
        }

        [Route("Student"), HttpPost]
        public async Task<HttpResponseMessage> Student(Student student)
        {
            return await _typedHttpClient.Execute("http://www.hogwarts.com/student", HttpMethod.Post, new StringContent(JsonSerializer.Serialize(student)));
        }
    }
}
