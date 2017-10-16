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
            this.graphMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // graphMaterialLabel
            // 
            this.graphMaterialLabel.Depth = 0;
            this.graphMaterialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.graphMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.graphMaterialLabel.Location = new System.Drawing.Point(3, 135);
            this.graphMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.graphMaterialLabel.Name = "graphMaterialLabel";
            this.graphMaterialLabel.Size = new System.Drawing.Size(524, 328);
            this.graphMaterialLabel.TabIndex = 0;
            this.graphMaterialLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.graphMaterialLabel_Paint);
            this.graphMaterialLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphMaterialLabel_MouseClick);
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.graphMaterialLabel);
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel graphMaterialLabel;
    }
}