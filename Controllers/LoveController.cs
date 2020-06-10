using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace valentinesday_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoveController : ControllerBase
    {
        private const string MeuAmor = "Gabriela";

        [HttpGet]
        [Route("BuscarMulherMaisLinda")]
        public IActionResult BuscarMulherMaisLinda()
        {
            return Ok(MeuAmor + " é sem dúvidas a mulher mais linda do mundo!");
        }

        [HttpGet]
        [Route("BuscarNomesNoCoracaoDoThomas")]
        public IActionResult BuscarNomesNoCoracaoDoThomas()
        {
            return Ok("Busca retornou apenas 1 resultado : \n 1- " + MeuAmor + " dos Santos Lima");
        }

        [HttpDelete]
        [Route("DeletarNomeDoCoracaoDoThomas")]
        public IActionResult DeletarNomeDoCoracaoDoThomas(string nome)
        {
            if (nome == MeuAmor)
            {
                return BadRequest("Impossível deletar o amor da minha vida do meu coração");
            }
            else
            {
                return NotFound("Nome não encontrado, não tem ninguem além da " + MeuAmor + " no meu coração.");
            }
        }

        [HttpGet]
        [Route("BuscarDatasMaisImportantes")]
        public IActionResult BuscarDatasMaisImportantes()
        {
            List<string> datas = new List<string>();
            datas.Add("15/11/2017");
            datas.Add("22/12/2017");
            return Ok(datas);
        }

        [HttpGet]
        [Route("BuscarMensagemEspecial")]
        public IActionResult BuscarMensagemEspecial()
        {
            return Ok("Oi meu amor <3 quero que saiba que você é a pessoa mais especial do mundo pra mim, me preocupo com cada coisinha sobre você, saiba que estou ao seu lado para qualquer coisa \n A vida não seria vida sem você ! EU TE AMO MUITO !!!! \n Thomas Mendes ");
        }

        [HttpGet]
        [Route("EasterEgg")]
        public IActionResult EasterEgg()
        {
            return Ok("Vale 1 massagem no corpo todo <3");
        }
    }
}