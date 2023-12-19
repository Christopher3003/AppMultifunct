using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : Controller
    {
        private readonly Fachada _fachada;
        public LoginController(Fachada fachada) {
            _fachada = fachada;
        }

        [HttpPost("Registrarse", Name = "GetRegistrarse")]
        public dynamic registrarse([FromBody] registro userData)
        {
            return _fachada.registrar(userData.nombreUsuario, userData.password);
        }

        [HttpGet("Suma", Name = "GetSuma")]
        public dynamic Suma(int val1, int val2)
        {
            var resultado = _fachada.suma(val1, val2);
            return resultado;
        }

        [HttpGet("Divisa", Name = "GetDivisa")]
        public dynamic convertirDivisas(int dolar)
        {
            var resultado = _fachada.convertD(dolar);
            return resultado;
        }

        [HttpGet("Temperatura", Name = "GetTemperatura")]
        public dynamic convertirTemp(double temp) 
        {
            return _fachada.convertT(temp);
        }

    }
}
