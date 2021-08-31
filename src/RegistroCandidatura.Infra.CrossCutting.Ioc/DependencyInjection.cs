using System;
using Amazon.Extensions.NETCore.Setup;
using Amazon.Runtime;
using Amazon.S3;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RegistroCandidatura.Domain.Interfaces.BlobStorages;
using RegistroCandidatura.Domain.Interfaces.Repositories;
using RegistroCandidatura.Infra.Data.Context;
using RegistroCandidatura.Infra.Data.Repositories.RegistroCandidatura;
using RegistroCandidatura.Infra.ExternalServices.BlobStorage.Minio;

namespace RegistroCandidatura.Infra.CrossCutting.Ioc
{
    public static class DependencyInjection
    {
        public static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RegistroCandidaturaContext>();
            services.AddScoped<IRegistroCandidaturaRepository, RegistroCandidaturaRepository>();
            //todo Implementar via injeção de dependêcia
            // var awsSecretKey = Environment.GetEnvironmentVariable("AWS_SECRET_KEY");
            // if (string.IsNullOrWhiteSpace(awsSecretKey))
            // {
            //     Environment.SetEnvironmentVariable("AWS_ACCESS_KEY_ID","minio");
            // }
            // var awsSecretAccessKey =Environment.GetEnvironmentVariable("AWS_SECRET_ACCESS_KEY");
            // if (string.IsNullOrWhiteSpace(awsSecretKey))
            // {
            //     Environment.SetEnvironmentVariable("AWS_SECRET_ACCESS_KEY","minio123");
            // }            
            //services.AddDefaultAWSOptions(configuration.GetAWSOptions());
            //services.AddAWSService<IAmazonS3>();
            services.AddScoped<IBlobStorageService, BlobStorageService>();
        }
    }
}