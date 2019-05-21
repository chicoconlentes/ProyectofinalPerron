using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.items
{
    class Gato2:Gato1
    {
        public string name = "GatoQueTambienSemuere";
        public static int salud = 100, hambre = 0;

        public Gato2(string name) : base(name)
        {
            this.name = name;
        }
    }
}
