using System.Threading.Tasks;
namespace MoviesProject.Server.Storage
{
    public interface IFilesStorage
    {
         Task<string> SaveFile(byte[] contenido, string extension, string nombreCapeta);
         Task DeleteFile(string ruta, string FilesStorage);
         Task<string> EditFile(byte[] contenido, string extension, string nombreCapeta, string ruta);
    }
}