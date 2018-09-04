using GeradorCpf_Cnpj.Models;
using GeradorCpf_Cnpj.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GeradorCpf_Cnpj.Controllers
{
    [RoutePrefix("api/gerar")]
    public class GeradorController : ApiController
    {
        [Route("cpf")]
        public HttpResponseMessage GetCpf()
        {
            var cpf = CpfUtils.GerarCpf();
            return Request.CreateResponse(HttpStatusCode.OK, cpf);
        }
        [Route("cnpj")]
        public HttpResponseMessage GetCnpj()
        {
            var cnpj = CnpjUtils.GerarCnpj();
            return Request.CreateResponse(HttpStatusCode.OK, cnpj);
        }
        [Route("validacao/cpf")]
        [HttpPost]
        public HttpResponseMessage Post([FromBody] GeradorCpf gerador)
        {
           gerador = CpfUtils.GerarCpf();
           bool valido = CpfUtils.ValidarCpf(gerador);
           return Request.CreateResponse(HttpStatusCode.OK, valido);
        }
        [Route("validacao/cnpj/{gerador}")]
        [HttpPost]
        public HttpResponseMessage Post([FromBody] GeradorCnpj gerador)
        {
            //gerador = CnpjUtils.GerarCnpj();
            bool valido = CnpjUtils.ValidarCnpj(gerador);
            return Request.CreateResponse(HttpStatusCode.OK, valido);
        }
    }
}
