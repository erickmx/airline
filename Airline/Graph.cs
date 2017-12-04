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
        public void removeAlone()
        {
            bool connected = false;
            int count = 0;

            foreach (Node n in listaNodos)
            {
                connected = n.getAdyCount() > 0;
                if (!connected)
                {
                    count =
                    listaNodos.Count(
                        node => node.getAdyList().Exists(
                            ady => ady.getNodo().getCiudad().getName().Equals(n.getCiudad().getName())
                        )
                    );

                    if (count < 1)
                    {
                        removeVertex(n.getCiudad().getName());
                        removeAlone();
                        break;
                    }
                }
            }

        }

        public void removeAlone(char city)
        {
            int alone =
            listaNodos.Count(
                node => node.getAdyList().Exists(
                    ady => ady.getNodo().getCiudad().Equals(city)
                    )
                );

            bool connect = listaNodos.Find(node => node.getCiudad().Equals(city)).getAdyCount() == 0;


            if (alone == 0 && connect)
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

        /////////////////////////////////
        //         Start kruskal       //
        /////////////////////////////////

        private List<Edge> inicializarCandidatos(int opc)
        {
            List<Edge> candidatos = new List<Edge>();

            foreach (Node n in this.listaNodos)
            {
                for (int i = 0; i < n.getAdyCount(); i++)
                {
                    Edge candidato = new Edge(n, n.getAdyEl(i).getNodo(), n.getAdyEl(i).getPondTime(), n.getAdyEl(i).getPondCosto());
                    candidatos.Add(candidato);
                }
            }

            candidatos.Sort(
                (candidato1, candidato2) => opc == 1 ?
                    candidato1.getPondTime().CompareTo(candidato2.getPondTime()) : candidato1.getPondCosto().CompareTo(candidato2.getPondCosto())
            );

            return candidatos;
        }

        private List<string> inicializaComponentesConexos()
        {
            List<string> cc = new List<string>();
            listaNodos.ForEach(node => cc.Add(node.getCiudad().getName().ToString()));
            return cc;
        }

        private Edge seleccionaCandidatos(List<Edge> listaCandidatos)
        {
            //como esta ordenado de menor a mayor
            Edge candidato = listaCandidatos[0];
            listaCandidatos.RemoveAt(0);
            return candidato;
            /*
            // sin ordenar seria
            int indice;
            int menor = 99999999;
            for(int i = 0; i < listaCandidatos.Count; i++)
            {
                // ejemplo con el costo
                if (listaCandidatos[i].getPondCosto() < menor)
                {
                    indice = i;
                    menor = listaCandidatos[i].getPondCosto();
                }
            }
            Edge candidatoBueno = listaCandidatos[indice];
            return candidatoBueno;
            */
        }

        private int buscaEnCC(List<string> componentesConexos, string search)
        {
            for (int i = 0; i < componentesConexos.Count; i++)
            {
                if (componentesConexos[i].Contains(search))
                {
                    return i;
                }
            }
            return -1;
        }

        private void combinacc(List<string> componentesConexos, int elem1, int elem2)
        {
            componentesConexos[elem1] += componentesConexos[elem2];
            componentesConexos.RemoveAt(elem2);
        }

        private bool sameConnectedComponent(List<string> componentesConexos, Edge candidato)
        {
            int origin = buscaEnCC(componentesConexos, candidato.getOrigin().getCiudad().getName().ToString());
            int destiny = buscaEnCC(componentesConexos, candidato.getDestiny().getCiudad().getName().ToString());
            return componentesConexos[origin].CompareTo(componentesConexos[destiny]) == 0 && origin == destiny;
        }

        public List<Edge> kruskal(int opc)
        {
            List<Edge> candidatos = inicializarCandidatos(opc);
            List<string> componentesConexos = inicializaComponentesConexos();
            List<Edge> arm = new List<Edge>();
            int component1;
            int component2;

            foreach (Edge candi in candidatos)
            {
                Console.WriteLine(candi.getOrigin().getCiudad().getName() + "->" + candi.getDestiny().getCiudad().getName() + ": " + candi.getPondTime());
            }

            while (componentesConexos.Count > 1 && candidatos.Count > 1)
            {
                Edge candidato = seleccionaCandidatos(candidatos);
                if (!sameConnectedComponent(componentesConexos, candidato))
                {
                    // componentesConexos.ForEach(c => Console.WriteLine(c));
                    // Console.WriteLine("--------------------------------------------------------");
                    arm.Add(candidato);
                    component1 = buscaEnCC(componentesConexos, candidato.getOrigin().getCiudad().getName().ToString());
                    component2 = buscaEnCC(componentesConexos, candidato.getDestiny().getCiudad().getName().ToString());
                    combinacc(componentesConexos, component1, component2);
                }
            }

            foreach (Edge edge in arm)
            {
                Console.WriteLine(edge.getOrigin().getCiudad().getName() + " -> " + edge.getDestiny().getCiudad().getName());
            }

            return arm;
        }

        /////////////////////////////////
        //          end kruskal        //
        /////////////////////////////////

        /////////////////////////////////
        //         Start Prim          //
        /////////////////////////////////

        // inicializar candidatos listo

        private Edge seleccionaFactible(List<Edge> candidatos, string s)
        {
            foreach (var candidato in candidatos)
            {
                if (perteneceAS(s, candidato.getOrigin()) && !perteneceAS(s, candidato.getDestiny()))
                {
                    return candidato;
                }
                else if (perteneceAS(s, candidato.getDestiny()) && !perteneceAS(s, candidato.getOrigin()))
                {
                    return candidato;
                }
            }
            foreach (var candidato in candidatos)
            {
                if (!perteneceAS(s, candidato.getOrigin()) && !perteneceAS(s, candidato.getDestiny()))
                {
                    return candidato;
                }
            }
            return null;
        }

        private bool perteneceAS(string s, Node v)
        {
            return s.Contains(v.getCiudad().getName().ToString());
        }

        public List<Edge> prim(int opc, char origen)
        {
            //incializaCandidatos
            var candidatos = inicializarCandidatos(opc);
            // inicializa(s, nodoaleatorio)
            var S = origen.ToString();
            var arm = new List<Edge>();

            while (S.Length < candidatos.Count)
            {
                var a = seleccionaFactible(candidatos, S);

                if (a == null)
                {
                    return arm;
                }

                arm.Add(a);

                if (perteneceAS(S, a.getOrigin()))
                {
                    // v2 u s
                    S += a.getDestiny().getCiudad().getName().ToString();
                }
                else
                {
                    // v1 u s
                    S += a.getOrigin().getCiudad().getName().ToString();
                }
            }

            return arm;

        }

        /////////////////////////////////
        //          end Prim           //
        /////////////////////////////////

        /////////////////////////////////
        //        Start Dijkstra       //
        /////////////////////////////////

        private List<DijkstraElement> inicialzaVectorDijkstra()
        {
            return (
                from node in this.listaNodos
                select new DijkstraElement(node, 9999999, false)
            ).ToList();
        }

        private DijkstraElement buscarElementoDijkstra(List<DijkstraElement> VD, Ady a)
        {
            //DE = DijkstraElement
            return VD.Find(DE => DE.getNode().getCiudad().getName().Equals(a.getNodo().getCiudad().getName()));
        }

        // falta g, pero g es el grafo en si
        /*
        private void actualizarPesos(ref List<DijkstraElement> VD, char n, int p, int opc)
        {
            var n_g = listaNodos.Find(node => node.getCiudad().getName().Equals(n));
            var pesoA = 0;
            foreach (Ady a in n_g.getAdyList())
            {
                var ED = buscarElementoDijkstra(VD, a);
                pesoA = opc == 0 ? a.getPondCosto() : a.getPondTime();
                if (p + pesoA < ED.getWeigth())
                {
                    ED.setWeigth(p + pesoA);
                    ED.setComing(n_g);
                }
            }
        }
        */
        private void actualizarPesos(ref List<DijkstraElement> VD, Node n_g, int p, int opc)
        {
            //var n_g = listaNodos.Find(node => node.getCiudad().getName().Equals(n));
            var pesoA = 0;
            foreach (Ady a in n_g.getAdyList())
            {
                var ED = buscarElementoDijkstra(VD, a);
                pesoA = opc == 0 ? a.getPondCosto() : a.getPondTime();
                if (p + pesoA < ED.getWeigth())
                {
                    ED.setWeigth(p + pesoA);
                    ED.setComing(n_g);
                }
            }
        }

        private DijkstraElement sigDefinitivo(List<DijkstraElement> VD)
        {
            return (
                from DE in VD
                where !DE.getIsDefinitive()
                orderby DE.getWeigth() ascending
                select DE
            ).First();
        }

        private bool allDefinitives(List<DijkstraElement> VD)
        {
            return VD.Count(DE => DE.getIsDefinitive()) == VD.Count;
        }

        public List<DijkstraElement> dijkstra(int opc, char origin, char destiny)
        {
            //vector dijkstra
            var VD = inicialzaVectorDijkstra();
            // arbol de expansion minimo
            var AEM = new List<DijkstraElement>();

            VD.Find(DE => DE.getNode().getCiudad().getName().Equals(origin)).setIsDefinitive(true);
            foreach (var DE in VD)
            {
                Console.WriteLine("Nodo: " + DE.getNode().getCiudad().getName() + " Peso: " + DE.getWeigth() + " definitivo: " + DE.getIsDefinitive());
            }
            // nodo inicial
            //var n = listaNodos.Find( nodo => nodo.getCiudad().getName().Equals(origin));
            var n = VD.Find(DE => DE.getNode().getCiudad().getName().Equals(origin));
            // peso
            var p = 0;
            while (!allDefinitives(VD))
            {
                actualizarPesos(ref VD, n.getNode(), p, opc);
                //var definitivo = sigDefinitivo(VD);
                n = sigDefinitivo(VD);
                n.setIsDefinitive(true);
                Console.WriteLine("Nodo: " + n.getNode().getCiudad().getName() + " Peso " + n.getWeigth());
                p = n.getWeigth();
                AEM.Add(n);
                // Descomentar para hacer que dijkstra se detenga en el destino
                //if (n.getNode().getCiudad().getName().Equals(destiny))
                //{
                //    break;
                //}
            }
            foreach (var DE in AEM)
            {
                Console.WriteLine("Nodo: " + DE.getNode().getCiudad().getName() + " Proviene de " + DE.getComming().getCiudad().getName() +" Peso: " + DE.getWeigth() + " definitivo: " + DE.getIsDefinitive());
            }
            return AEM;
        }

        /////////////////////////////////
        //        end Dijkstra         //
        /////////////////////////////////

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

    // aristas para los recorrimientos
    public class Edge
    {
        Node origin;
        Node destiny;
        int pondTime;
        int pondCosto;

        public Edge(Node origin, Node destiny, int pondTime, int pondCosto)
        {
            this.origin = origin;
            this.destiny = destiny;
            this.pondTime = pondTime;
            this.pondCosto = pondCosto;
        }

        public Node getOrigin()
        {
            return this.origin;
        }

        public Node getDestiny()
        {
            return this.destiny;
        }

        public int getPondTime()
        {
            return this.pondTime;
        }

        public int getPondCosto()
        {
            return this.pondCosto;
        }

    }

    public class DijkstraElement
    {
        int weigth;
        Node node;
        bool isDefinitive;
        Node coming;

        public DijkstraElement()
        {
            this.weigth = 0;
            this.node = null;
            this.isDefinitive = false;
            this.coming = null;
        }

        public DijkstraElement(Node node, Node coming, int weigth, bool isDefinitive) : this()
        {
            this.node = node;
            this.coming = coming;
            this.weigth = weigth;
            this.isDefinitive = isDefinitive;
        }

        public DijkstraElement(Node node, int weigth, bool isDefinitive) : this(node, null, weigth, isDefinitive)
        {

        }

        public int getWeigth()
        {
            return this.weigth;
        }

        public Node getNode()
        {
            return this.node;
        }

        public bool getIsDefinitive()
        {
            return this.isDefinitive;
        }

        public Node getComming()
        {
            return this.coming;
        }

        public void setWeigth(int weigth)
        {
            this.weigth = weigth;
        }

        public void setNode(Node node)
        {
            this.node = node;
        }

        public void setIsDefinitive(bool isDefinitive)
        {
            this.isDefinitive = isDefinitive;
        }

        public void setComing(Node coming)
        {
            this.coming = coming;
        }

    }


}
