namespace Airline
{
    partial class AsientosForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aceptarMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.cancelarMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // aceptarMaterialFlatButton
            // 
            this.aceptarMaterialFlatButton.AutoSize = true;
            this.aceptarMaterialFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aceptarMaterialFlatButton.Depth = 0;
            this.aceptarMaterialFlatButton.Icon = null;
            this.aceptarMaterialFlatButton.Location = new System.Drawing.Point(421, 87);
            this.aceptarMaterialFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.aceptarMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.aceptarMaterialFlatButton.Name = "aceptarMaterialFlatButton";
            this.aceptarMaterialFlatButton.Primary = false;
            this.aceptarMaterialFlatButton.Size = new System.Drawing.Size(82, 36);
            this.aceptarMaterialFlatButton.TabIndex = 0;
            this.aceptarMaterialFlatButton.Text = "Aceptar";
            this.aceptarMaterialFlatButton.UseVisualStyleBackColor = true;
            this.aceptarMaterialFlatButton.Click += new System.EventHandler(this.aceptarMaterialFlatButton_Click);
            // 
            // cancelarMaterialFlatButton
            // 
            this.cancelarMaterialFlatButton.AutoSize = true;
            this.cancelarMaterialFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelarMaterialFlatButton.Depth = 0;
            this.cancelarMaterialFlatButton.Icon = null;
            this.cancelarMaterialFlatButton.Location = new System.Drawing.Point(421, 135);
            this.cancelarMaterialFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cancelarMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelarMaterialFlatButton.Name = "cancelarMaterialFlatButton";
            this.cancelarMaterialFlatButton.Primary = false;
            this.cancelarMaterialFlatButton.Size = new System.Drawing.Size(91, 36);
            this.cancelarMaterialFlatButton.TabIndex = 1;
            this.cancelarMaterialFlatButton.Text = "Cancelar";
            this.cancelarMaterialFlatButton.UseVisualStyleBackColor = true;
            this.cancelarMaterialFlatButton.Click += new System.EventHandler(this.cancelarMaterialFlatButton_Click);
            // 
            // AsientosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.cancelarMaterialFlatButton);
            this.Controls.Add(this.aceptarMaterialFlatButton);
            this.Name = "AsientosForm";
            this.Text = "Asientos del vuelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton aceptarMaterialFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton cancelarMaterialFlatButton;
    }
}