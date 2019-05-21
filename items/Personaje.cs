using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.items
{
    public class Personaje
    {
        public string name;
        public static int salud = 100, hambre = 0;
        public Personaje(string name)
        {
            this.name = name; 
        }
    }
}
