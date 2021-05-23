using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace BaseExporter.Contracts
{
    public interface IWordPage
    {
        void CreatePage(Document document);
    }
}
