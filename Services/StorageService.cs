using System.Text;
using Azure.Storage.Blobs;
using POC.Models;

namespace POC.Services
{
    public static class StorageService
    {
        private static IConfiguration conf;
        public static string UploadDoc(Documento doc) { 

            string connectionString = "SUPRIMIDO";
            string containerName = "docspropostas";
            string fileName = Guid.NewGuid().ToString() + doc.Extensao;

            //BlobServiceClient blobServiceClient = new BlobServiceClient(connectionString);
            BlobContainerClient container = new BlobContainerClient(connectionString, containerName);

            BlobClient blobClient = container.GetBlobClient(fileName);

            try
            {                

                var bytes = Convert.FromBase64String(doc.DocumentoBase64);
                MemoryStream stream = new MemoryStream(bytes);
                blobClient.Upload(stream, true);


                return blobClient.Uri.ToString();
            }
            
            catch (Exception Ex)
            {
                return "";
            }

        }
        
    }
}
