using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Proyecto.items
{
    public class InOut
    {
        public string ID, Dialog, opcion1, opcion2, img;

        public InOut()
        {

        }

        public static void vaciarLog() {
            System.IO.File.WriteAllText(@"C:\Users\Sebastian\source\repos\Proyecto\items\txt\PathLog.txt", String.Empty);
        }

        public void genData(string fileName)
        {

            string textFile = @"C:\Users\Sebastian\source\repos\Proyecto\items\txt\" + fileName + ".txt";
            try
            {
                string[] lines = File.ReadAllLines(textFile);
                this.ID = lines[0];
                this.Dialog = lines[1];
                this.opcion1 = lines[2];
                this.opcion2 = lines[3];
                /*MessageBox.Show(ID);
                MessageBox.Show(opcion1);
                MessageBox.Show(opcion2);
                MessageBox.Show(Dialog);*/
            }
            catch (Exception e)
            {
                // mandar mensaje jeje
            }
            //Console.ReadKey();
        }


    }
}
