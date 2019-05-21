using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Proyecto.items
{
    class PathData
    {

        public static void genPath(string place)
        {
            using (StreamWriter file =  File.AppendText(@"C:\Users\Sebastian\source\repos\Proyecto\items\txt\PathLog.txt"))
            {
                try
                {
                    if(place[0]>='0' && place[0]<='9') {
                        file.Write(place+"->");
                    }
                    else {
                        throw new Exception();
                    }
                    file.Close();
                }
                catch (Exception ex) {
                    file.Write("END");
                    file.Close();
                }

            }
        }
    }
}
