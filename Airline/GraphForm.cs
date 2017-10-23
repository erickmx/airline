using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// added by me
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using System.Drawing.Drawing2D;

namespace Airline
{
    public partial class GraphForm : MaterialForm
    {

        Graph graph;
        int opc;
        int posX;
        int posY;

        public GraphForm(ref Graph graph, int opc)
        {
            this.graph = graph;
            this.opc = opc;

            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue300, // parte debajo de la barra 
                Primary.Blue400, // barra de opciones
                Primary.Blue400, // ??
                Accent.Green100, // shades de adorno
                TextShade.WHITE  // color letra
                );

            posX = -1;
            posY = -1;

            MessageBox.Show("da click en la posicion de la nueva ciudad", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        public int getPosX()
        {
            return posX;
        }

        public int getPosY()
        {
            return posY;
        }

        private void graphMaterialLabel_Paint(object sender, PaintEventArgs e)
        {
            startDraw();
        }


        private void graphMaterialLabel_MouseClick(object sender, MouseEventArgs e)
        {
            this.posX = e.X - 15;
            this.posY = e.Y - 15;
            MessageBox.Show("Punto almacenado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }

        private void startDraw()
        {
            double angulo;
            double radio;
            int div = graph.getNodesCount();
            int x;
            int y;
            string nom;

            Pen pluma1 = new Pen(Color.BlueViolet);
            Pen pluma2 = new Pen(Color.Red);
            SolidBrush mensajes = new SolidBrush(Color.White);
            
            radio = (graphPanel.Height - 30) / 2;
            angulo = 2 * Math.PI / div;

            for (int i = 0; i < graph.getNodesCount(); i++)
            {   
                x = graph.getNode(i).getCiudad().getPosX();
                y = graph.getNode(i).getCiudad().getPosY();

                graphPanel.CreateGraphics().DrawEllipse(pluma2, x - 10, y - 10, 20, 20);
            }

            int originX = 0;
            int originY = 0;
            int destinyX = 0;
            int destinyY = 0;

            int letterX = 0;
            int letterY = 0;
            string letter;

            Pen arista = new Pen(Color.BlueViolet, 1);

            SolidBrush letterPen = new SolidBrush(Color.White);
            AdjustableArrowCap arrow = new AdjustableArrowCap(3, 5);
            arista.CustomEndCap = arrow;

            for (int i = 0; i < graph.getNodesCount(); i++)
            {
                for (int j = 0; j < graph.getNode(i).getAdyCount(); j++)
                {
                    originX = graph.getNode(i).getCiudad().getPosX();
                    originY = graph.getNode(i).getCiudad().getPosY();
                    destinyX = graph.getNode(i).getAdyEl(j).getNodo().getCiudad().getPosX();
                    destinyY = graph.getNode(i).getAdyEl(j).getNodo().getCiudad().getPosY();

                    this.graphPanel.CreateGraphics().DrawLine(arista, originX, originY, destinyX, destinyY);

                    letterX = (originX + destinyX) / 2;
                    letterY = (originY + destinyY) / 2;
                    letter = graph.getNode(i).getAdyEl(j).getPondCosto() + ", " + graph.getNode(i).getAdyEl(j).getPondTime();
                    graphPanel.CreateGraphics().DrawString(letter, DefaultFont, letterPen, letterX, letterY);
                }
            }

            for (int i = 0; i < graph.getNodesCount(); i++)
            {
                nom = graph.getNode(i).getCiudad().getName().ToString();
                x = graph.getNode(i).getCiudad().getPosX();
                y = graph.getNode(i).getCiudad().getPosY();

                graphPanel.CreateGraphics().DrawString(nom, DefaultFont, mensajes, x - 5, y - 5);

            }

        }



        private int calculateX(int x)
        {
            int diameter = 15;
            int posX = this.graphPanel.Width;
            posX = posX / 4;
            if (x > posX * 0 && x < posX * 1)
            {
                return x + diameter;
            }
            if (x > posX * 1 && x < posX * 2)
            {
                return x + (diameter / 2);
            }
            if (x > posX * 2 && x < posX * 3)
            {
                return x;
            }
            if (x > posX * 3 && x < posX * 4)
            {
                return x - diameter;
            }

            return 0;
        }

        private int calculateY(int y)
        {
            int diameter = 15;
            int posY = this.graphPanel.Height + 15;
            posY = posY / 4;
            if (y > posY * 0 && y < posY * 1)
            {
                return y + diameter;
            }
            if (y > posY * 1 && y < posY * 2)
            {
                return y + (diameter / 2);
            }
            if (y > posY * 2 && y < posY * 3)
            {
                return y;
            }
            if (y > posY * 3 && y < posY * 4)
            {
                return y - diameter;
            }
            return 0;
        }



    }
}
