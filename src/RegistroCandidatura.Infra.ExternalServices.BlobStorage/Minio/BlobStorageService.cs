using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using RegistroCandidatura.Domain.Interfaces.BlobStorages;

namespace RegistroCandidatura.Infra.ExternalServices.BlobStorage.Minio
{
    public class BlobStorageService : IBlobStorageService
    {
        //private readonly IAmazonS3 _s3Client; todo Implementar via injeção de dependêcia
        private readonly AmazonS3Client _s3Client;

        public BlobStorageService()
        {
            //_s3Client = s3Client; todo Implementar via injeção de dependêcia
            var config = new AmazonS3Config
            {
                RegionEndpoint = RegionEndpoint.USEast1,
                ServiceURL = "http://minio:9000",
                ForcePathStyle = true
            };
            _s3Client = new AmazonS3Client("minio", "minio123", config);
        }

        public async Task<bool> ExisteBucketAsync(string nomeDoBucket, CancellationToken cancellationToken = default)
        {
            var buckets = await _s3Client.ListBucketsAsync(cancellationToken);
            return buckets.Buckets.Exists(bucket => bucket.BucketName == nomeDoBucket);
        }

        public async Task CriarBucketAsync(string nomeDoBucket, CancellationToken cancellationToken = default)
        {
            if (!await ExisteBucketAsync(nomeDoBucket,cancellationToken))
            {
                await _s3Client.PutBucketAsync(nomeDoBucket,cancellationToken);
            }
        }
        
        public async Task<bool> ExisteArquivoAsync(string nomeDoBucket, string nomeObjeto, CancellationToken cancellationToken = default)
        {
            try
            {
                await _s3Client.GetObjectAsync(nomeDoBucket, nomeObjeto, cancellationToken);
                return true;
            }
            catch
            {
                return false;
            }
        }        

        public async Task AdicionarArquivoAsync(string nomeDoBucket, string nomeObjeto, Stream arquivo, CancellationToken cancellationToken = default)
        {
            await CriarBucketAsync(nomeDoBucket, cancellationToken);
            var objetoRequest = new PutObjectRequest()
            {
                BucketName = nomeDoBucket,
                Key = nomeObjeto,
                InputStream = arquivo
            };
            await _s3Client.PutObjectAsync(objetoRequest, cancellationToken);
        }

        public async Task<Stream> ObterArquivoAsync(string nomeDoBucket, string nomeObjeto, CancellationToken cancellationToken = default)
        {
            var objectResponse = await _s3Client.GetObjectAsync(nomeDoBucket, nomeObjeto, cancellationToken);
            return objectResponse.ResponseStream;
        }

        public async Task RemoverArquivoAsync(string nomeDoBucket, string nomeObjeto, CancellationToken cancellationToken = default)
        {
            await _s3Client.DeleteObjectAsync(nomeDoBucket,nomeObjeto, cancellationToken);
        }
    }
}