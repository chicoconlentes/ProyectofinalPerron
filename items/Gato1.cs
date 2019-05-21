using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.items
{
    class Gato1:Personaje
    {
        public string name = "GatoQueSemuere";
        public static int salud = 100, hambre = 0;

        public Gato1(string name) : base(name)
        {
            this.name = name;
        }
    }
}
