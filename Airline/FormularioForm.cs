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
using System.Text.RegularExpressions;

namespace Airline
{
    public partial class FormularioForm : MaterialForm
    {
        Vuelo vuelo;
        int asiento;
        bool aceptar;
        Color colorLabels;

        public FormularioForm(Vuelo vuelo)
        {
            this.vuelo = vuelo;
            this.aceptar = false;
            this.asiento = -1;

            InitializeComponent();


            vueloMaterialLabel.Text += vuelo.ToString();
            asientoMaterialLabel.Text += vuelo.getAsientosDip().ToString();

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
            colorLabels = nameLineTextField.BackColor;
        }

        public bool getAceptar()
        {
            return this.aceptar;
        }

        private void aceptarMaterialFlatButton_Click(object sender, EventArgs e)
        {
            bool disp = true;
            this.aceptar = false;
            if (this.asiento != -1 && this.todoListo())
            {
                vuelo.getListaPasajeros().ForEach((p) => {
                    if (p.getNumeroAsiento() == this.asiento)
                    {
                        disp = false;
                        MessageBox.Show("El asiento: " + (this.asiento + 1) + " ya esta ocupado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                });
                if (disp)
                {
                    vuelo.setAsientosDisp(vuelo.getAsientosDip() - 1);
                    this.addPasajero();
                    this.Close();
                }
            }
            else if (this.asiento == -1)
            {
                MessageBox.Show("No se ha seleccionado un asiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Un campo tiene datos erroneos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancelarMaterialFlatButton_Click(object sender, EventArgs e)
        {
            this.aceptar = true;
            this.Close();
        }

        private void asientoMaterialFlatButton_Click(object sender, EventArgs e)
        {
            AsientosForm asientosWindow = new AsientosForm(ref this.vuelo);
            this.Hide();
            asientosWindow.ShowDialog();
            this.asiento = asientosWindow.getAsiento();
            this.Show();
            if (this.asiento != -1)
            {
                this.asignadoMaterialLabel.Text = "Asiento: " + (this.asiento + 1);
            }
            else
            {
                this.asignadoMaterialLabel.Text = "Asiento: ";
            }
        }

        private bool todoListo()
        {
            return nombreValido() && apellidoValido() && edadValida();
        }
        private bool nombreValido()
        {
            Regex expresion = new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}");
            return expresion.IsMatch(this.nameLineTextField.Text);
        }

        private bool apellidoValido()
        {
            Regex expresion = new Regex(@"[a-zA-ZñÑáéíóú\s]{2,50}");
            return expresion.IsMatch(this.apellidoLineTextField.Text);
        }

        private bool edadValida()
        {
            Regex expresion = new Regex(@"(?:\d*\.)?\d+");
            return expresion.IsMatch(this.ageLineTextField.Text);
        }


        private void nameLineTextField_TextChanged(object sender, EventArgs e)
        {
            if (this.nombreValido())
            {
                this.nameLineTextField.BackColor = colorLabels;
            }
            else
            {
                this.nameLineTextField.BackColor = Color.Red;
            }
        }

        private void apellidoLineTextField_TextChanged(object sender, EventArgs e)
        {
            if (this.apellidoValido())
            {
                this.apellidoLineTextField.BackColor = colorLabels;
            }
            else
            {
                this.apellidoLineTextField.BackColor = Color.Red;
            }
        }

        private void ageLineTextField_TextChanged(object sender, EventArgs e)
        {
            if (this.edadValida())
            {
                this.ageLineTextField.BackColor = colorLabels;
            }
            else
            {
                this.ageLineTextField.BackColor = Color.Red;
            }
        }

        public void addPasajero()
        {
            Pasajero pas = new Pasajero();
            pas.setEdad(Convert.ToInt32(this.ageLineTextField.Text));
            pas.setNombre(this.nameLineTextField.Text);
            pas.setApellido(this.apellidoLineTextField.Text);
            pas.setNumeroAsiento(this.asiento);
            pas.setVuelo(this.vuelo.ToString());
            this.vuelo.getListaPasajeros().Add(pas);
        }



    }
}
