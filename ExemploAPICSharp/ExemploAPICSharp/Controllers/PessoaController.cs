using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExemploAPICSharp.Model;

namespace ExemploAPICSharp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {

        [HttpGet("GetPessoa")]

        public Pessoa GetPessoa() {
            
            var vPessoa = new Pessoa();
            vPessoa.Id = 1;
            vPessoa.Nome = "Zé Robson";
            vPessoa.NumeroCelular = "(18) 990123-0123";

            return vPessoa;
            
        }
    }
}
