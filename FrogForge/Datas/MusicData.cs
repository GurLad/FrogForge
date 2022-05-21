using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class MusicData : NamedData
    {
        public string FullFileName { get; set; }
        public string FileName
        {
            get
            {
                return FullFileName.Substring(FullFileName.LastIndexOf(@"\"));
            }
        }
        public string Directory
        {
            get
            {
                return FullFileName.Substring(0, FullFileName.LastIndexOf(@"\"));
            }
        }

        public MusicData(string internalName, string fullFileName)
        {
            Name = internalName;
            FullFileName = fullFileName;
        }
    }
}
