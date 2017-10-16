namespace Airline
{
    partial class RegistroVueloForm
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
            this.origenMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.origenLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.destinoLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.destinoMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tiempoLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tiempoMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.costoLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.costoMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.asientosLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.asientosMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // aceptarMaterialFlatButton
            // 
            this.aceptarMaterialFlatButton.AutoSize = true;
            this.aceptarMaterialFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aceptarMaterialFlatButton.Depth = 0;
            this.aceptarMaterialFlatButton.Icon = null;
            this.aceptarMaterialFlatButton.Location = new System.Drawing.Point(446, 90);
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
            this.cancelarMaterialFlatButton.Location = new System.Drawing.Point(446, 138);
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
            // origenMaterialLabel
            // 
            this.origenMaterialLabel.AutoSize = true;
            this.origenMaterialLabel.Depth = 0;
            this.origenMaterialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.origenMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.origenMaterialLabel.Location = new System.Drawing.Point(12, 90);
            this.origenMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.origenMaterialLabel.Name = "origenMaterialLabel";
            this.origenMaterialLabel.Size = new System.Drawing.Size(56, 19);
            this.origenMaterialLabel.TabIndex = 2;
            this.origenMaterialLabel.Text = "Origen:";
            // 
            // origenLineTextField
            // 
            this.origenLineTextField.Depth = 0;
            this.origenLineTextField.Hint = "";
            this.origenLineTextField.Location = new System.Drawing.Point(12, 112);
            this.origenLineTextField.MaxLength = 32767;
            this.origenLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.origenLineTextField.Name = "origenLineTextField";
            this.origenLineTextField.PasswordChar = '\0';
            this.origenLineTextField.SelectedText = "";
            this.origenLineTextField.SelectionLength = 0;
            this.origenLineTextField.SelectionStart = 0;
            this.origenLineTextField.Size = new System.Drawing.Size(195, 23);
            this.origenLineTextField.TabIndex = 3;
            this.origenLineTextField.TabStop = false;
            this.origenLineTextField.UseSystemPasswordChar = false;
            this.origenLineTextField.TextChanged += new System.EventHandler(this.origenLineTextField_TextChanged);
            // 
            // destinoLineTextField
            // 
            this.destinoLineTextField.Depth = 0;
            this.destinoLineTextField.Hint = "";
            this.destinoLineTextField.Location = new System.Drawing.Point(12, 177);
            this.destinoLineTextField.MaxLength = 32767;
            this.destinoLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.destinoLineTextField.Name = "destinoLineTextField";
            this.destinoLineTextField.PasswordChar = '\0';
            this.destinoLineTextField.SelectedText = "";
            this.destinoLineTextField.SelectionLength = 0;
            this.destinoLineTextField.SelectionStart = 0;
            this.destinoLineTextField.Size = new System.Drawing.Size(195, 23);
            this.destinoLineTextField.TabIndex = 5;
            this.destinoLineTextField.TabStop = false;
            this.destinoLineTextField.UseSystemPasswordChar = false;
            this.destinoLineTextField.TextChanged += new System.EventHandler(this.destinoLineTextField_TextChanged);
            // 
            // destinoMaterialLabel
            // 
            this.destinoMaterialLabel.AutoSize = true;
            this.destinoMaterialLabel.Depth = 0;
            this.destinoMaterialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.destinoMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.destinoMaterialLabel.Location = new System.Drawing.Point(12, 155);
            this.destinoMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.destinoMaterialLabel.Name = "destinoMaterialLabel";
            this.destinoMaterialLabel.Size = new System.Drawing.Size(65, 19);
            this.destinoMaterialLabel.TabIndex = 4;
            this.destinoMaterialLabel.Text = "Destino:";
            // 
            // tiempoLineTextField
            // 
            this.tiempoLineTextField.Depth = 0;
            this.tiempoLineTextField.Hint = "";
            this.tiempoLineTextField.Location = new System.Drawing.Point(12, 245);
            this.tiempoLineTextField.MaxLength = 32767;
            this.tiempoLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.tiempoLineTextField.Name = "tiempoLineTextField";
            this.tiempoLineTextField.PasswordChar = '\0';
            this.tiempoLineTextField.SelectedText = "";
            this.tiempoLineTextField.SelectionLength = 0;
            this.tiempoLineTextField.SelectionStart = 0;
            this.tiempoLineTextField.Size = new System.Drawing.Size(195, 23);
            this.tiempoLineTextField.TabIndex = 7;
            this.tiempoLineTextField.TabStop = false;
            this.tiempoLineTextField.UseSystemPasswordChar = false;
            this.tiempoLineTextField.TextChanged += new System.EventHandler(this.tiempoLineTextField_TextChanged);
            // 
            // tiempoMaterialLabel
            // 
            this.tiempoMaterialLabel.AutoSize = true;
            this.tiempoMaterialLabel.Depth = 0;
            this.tiempoMaterialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.tiempoMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tiempoMaterialLabel.Location = new System.Drawing.Point(12, 223);
            this.tiempoMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tiempoMaterialLabel.Name = "tiempoMaterialLabel";
            this.tiempoMaterialLabel.Size = new System.Drawing.Size(64, 19);
            this.tiempoMaterialLabel.TabIndex = 6;
            this.tiempoMaterialLabel.Text = "Tiempo:";
            // 
            // costoLineTextField
            // 
            this.costoLineTextField.Depth = 0;
            this.costoLineTextField.Hint = "";
            this.costoLineTextField.Location = new System.Drawing.Point(12, 310);
            this.costoLineTextField.MaxLength = 32767;
            this.costoLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.costoLineTextField.Name = "costoLineTextField";
            this.costoLineTextField.PasswordChar = '\0';
            this.costoLineTextField.SelectedText = "";
            this.costoLineTextField.SelectionLength = 0;
            this.costoLineTextField.SelectionStart = 0;
            this.costoLineTextField.Size = new System.Drawing.Size(195, 23);
            this.costoLineTextField.TabIndex = 9;
            this.costoLineTextField.TabStop = false;
            this.costoLineTextField.UseSystemPasswordChar = false;
            this.costoLineTextField.TextChanged += new System.EventHandler(this.costoLineTextField_TextChanged);
            // 
            // costoMaterialLabel
            // 
            this.costoMaterialLabel.AutoSize = true;
            this.costoMaterialLabel.Depth = 0;
            this.costoMaterialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.costoMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.costoMaterialLabel.Location = new System.Drawing.Point(12, 288);
            this.costoMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.costoMaterialLabel.Name = "costoMaterialLabel";
            this.costoMaterialLabel.Size = new System.Drawing.Size(54, 19);
            this.costoMaterialLabel.TabIndex = 8;
            this.costoMaterialLabel.Text = "Costo:";
            // 
            // asientosLineTextField
            // 
            this.asientosLineTextField.Depth = 0;
            this.asientosLineTextField.Hint = "";
            this.asientosLineTextField.Location = new System.Drawing.Point(12, 376);
            this.asientosLineTextField.MaxLength = 32767;
            this.asientosLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.asientosLineTextField.Name = "asientosLineTextField";
            this.asientosLineTextField.PasswordChar = '\0';
            this.asientosLineTextField.SelectedText = "";
            this.asientosLineTextField.SelectionLength = 0;
            this.asientosLineTextField.SelectionStart = 0;
            this.asientosLineTextField.Size = new System.Drawing.Size(195, 23);
            this.asientosLineTextField.TabIndex = 11;
            this.asientosLineTextField.TabStop = false;
            this.asientosLineTextField.UseSystemPasswordChar = false;
            this.asientosLineTextField.TextChanged += new System.EventHandler(this.asientosLineTextField_TextChanged);
            // 
            // asientosMaterialLabel
            // 
            this.asientosMaterialLabel.AutoSize = true;
            this.asientosMaterialLabel.Depth = 0;
            this.asientosMaterialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.asientosMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.asientosMaterialLabel.Location = new System.Drawing.Point(12, 354);
            this.asientosMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.asientosMaterialLabel.Name = "asientosMaterialLabel";
            this.asientosMaterialLabel.Size = new System.Drawing.Size(73, 19);
            this.asientosMaterialLabel.TabIndex = 10;
            this.asientosMaterialLabel.Text = "Asientos:";
            // 
            // RegistroVueloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.asientosLineTextField);
            this.Controls.Add(this.asientosMaterialLabel);
            this.Controls.Add(this.costoLineTextField);
            this.Controls.Add(this.costoMaterialLabel);
            this.Controls.Add(this.tiempoLineTextField);
            this.Controls.Add(this.tiempoMaterialLabel);
            this.Controls.Add(this.destinoLineTextField);
            this.Controls.Add(this.destinoMaterialLabel);
            this.Controls.Add(this.origenLineTextField);
            this.Controls.Add(this.origenMaterialLabel);
            this.Controls.Add(this.cancelarMaterialFlatButton);
            this.Controls.Add(this.aceptarMaterialFlatButton);
            this.Name = "RegistroVueloForm";
            this.Text = "Registrar Vuelo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton aceptarMaterialFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton cancelarMaterialFlatButton;
        private MaterialSkin.Controls.MaterialLabel origenMaterialLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField origenLineTextField;
        private MaterialSkin.Controls.MaterialSingleLineTextField destinoLineTextField;
        private MaterialSkin.Controls.MaterialLabel destinoMaterialLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField tiempoLineTextField;
        private MaterialSkin.Controls.MaterialLabel tiempoMaterialLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField costoLineTextField;
        private MaterialSkin.Controls.MaterialLabel costoMaterialLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField asientosLineTextField;
        private MaterialSkin.Controls.MaterialLabel asientosMaterialLabel;
    }
}