namespace Airline
{
    partial class GraphForm
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
            this.graphPanel = new System.Windows.Forms.Panel();
            this.infoMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // graphPanel
            // 
            this.graphPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.graphPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.graphPanel.Location = new System.Drawing.Point(3, 135);
            this.graphPanel.Name = "graphPanel";
            this.graphPanel.Size = new System.Drawing.Size(450, 328);
            this.graphPanel.TabIndex = 1;
            this.graphPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.graphMaterialLabel_Paint);
            this.graphPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphMaterialLabel_MouseClick);
            // 
            // infoMaterialLabel
            // 
            this.infoMaterialLabel.AutoSize = true;
            this.infoMaterialLabel.Depth = 0;
            this.infoMaterialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.infoMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.infoMaterialLabel.Location = new System.Drawing.Point(12, 89);
            this.infoMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoMaterialLabel.Name = "infoMaterialLabel";
            this.infoMaterialLabel.Size = new System.Drawing.Size(288, 19);
            this.infoMaterialLabel.TabIndex = 2;
            this.infoMaterialLabel.Text = "Da click en la posicion de la nueva ciudad";
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 480);
            this.Controls.Add(this.infoMaterialLabel);
            this.Controls.Add(this.graphPanel);
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel graphPanel;
        private MaterialSkin.Controls.MaterialLabel infoMaterialLabel;
    }
}