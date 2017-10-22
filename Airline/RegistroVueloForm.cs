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
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using MaterialSkin;
using System.Text.RegularExpressions;

namespace Airline
{
    public partial class RegistroVueloForm : MaterialForm
    {
        GenericList<Vuelo> flyList;
        Graph graph;
        Color colorLine;

        public RegistroVueloForm(ref GenericList<Vuelo> flyList, Graph graph)
        {
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

            colorLine = this.origenLineTextField.BackColor;
        }

        private void aceptarMaterialFlatButton_Click(object sender, EventArgs e)
        {
            if (allReady() && (Convert.ToInt32(asientosLineTextField.Text) % 2 == 0) && routeFree() && !beSelf())
            {
                Vuelo v = new Vuelo(
                    origenLineTextField.Text.ToCharArray()[0], 
                    destinoLineTextField.Text.ToCharArray()[0], 
                    Convert.ToInt32(tiempoLineTextField.Text), 
                    Convert.ToInt32(costoLineTextField.Text), 
                    Convert.ToInt32(asientosLineTextField.Text)
                    );
                this.flyList.Add(v);
                // ************************************************************
                // Aqui es donde se hace el agregado para el nodo

                if (!graph.existVertex(v.getOrigen()))
                {
                    graph.addVertex(v.getOrigen());
                    GraphForm grafoVentana = new GraphForm(ref graph, 1);
                    this.Hide();
                    grafoVentana.ShowDialog();
                    this.Show();
                    int x = grafoVentana.getPosX();
                    int y = grafoVentana.getPosY();
                    
                    if (x > -1 && y > -1)
                    {
                        graph.setCityPoints(v.getOrigen(), x, y);
                    }
                }
                if (!graph.existVertex(v.getDestino()))
                {
                    graph.addVertex(v.getDestino());
                    GraphForm grafoVentana = new GraphForm(ref graph, 1);
                    this.Hide();
                    grafoVentana.ShowDialog();
                    this.Show();
                    int x = grafoVentana.getPosX();
                    int y = grafoVentana.getPosY();
                    if (x > -1 && y > -1)
                    {
                        graph.setCityPoints(v.getDestino(), x, y);
                    }
                }
                graph.createAdy(v.getOrigen(), v.getDestino(), v.getCosto(), v.getTiempo());
                // *************************************************************

                this.Close();
            }
            else if (!routeFree())
            {
                MessageBox.Show("La ruta ya esta ocupada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (beSelf())
            {
                MessageBox.Show("El origen y destino son el mismo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((Convert.ToInt32(asientosLineTextField.Text) % 2 != 0))
            {
                MessageBox.Show("El número de asientos debe ser par", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Algun dato esta erroneo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelarMaterialFlatButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void origenLineTextField_TextChanged(object sender, EventArgs e)
        {
            if (validText(this.origenLineTextField))
            {
                this.origenLineTextField.BackColor = colorLine;
            }
            else
            {
                this.origenLineTextField.BackColor = Color.Red;
            }
        }

        private void destinoLineTextField_TextChanged(object sender, EventArgs e)
        {
            if (validText(this.destinoLineTextField))
            {
                this.destinoLineTextField.BackColor = colorLine;
            }
            else
            {
                this.destinoLineTextField.BackColor = Color.Red;
            }
        }

        private void tiempoLineTextField_TextChanged(object sender, EventArgs e)
        {
            if (validDigit(this.tiempoLineTextField))
            {
                this.tiempoLineTextField.BackColor = colorLine;
            }
            else
            {
                this.tiempoLineTextField.BackColor = Color.Red;
            }
        }

        private void costoLineTextField_TextChanged(object sender, EventArgs e)
        {
            if (validDigit(this.costoLineTextField))
            {
                this.costoLineTextField.BackColor = colorLine;
            }
            else
            {
                this.costoLineTextField.BackColor = Color.Red;
            }
        }

        private void asientosLineTextField_TextChanged(object sender, EventArgs e)
        {
            if (validDigit(this.asientosLineTextField))
            {
                this.asientosLineTextField.BackColor = colorLine;
            }
            else
            {
                this.asientosLineTextField.BackColor = Color.Red;
            }
        }


        private bool routeFree()
        {
            char ori = origenLineTextField.Text.ToString()[0];
            char dest = destinoLineTextField.Text.ToString()[0];
            return flyList.Count((v) =>
               ori.Equals(v.getOrigen()) && dest.Equals(v.getDestino())
                ) == 0;
        }

        // apunta asi mmismo?
        private bool beSelf()
        {
            return origenLineTextField.Text.ToString()[0].Equals(destinoLineTextField.Text.ToString()[0]);
        }


        private bool allReady()
        {
            return validText(origenLineTextField) && validText(destinoLineTextField) && validDigit(tiempoLineTextField) && validDigit(costoLineTextField);
        }

        private bool validText(MaterialSingleLineTextField tb)//solo para el origen y el destino
        {
            Regex expresion = new Regex(@"\b\w{1}\b");
            return expresion.IsMatch(tb.Text);
        }
        private bool validDigit(MaterialSingleLineTextField tb)
        {
            // \b\d{2,6}[.]\d{2,6}\b 22.22
            Regex expresion = new Regex(@"(?:\d*\.)?\d+");
            return expresion.IsMatch(tb.Text);
        }

    }
}
