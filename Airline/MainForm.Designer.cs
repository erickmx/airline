﻿namespace Airline
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
            this.ordenarPasajeroFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
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
            this.sortVuelosMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.timeVueloRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.costoVueloRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
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
            this.kruskalutaFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.PrimRutaFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.totalRutaMaterialLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tiempoRutasMaterialRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.costoRutasMaterialRadioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.eliminarCiudadRutaFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ciudadRutaMaterialListView = new MaterialSkin.Controls.MaterialListView();
            this.cityRutasColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rutaPanel = new System.Windows.Forms.Panel();
            this.mostrarRutaMaterialFlatButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.OrigenRutaMaterialListView = new MaterialSkin.Controls.MaterialListView();
            this.origenColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dijkstraMaterialButton = new MaterialSkin.Controls.MaterialFlatButton();
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
            this.pasajeroTabPage.Controls.Add(this.ordenarPasajeroFlatButton);
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
            // ordenarPasajeroFlatButton
            // 
            this.ordenarPasajeroFlatButton.AutoSize = true;
            this.ordenarPasajeroFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ordenarPasajeroFlatButton.Depth = 0;
            this.ordenarPasajeroFlatButton.Icon = null;
            this.ordenarPasajeroFlatButton.Location = new System.Drawing.Point(433, 9);
            this.ordenarPasajeroFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ordenarPasajeroFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ordenarPasajeroFlatButton.Name = "ordenarPasajeroFlatButton";
            this.ordenarPasajeroFlatButton.Primary = false;
            this.ordenarPasajeroFlatButton.Size = new System.Drawing.Size(83, 36);
            this.ordenarPasajeroFlatButton.TabIndex = 5;
            this.ordenarPasajeroFlatButton.Text = "Ordenar";
            this.ordenarPasajeroFlatButton.UseVisualStyleBackColor = true;
            this.ordenarPasajeroFlatButton.Click += new System.EventHandler(this.ordenarPasajeroFlatButton_Click);
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
            this.rutaColumnHeader.Width = 75;
            // 
            // asientoColumnHeader
            // 
            this.asientoColumnHeader.Text = "Asiento";
            this.asientoColumnHeader.Width = 75;
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
            this.vueloTabPage.Controls.Add(this.sortVuelosMaterialFlatButton);
            this.vueloTabPage.Controls.Add(this.timeVueloRadioButton);
            this.vueloTabPage.Controls.Add(this.costoVueloRadioButton);
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
            // sortVuelosMaterialFlatButton
            // 
            this.sortVuelosMaterialFlatButton.AutoSize = true;
            this.sortVuelosMaterialFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sortVuelosMaterialFlatButton.Depth = 0;
            this.sortVuelosMaterialFlatButton.Icon = null;
            this.sortVuelosMaterialFlatButton.Location = new System.Drawing.Point(532, 54);
            this.sortVuelosMaterialFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sortVuelosMaterialFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.sortVuelosMaterialFlatButton.Name = "sortVuelosMaterialFlatButton";
            this.sortVuelosMaterialFlatButton.Primary = false;
            this.sortVuelosMaterialFlatButton.Size = new System.Drawing.Size(83, 36);
            this.sortVuelosMaterialFlatButton.TabIndex = 10;
            this.sortVuelosMaterialFlatButton.Text = "Ordenar";
            this.sortVuelosMaterialFlatButton.UseVisualStyleBackColor = true;
            this.sortVuelosMaterialFlatButton.Click += new System.EventHandler(this.sortVuelosMaterialFlatButton_Click);
            // 
            // timeVueloRadioButton
            // 
            this.timeVueloRadioButton.AutoSize = true;
            this.timeVueloRadioButton.Depth = 0;
            this.timeVueloRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.timeVueloRadioButton.Location = new System.Drawing.Point(532, 171);
            this.timeVueloRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.timeVueloRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.timeVueloRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.timeVueloRadioButton.Name = "timeVueloRadioButton";
            this.timeVueloRadioButton.Ripple = true;
            this.timeVueloRadioButton.Size = new System.Drawing.Size(76, 30);
            this.timeVueloRadioButton.TabIndex = 9;
            this.timeVueloRadioButton.TabStop = true;
            this.timeVueloRadioButton.Text = "Tiempo";
            this.timeVueloRadioButton.UseVisualStyleBackColor = true;
            // 
            // costoVueloRadioButton
            // 
            this.costoVueloRadioButton.AutoSize = true;
            this.costoVueloRadioButton.Depth = 0;
            this.costoVueloRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.costoVueloRadioButton.Location = new System.Drawing.Point(532, 141);
            this.costoVueloRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.costoVueloRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.costoVueloRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.costoVueloRadioButton.Name = "costoVueloRadioButton";
            this.costoVueloRadioButton.Ripple = true;
            this.costoVueloRadioButton.Size = new System.Drawing.Size(65, 30);
            this.costoVueloRadioButton.TabIndex = 8;
            this.costoVueloRadioButton.TabStop = true;
            this.costoVueloRadioButton.Text = "Costo";
            this.costoVueloRadioButton.UseVisualStyleBackColor = true;
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
            this.rutaTabPage.Controls.Add(this.dijkstraMaterialButton);
            this.rutaTabPage.Controls.Add(this.OrigenRutaMaterialListView);
            this.rutaTabPage.Controls.Add(this.kruskalutaFlatButton);
            this.rutaTabPage.Controls.Add(this.PrimRutaFlatButton);
            this.rutaTabPage.Controls.Add(this.totalRutaMaterialLabel);
            this.rutaTabPage.Controls.Add(this.tiempoRutasMaterialRadioButton);
            this.rutaTabPage.Controls.Add(this.costoRutasMaterialRadioButton);
            this.rutaTabPage.Controls.Add(this.eliminarCiudadRutaFlatButton);
            this.rutaTabPage.Controls.Add(this.ciudadRutaMaterialListView);
            this.rutaTabPage.Controls.Add(this.rutaPanel);
            this.rutaTabPage.Controls.Add(this.mostrarRutaMaterialFlatButton);
            this.rutaTabPage.Location = new System.Drawing.Point(4, 22);
            this.rutaTabPage.Name = "rutaTabPage";
            this.rutaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rutaTabPage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rutaTabPage.Size = new System.Drawing.Size(632, 334);
            this.rutaTabPage.TabIndex = 2;
            this.rutaTabPage.Text = "Rutas";
            this.rutaTabPage.Enter += new System.EventHandler(this.rutaTabPage_Enter);
            // 
            // kruskalutaFlatButton
            // 
            this.kruskalutaFlatButton.AutoSize = true;
            this.kruskalutaFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.kruskalutaFlatButton.Depth = 0;
            this.kruskalutaFlatButton.Icon = null;
            this.kruskalutaFlatButton.Location = new System.Drawing.Point(460, 57);
            this.kruskalutaFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.kruskalutaFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.kruskalutaFlatButton.Name = "kruskalutaFlatButton";
            this.kruskalutaFlatButton.Primary = false;
            this.kruskalutaFlatButton.Size = new System.Drawing.Size(81, 36);
            this.kruskalutaFlatButton.TabIndex = 9;
            this.kruskalutaFlatButton.Text = "Kruskal";
            this.kruskalutaFlatButton.UseVisualStyleBackColor = true;
            this.kruskalutaFlatButton.Click += new System.EventHandler(this.kruskalutaFlatButton_Click);
            // 
            // PrimRutaFlatButton
            // 
            this.PrimRutaFlatButton.AutoSize = true;
            this.PrimRutaFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PrimRutaFlatButton.Depth = 0;
            this.PrimRutaFlatButton.Icon = null;
            this.PrimRutaFlatButton.Location = new System.Drawing.Point(460, 9);
            this.PrimRutaFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PrimRutaFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PrimRutaFlatButton.Name = "PrimRutaFlatButton";
            this.PrimRutaFlatButton.Primary = false;
            this.PrimRutaFlatButton.Size = new System.Drawing.Size(54, 36);
            this.PrimRutaFlatButton.TabIndex = 8;
            this.PrimRutaFlatButton.Text = "Prim";
            this.PrimRutaFlatButton.UseVisualStyleBackColor = true;
            this.PrimRutaFlatButton.Click += new System.EventHandler(this.PrimRutaFlatButton_Click);
            // 
            // totalRutaMaterialLabel
            // 
            this.totalRutaMaterialLabel.AutoSize = true;
            this.totalRutaMaterialLabel.Depth = 0;
            this.totalRutaMaterialLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.totalRutaMaterialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalRutaMaterialLabel.Location = new System.Drawing.Point(456, 129);
            this.totalRutaMaterialLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalRutaMaterialLabel.Name = "totalRutaMaterialLabel";
            this.totalRutaMaterialLabel.Size = new System.Drawing.Size(48, 19);
            this.totalRutaMaterialLabel.TabIndex = 7;
            this.totalRutaMaterialLabel.Text = "Total:";
            // 
            // tiempoRutasMaterialRadioButton
            // 
            this.tiempoRutasMaterialRadioButton.AutoSize = true;
            this.tiempoRutasMaterialRadioButton.Depth = 0;
            this.tiempoRutasMaterialRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.tiempoRutasMaterialRadioButton.Location = new System.Drawing.Point(534, 129);
            this.tiempoRutasMaterialRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.tiempoRutasMaterialRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.tiempoRutasMaterialRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.tiempoRutasMaterialRadioButton.Name = "tiempoRutasMaterialRadioButton";
            this.tiempoRutasMaterialRadioButton.Ripple = true;
            this.tiempoRutasMaterialRadioButton.Size = new System.Drawing.Size(72, 30);
            this.tiempoRutasMaterialRadioButton.TabIndex = 6;
            this.tiempoRutasMaterialRadioButton.TabStop = true;
            this.tiempoRutasMaterialRadioButton.Text = "tiempo";
            this.tiempoRutasMaterialRadioButton.UseVisualStyleBackColor = true;
            this.tiempoRutasMaterialRadioButton.Click += new System.EventHandler(this.tiempoRutasMaterialRadioButton_Click);
            // 
            // costoRutasMaterialRadioButton
            // 
            this.costoRutasMaterialRadioButton.AutoSize = true;
            this.costoRutasMaterialRadioButton.Depth = 0;
            this.costoRutasMaterialRadioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.costoRutasMaterialRadioButton.Location = new System.Drawing.Point(534, 99);
            this.costoRutasMaterialRadioButton.Margin = new System.Windows.Forms.Padding(0);
            this.costoRutasMaterialRadioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.costoRutasMaterialRadioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.costoRutasMaterialRadioButton.Name = "costoRutasMaterialRadioButton";
            this.costoRutasMaterialRadioButton.Ripple = true;
            this.costoRutasMaterialRadioButton.Size = new System.Drawing.Size(65, 30);
            this.costoRutasMaterialRadioButton.TabIndex = 5;
            this.costoRutasMaterialRadioButton.TabStop = true;
            this.costoRutasMaterialRadioButton.Text = "Costo";
            this.costoRutasMaterialRadioButton.UseVisualStyleBackColor = true;
            this.costoRutasMaterialRadioButton.Click += new System.EventHandler(this.costoRutasMaterialRadioButton_Click);
            // 
            // eliminarCiudadRutaFlatButton
            // 
            this.eliminarCiudadRutaFlatButton.AutoSize = true;
            this.eliminarCiudadRutaFlatButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eliminarCiudadRutaFlatButton.Depth = 0;
            this.eliminarCiudadRutaFlatButton.Icon = null;
            this.eliminarCiudadRutaFlatButton.Location = new System.Drawing.Point(534, 57);
            this.eliminarCiudadRutaFlatButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eliminarCiudadRutaFlatButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.eliminarCiudadRutaFlatButton.Name = "eliminarCiudadRutaFlatButton";
            this.eliminarCiudadRutaFlatButton.Primary = false;
            this.eliminarCiudadRutaFlatButton.Size = new System.Drawing.Size(83, 36);
            this.eliminarCiudadRutaFlatButton.TabIndex = 4;
            this.eliminarCiudadRutaFlatButton.Text = "Eliminar";
            this.eliminarCiudadRutaFlatButton.UseVisualStyleBackColor = true;
            this.eliminarCiudadRutaFlatButton.Click += new System.EventHandler(this.eliminarCiudadRutaFlatButton_Click);
            // 
            // ciudadRutaMaterialListView
            // 
            this.ciudadRutaMaterialListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ciudadRutaMaterialListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cityRutasColumnHeader});
            this.ciudadRutaMaterialListView.Depth = 0;
            this.ciudadRutaMaterialListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ciudadRutaMaterialListView.FullRowSelect = true;
            this.ciudadRutaMaterialListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ciudadRutaMaterialListView.Location = new System.Drawing.Point(519, 167);
            this.ciudadRutaMaterialListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ciudadRutaMaterialListView.MouseState = MaterialSkin.MouseState.OUT;
            this.ciudadRutaMaterialListView.Name = "ciudadRutaMaterialListView";
            this.ciudadRutaMaterialListView.OwnerDraw = true;
            this.ciudadRutaMaterialListView.Size = new System.Drawing.Size(100, 159);
            this.ciudadRutaMaterialListView.TabIndex = 3;
            this.ciudadRutaMaterialListView.UseCompatibleStateImageBehavior = false;
            this.ciudadRutaMaterialListView.View = System.Windows.Forms.View.Details;
            this.ciudadRutaMaterialListView.SelectedIndexChanged += new System.EventHandler(this.ciudadRutaMaterialListView_SelectedIndexChanged);
            // 
            // cityRutasColumnHeader
            // 
            this.cityRutasColumnHeader.Text = "Des";
            this.cityRutasColumnHeader.Width = 83;
            // 
            // rutaPanel
            // 
            this.rutaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rutaPanel.Location = new System.Drawing.Point(3, 3);
            this.rutaPanel.Name = "rutaPanel";
            this.rutaPanel.Size = new System.Drawing.Size(403, 328);
            this.rutaPanel.TabIndex = 2;
            this.rutaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rutaMaterialLabel_Paint);
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
            // OrigenRutaMaterialListView
            // 
            this.OrigenRutaMaterialListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrigenRutaMaterialListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.origenColumnHeader});
            this.OrigenRutaMaterialListView.Depth = 0;
            this.OrigenRutaMaterialListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.OrigenRutaMaterialListView.FullRowSelect = true;
            this.OrigenRutaMaterialListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.OrigenRutaMaterialListView.Location = new System.Drawing.Point(414, 167);
            this.OrigenRutaMaterialListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.OrigenRutaMaterialListView.MouseState = MaterialSkin.MouseState.OUT;
            this.OrigenRutaMaterialListView.Name = "OrigenRutaMaterialListView";
            this.OrigenRutaMaterialListView.OwnerDraw = true;
            this.OrigenRutaMaterialListView.Size = new System.Drawing.Size(100, 159);
            this.OrigenRutaMaterialListView.TabIndex = 10;
            this.OrigenRutaMaterialListView.UseCompatibleStateImageBehavior = false;
            this.OrigenRutaMaterialListView.View = System.Windows.Forms.View.Details;
            this.OrigenRutaMaterialListView.SelectedIndexChanged += new System.EventHandler(this.OrigenRutaMaterialListView_SelectedIndexChanged);
            // 
            // origenColumnHeader
            // 
            this.origenColumnHeader.Text = "Ori";
            this.origenColumnHeader.Width = 83;
            // 
            // dijkstraMaterialButton
            // 
            this.dijkstraMaterialButton.AutoSize = true;
            this.dijkstraMaterialButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dijkstraMaterialButton.Depth = 0;
            this.dijkstraMaterialButton.Icon = null;
            this.dijkstraMaterialButton.Location = new System.Drawing.Point(460, 87);
            this.dijkstraMaterialButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dijkstraMaterialButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.dijkstraMaterialButton.Name = "dijkstraMaterialButton";
            this.dijkstraMaterialButton.Primary = false;
            this.dijkstraMaterialButton.Size = new System.Drawing.Size(84, 36);
            this.dijkstraMaterialButton.TabIndex = 11;
            this.dijkstraMaterialButton.Text = "Dijkstra";
            this.dijkstraMaterialButton.UseVisualStyleBackColor = true;
            this.dijkstraMaterialButton.Click += new System.EventHandler(this.dijkstraMaterialButton_Click);
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
        private MaterialSkin.Controls.MaterialFlatButton mostrarRutaMaterialFlatButton;
        private MaterialSkin.Controls.MaterialRadioButton timeVueloRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton costoVueloRadioButton;
        private MaterialSkin.Controls.MaterialFlatButton sortVuelosMaterialFlatButton;
        private System.Windows.Forms.Panel rutaPanel;
        private MaterialSkin.Controls.MaterialFlatButton ordenarPasajeroFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton eliminarCiudadRutaFlatButton;
        private MaterialSkin.Controls.MaterialListView ciudadRutaMaterialListView;
        private System.Windows.Forms.ColumnHeader cityRutasColumnHeader;
        private MaterialSkin.Controls.MaterialRadioButton tiempoRutasMaterialRadioButton;
        private MaterialSkin.Controls.MaterialRadioButton costoRutasMaterialRadioButton;
        private MaterialSkin.Controls.MaterialLabel totalRutaMaterialLabel;
        private MaterialSkin.Controls.MaterialFlatButton kruskalutaFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton PrimRutaFlatButton;
        private MaterialSkin.Controls.MaterialFlatButton dijkstraMaterialButton;
        private MaterialSkin.Controls.MaterialListView OrigenRutaMaterialListView;
        private System.Windows.Forms.ColumnHeader origenColumnHeader;
    }
}

