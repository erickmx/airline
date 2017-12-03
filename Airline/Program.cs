using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
// added by me
using System.IO;

namespace Airline
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // declaring tdas
            GenericList<Vuelo> flyList = new GenericList<Vuelo>();
            readFromDisk(ref flyList);

            Graph graph = new Graph();
            //graphFromDisk(ref graph, flyList);
            //graph.imprime();
            graph = testKruskal();
            // program auoconfig
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm principalForm = new MainForm(ref flyList, graph);
            Application.Run(principalForm);

            // saving the changes on the tdas
            writeToDisk(ref flyList);
            graphToDisk(ref graph);
            graph.imprime();

        }


        static void agregar(ref GenericList<Vuelo> vuelosList)
        {

            //A
            Vuelo v1 = new Vuelo('A', 'B', 50, 800);
            Vuelo v2 = new Vuelo('A', 'F', 90, 1050);
            Vuelo v3 = new Vuelo('A', 'G', 80, 1150);
            //B
            Vuelo v4 = new Vuelo('B', 'A', 50, 800);
            Vuelo v5 = new Vuelo('B', 'C', 40, 750);
            Vuelo v6 = new Vuelo('B', 'D', 60, 650);
            Vuelo v7 = new Vuelo('B', 'E', 70, 1850);
            //C
            Vuelo v8 = new Vuelo('C', 'B', 35, 800);
            Vuelo v9 = new Vuelo('C', 'E', 50, 850);
            //E
            Vuelo v10 = new Vuelo('E', 'C', 45, 750);
            Vuelo v11 = new Vuelo('E', 'G', 80, 1150);
            Vuelo v12 = new Vuelo('E', 'L', 60, 1650);
            Vuelo v13 = new Vuelo('E', 'D', 35, 700);
            //D
            Vuelo v14 = new Vuelo('D', 'E', 45, 900);
            Vuelo v15 = new Vuelo('D', 'B', 55, 700);
            //F
            Vuelo v16 = new Vuelo('F', 'B', 65, 800);
            Vuelo v17 = new Vuelo('F', 'L', 140, 2850);
            //G
            Vuelo v18 = new Vuelo('G', 'A', 95, 1250);
            Vuelo v19 = new Vuelo('G', 'E', 75, 1175);
            Vuelo v20 = new Vuelo('G', 'L', 135, 2675);
            Vuelo v21 = new Vuelo('G', 'J', 60, 1400);
            Vuelo v22 = new Vuelo('G', 'H', 25, 450);
            //H
            Vuelo v23 = new Vuelo('H', 'G', 30, 350);
            Vuelo v24 = new Vuelo('H', 'I', 35, 400);
            //I
            Vuelo v25 = new Vuelo('I', 'H', 30, 400);
            Vuelo v26 = new Vuelo('I', 'K', 35, 400);
            //K
            Vuelo v27 = new Vuelo('K', 'I', 35, 400);
            Vuelo v28 = new Vuelo('K', 'J', 25, 300);
            //J
            Vuelo v29 = new Vuelo('J', 'L', 40, 750);
            Vuelo v30 = new Vuelo('J', 'M', 70, 1450);
            //L
            Vuelo v31 = new Vuelo('L', 'M', 40, 650);
            Vuelo v32 = new Vuelo('L', 'K', 70, 700);
            Vuelo v33 = new Vuelo('L', 'E', 60, 1550);
            //M
            Vuelo v34 = new Vuelo('M', 'L', 40, 700);

            vuelosList.Add(v1);
            vuelosList.Add(v2);
            vuelosList.Add(v3);
            vuelosList.Add(v4);
            vuelosList.Add(v5);
            vuelosList.Add(v6);
            vuelosList.Add(v7);
            vuelosList.Add(v8);
            vuelosList.Add(v9);
            vuelosList.Add(v10);
            vuelosList.Add(v11);
            vuelosList.Add(v12);
            vuelosList.Add(v13);
            vuelosList.Add(v14);
            vuelosList.Add(v15);
            vuelosList.Add(v16);
            vuelosList.Add(v17);
            vuelosList.Add(v18);
            vuelosList.Add(v19);
            vuelosList.Add(v20);
            vuelosList.Add(v21);
            vuelosList.Add(v22);
            vuelosList.Add(v23);
            vuelosList.Add(v24);
            vuelosList.Add(v25);
            vuelosList.Add(v26);
            vuelosList.Add(v27);
            vuelosList.Add(v28);
            vuelosList.Add(v29);
            vuelosList.Add(v30);
            vuelosList.Add(v31);
            vuelosList.Add(v32);
            vuelosList.Add(v33);
            vuelosList.Add(v34);


        }

        static void readFromDisk(ref GenericList<Vuelo> vuelosList)
        {
            if (File.Exists("ArchivoVuelos.bin"))
            {
                using (Stream stream = File.Open("ArchivoVuelos.bin", FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    vuelosList = (GenericList<Vuelo>)bformatter.Deserialize(stream);
                }
            }
            else
            {
                agregar(ref vuelosList);
            }

        }

        static void writeToDisk(ref GenericList<Vuelo> vuelosList)
        {
            using (Stream stream = File.Open("ArchivoVuelos.bin", FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, vuelosList);
            }
        }

        static void graphFromDisk(ref Graph vuelosList, GenericList<Vuelo> lv)
        {
            if (File.Exists("ArchivoRutas.bin"))
            {
                using (Stream stream = File.Open("ArchivoRutas.bin", FileMode.Open))
                {
                    var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                    vuelosList = (Graph)bformatter.Deserialize(stream);
                }
            }
            else
            {
                vuelosList = new Graph(lv);
            }

        }

        static void graphToDisk(ref Graph vuelosList)
        {
            using (Stream stream = File.Open("ArchivoRutas.bin", FileMode.Create))
            {
                var bformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                bformatter.Serialize(stream, vuelosList);
            }
        }

        static Graph testKruskal()
        {
            /*
            Graph grafiti = new Graph();
            grafiti.addVertex('a');
            grafiti.addVertex('b');
            grafiti.addVertex('c');
            grafiti.addVertex('d');
            grafiti.addVertex('e');
            /*
            grafiti.addVertex('f');

            grafiti.createAdy('a', 'b', 10, 10);
            grafiti.createAdy('a', 'c', 20, 20);
            grafiti.createAdy('a', 'd', 30, 30);

            grafiti.createAdy('b', 'c', 10, 10);
            grafiti.createAdy('b', 'f', 40, 40);

            grafiti.createAdy('c', 'f', 5, 5);

            grafiti.createAdy('d', 'e', 15, 15);
            grafiti.createAdy('d', 'a', 80, 80);

            grafiti.createAdy('e', 'd', 25, 25);
            */
            /*
            grafiti.createAdy('a', 'b', 7, 7);
            grafiti.createAdy('a', 'c', 20, 20);
            grafiti.createAdy('a', 'e', 5, 5);

            grafiti.createAdy('b', 'c', 2, 2);
            grafiti.createAdy('b', 'd', 6, 6);
            grafiti.createAdy('b', 'e', 9, 9);

            grafiti.createAdy('c', 'd', 5, 5);

            grafiti.createAdy('d', 'e', 10, 10);

            Console.WriteLine("Grafo de pruebas: ");
            grafiti.imprime();

            Console.WriteLine("Su kruskal: ");
            grafiti.kruskal(1);
            */
            Graph grafiti = new Graph();
            grafiti.addVertex('A');
            grafiti.addVertex('B');
            grafiti.addVertex('C');
            grafiti.addVertex('D');
            grafiti.addVertex('E');
            grafiti.addVertex('F');
            grafiti.addVertex('G');
            grafiti.addVertex('H');
            grafiti.addVertex('I');
            grafiti.addVertex('J');

            grafiti.createAdy('A', 'B', 1, 1);
            grafiti.createAdy('F', 'E', 5, 5);
            grafiti.createAdy('B', 'D', 18, 18);
            grafiti.createAdy('A', 'C', 25, 25);
            grafiti.createAdy('C', 'B', 30, 30);
            grafiti.createAdy('C', 'E', 50, 50);
            grafiti.createAdy('B', 'E', 52, 52);
            grafiti.createAdy('F', 'D', 60, 60);
            grafiti.createAdy('H', 'I', 62, 62);
            grafiti.createAdy('I', 'J', 68, 68);
            grafiti.createAdy('F', 'G', 70, 70);
            grafiti.createAdy('H', 'J', 90, 90);

            Console.WriteLine("Grafo de pruebas: ");
            grafiti.imprime();

            Console.WriteLine("Su kruskal: ");
            grafiti.kruskal(1);

            Console.WriteLine("Su prim: ");
            var prim = grafiti.prim(1, 'F');

            foreach(var p in prim)
            {
                Console.WriteLine(p.getOrigin().getCiudad().getName() + "->" + p.getDestiny().getCiudad().getName() + ": " + p.getPondCosto());
            }

            return grafiti;

        }


    }
}
