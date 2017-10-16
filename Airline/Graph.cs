using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    [Serializable]
    public class Graph
    {

        List<Node> listaNodos;

        public Graph()
        {
            listaNodos = new List<Node>();
        }

        public Graph(GenericList<Vuelo> lv)
        {
            // inicializar lista de nodos
            listaNodos = new List<Node>();

            // se agrega el origen
            lv.ForEach(v => this.addVertex(v.getOrigen()));
            // se agrega el destino
            lv.ForEach(v => this.addVertex(v.getDestino()));

            // crear lista de adyacencia de cad nodo
            lv.ForEach(v => this.createAdy(v.getOrigen(), v.getDestino(), v.getCosto(), v.getTiempo()));
        }

        public void imprime()
        {
            foreach (Node n in listaNodos)
            {
                Console.Write(n.getCiudad() + " -> ");
                n.imprimeAdy();
                Console.Write("\n");
            }
        }

        public bool existVertex(char city)
        {
            return listaNodos.Exists(n => n.getCiudad().Equals(city));
        }

        public void addVertex(Node n)
        {
            if (!existVertex(n.getCiudad().getName()))
            {
                this.listaNodos.Add(n);
            }
        }

        public void addVertex(char city)
        {
            Node n = new Node(city);
            addVertex(n);
        }

        public void removeVertex(char city)
        {
            listaNodos.RemoveAll(node => node.getCiudad().Equals(city));
            listaNodos.ForEach(node => this.removeAdy(node, city));
        }

        private bool existAdy(char origin, char destiny)
        {
            return existAdy(listaNodos.Find(n => n.getCiudad().Equals(origin)), destiny);
        }

        private bool existAdy(Node origin, char destiny)
        {
            for (int i = 0; i < origin.getAdyCount(); i++)
            {
                if (origin.getAdyEl(i).getNodo().getCiudad().Equals(destiny))
                {
                    return true;
                }
            }
            return false;
        }

        public void createAdy(Node origin, char destiny, int weigthC, int weigthT)
        {
            if (!existAdy(origin, destiny))
            {
                Node destNode = listaNodos.Find(node => node.getCiudad().Equals(destiny));
                Ady newAdy = new Ady(destNode, weigthC, weigthT);
                origin.insertAdy(newAdy);
            }
        }

        public void createAdy(char origin, char destiny, int weigthC, int weigthT)
        {
            createAdy(listaNodos.Find(node => node.getCiudad().Equals(origin)), destiny, weigthC, weigthT);
        }

        public void removeAdy(Node origin, char destiny)
        {
            for (int i = 0; i < origin.getAdyCount(); i++)
            {
                if (origin.getAdyEl(i).getNodo().getCiudad().Equals(destiny))
                {
                    origin.removeAdy(i);
                }
            }
            //origin.getAdyList().RemoveAll( ady => ady.getNodo().getCiudad().Equals(destiny) );
        }

        public void removeAdy(char origin, char destiny)
        {
            removeAdy(listaNodos.Find(node => node.getCiudad().Equals(origin)), destiny);
        }

        // eliminara los nodos que se encuentren aislados
        public void removeAlone(char city)
        {
            int alone =
            listaNodos.Count(
                node => node.getAdyList().Exists(
                    ady => ady.getNodo().getCiudad().Equals(city)
                    )
                );

            bool noConnect = listaNodos.Find(node => node.getCiudad().Equals(city)).getAdyCount() == 0;

            if (alone == 0 && noConnect)
            {
                removeVertex(city);
            }
        }

        public Node getNode(int i)
        {
            return listaNodos[i];
        }

        public int getNodesCount()
        {
            return listaNodos.Count;
        }

        public void setCityPoints(char city, int x, int y)
        {
            setCityPoints(listaNodos.Find(node => node.getCiudad().Equals(city)), x, y);
        }

        public void setCityPoints(Node city, int x, int y)
        {
            if (city.getCiudad().getPosX() == -1 && city.getCiudad().getPosY() == -1)
            {
                city.getCiudad().setPos(x, y);
            }
        }

    }


    [Serializable]
    public class Node
    {
        char ciudad;
        City city;
        List<Ady> listaAdy;

        public Node(char ciudad)
        {
            City c = new City(ciudad);
            this.city = c;
            this.ciudad = ciudad;
            listaAdy = new List<Ady>();
        }

        public Node(City city)
        {
            this.city = city;
            listaAdy = new List<Ady>();
        }

        public City getCiudad()
        {
            return this.city;
        }

        public void insertAdy(Ady a)
        {
            this.listaAdy.Add(a);
        }

        public void removeAdy(int i)
        {
            listaAdy.RemoveAt(i);
        }

        public List<Ady> getAdyList()
        {
            return this.listaAdy;
        }

        public Ady getAdyEl(int i)
        {
            return this.listaAdy[i];
        }

        public int getAdyCount()
        {
            return this.listaAdy.Count;
        }

        public void imprimeAdy()
        {
            foreach (Ady a in listaAdy)
            {
                Console.Write(a.getNodo().getCiudad() + " -> ");
            }
        }

    }

    [Serializable]
    public class Ady
    {
        // incluye el destino
        Node n;
        int pondCosto;
        int pondTime;

        public Ady(Node n, int pc, int pt)
        {
            this.n = n;
            this.pondCosto = pc;
            this.pondTime = pt;
        }

        public Node getNodo()
        {
            return n;
        }

        public int getPondCosto()
        {
            return pondCosto;
        }

        public int getPondTime()
        {
            return pondTime;
        }

    }

    [Serializable]
    public class City
    {
        char name;
        int posX;
        int posY;

        public City(char name)
        {
            this.name = name;
            this.posX = -1;
            this.posY = -1;
        }

        public City(char name, int posX, int posY) : this(name)
        {
            this.posX = posX;
            this.posY = posY;
        }

        public char getName()
        {
            return this.name;
        }

        public int getPosX()
        {
            return this.posX;
        }

        public int getPosY()
        {
            return this.posY;
        }

        public int getPos()
        {
            return this.posX + this.posY;
        }

        public void setPosX(int x)
        {
            this.posX = x;
        }

        public void setPosY(int y)
        {
            this.posY = y;
        }

        public void setPos(int x, int y)
        {
            this.posX = x;
            this.posY = y;
        }

        public override bool Equals(object obj)
        {
            char cityName = (char)obj;
            return cityName.Equals(name);
            //return this.name.Equals(cityName);
            //return base.Equals(obj);
        }

        public override string ToString()
        {
            return this.name.ToString();
        }

    }



}
