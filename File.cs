using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    interface IFile
    {
        string FileName { get; set; }

        int Size { get; set; }

        DateTime CreatedOn { get; set; }

        abstract void Compress();
    }
}
