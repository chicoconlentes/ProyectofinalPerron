using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.items
{
    class Bruja:Personaje
    {
        public string name="brujamala";
        public static int salud = 100, hambre = 0;

        public Bruja(string name): base(name)
        {
            this.name = name;
        }

    }
}
