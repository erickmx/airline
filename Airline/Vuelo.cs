using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    [Serializable]
    public class Vuelo
    {
        char origen;
        char destino;
        string ruta;
        int tiempo;
        int costo;
        int numAsientos;
        ////////////////////////////////////////////////////////////////
        int totalAsientos;
        bool[] asientosDisp;
        GenericList<Pasajero> listaPasajeros;

        public Vuelo(char origen, char destino, int tiempo, int costo) : this(origen, destino, tiempo, costo, 20)
        {

        }

        public Vuelo(char origen, char destino, int tiempo, int costo, int asientos)
        {
            this.origen = origen;
            this.destino = destino;
            this.tiempo = tiempo;
            this.costo = costo;
            this.ruta = "SK1" + origen + destino;
            this.numAsientos = asientos;
            this.asientosDisp = new bool[this.numAsientos];
            this.listaPasajeros = new GenericList<Pasajero>();
            /////////////////////////////////////////////////////////////
            this.totalAsientos = asientos;
            for (int i = 0; i < this.numAsientos; i++)
            {
                asientosDisp[i] = false;
            }
        }

        public int getAsientosDip()
        {
            return this.numAsientos;
        }

        public void setAsientosDisp(int i)
        {
            this.numAsientos = i;
        }

        public void setAsientoOcupado(int i)
        {
            this.asientosDisp[i] = true;
        }

        public void setAsientoDesocupado(int i)
        {
            this.asientosDisp[i] = false;
        }

        public bool getAsientoOcupado(int i)
        {
            return this.asientosDisp[i];
        }

        public GenericList<Pasajero> getListaPasajeros()
        {
            return this.listaPasajeros;
        }

        public int getTotalAsientos()
        {
            return this.totalAsientos;
        }

        public char getOrigen()
        {
            return this.origen;
        }

        public char getDestino()
        {
            return this.destino;
        }

        public int getCosto()
        {
            return this.costo;
        }

        public int getTiempo()
        {
            return this.tiempo;
        }

        public override string ToString()
        {
            return ruta;
        }

        public int compareTo(Vuelo v, int opc)
        {
            int valor = 0;
            switch (opc)
            {
                case 1:
                    if (this.origen > v.origen)
                    {
                        valor = 1;
                    }
                    else if (this.origen < v.origen)
                    {
                        valor = -1;
                    }
                    break;
                case 2:
                    if (this.destino > v.destino)
                    {
                        valor = 1;
                    }
                    else if (this.destino < v.destino)
                    {
                        valor = -1;
                    }
                    break;
                case 3:
                    if (this.costo > v.costo)
                    {
                        valor = 1;
                    }
                    else if (this.costo < v.costo)
                    {
                        valor = -1;
                    }
                    break;
                case 4:
                    if (this.tiempo > v.tiempo)
                    {
                        valor = 1;
                    }
                    else if (this.tiempo < v.tiempo)
                    {
                        valor = -1;
                    }
                    break;
            }
            return valor;
        }



    }
}
