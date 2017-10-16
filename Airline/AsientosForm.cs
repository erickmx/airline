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

namespace Airline
{
    public partial class AsientosForm : MaterialForm
    {

        int id;
        Vuelo fly;
        MaterialFlatButton[] arrayButton;

        public AsientosForm(ref Vuelo fly)
        {
            this.fly = fly;
            id = -1;
            this.arrayButton = new MaterialFlatButton[this.fly.getTotalAsientos()];
            InitializeComponent();
            this.aceptarMaterialFlatButton.Enabled = false;

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

            this.addAsientos();
        }

        public int getAsiento()
        {
            return this.id;
        }

        private void aceptarMaterialFlatButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelarMaterialFlatButton_Click(object sender, EventArgs e)
        {
            this.id = -1;
            this.Close();
        }

        void addAsientos()
        {
            int x;
            int y;
            int contador = 0;
            int filas = this.fly.getTotalAsientos() % 4 == 2 ? (this.fly.getTotalAsientos() / 4) + 1 : this.fly.getTotalAsientos() / 4;

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < 4 && contador < this.fly.getTotalAsientos(); j++)
                {
                    this.arrayButton[contador] = new MaterialFlatButton();

                    //x = 10 + j * 60;
                    //y = 10 + i * 60;
                    x = 10 + j * 60;
                    y = 90 + (10 + i * 60);

                    if (j >= 2)
                    {
                        x += 50;
                    }
                    
                    this.arrayButton[contador].AutoSize = true;
                    this.arrayButton[contador].AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                    this.arrayButton[contador].Depth = 0;
                    this.arrayButton[contador].Icon = null;
                    this.arrayButton[contador].Location = new System.Drawing.Point(x, y);
                    this.arrayButton[contador].Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
                    this.arrayButton[contador].MouseState = MaterialSkin.MouseState.HOVER;
                    this.arrayButton[contador].Name = "asientoButton" + contador.ToString();
                    this.arrayButton[contador].Primary = false;
                    this.arrayButton[contador].Size = new System.Drawing.Size(50, 50);
                    this.arrayButton[contador].TabIndex = 0;
                    this.arrayButton[contador].Text = (contador + 1).ToString();
                    this.arrayButton[contador].UseVisualStyleBackColor = true;
                    this.arrayButton[contador].Click += new System.EventHandler(this.asientosButton_Click);
                    
                    //this.arrayButton[contador].BackColor = Color.BlueViolet;


                    this.Controls.Add(arrayButton[contador]);
                    contador++;
                }
            }

            /*
            fly.getListaPasajeros().ForEach(p => {
                this.arrayButton[p.getNumeroAsiento()].BackColor = Color.Red;
            });
            */

            fly.getListaPasajeros().ForEach(p => {
                this.arrayButton[p.getNumeroAsiento()].Primary = true;
            });

        }

        void asientosButton_Click(object sender, EventArgs e)
        {
            this.aceptarMaterialFlatButton.Enabled = true;
            MaterialFlatButton b = (MaterialFlatButton)sender;
            this.id = Convert.ToInt32(b.Text) - 1;
        }
    }
}
