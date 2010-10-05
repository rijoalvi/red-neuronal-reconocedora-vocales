using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;

namespace Backpropagation_network
{
    class ControlDeRed
    {
        /// <summary>
        /// constructor
        /// </summary>
        public ControlDeRed()
        {
        }

        /// <summary>
        /// Metodo que se llama para empezar a entrenar la red
        /// </summary>
        /// <param name="numNeuronas"></param>
        /// <param name="error"></param>
        /// <param name="direccionArchivo"></param>
        public void entrenar(int numNeuronas, double error, StreamReader direccionArchivo)
        {
            //para leer una linea de texto:
            string sLine = "";
            ArrayList arrText = new ArrayList();
            while (sLine != null)
            {
                sLine = direccionArchivo.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            direccionArchivo.Close();
        }


    }
}
