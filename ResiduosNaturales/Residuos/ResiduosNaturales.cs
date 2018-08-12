using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Residuos
{
    public class ResiduosNaturales

    {
        private string tipo;
        private int identificador;
        private string nombre;

        public ResiduosNaturales(string tipo, int identificador, string nombre)
        {
            this.Tipo = tipo;
            this.identificador = identificador;
            this.nombre = nombre;
        }

        public string Tipo { get => tipo; set => tipo = value; }
        public int Identificador { get => identificador; set => identificador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
