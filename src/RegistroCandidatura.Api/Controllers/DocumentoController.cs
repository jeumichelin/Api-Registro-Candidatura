using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegistroCandidatura.Domain.Interfaces.BlobStorages;

namespace RegistroCandidatura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentoController : ControllerBase
    {
        private readonly ILogger<DocumentoController> _logger;
        private readonly IBlobStorageService _storageService;

        public DocumentoController(ILogger<DocumentoController> logger,IBlobStorageService storageService)
        {
            _logger = logger;
            _storageService = storageService;
        }
        
        [HttpPost]
        public async Task<IActionResult> UploadDocumento(string iDCandidatura, IFormFile file)
        {
            await using var stream = file.OpenReadStream();
            await _storageService.AdicionarArquivoAsync("teste", iDCandidatura, stream);
            return Ok();
        }
    }
}