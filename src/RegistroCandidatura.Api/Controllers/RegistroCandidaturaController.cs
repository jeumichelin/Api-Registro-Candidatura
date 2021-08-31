using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegistroCandidatura.Domain.Commands.RegistroCandidatura.Deletar;
using RegistroCandidatura.Domain.Commands.RegistroCandidatura.Listar;
using RegistroCandidatura.Domain.Commands.RegistroCandidatura.Obter;
using RegistroCandidatura.Dtos.Requests;
using RegistroCandidatura.Dtos.Responses;
using RegistroCandidatura.Mappers;

namespace RegistroCandidatura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegistroCandidaturaController : ControllerBase
    {
        private readonly ILogger<RegistroCandidaturaController> _logger;
        private readonly IMediator _mediator;

        public RegistroCandidaturaController(ILogger<RegistroCandidaturaController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<RegistroCandidaturaResponse> ObterRegistroCandidatura(string id)
        {
            return ObterRegistrosCandidaturaResponseMapper.Map(
                await _mediator.Send(new ObterRegistroCandidaturaCommand()
                {
                    Id = id
                },default));
        }
        
        [HttpGet("Listar")]
        public async Task<IEnumerable<RegistroCandidaturaResponse>> ListarRegistrosCandidatura()
        {
            var response = await _mediator.Send(new ListarRegistroCandidaturaCommand());
            return ListarRegistrosCandidaturaResponseMapper.Map(response);
        }        

        [HttpPost]
        public async Task<IActionResult> InserirRegistroCandidatura(RegistroCandidaturaRequest request)
        {
            return Ok(await _mediator.Send(InserirRegistroCandidaturaRequestMapper.Map(request)));
        }

        [HttpPut]
        public async Task<IActionResult> AtualizarRegistroCandidatura(RegistroCandidaturaRequest request)
        {
            await _mediator.Send(AtualizarRegistroCandidaturaRequestMapper.Map(request));
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeletarRegistroCandidatura(string id)
        {
            await _mediator.Send(new DeletarRegistroCandidaturaCommand(){Id = id});
            return Ok();
        }
    }
}