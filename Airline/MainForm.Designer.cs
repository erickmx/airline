namespace Airline
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuMaterialTabSelector = new MaterialSkin.Controls.MaterialTabSelector();
            this.menuMaterialTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.pasajeroTabPage = new System.Windows.Forms.TabPage();
            this.pasajeroMaterialListView = new MaterialSkin.Controls.MaterialListView();
            this.nombreColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rutaColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.asientoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchPasajeroLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.namePasajeroRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.asientoPasajeroRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.flyPasajeroRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.deletePasajeromaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.vueloTabPage = new System.Windows.Forms.TabPage();
            this.destinyVueloRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.originVueloRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.routeVueloRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.searchVueloLineTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.vueloMaterialListView = new MaterialSkin.Controls.MaterialListView();
            this.routeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.originColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destinyColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.registrarMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.comprarVueloMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.deleteVueloMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.rutaTabPage = new System.Windows.Forms.TabPage();
            this.rutaMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.mostrarRutaMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.menuMaterialTabControl.SuspendLayout();
            this.pasajeroTabPage.SuspendLayout();
            this.vueloTabPage.SuspendLayout();
            this.rutaTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMaterialTabSelector
            // 
            this.menuMaterialTabSelector.BaseTabControl = this.menuMaterialTabControl;
            this.menuMaterialTabSelector.Depth = 0;
            this.menuMaterialTabSelector.Location = new System.Drawing.Point(0, 64);
            this.menuMaterialTabSelector.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuMaterialTabSelector.Name = "menuMaterialTabSelector";
            this.menuMaterialTabSelector.Size = new System.Drawing.Size(640, 50);
            this.menuMaterialTabSelector.TabIndex = 0;
            this.menuMaterialTabSelector.Text = "Menu";
            // 
            // menuMaterialTabControl
            // 
            this.menuMaterialTabControl.Controls.Add(this.pasajeroTabPage);
            this.menuMaterialTabControl.Controls.Add(this.vueloTabPage);
            this.menuMaterialTabControl.Controls.Add(this.rutaTabPage);
            this.menuMaterialTabControl.Depth = 0;
            this.menuMaterialTabControl.Location = new System.Drawing.Point(0, 120);
            this.menuMaterialTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuMaterialTabControl.Name = "menuMaterialTabControl";
            this.menuMaterialTabControl.SelectedIndex = 0;
            this.menuMaterialTabControl.Size = new System.Drawing.Size(640, 360);
            this.menuMaterialTabControl.TabIndex = 1;
            // 
            // pasajeroTabPage
            // 
            this.pasajeroTabPage.BackColor = System.Drawing.Color.White;
            this.pasajeroTabPage.Controls.Add(this.pasajeroMaterialListView);
            this.pasajeroTabPage.Controls.Add(this.searchPasajeroLineTextField);
            this.pasajeroTabPage.Controls.Add(this.namePasajeroRadioButton);
            this.pasajeroTabPage.Controls.Add(this.asientoPasajeroRadioButton);
            this.pasajeroTabPage.Controls.Add(this.flyPasajeroRadioButton);
            this.pasajeroTabPage.Controls.Add(this.deletePasajeromaterialFlatButton);
            this.pasajeroTabPage.Location = new System.Drawing.Point(4, 22);
            this.pasajeroTabPage.Name = "pasajeroTabPage";
            this.pasajeroTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.pasajeroTabPage.Size = new System.Drawing.Size(632, 334);
            this.pasajeroTabPage.TabIndex = 0;
            this.pasajeroTabPage.Text = "Pasajeros";
            this.pasajeroTabPage.Enter += new System.EventHandler(this.pasajeroTabPage_Enter);
            // 
            // pasajeroMaterialListView
            // 
            this.pasajeroMaterialListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pasajeroMaterialListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nombreColumnHeader,
            this.rutaColumnHeader,
            this.asientoColumnHeader});
            this.pasajeroMaterialListView.Depth = 0;
            this.pasajeroMaterialListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.pasajeroMaterialListView.FullRowSelect = true;
            this.pasajeroMaterialListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.pasajeroMaterialListView.Location = new System.Drawing.Point(8, 6);
            this.pasajeroMaterialListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.pasajeroMaterialListView.MouseState = MaterialSkin.MouseState.OUT;
            this.pasajeroMaterialListView.Name = "pasajeroMaterialListView";
            this.pasajeroMaterialListView.OwnerDraw = true;
            this.pasajeroMaterialListView.Size = new System.Drawing.Size(310, 318);
            this.pasajeroMaterialListView.TabIndex = 1;
            this.pasajeroMaterialListView.UseCompatibleStateImageBehavior = false;
            this.pasajeroMaterialListView.View = System.Windows.Forms.View.Details;
            this.pasajeroMaterialListView.SelectedIndexChanged += new System.EventHandler(this.pasajeroMaterialListView_SelectedIndexChanged);
            // 
            // nombreColumnHeader
            // 
            this.nombreColumnHeader.Text = "Nombre";
            this.nombreColumnHeader.Width = 160;
            // 
            // rutaColumnHeader
            // 
            this.rutaColumnHeader.Text = "Ruta";
            this.rutaColumnHeader.Width = 70;
            // 
            // asientoColumnHeader
            // 
            this.asientoColumnHeader.Text = "Asiento";
            this.asientoColumnHeader.Width = 80;
            // 
            // searchPasajeroLineTextField
            // 
            this.searchPasajeroLineTextField.Depth = 0;
            this.searchPasajeroLineTextField.Hint = "";
            this.searchPasajeroLineTextField.Location = new System.Drawing.Point(459, 65);
            this.searchPasajeroLineTextField.MaxLength = 32767;
            this.searchPasajeroLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchPasajeroLineTextField.Name = "searchPasajeroLineTextField";
            this.searchPasajeroLineTextField.PasswordChar = '\0';
            this.searchPasajeroLineTextField.SelectedText = "";
            this.searchPasajeroLineTextField.SelectionLength = 0;
            this.searchPasajeroLineTextField.SelectionStart = 0;
            this.searchPasajeroLineTextField.Size = new System.Drawing.Size(156, 23);
            this.searchPasajeroLineTextField.TabIndex = 4;
            this.searchPasajeroLineTextField.TabStop = false;
            this.searchPasajeroLineTextField.UseSystemPasswordChar = false;
            this.searchPasajeroLineTextField.TextChanged += new System.EventHandler(this.searchPasajeroLineTextField_TextChanged);
            // 
            // namePasajeroRadioButton
            // 
            this.namePasajeroRadioButton.AutoSize = true;
            this.namePasajeroRadioButton.Depth = 0;
            this.namePasajeroRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.namePasajeroRadioButton.Location = new System.Drawing.Point(452, 185);
            this.namePasajeroRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.namePasajeroRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.namePasajeroRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.namePasajeroRadioButton.Name = "namePasajeroRadioButton";
            this.namePasajeroRadioButton.Ripple = true;
            this.namePasajeroRadioButton.Size = new System.Drawing.Size(134, 30);
            this.namePasajeroRadioButton.TabIndex = 3;
            this.namePasajeroRadioButton.Text = "Nombre/Apellido";
            this.namePasajeroRadioButton.UseVisualStyleBackColor = true;
            this.namePasajeroRadioButton.CheckedChanged += new System.EventHandler(this.namePasajeroRadioButton_CheckedChanged);
            // 
            // asientoPasajeroRadioButton
            // 
            this.asientoPasajeroRadioButton.AutoSize = true;
            this.asientoPasajeroRadioButton.Depth = 0;
            this.asientoPasajeroRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.asientoPasajeroRadioButton.Location = new System.Drawing.Point(452, 155);
            this.asientoPasajeroRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.asientoPasajeroRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.asientoPasajeroRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.asientoPasajeroRadioButton.Name = "asientoPasajeroRadioButton";
            this.asientoPasajeroRadioButton.Ripple = true;
            this.asientoPasajeroRadioButton.Size = new System.Drawing.Size(76, 30);
            this.asientoPasajeroRadioButton.TabIndex = 2;
            this.asientoPasajeroRadioButton.Text = "Asiento";
            this.asientoPasajeroRadioButton.UseVisualStyleBackColor = true;
            this.asientoPasajeroRadioButton.CheckedChanged += new System.EventHandler(this.asientoPasajeroRadioButton_CheckedChanged);
            // 
            // flyPasajeroRadioButton
            // 
            this.flyPasajeroRadioButton.AutoSize = true;
            this.flyPasajeroRadioButton.Checked = true;
            this.flyPasajeroRadioButton.Depth = 0;
            this.flyPasajeroRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.flyPasajeroRadioButton.Location = new System.Drawing.Point(452, 125);
            this.flyPasajeroRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.flyPasajeroRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.flyPasajeroRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.flyPasajeroRadioButton.Name = "flyPasajeroRadioButton";
            this.flyPasajeroRadioButton.Ripple = true;
            this.flyPasajeroRadioButton.Size = new System.Drawing.Size(64, 30);
            this.flyPasajeroRadioButton.TabIndex = 1;
            this.flyPasajeroRadioButton.TabStop = true;
            this.flyPasajeroRadioButton.Text = "Vuelo";
            this.flyPasajeroRadioButton.UseVisualStyleBackColor = true;
            this.flyPasajeroRadioButton.CheckedChanged += new System.EventHandler(this.flyPasajeroRadioButton_CheckedChanged);
            // 
            // deletePasajeromaterialFlatButton
            // 
            this.deletePasajeromaterialFlatButton.AutoSize = true;
            this.deletePasajeromaterialFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deletePasajeromaterialFlatButton.Depth = 0;
            this.deletePasajeromaterialFlatButton.Icon = null;
            this.deletePasajeromaterialFlatButton.Location = new System.Drawing.Point(532, 9);
            this.deletePasajeromaterialFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deletePasajeromaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deletePasajeromaterialFlatButton.Name = "deletePasajeromaterialFlatButton";
            this.deletePasajeromaterialFlatButton.Primary = false;
            this.deletePasajeromaterialFlatButton.Size = new System.Drawing.Size(83, 36);
            this.deletePasajeromaterialFlatButton.TabIndex = 0;
            this.deletePasajeromaterialFlatButton.Text = "Eliminar";
            this.deletePasajeromaterialFlatButton.UseVisualStyleBackColor = true;
            this.deletePasajeromaterialFlatButton.Click += new System.EventHandler(this.deletePasajeromaterialFlatButton_Click);
            // 
            // vueloTabPage
            // 
            this.vueloTabPage.BackColor = System.Drawing.Color.White;
            this.vueloTabPage.Controls.Add(this.destinyVueloRadioButton);
            this.vueloTabPage.Controls.Add(this.originVueloRadioButton);
            this.vueloTabPage.Controls.Add(this.routeVueloRadioButton);
            this.vueloTabPage.Controls.Add(this.searchVueloLineTextField);
            this.vueloTabPage.Controls.Add(this.vueloMaterialListView);
            this.vueloTabPage.Controls.Add(this.registrarMaterialFlatButton);
            this.vueloTabPage.Controls.Add(this.comprarVueloMaterialFlatButton);
            this.vueloTabPage.Controls.Add(this.deleteVueloMaterialFlatButton);
            this.vueloTabPage.Location = new System.Drawing.Point(4, 22);
            this.vueloTabPage.Name = "vueloTabPage";
            this.vueloTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.vueloTabPage.Size = new System.Drawing.Size(632, 334);
            this.vueloTabPage.TabIndex = 1;
            this.vueloTabPage.Text = "Vuelos";
            this.vueloTabPage.Enter += new System.EventHandler(this.vueloTabPage_Enter);
            // 
            // destinyVueloRadioButton
            // 
            this.destinyVueloRadioButton.AutoSize = true;
            this.destinyVueloRadioButton.Depth = 0;
            this.destinyVueloRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.destinyVueloRadioButton.Location = new System.Drawing.Point(448, 201);
            this.destinyVueloRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.destinyVueloRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.destinyVueloRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.destinyVueloRadioButton.Name = "destinyVueloRadioButton";
            this.destinyVueloRadioButton.Ripple = true;
            this.destinyVueloRadioButton.Size = new System.Drawing.Size(76, 30);
            this.destinyVueloRadioButton.TabIndex = 7;
            this.destinyVueloRadioButton.Text = "Destino";
            this.destinyVueloRadioButton.UseVisualStyleBackColor = true;
            this.destinyVueloRadioButton.CheckedChanged += new System.EventHandler(this.destinyVueloRadioButton_CheckedChanged);
            // 
            // originVueloRadioButton
            // 
            this.originVueloRadioButton.AutoSize = true;
            this.originVueloRadioButton.Depth = 0;
            this.originVueloRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.originVueloRadioButton.Location = new System.Drawing.Point(448, 171);
            this.originVueloRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.originVueloRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.originVueloRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.originVueloRadioButton.Name = "originVueloRadioButton";
            this.originVueloRadioButton.Ripple = true;
            this.originVueloRadioButton.Size = new System.Drawing.Size(70, 30);
            this.originVueloRadioButton.TabIndex = 6;
            this.originVueloRadioButton.Text = "Origen";
            this.originVueloRadioButton.UseVisualStyleBackColor = true;
            this.originVueloRadioButton.CheckedChanged += new System.EventHandler(this.originVueloRadioButton_CheckedChanged);
            // 
            // routeVueloRadioButton
            // 
            this.routeVueloRadioButton.AutoSize = true;
            this.routeVueloRadioButton.Checked = true;
            this.routeVueloRadioButton.Depth = 0;
            this.routeVueloRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.routeVueloRadioButton.Location = new System.Drawing.Point(448, 141);
            this.routeVueloRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.routeVueloRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.routeVueloRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.routeVueloRadioButton.Name = "routeVueloRadioButton";
            this.routeVueloRadioButton.Ripple = true;
            this.routeVueloRadioButton.Size = new System.Drawing.Size(57, 30);
            this.routeVueloRadioButton.TabIndex = 5;
            this.routeVueloRadioButton.TabStop = true;
            this.routeVueloRadioButton.Text = "Ruta";
            this.routeVueloRadioButton.UseVisualStyleBackColor = true;
            this.routeVueloRadioButton.CheckedChanged += new System.EventHandler(this.routeVueloRadioButton_CheckedChanged);
            // 
            // searchVueloLineTextField
            // 
            this.searchVueloLineTextField.Depth = 0;
            this.searchVueloLineTextField.Hint = "";
            this.searchVueloLineTextField.Location = new System.Drawing.Point(448, 99);
            this.searchVueloLineTextField.MaxLength = 32767;
            this.searchVueloLineTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchVueloLineTextField.Name = "searchVueloLineTextField";
            this.searchVueloLineTextField.PasswordChar = '\0';
            this.searchVueloLineTextField.SelectedText = "";
            this.searchVueloLineTextField.SelectionLength = 0;
            this.searchVueloLineTextField.SelectionStart = 0;
            this.searchVueloLineTextField.Size = new System.Drawing.Size(163, 23);
            this.searchVueloLineTextField.TabIndex = 4;
            this.searchVueloLineTextField.TabStop = false;
            this.searchVueloLineTextField.UseSystemPasswordChar = false;
            this.searchVueloLineTextField.TextChanged += new System.EventHandler(this.searchVueloLineTextField_TextChanged);
            // 
            // vueloMaterialListView
            // 
            this.vueloMaterialListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vueloMaterialListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.routeColumnHeader,
            this.originColumnHeader,
            this.destinyColumnHeader});
            this.vueloMaterialListView.Depth = 0;
            this.vueloMaterialListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.vueloMaterialListView.FullRowSelect = true;
            this.vueloMaterialListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.vueloMaterialListView.Location = new System.Drawing.Point(6, 9);
            this.vueloMaterialListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.vueloMaterialListView.MouseState = MaterialSkin.MouseState.OUT;
            this.vueloMaterialListView.Name = "vueloMaterialListView";
            this.vueloMaterialListView.OwnerDraw = true;
            this.vueloMaterialListView.Size = new System.Drawing.Size(294, 317);
            this.vueloMaterialListView.TabIndex = 3;
            this.vueloMaterialListView.UseCompatibleStateImageBehavior = false;
            this.vueloMaterialListView.View = System.Windows.Forms.View.Details;
            this.vueloMaterialListView.SelectedIndexChanged += new System.EventHandler(this.vueloMaterialListView_SelectedIndexChanged);
            // 
            // routeColumnHeader
            // 
            this.routeColumnHeader.Text = "Ruta";
            this.routeColumnHeader.Width = 117;
            // 
            // originColumnHeader
            // 
            this.originColumnHeader.Text = "Origen";
            this.originColumnHeader.Width = 80;
            // 
            // destinyColumnHeader
            // 
            this.destinyColumnHeader.Text = "Destino";
            this.destinyColumnHeader.Width = 80;
            // 
            // registrarMaterialFlatButton
            // 
            this.registrarMaterialFlatButton.AutoSize = true;
            this.registrarMaterialFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registrarMaterialFlatButton.Depth = 0;
            this.registrarMaterialFlatButton.Icon = null;
            this.registrarMaterialFlatButton.Location = new System.Drawing.Point(385, 54);
            this.registrarMaterialFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registrarMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.registrarMaterialFlatButton.Name = "registrarMaterialFlatButton";
            this.registrarMaterialFlatButton.Primary = false;
            this.registrarMaterialFlatButton.Size = new System.Drawing.Size(139, 36);
            this.registrarMaterialFlatButton.TabIndex = 2;
            this.registrarMaterialFlatButton.Text = "Registrar Vuelo";
            this.registrarMaterialFlatButton.UseVisualStyleBackColor = true;
            this.registrarMaterialFlatButton.Click += new System.EventHandler(this.registrarMaterialFlatButton_Click);
            // 
            // comprarVueloMaterialFlatButton
            // 
            this.comprarVueloMaterialFlatButton.AutoSize = true;
            this.comprarVueloMaterialFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.comprarVueloMaterialFlatButton.Depth = 0;
            this.comprarVueloMaterialFlatButton.Icon = null;
            this.comprarVueloMaterialFlatButton.Location = new System.Drawing.Point(383, 6);
            this.comprarVueloMaterialFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.comprarVueloMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.comprarVueloMaterialFlatButton.Name = "comprarVueloMaterialFlatButton";
            this.comprarVueloMaterialFlatButton.Primary = false;
            this.comprarVueloMaterialFlatButton.Size = new System.Drawing.Size(141, 36);
            this.comprarVueloMaterialFlatButton.TabIndex = 1;
            this.comprarVueloMaterialFlatButton.Text = "Comprar Boleto";
            this.comprarVueloMaterialFlatButton.UseVisualStyleBackColor = true;
            this.comprarVueloMaterialFlatButton.Click += new System.EventHandler(this.comprarVueloMaterialFlatButton_Click);
            // 
            // deleteVueloMaterialFlatButton
            // 
            this.deleteVueloMaterialFlatButton.AutoSize = true;
            this.deleteVueloMaterialFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteVueloMaterialFlatButton.Depth = 0;
            this.deleteVueloMaterialFlatButton.Icon = null;
            this.deleteVueloMaterialFlatButton.Location = new System.Drawing.Point(532, 9);
            this.deleteVueloMaterialFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteVueloMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteVueloMaterialFlatButton.Name = "deleteVueloMaterialFlatButton";
            this.deleteVueloMaterialFlatButton.Primary = false;
            this.deleteVueloMaterialFlatButton.Size = new System.Drawing.Size(79, 36);
            this.deleteVueloMaterialFlatButton.TabIndex = 0;
            this.deleteVueloMaterialFlatButton.Text = "Elimnar";
            this.deleteVueloMaterialFlatButton.UseVisualStyleBackColor = true;
            this.deleteVueloMaterialFlatButton.Click += new System.EventHandler(this.deleteVueloMaterialFlatButton_Click);
            // 
            // rutaTabPage
            // 
            this.rutaTabPage.BackColor = System.Drawing.Color.White;
            this.rutaTabPage.Controls.Add(this.mostrarRutaMaterialFlatButton);
            this.rutaTabPage.Controls.Add(this.rutaMaterialLabel);
            this.rutaTabPage.Location = new System.Drawing.Point(4, 22);
            this.rutaTabPage.Name = "rutaTabPage";
            this.rutaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rutaTabPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rutaTabPage.Size = new System.Drawing.Size(632, 334);
            this.rutaTabPage.TabIndex = 2;
            this.rutaTabPage.Text = "Rutas";
            this.rutaTabPage.Enter += new System.EventHandler(this.rutaTabPage_Enter);
            // 
            // rutaMaterialLabel
            // 
            this.rutaMaterialLabel.Depth = 0;
            this.rutaMaterialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.rutaMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rutaMaterialLabel.Location = new System.Drawing.Point(3, 3);
            this.rutaMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.rutaMaterialLabel.Name = "rutaMaterialLabel";
            this.rutaMaterialLabel.Size = new System.Drawing.Size(524, 328);
            this.rutaMaterialLabel.TabIndex = 0;
            this.rutaMaterialLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.rutaMaterialLabel_Paint);
            // 
            // mostrarRutaMaterialFlatButton
            // 
            this.mostrarRutaMaterialFlatButton.AutoSize = true;
            this.mostrarRutaMaterialFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mostrarRutaMaterialFlatButton.Depth = 0;
            this.mostrarRutaMaterialFlatButton.Icon = null;
            this.mostrarRutaMaterialFlatButton.Location = new System.Drawing.Point(534, 9);
            this.mostrarRutaMaterialFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mostrarRutaMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.mostrarRutaMaterialFlatButton.Name = "mostrarRutaMaterialFlatButton";
            this.mostrarRutaMaterialFlatButton.Primary = false;
            this.mostrarRutaMaterialFlatButton.Size = new System.Drawing.Size(85, 36);
            this.mostrarRutaMaterialFlatButton.TabIndex = 1;
            this.mostrarRutaMaterialFlatButton.Text = "Mostrar";
            this.mostrarRutaMaterialFlatButton.UseVisualStyleBackColor = true;
            this.mostrarRutaMaterialFlatButton.Click += new System.EventHandler(this.mostrarRutaMaterialFlatButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.menuMaterialTabControl);
            this.Controls.Add(this.menuMaterialTabSelector);
            this.Name = "MainForm";
            this.Text = "Airline";
            this.menuMaterialTabControl.ResumeLayout(false);
            this.pasajeroTabPage.ResumeLayout(false);
            this.pasajeroTabPage.PerformLayout();
            this.vueloTabPage.ResumeLayout(false);
            this.vueloTabPage.PerformLayout();
            this.rutaTabPage.ResumeLayout(false);
            this.rutaTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector menuMaterialTabSelector;
        private MaterialSkin.Controls.MaterialTabControl menuMaterialTabControl;
        private System.Windows.Forms.TabPage pasajeroTabPage;
        private System.Windows.Forms.TabPage vueloTabPage;
        private System.Windows.Forms.TabPage rutaTabPage;
        private MaterialSkin.Controls.MaterialSingleLineTextField searchPasajeroLineTextField;
        private MaterialSkin.Controls.MaterialRadioButton namePasajeroRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton asientoPasajeroRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton flyPasajeroRadioButton;
        private MaterialSkin.Controls.MaterialFlatButton deletePasajeromaterialFlatButton;
        private MaterialSkin.Controls.MaterialListView pasajeroMaterialListView;
        private System.Windows.Forms.ColumnHeader nombreColumnHeader;
        private System.Windows.Forms.ColumnHeader rutaColumnHeader;
        private System.Windows.Forms.ColumnHeader asientoColumnHeader;
        private MaterialSkin.Controls.MaterialListView vueloMaterialListView;
        private System.Windows.Forms.ColumnHeader routeColumnHeader;
        private System.Windows.Forms.ColumnHeader originColumnHeader;
        private System.Windows.Forms.ColumnHeader destinyColumnHeader;
        private MaterialSkin.Controls.MaterialFlatButton registrarMaterialFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton comprarVueloMaterialFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton deleteVueloMaterialFlatButton;
        private MaterialSkin.Controls.MaterialRadioButton destinyVueloRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton originVueloRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton routeVueloRadioButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField searchVueloLineTextField;
        private MaterialSkin.Controls.MaterialLabel rutaMaterialLabel;
        private MaterialSkin.Controls.MaterialFlatButton mostrarRutaMaterialFlatButton;
    }
}

