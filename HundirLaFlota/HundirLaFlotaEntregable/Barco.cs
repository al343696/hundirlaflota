using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HundirLaFlotaEntregable
{
    class Barco
    {
        // Atributos indicados en el enunciado que han de estar en esta clase
        private int filaInicial;
        private int columnaInicial;
        private Orientacion orientacion;
        private int tamanyo;
        private int tocadas;

        public Barco(int f, int c, Orientacion orientacion, int tamanyo, int tocadas)
        {
            this.filaInicial = f;
            this.columnaInicial = c;
            this.orientacion = orientacion;
            this.tamanyo = tamanyo;
            this.tocadas = tocadas;
        }

        // Getters y setters necesarios para los atributos indicados en la descripción del juego ...

        public int FilaInicial { get { return filaInicial; } set { filaInicial = value; } }
        public int ColumnaInicial { get { return columnaInicial; } set { columnaInicial = value; } }
        public Orientacion Orientacion { get { return orientacion; } set { orientacion = value; } }
        public int Tamanyo { get { return tamanyo; } set { tamanyo = value; } }
        public int Tocadas { get { return tocadas; } set { tocadas = value; } }

        // Método tocaBarco() que debe calcular lo que 
        //   se indica en el enunciado.

        public bool tocaBarco() 
        {
            tocadas++;
            if (tocadas == tamanyo) { return true; } 
            else { return false; }
        }

        // Método toString() que debe devolver un String con el
        //   contenido que se indica en el enunciado.

        public string toString()
        {
            string informacion = filaInicial + "#" + columnaInicial + "#" + orientacion + "#" + tamanyo;
            return informacion; 
        }

    }
}
