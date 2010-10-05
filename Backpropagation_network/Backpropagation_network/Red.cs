using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backpropagation_network
{
    class Red
    {
        /// <summary>
        /// variables Globales
        /// </summary>
        double[] pesosCapaEntrada;
        double[] pesosCapaOculta;
        double[] pesosCapaSalida;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pesosEntrada"></param>
        /// <param name="pesosOculta"></param>
        /// <param name="pesosSalida"></param>
        public Red(double[] pesosEntrada, double[] pesosOculta, double[] pesosSalida)
        {
            pesosCapaEntrada = pesosEntrada;
            pesosCapaOculta = pesosOculta;
            pesosCapaSalida = pesosSalida;
        }

        /// <summary>
        /// Get de los pesos de la capa de entrada
        /// </summary>
        /// <returns></returns>
        public double[] obtenerPesosEntrada()
        {
            return (pesosCapaEntrada);
        }

        /// <summary>
        /// Get de los pesos de la capa oculta
        /// </summary>
        /// <returns></returns>
        public double[] obtenerPesosOculta()
        {
            return (pesosCapaOculta);
        }

        /// <summary>
        /// Get de los pesos de la capa de salida
        /// </summary>
        /// <returns></returns>
        public double[] obtenerPesosSalida()
        {
            return (pesosCapaSalida);
        }

        /// <summary>
        /// Set de los pesos de la capa de entrada
        /// </summary>
        /// <param name="entrada"></param>
        public void colocarPesosEntrada(double[] entrada)
        {
            pesosCapaEntrada = entrada;
        }

        /// <summary>
        /// Set de los pesos de la capa oculta
        /// </summary>
        /// <param name="oculta"></param>
        public void colocarPesosOculta(double[] oculta)
        {
            pesosCapaOculta = oculta;
        }

        /// <summary>
        /// Set de los pesos de la capa de salida
        /// </summary>
        /// <param name="salida"></param>
        public void colocarPesosSalida(double[] salida)
        {
            pesosCapaSalida = salida;
        }
    }

}
