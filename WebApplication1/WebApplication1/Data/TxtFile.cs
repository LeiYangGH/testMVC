using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data
{
    public class TxtFile
    {
        public TxtFile(string fullName)
        {
            this.FullName = fullName;
            this.FileName = System.IO.Path.GetFileNameWithoutExtension(fullName);
        }
        public string FileName { get; set; }
        public string FullName { get; set; }
    }
}
