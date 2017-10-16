using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    [Serializable]
    public class Pasajero
    {

        int edad;
        string nombre;
        string apellido;
        int numeroAsiento;
        string vuelo;

        public Pasajero()
        {
            this.edad = 0;
            this.nombre = "";
            this.apellido = "";
            this.vuelo = "";
            this.numeroAsiento = -1;
        }

        public int getEdad()
        {
            return this.edad;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getApellido()
        {
            return this.apellido;
        }

        public int getNumeroAsiento()
        {
            return this.numeroAsiento;
        }

        public string getCompleteName()
        {
            return this.nombre + " " + this.apellido;
        }

        public string getVuelo()
        {
            return this.vuelo;
        }


        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public void setNumeroAsiento(int numeroAsiento)
        {
            this.numeroAsiento = numeroAsiento;
        }

        public void setCompleteName(string completeName)
        {
            String[] aux = completeName.Split(' ');
            this.nombre = aux[0];
            this.apellido = aux[aux.Length - 1];
        }

        public void setVuelo(string vuelo)
        {
            this.vuelo = vuelo;
        }

        public override string ToString()
        {
            return this.nombre + " " + this.apellido + " " + (this.numeroAsiento + 1);
        }


        public int compareTo(Pasajero p, int opc)
        {
            int valor = 0;
            switch (opc)
            {
                case 1:
                    valor = this.getCompleteName().CompareTo(p.getCompleteName());
                    break;
                case 2:
                    valor = this.vuelo.CompareTo(p.vuelo);
                    break;
                case 3:
                    if (this.numeroAsiento > p.numeroAsiento)
                    {
                        valor = 1;
                    }
                    else if (this.numeroAsiento < p.numeroAsiento)
                    {
                        valor = -1;
                    }
                    break;
            }
            return valor;
        }


    }
}
