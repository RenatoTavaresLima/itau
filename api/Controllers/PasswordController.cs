using Microsoft.AspNetCore.Mvc;

namespace itau_teste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PasswordController : ControllerBase
    {
        [HttpPost]
        [Route("validate")]
        public bool Post(PasswordDto password) => true;
    }
}
