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
            char nom;

            Pen pluma1 = new Pen(Color.Blue, 2);
            Pen pluma2 = new Pen(Color.White, 13);
            SolidBrush mensajes = new SolidBrush(Color.Red);
            //graphPanel.CreateGraphics().DrawEllipse(pluma1, 20, 20, graphPanel.Width - 15, graphPanel.Height - 15);
            radio = (graphPanel.Height - 30) / 2;
            angulo = 2 * Math.PI / div;
            for (int i = 0; i < graph.getNodesCount(); i++)
            {

                nom = graph.getNode(i).getCiudad().getName();
                if (graph.getNode(i).getCiudad().getPos() < 0 && opc == 0)
                {
                    x = Convert.ToInt32(Math.Cos(i * angulo) * radio + 20 + radio);
                    y = Convert.ToInt32(Math.Sin(i * angulo) * radio + 20 + radio);
                    graph.getNode(i).getCiudad().setPos(x, y);
                }
                else
                {
                    x = graph.getNode(i).getCiudad().getPosX();
                    y = graph.getNode(i).getCiudad().getPosY();
                }

                graphPanel.CreateGraphics().DrawEllipse(pluma2, x - 10, y - 10, 15, 15);
                graphPanel.CreateGraphics().DrawString(Convert.ToString(nom), DefaultFont, mensajes, x - 9, y - 9);

            }

            AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 8);
            pluma1.CustomEndCap = bigArrow;

            int originX = 0;
            int originY = 0;
            int destinyX = 0;
            int destinyY = 0;

            int letterX = 0;
            int letterY = 0;
            string letter = "";

            for (int j = 0; j < graph.getNodesCount(); j++)
            {
                for (int k = 0; k < graph.getNode(j).getAdyCount(); k++)
                {

                    originX = this.calculateX(graph.getNode(j).getCiudad().getPosX());
                    originY = this.calculateY(graph.getNode(j).getCiudad().getPosY());
                    destinyX = this.calculateX(graph.getNode(j).getAdyEl(k).getNodo().getCiudad().getPosX());
                    destinyY = this.calculateY(graph.getNode(j).getAdyEl(k).getNodo().getCiudad().getPosY());

                    graphPanel.CreateGraphics().DrawLine(pluma1,
                        originX,
                        originY,
                        destinyX,
                        destinyY);

                    letterX = (graph.getNode(j).getCiudad().getPosX() + graph.getNode(j).getAdyEl(k).getNodo().getCiudad().getPosX()) / 2;
                    letterY = (graph.getNode(j).getCiudad().getPosY() + graph.getNode(j).getAdyEl(k).getNodo().getCiudad().getPosY()) / 2;
                    letter = graph.getNode(j).getAdyEl(k).getPondCosto() + ", " + graph.getNode(j).getAdyEl(k).getPondTime();

                    //graphPanel.CreateGraphics().DrawString(letter, DefaultFont, mensajes, letterX - 9, letterY - 9);
                    graphPanel.CreateGraphics().DrawString(letter, DefaultFont, mensajes, letterX - letter.Length, letterY - 15);
                }
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
