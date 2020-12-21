
using System;
using System.Drawing;

namespace CapaInfrastructure
{
    public class DataImage : IDataImage
    {
        public Bitmap OpenImage(string path)
        {
            return new Bitmap(path,true);
        }

        public bool SaveImage(string path, string name, Bitmap image)
        {
            try
            {
                image.Save(path);
                return true;
            }
            catch (System.Exception e)
            {
                Console.WriteLine("No se ha podido guardar la imagen"+e);
                return false;
                throw;
            }
        }
    }
}
