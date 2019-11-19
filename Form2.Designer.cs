namespace ToDoListEE5
{
    partial class frmAgregar
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
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombreU = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAceptar.Location = new System.Drawing.Point(89, 222);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 3;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtEncargado
            // 
            this.txtEncargado.Location = new System.Drawing.Point(102, 165);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(100, 20);
            this.txtEncargado.TabIndex = 20;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(100, 123);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 19;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(100, 89);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 18;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(100, 51);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 17;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 16;
            // 
            // lblNombreU
            // 
            this.lblNombreU.AutoSize = true;
            this.lblNombreU.Location = new System.Drawing.Point(31, 168);
            this.lblNombreU.Name = "lblNombreU";
            this.lblNombreU.Size = new System.Drawing.Size(65, 13);
            this.lblNombreU.TabIndex = 15;
            this.lblNombreU.Text = "Encargado :\r\n";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(31, 130);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(31, 96);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 13;
            this.lblHora.Text = "Hora";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(31, 58);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 272);
            this.Controls.Add(this.txtEncargado);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreU);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAceptar);
            this.Name = "frmAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.frmAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAceptar;
        public System.Windows.Forms.TextBox txtEncargado;
        public System.Windows.Forms.TextBox txtFecha;
        public System.Windows.Forms.TextBox txtHora;
        public System.Windows.Forms.TextBox txtEstado;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombreU;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label1;
    }
}