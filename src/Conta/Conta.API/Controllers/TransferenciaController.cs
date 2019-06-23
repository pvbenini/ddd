using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conta.Domain.Entidades;
using Conta.Domain.Regras;
using Conta.Domain.Regras.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Conta.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferenciaController : ControllerBase
    {
        // POST: api/transferencia
        [HttpPost]
        public ActionResult Post([FromBody] Model.Transferencia data)
        {
            var obj = new Transferencia
            {
                Destino = new ContaCorrente { Numero = data.destino },
                Origem = new ContaCorrente { Numero = data.origem },
                Valor = data.valor
            };
            IRegraTransferencia regra = new RegraTransferencia(obj);
            if (!regra.Validar())
                return BadRequest();
            regra.Preparar();
            //var repo = new Conta.Infrastucture.Repository.Generic.Repository.Transferencia
            return Ok();
        }

    }
}
