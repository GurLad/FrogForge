using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public class DisplayNamedData : NamedData
    {
        private string _displayName = "";
        public string DisplayName
        {
            get
            {
                return _displayName != "" ? _displayName : Name;
            }
            set
            {
                _displayName = value;
            }
        }
    }
}
