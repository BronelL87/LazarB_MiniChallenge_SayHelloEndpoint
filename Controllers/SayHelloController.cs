using Microsoft.AspNetCore.Mvc;

namespace LazarB_MiniChallenge_SayHelloEndpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        public List<string> SayHello = new();
    [HttpPost]
    [Route("InsertName/{userName}")]
    public List<string> InsertName(string userName){
        SayHello.Add($"Hello, {userName}");
        return SayHello;
    }

    }
}