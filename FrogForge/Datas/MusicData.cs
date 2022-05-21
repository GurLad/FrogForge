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
        [System.Text.Json.Serialization.JsonIgnore]
        public string FileName
        {
            get
            {
                int index = FullFileName.LastIndexOf(@"\");
                return index >= 0 ? FullFileName.Substring(index + 1) : FullFileName;
            }
        }
        [System.Text.Json.Serialization.JsonIgnore]
        public string Directory
        {
            get
            {
                int index = FullFileName.LastIndexOf(@"\");
                return index >= 0 ? FullFileName.Substring(0, index) : "";
            }
        }

        public MusicData() { }

        public MusicData(string internalName, string fullFileName)
        {
            Name = internalName;
            FullFileName = fullFileName;
        }
    }
}
