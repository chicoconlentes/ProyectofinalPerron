using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.items
{
    public class Scene
    {
        public string id, Dialog, opcion1, opcion2, img;



        public Scene(int ID)
        {
            

            InOut io = new InOut();
            io.genData(ID.ToString());

            id = io.ID; // string -> int
            Dialog = io.Dialog;
            opcion1 = io.opcion1; // 
            opcion2 = io.opcion2; //
            img = id.ToString();

        }
    }
}
