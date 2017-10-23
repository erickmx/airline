using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Added by me
using System.Drawing.Drawing2D;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;


namespace Airline
{
    public partial class MainForm : MaterialForm
    {
        // general use
        GenericList<Vuelo> flyList;
        Graph graph;

        // pasajerosTab use
        string vueloPasajero;
        string nombrePasajero;
        int asientoPasajero;
        GenericList<Pasajero> pasajerosList;

        // vuelosTab use
        string rutaVuelo;

        // rutasTab use
        char cityRoute;

        public MainForm(ref GenericList<Vuelo> flyList, Graph graph)
        {
            // General config
            this.flyList = flyList;
            this.graph = graph;

            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue300, // parte debajo de la barra 
                Primary.Blue400, // barra de opciones
                Primary.Blue400, // ??
                Accent.Green100, // shades de adorno
                TextShade.WHITE  // color letra
                );

            // pasajerosTab config
            this.pasajerosList = new GenericList<Pasajero>();
            showListPasajeros();

            // vuelosTab config
            showListVuelos();
            this.comprarVueloMaterialFlatButton.Enabled = false;

            // rutasTab config
            this.cityRoute = '\n';
            this.eliminarCiudadRutaFlatButton.Enabled = false;
            this.startDrawRuta();


           
        }


        private void pasajeroTabPage_Enter(object sender, EventArgs e)
        {
            showListPasajeros();
            this.ordenarPasajeroFlatButton.PerformClick();
            this.displayContentPasajero(pasajerosList);
        }

        private void vueloTabPage_Enter(object sender, EventArgs e)
        {
            this.vueloMaterialListView.Items.Clear();
            GenericList<Vuelo> tmp;
            if (searchVueloLineTextField.TextLength == 0)
            {
                showListVuelos();
            }
            else if (this.routeVueloRadioButton.Checked)
            {
                // filterFunc<string, Vuelo> searchFly = (cad, v) => { return validSearch(v.ToString(), cad); };
                filterFunc<string, Vuelo> searchFly = (cad, v) => v.ToString().Contains(cad);
                tmp = flyList.findDatas(this.searchVueloLineTextField.Text.ToString(), searchFly);
                showListVuelos(tmp);
            }
            else if (this.originVueloRadioButton.Checked)
            {
                filterFunc<string, Vuelo> searchOrigin = (cad, v) => cad[0].Equals(v.getOrigen()) && cad.Length == 1;
                tmp = flyList.findDatas(this.searchVueloLineTextField.Text.ToString(), searchOrigin);
                showListVuelos(tmp);
            }
            else if (this.destinyVueloRadioButton.Checked)
            {
                filterFunc<string, Vuelo> searchDestiny = (cad, v) => cad[0].Equals(v.getDestino()) && cad.Length == 1;
                tmp = flyList.findDatas(this.searchVueloLineTextField.Text.ToString(), searchDestiny);
                showListVuelos(tmp);
            }
        }

        private void rutaTabPage_Enter(object sender, EventArgs e)
        {
            startDrawRuta();
        }




        /*
         * pasajerosTab
         */

        private void showListPasajeros()
        {
            this.pasajeroMaterialListView.Items.Clear();
            this.pasajerosList.Clear();
            foreach (Vuelo v in this.flyList)
            {
                v.getListaPasajeros().ForEach( pas => pasajerosList.Add(pas) );
            }
            showListPasajeros(this.pasajerosList);
        }

        private void showListPasajeros(GenericList<Pasajero> listaP)
        {
            string[] arrayString = new string[3];
            int sizeClientList;
            sizeClientList = listaP.Count;
            for (int i = 0; i < sizeClientList; i++)
            {
                arrayString[0] = listaP[i].getCompleteName();
                arrayString[1] = listaP[i].getVuelo();
                arrayString[2] = (listaP[i].getNumeroAsiento() + 1).ToString();

                ListViewItem item = new ListViewItem(arrayString);
                this.pasajeroMaterialListView.Items.Add(item);
            }
        }

        private void deletePasajeromaterialFlatButton_Click(object sender, EventArgs e)
        {
            this.pasajeroMaterialListView.Items.Clear();
            if (nombrePasajero == " " && vueloPasajero == " ")
            {
                MessageBox.Show("No se puede eliminar el elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.searchPasajeroLineTextField.Text.Length == 0)
            {
                showListPasajeros(pasajerosList);
            }
            if (vueloPasajero.Length > 0)
            {
                foreach(Vuelo v in flyList)
                {
                    if (vueloPasajero.CompareTo(v.ToString()) == 0)
                    {
                        v.getListaPasajeros().RemoveAll(
                            pas => nombrePasajero.CompareTo(pas.getCompleteName()) == 0 && asientoPasajero == pas.getNumeroAsiento()
                        );
                        v.setAsientosDisp(v.getAsientosDip() + 1);
                    }
                }
                pasajerosList.RemoveAll( pas => nombrePasajero.CompareTo(pas.getCompleteName()) == 0 && asientoPasajero == pas.getNumeroAsiento() );
                displayContentPasajero(pasajerosList);

            }
        }

        private void pasajeroMaterialListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.vueloPasajero = pasajeroMaterialListView.FocusedItem.SubItems[1].Text;
            this.nombrePasajero = pasajeroMaterialListView.FocusedItem.SubItems[0].Text;
            this.asientoPasajero = int.Parse(pasajeroMaterialListView.FocusedItem.SubItems[2].Text);
            this.asientoPasajero--;
        }

        private void searchPasajeroLineTextField_TextChanged(object sender, EventArgs e)
        {
            displayContentPasajero(pasajerosList);
        }

        public void displayContentPasajero(GenericList<Pasajero> lp)
        {
            this.pasajeroMaterialListView.Items.Clear();
            if (searchPasajeroLineTextField.TextLength == 0)
            {
                showListPasajeros(lp);
            }
            else if (this.flyPasajeroRadioButton.Checked)
            {
                addByFly(lp);
            }
            else if (this.asientoPasajeroRadioButton.Checked)
            {
                addBySit(lp);
            }
            else if (this.namePasajeroRadioButton.Checked)
            {
                addByName(lp);
            }
        }

        private void addByName(GenericList<Pasajero> lp)
        {
            this.pasajeroMaterialListView.Items.Clear();
            GenericList<Pasajero> tmp = new GenericList<Pasajero>();
            foreach(Pasajero pas in lp) 
            {
                if (pas.getCompleteName().Contains(searchPasajeroLineTextField.Text.ToString()))
                {
                    tmp.Add(pas);
                }
            }
            showListPasajeros(tmp);
        }

        private void addByFly(GenericList<Pasajero> lp)
        {
            this.pasajeroMaterialListView.Items.Clear();
            GenericList<Pasajero> tmp = new GenericList<Pasajero>();
            foreach (Pasajero pas in lp)
            {
                if (pas.getVuelo().Contains(searchPasajeroLineTextField.Text.ToString()))
                {
                    tmp.Add(pas);
                }
            }
            showListPasajeros(tmp);
        }

        private void addBySit(GenericList<Pasajero> listap)
        {
            try
            {
                this.pasajeroMaterialListView.Items.Clear();
                int asi = int.Parse(this.searchPasajeroLineTextField.Text.ToString());
                asi--;

                GenericList<Pasajero> lp = new GenericList<Pasajero>();
                foreach(Pasajero pas in listap)
                {
                    if (asi == pas.getNumeroAsiento())
                    {
                        lp.Add(pas);
                    }
                }
                this.showListPasajeros(lp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingreso un tipo de dato que no es númerico" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void flyPasajeroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayContentPasajero(pasajerosList);
        }

        private void asientoPasajeroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayContentPasajero(pasajerosList);
        }

        private void namePasajeroRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            displayContentPasajero(pasajerosList);
        }


        private void ordenarPasajeroFlatButton_Click(object sender, EventArgs e)
        {
            this.pasajeroMaterialListView.Items.Clear();
            if(this.namePasajeroRadioButton.Checked)
            {
                pasajerosList.qSort( (a, b) => a.compareTo(b, 1) );
            }
            else if(this.flyPasajeroRadioButton.Checked)
            {
                pasajerosList.qSort( (a, b) => a.compareTo(b, 2) );
            }
            else if(this.asientoPasajeroRadioButton.Checked)
            {
                pasajerosList.qSort( (a, b) => a.compareTo(b, 3) );
            }
            displayContentPasajero(pasajerosList);
        }

        /*
         * pasajerosTab End
         */



        /*
         * vuelosTab
         */


        private void showListVuelos()
        {
            this.vueloMaterialListView.Items.Clear();
            showListVuelos(this.flyList);
        }

        private void showListVuelos(GenericList<Vuelo> listaV)
        {
            string[] arrayString = new string[3];
            foreach (Vuelo v in listaV)
            {
                arrayString[0] = v.ToString();
                arrayString[1] = v.getOrigen().ToString();
                arrayString[2] = v.getDestino().ToString();

                ListViewItem item = new ListViewItem(arrayString);
                this.vueloMaterialListView.Items.Add(item);
            }
        }

        private bool validSearchVuelo(string word1, string word2)
        {
            for (int i = 0; i < word2.Length; i++)
            {
                if (!word1[i].Equals(word2[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private void comprarVueloMaterialFlatButton_Click(object sender, EventArgs e)
        {
            flyList.ForEach(v => {
                if (rutaVuelo.CompareTo(v.ToString()) == 0)
                {
                    FormularioForm formularioWindow = new FormularioForm(v);
                    this.Hide();
                    formularioWindow.ShowDialog();
                    this.Show();
                    this.comprarVueloMaterialFlatButton.Enabled = false;
                    return;
                }
            });
        }

        private void deleteVueloMaterialFlatButton_Click(object sender, EventArgs e)
        {
            if (this.rutaVuelo.Length == 0)
            {
                MessageBox.Show("No se puede eliminar el elemento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (this.searchVueloLineTextField.Text.Length == 0 && this.rutaVuelo.Length == 0)
            {
                showListVuelos();
                return;
            }
            flyList.RemoveAll((v) => this.rutaVuelo.CompareTo(v.ToString()) == 0);
            /*
             *Aqui va lo del grafo
             */
            graph.removeAdy(this.rutaVuelo[3], this.rutaVuelo[4]);
            graph.removeAlone(this.rutaVuelo[3]);
            graph.removeAlone(this.rutaVuelo[4]);
            showListVuelos();
            this.rutaVuelo = "";
        }

        private void registrarMaterialFlatButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroVueloForm registroVueloWindow = new RegistroVueloForm(ref this.flyList, this.graph);
            registroVueloWindow.ShowDialog();
            this.Show();
        }

        private void searchVueloLineTextField_TextChanged(object sender, EventArgs e)
        {

            this.vueloMaterialListView.Items.Clear();
            GenericList<Vuelo> tmp;
            if (searchVueloLineTextField.TextLength == 0)
            {
                showListVuelos();
            }
            else if (this.routeVueloRadioButton.Checked)
            {
                // filterFunc<string, Vuelo> searchFly = (cad, v) => { return validSearch(v.ToString(), cad); };
                filterFunc<string, Vuelo> searchFly = (cad, v) => v.ToString().Contains(cad);
                tmp = flyList.findDatas(this.searchVueloLineTextField.Text.ToString(), searchFly);
                showListVuelos(tmp);
            }
            else if (this.originVueloRadioButton.Checked)
            {
                filterFunc<string, Vuelo> searchOrigin = (cad, v) => cad[0].Equals(v.getOrigen()) && cad.Length == 1;
                tmp = flyList.findDatas(this.searchVueloLineTextField.Text.ToString(), searchOrigin);
                showListVuelos(tmp);
            }
            else if (this.destinyVueloRadioButton.Checked)
            {
                filterFunc<string, Vuelo> searchDestiny = (cad, v) => cad[0].Equals(v.getDestino()) && cad.Length == 1;
                tmp = flyList.findDatas(this.searchVueloLineTextField.Text.ToString(), searchDestiny);
                showListVuelos(tmp);
            }


        }

        private void vueloMaterialListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rutaVuelo = vueloMaterialListView.FocusedItem.SubItems[0].Text;
            this.comprarVueloMaterialFlatButton.Enabled = true;
        }

        private void routeVueloRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.vueloMaterialListView.Items.Clear();
            GenericList<Vuelo> tmp;
            if (searchVueloLineTextField.TextLength == 0)
            {
                showListVuelos();
                return;
            }
            filterFunc<string, Vuelo> searchFly = (cad, v) => v.ToString().Contains(cad);
            tmp = flyList.findDatas(this.searchVueloLineTextField.Text.ToString(), searchFly);
            showListVuelos(tmp);
        }

        private void originVueloRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.vueloMaterialListView.Items.Clear();
            GenericList<Vuelo> tmp;
            if (searchVueloLineTextField.TextLength == 0)
            {
                showListVuelos();
                return;
            }
            filterFunc<string, Vuelo> searchOrigin = (cad, v) => cad[0].Equals(v.getOrigen()) && cad.Length == 1;
            tmp = flyList.findDatas(this.searchVueloLineTextField.Text.ToString(), searchOrigin);
            showListVuelos(tmp);
        }

        private void destinyVueloRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.vueloMaterialListView.Items.Clear();
            GenericList<Vuelo> tmp;
            if (searchVueloLineTextField.TextLength == 0)
            {
                showListVuelos();
                return;
            }
            filterFunc<string, Vuelo> searchDestiny = (cad, v) => cad[0].Equals(v.getDestino()) && cad.Length == 1;
            tmp = flyList.findDatas(this.searchVueloLineTextField.Text.ToString(), searchDestiny);
            showListVuelos(tmp);
        }

        private void sortVuelosMaterialFlatButton_Click(object sender, EventArgs e)
        {
            this.vueloMaterialListView.Items.Clear();
            GenericList<Vuelo> tmp;

            if (this.routeVueloRadioButton.Checked)
            {
                this.flyList.qSort((a, b) => a.compareTo(b, 0));
            }
            else if(this.originVueloRadioButton.Checked)
            {
                this.flyList.qSort((a, b) => a.compareTo(b, 1));
            }
            else if (this.destinyVueloRadioButton.Checked)
            {
                this.flyList.qSort((a, b) => a.compareTo(b, 2));
            }
            else if(this.costoVueloRadioButton.Checked)
            {
                this.flyList.qSort((a, b) => a.compareTo(b, 3));
            }
            else if(this.timeVueloRadioButton.Checked)
            {
                this.flyList.qSort((a, b) => a.compareTo(b, 4));
            }

            
            if (searchVueloLineTextField.TextLength == 0)
            {
                showListVuelos();
            }
            else if (this.routeVueloRadioButton.Checked)
            {
                // filterFunc<string, Vuelo> searchFly = (cad, v) => { return validSearch(v.ToString(), cad); };
                filterFunc<string, Vuelo> searchFly = (cad, v) => v.ToString().Contains(cad);
                tmp = flyList.findDatas(this.searchVueloLineTextField.Text.ToString(), searchFly);
                showListVuelos(tmp);
            }
            else if (this.originVueloRadioButton.Checked)
            {
                filterFunc<string, Vuelo> searchOrigin = (cad, v) => cad[0].Equals(v.getOrigen()) && cad.Length == 1;
                tmp = flyList.findDatas(this.searchVueloLineTextField.Text.ToString(), searchOrigin);
                showListVuelos(tmp);
            }
            else if (this.destinyVueloRadioButton.Checked)
            {
                filterFunc<string, Vuelo> searchDestiny = (cad, v) => cad[0].Equals(v.getDestino()) && cad.Length == 1;
                tmp = flyList.findDatas(this.searchVueloLineTextField.Text.ToString(), searchDestiny);
                showListVuelos(tmp);
            }
            else
            {
                showListVuelos();
            }

        }


        /*
         * vuelosTab End
         */



        /*
         * rutasTab
         */

        private void startDrawRuta()
        {

            chargeCitysRuta();
            double angulo;
            double radio;
            int div = graph.getNodesCount();
            int x;
            int y;
            string nom;

            Pen pluma1 = new Pen(Color.BlueViolet);
            Pen pluma2 = new Pen(Color.Red);
            SolidBrush mensajes = new SolidBrush(Color.White);

            //this.rutaPanel.CreateGraphics().DrawEllipse(pluma1, 20, 20, rutaPanel.Height - 30, rutaPanel.Height - 30);
            radio = (rutaPanel.Height - 30) / 2;
            angulo = 2 * Math.PI / div;

            for (int i = 0; i < graph.getNodesCount(); i++)
            {
                //nom = graph.getNode(i).getCiudad().getName().ToString();
                if (graph.getNode(i).getCiudad().getPos() < 0)
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

                rutaPanel.CreateGraphics().DrawEllipse(pluma2, x - 10, y - 10, 20, 20);
                //rutaPanel.CreateGraphics().DrawString(nom, DefaultFont, mensajes, x - 5, y - 5);

            }

            int originX = 0;
            int originY = 0;
            int destinyX = 0;
            int destinyY = 0;

            int letterX = 0;
            int letterY = 0;
            string letter;

            Pen arista = new Pen(Color.BlueViolet, 1);
            // DarkCyan
            // DarkGoldenrod
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

                    this.rutaPanel.CreateGraphics().DrawLine(arista, originX, originY, destinyX, destinyY);

                    letterX = (originX + destinyX) / 2;
                    letterY = (originY + destinyY) / 2;
                    letter = graph.getNode(i).getAdyEl(j).getPondCosto() + ", " + graph.getNode(i).getAdyEl(j).getPondTime();
                    rutaPanel.CreateGraphics().DrawString(letter, DefaultFont, letterPen, letterX, letterY);
                }
            }

            for (int i = 0; i < graph.getNodesCount(); i++)
            {
                nom = graph.getNode(i).getCiudad().getName().ToString();
                x = graph.getNode(i).getCiudad().getPosX();
                y = graph.getNode(i).getCiudad().getPosY();
                
                rutaPanel.CreateGraphics().DrawString(nom, DefaultFont, mensajes, x - 5, y - 5);

            }

        }

        private int calculateXRuta(int x)
        {
            int diameter = 15;
            int posX = this.rutaPanel.Width;
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

        private int calculateYRuta(int y)
        {
            int diameter = 15;
            int posY = this.rutaPanel.Height + 15;
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

        private void chargeCitysRuta()
        {
            this.ciudadRutaMaterialListView.Items.Clear();

            string[] arrayString = new string[1];
            int limit = graph.getNodesCount();

            for(int i = 0; i < limit; i++)
            {
                arrayString[0] = graph.getNode(i).getCiudad().getName().ToString();
                ListViewItem item = new ListViewItem(arrayString);
                this.ciudadRutaMaterialListView.Items.Add(item);
            }

        }

        // rutaPanel event
        private void rutaMaterialLabel_Paint(object sender, PaintEventArgs e)
        {
            startDrawRuta();
        }

        private void mostrarRutaMaterialFlatButton_Click(object sender, EventArgs e)
        {
            startDrawRuta();
        }

        private void ciudadRutaMaterialListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cityRoute = ciudadRutaMaterialListView.FocusedItem.SubItems[0].Text[0];
            this.eliminarCiudadRutaFlatButton.Enabled = true;
        }

        private void eliminarCiudadRutaFlatButton_Click(object sender, EventArgs e)
        {
            this.graph.removeVertex(cityRoute);
            this.flyList.RemoveAll( fly => fly.getOrigen().Equals(cityRoute) || fly.getDestino().Equals(cityRoute) );
            this.cityRoute = '\n';
            this.eliminarCiudadRutaFlatButton.Enabled = false;
            startDrawRuta();
        }



        /*
         * rutasTab End
         */


    }
}
