using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class WordDocumentFile : IFile
    {
        public string FileName { get; set; }

        public int Size { get; set; }

        public DateTime CreatedOn { get; set; }

        public void Compress()
        {
            Console.WriteLine("Compressing WordFile");
        }
        public void Present()
        {
            Console.WriteLine($"{FileName} printing..");
        }
    }
}
