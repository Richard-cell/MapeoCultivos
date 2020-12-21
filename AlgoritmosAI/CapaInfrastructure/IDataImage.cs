
using System.Drawing;
namespace CapaInfrastructure
{
    public interface IDataImage
    {
        Bitmap OpenImage(string path);
        bool SaveImage(string path, string name, Bitmap image);
    }
}
