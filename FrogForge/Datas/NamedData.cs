using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogForge.Datas
{
    public abstract class NamedData
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value.Replace("?", "").Replace("!", "").Replace("/", "").Replace(@"\", "").Replace(",", "").Replace("<", "").Replace(">", "");
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
