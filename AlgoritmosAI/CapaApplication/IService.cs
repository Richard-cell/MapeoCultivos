

namespace CapaApplication
{
    public interface IService
    {
        double[] Simulate(double[] vector, string path);
        double[] GetVector(string path);
        int GetNOutputFile(string path);
    }
}
