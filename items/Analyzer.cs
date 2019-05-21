using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.items
{
    public class Analyzer
    {
        public string opcionText = "";
        public string referencia = "";
        public string acciones = "";
        public string vida = "";
        public string hambre = "";

        public Analyzer(string cadena)
        {
            bool comillasActivadas = false;
            bool corchetesActivados = false;
            bool parentesisActivados = false;
            int counter = 0;
            int vida = -1;
            int hambre = -1;


            for (int i = 0; i < cadena.Length; i++)
            {
                if (counter == 6)
                {
                    if (vida < 0)
                    {
                        // algo

                    }
                    else
                    {
                        // algo


                    }
                }
                if (comillasActivadas && cadena[i] != '"')
                {
                    opcionText += cadena[i];
                }
                if (corchetesActivados && cadena[i] != ']')
                {
                    referencia += cadena[i];
                }
                if (parentesisActivados && cadena[i] != ')')
                {
                    acciones += cadena[i];
                }
                else
                {
                    if (cadena[i] == '[' || cadena[i] == ']')
                    {
                        corchetesActivados = !corchetesActivados;
                        counter++;
                    }

                    if (cadena[i] == '(' || cadena[i] == ')')
                    {
                        parentesisActivados = !parentesisActivados;
                        counter++;
                    }

                    if (cadena[i] == '"')
                    {
                        comillasActivadas = !comillasActivadas;
                        counter++;
                    }
                }


            }
        }
    }
}
