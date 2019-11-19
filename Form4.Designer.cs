namespace ToDoListEE5
{
    partial class frmDetalles
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
            this.dgtvTarea = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtvTarea)).BeginInit();
            this.SuspendLayout();
            // 
            // dgtvTarea
            // 
            this.dgtvTarea.AllowUserToAddRows = false;
            this.dgtvTarea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtvTarea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Estado,
            this.Encargado,
            this.Hora,
            this.Fecha,
            this.NoTarea});
            this.dgtvTarea.Location = new System.Drawing.Point(1, 0);
            this.dgtvTarea.Name = "dgtvTarea";
            this.dgtvTarea.Size = new System.Drawing.Size(643, 150);
            this.dgtvTarea.TabIndex = 0;
            this.dgtvTarea.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtvTarea_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre ";
            this.Nombre.Name = "Nombre";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Encargado
            // 
            this.Encargado.HeaderText = "Encargado";
            this.Encargado.Name = "Encargado";
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // NoTarea
            // 
            this.NoTarea.HeaderText = "NoTarea";
            this.NoTarea.Name = "NoTarea";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAceptar.Location = new System.Drawing.Point(266, 165);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 1;
            this.BtnAceptar.Text = "&Aceptar\r\n";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // frmDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 210);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.dgtvTarea);
            this.Name = "frmDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalles ";
            this.Load += new System.EventHandler(this.frmDetalles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtvTarea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgtvTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encargado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoTarea;
        private System.Windows.Forms.Button BtnAceptar;
    }
}