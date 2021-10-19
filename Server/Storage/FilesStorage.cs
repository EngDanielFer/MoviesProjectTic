using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesProject.Server.Storage
{
    public class FilesStorage: IFilesStorage
    {
        private string connectionString;
        public FilesStorage(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("AzureStorage");
        }
        /* Cargar la imagen en AzureStorage al crear un actor */
        public async Task<string> SaveFile(byte[] contenido, string extension, string nombreCarpeta)
        {
            var client = new BlobContainerClient(connectionString, nombreCarpeta);
            await client.CreateIfNotExistsAsync();
            client.SetAccessPolicy(Azure.Storage.Blobs.Models.PublicAccessType.Blob);
            /* Para crear nombres aleatorios de imágenes */
            var fileName = $"{Guid.NewGuid()}{extension}";
            var blob = client.GetBlobClient(fileName);
            using (var memoryStream = new MemoryStream(contenido))
            {
                await blob.UploadAsync(memoryStream);
            };
            /* URL de la imagen */
            return blob.Uri.ToString();
        }

        /* Eliminar la foto al eliminar el recurso por el Id */
        public async Task DeleteFile(string ruta, string nombreCarpeta)
        {
            if (string.IsNullOrEmpty(ruta))
            {
                return;
            }
            var client = new BlobContainerClient(connectionString, nombreCarpeta);
            await client.CreateIfNotExistsAsync();
            /* La ruta capturada en el GetFileName es la que devuelve el SaveFile */
            var fileName = Path.GetFileName(ruta);
            var blob = client.GetBlobClient(fileName);
            await blob.DeleteIfExistsAsync();
        }
        public async Task<string> EditFile(byte[] contenido, string extension, string nombreCapeta, string ruta)
        {
            await DeleteFile(ruta, nombreCapeta);
            return await SaveFile(contenido, extension, nombreCapeta);
        }
    }
}