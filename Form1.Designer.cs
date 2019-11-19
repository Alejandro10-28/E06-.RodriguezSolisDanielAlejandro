namespace ToDoListEE5
{
    partial class frmToDoList
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
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnStatus = new System.Windows.Forms.Button();
            this.BtnTareas = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgtvLista = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.lblM = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtvLista)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(296, 196);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 11;
            this.BtnAgregar.Text = "&Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnStatus
            // 
            this.BtnStatus.Location = new System.Drawing.Point(296, 236);
            this.BtnStatus.Name = "BtnStatus";
            this.BtnStatus.Size = new System.Drawing.Size(75, 23);
            this.BtnStatus.TabIndex = 12;
            this.BtnStatus.Text = "&Estado";
            this.BtnStatus.UseVisualStyleBackColor = true;
            this.BtnStatus.Click += new System.EventHandler(this.BtnStatus_Click);
            // 
            // BtnTareas
            // 
            this.BtnTareas.Location = new System.Drawing.Point(404, 87);
            this.BtnTareas.Name = "BtnTareas";
            this.BtnTareas.Size = new System.Drawing.Size(75, 23);
            this.BtnTareas.TabIndex = 13;
            this.BtnTareas.Text = "&Mostrar";
            this.BtnTareas.UseVisualStyleBackColor = true;
            this.BtnTareas.Click += new System.EventHandler(this.BtnTareas_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(284, 90);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 14;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgtvLista
            // 
            this.dgtvLista.AllowUserToAddRows = false;
            this.dgtvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Estados,
            this.Encargado,
            this.Hora,
            this.Fecha,
            this.NoTarea});
            this.dgtvLista.Location = new System.Drawing.Point(-2, 52);
            this.dgtvLista.Name = "dgtvLista";
            this.dgtvLista.ReadOnly = true;
            this.dgtvLista.Size = new System.Drawing.Size(243, 279);
            this.dgtvLista.TabIndex = 15;
            this.dgtvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Estados
            // 
            this.Estados.HeaderText = "Estados";
            this.Estados.Name = "Estados";
            this.Estados.ReadOnly = true;
            // 
            // Encargado
            // 
            this.Encargado.HeaderText = "Encargado";
            this.Encargado.Name = "Encargado";
            this.Encargado.ReadOnly = true;
            this.Encargado.Visible = false;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            this.Hora.Visible = false;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Visible = false;
            // 
            // NoTarea
            // 
            this.NoTarea.HeaderText = "NoTarea";
            this.NoTarea.Name = "NoTarea";
            this.NoTarea.ReadOnly = true;
            this.NoTarea.Visible = false;
            // 
            // BtnSalir
            // 
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir.Location = new System.Drawing.Point(296, 265);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(75, 23);
            this.BtnSalir.TabIndex = 16;
            this.BtnSalir.Text = "&Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(281, 52);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(147, 13);
            this.lblM.TabIndex = 17;
            this.lblM.Text = "Ingresa el nombre de la tarea:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            this.archivosToolStripMenuItem.Click += new System.EventHandler(this.archivosToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.cerrarToolStripMenuItem.Text = "&Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.limpiarToolStripMenuItem,
            this.estadoToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            this.herramientasToolStripMenuItem.Click += new System.EventHandler(this.herramientasToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.agregarToolStripMenuItem.Text = "&Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.limpiarToolStripMenuItem.Text = "&Limpiar";
            // 
            // estadoToolStripMenuItem
            // 
            this.estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            this.estadoToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.estadoToolStripMenuItem.Text = "&Estado";
            this.estadoToolStripMenuItem.Click += new System.EventHandler(this.estadoToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem1});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "&Acerca de";
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.acercaDeToolStripMenuItem1.Text = "&Acerca de";
            this.acercaDeToolStripMenuItem1.Click += new System.EventHandler(this.acercaDeToolStripMenuItem1_Click);
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Location = new System.Drawing.Point(296, 296);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpiar.TabIndex = 19;
            this.BtnLimpiar.Text = "&Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // frmToDoList
            // 
            this.AcceptButton = this.BtnAgregar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnSalir;
            this.ClientSize = new System.Drawing.Size(491, 331);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.dgtvLista);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.BtnTareas);
            this.Controls.Add(this.BtnStatus);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmToDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtvLista)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnTareas;
        private System.Windows.Forms.Button BtnStatus;
       public System.Windows.Forms.TextBox txtBuscar;
        public System.Windows.Forms.DataGridView dgtvLista;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoTarea;
    }
}

