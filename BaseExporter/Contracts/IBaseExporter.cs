using System.IO;

namespace BaseExporter.Contracts
{
    public interface IBaseExporter<T>
    {
        T CreateExportDoc();
        void SaveExportDoc();

    }
}
