namespace ToDoListEE5
{
    partial class frmStatus
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
            this.lblN = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.BtnA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(26, 29);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(44, 13);
            this.lblN.TabIndex = 0;
            this.lblN.Text = "Nombre";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(27, 83);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Estado:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(86, 83);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 3;
            // 
            // BtnA
            // 
            this.BtnA.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnA.Location = new System.Drawing.Point(111, 118);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(75, 23);
            this.BtnA.TabIndex = 4;
            this.BtnA.Text = "&Aceptar";
            this.BtnA.UseVisualStyleBackColor = true;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // frmStatus
            // 
            this.AcceptButton = this.BtnA;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 192);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblN);
            this.Name = "frmStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Status";
            this.Load += new System.EventHandler(this.frmStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblStatus;
        public System.Windows.Forms.TextBox txtNombre;
        public System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Button BtnA;
    }
}