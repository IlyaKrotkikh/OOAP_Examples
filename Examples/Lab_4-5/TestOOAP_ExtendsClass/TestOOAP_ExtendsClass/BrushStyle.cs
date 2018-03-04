using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOAP_ExtendsClass
{
    class BrushStyle
    {
        public String Name { get; set; }

        public BrushStyle(string Name)
        {
            this.Name = Name;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
