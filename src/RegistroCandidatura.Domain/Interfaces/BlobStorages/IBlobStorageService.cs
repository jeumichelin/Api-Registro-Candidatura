using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace RegistroCandidatura.Domain.Interfaces.BlobStorages
{
    public interface IBlobStorageService
    {
        Task<bool> ExisteBucketAsync(string nomeDoBucket, CancellationToken cancellationToken = default);

        Task CriarBucketAsync(string nomeDoBucket, CancellationToken cancellationToken = default);

        Task<bool> ExisteArquivoAsync(string nomeDoBucket, string nomeObjeto, CancellationToken cancellationToken = default);

        Task AdicionarArquivoAsync(string nomeDoBucket, string nomeObjeto, Stream arquivo, CancellationToken cancellationToken = default);

        Task<Stream> ObterArquivoAsync(string nomeDoBucket, string nomeObjeto, CancellationToken cancellationToken = default);

        Task RemoverArquivoAsync(string nomeDoBucket, string nomeObjeto, CancellationToken cancellationToken = default);
    }
}