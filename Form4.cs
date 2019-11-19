using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListEE5
{
    public partial class frmDetalles : Form
    {
        public frmDetalles()
        {
            InitializeComponent();
           this.Text = "DETALLES";
            this.BackColor = Color.DeepSkyBlue;
        }

        private void BtnAc_Click(object sender, EventArgs e)
        {
            
        }

        private void frmDetalles_Load(object sender, EventArgs e)
        {

        }

        private void dgtvTarea_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
        }
    }
}
