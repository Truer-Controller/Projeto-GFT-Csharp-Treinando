using cursoteste.Filter;
using cursoteste.Models.Usuarios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cursoteste.Controllers
{
    /// <summary>
    /// Autentificar um usuario cadastrado e ativo
    /// </summary>
    ///<param name="loginViewModelInput">View model do login</param>param>
    ///<returns>Retorna status ok e se o token estiver errado da erro</returns>
    [SwaggerResponse(statusCode: 200, description:"Sucesso ao autentificar", Type = typeof(LoginViewModelInput))]
    [SwaggerResponse(statusCode: 400, description: "Campos obrigatorios faltantes", Type = typeof(ValidaCampoViewModelOutput))]
    [SwaggerResponse(statusCode: 500, description: "Erro interno", Type = typeof(ErroGenericoViewModel))]
    [Route("api/v1/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {   
        [HttpPost]
        [Route("logar")]
        [ValidacaoModelStateCustomizado]
        public IActionResult Logar(LoginViewModelInput loginViewModelInput)
        {
            return Ok(loginViewModelInput);
        }

        [HttpPost]
        [Route("registrar")]
        [ValidacaoModelStateCustomizado]
        public IActionResult Registrar(RegistroViewModelInput loginViewModelInput)
        {
            return Created("", loginViewModelInput);
        }
    }
}
