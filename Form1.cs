using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ToDoListEE5
{
   
    public partial class frmToDoList : Form
    {
        //Instanció Tarea que es donde tengo los atributos principales 
        Tarea A = new Tarea();

        public frmToDoList()
        {
            InitializeComponent();
            //Es para que cuando se inicie el programa cambie el color y el titulo del formulario 
            this.Text = "LISTA DE TAREAS";
            this.BackColor = Color.SkyBlue;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            //Uso el metodo para agregar nuevas tareas y mando como parametro el enlace del archivo donde se iran guardando
           Agregar(A, @"C:/Users/dany1/OneDrive/Documents/EXAMEN6.txt");

            

        }
        private void BtnStatus_Click(object sender, EventArgs e)
        {
            //Creo la referencia al metodo Cambiarstatus
            Cambiarstatus();
        }

        private void BtnTareas_Click(object sender, EventArgs e)
        {
            //Creo la referencia al metodo ListaTareas

            ListaTareas();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
      
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void archivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        public void Limpiar()
        {
            //Se usa para limpiar las columnas del datagrid
            dgtvLista.Rows.Clear();
            //lo hago para que cuando el usuario limpie la lista de tarea empiece de cero con la lista

            A.NoTarea = 0;


        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Se usa para que el programa se cierre

            this.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         Agregar(A, @"C:/Users/dany1/OneDrive/Documents/EXAMEN6.txt");


        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Cambiarstatus();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EXAMEN TODOLIST: POO 2019","Acerca de:");
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
        public void Agregar(Tarea A, string path)
        {
            //Instanció mi segundo formulario que usare para agregar tareas
            frmAgregar agregar = new frmAgregar();
            //Se llama con el showDialog para que aparezca
            agregar.ShowDialog();
            //Asigno las cajas de texto a los atributos para poder manejarlos con mas facilidad 
            A.Work = agregar.txtNombre.Text;
            A.Status = agregar.txtEstado.Text;
            A.Hora = agregar.txtHora.Text;
            A.Fecha = Convert.ToDateTime(agregar.txtFecha.Text);
            A.NombreE = agregar.txtEncargado.Text;
            A.NoTarea++;
            //Se una C para que se vayan agregando filas
            int C = dgtvLista.Rows.Add();
            //Se asignan los datos que tendran las filas y celdas
            dgtvLista.Rows[C].Cells[0].Value = A.Work;
            dgtvLista.Rows[C].Cells[1].Value = A.Status;
            dgtvLista.Rows[C].Cells[2].Value = A.NombreE;
            dgtvLista.Rows[C].Cells[3].Value = A.Hora;
            dgtvLista.Rows[C].Cells[4].Value = A.Fecha;
            dgtvLista.Rows[C].Cells[5].Value = A.NoTarea;
            //Utilizo data para guardar los datos que quiero que se muestren en el archivo 
            string data = A.NoTarea + "," + A.NombreE + "," + A.Work + "," + A.Status;
            // datos va a guardar el metodo obtenerLineas
            var datos = ObtenerLineas(path);
            //Se hace una condición para verificar que datos sea distinto a null 
            if (datos != null)
            {
                //si es distinto se agregara la informacion de data en datos.
                datos.Add(data);
                //se manda al archivo
                File.WriteAllLines(path, datos);
            }
            else
            {
               //si no se crea el archivo
                File.WriteAllText(path, data);
            }




        }
        //El metodo obtener lineas es para asegurarse de que exista un archivo a donde mandarse
        public List<string> ObtenerLineas(string path)
        {
            //se usa un arreglo de string para eventualmente guardar los datos
            string[] data = null;
            //si el archivo existe
            if (File.Exists(path))
            {
                // data se usa para que escriba las lineas en el archivo y se puedan leer

                data = File.ReadAllLines(path);
                MessageBox.Show("Registro exitoso", "AVISO");

            }
            else

            {
                //si no existe el archivo se le avisara al usuario
                MessageBox.Show("No se encontro ningún archivo", "AVISO");
                return null;
            }
            //se crea una lista de tipo string
            List<string> Datos = new List<string>();
            // recorremos data
            foreach (var iteam in data)
            {
                // agregamos los valores existentes en data
                Datos.Add(iteam);
            }
            //regresamos la nueva informacion
            return Datos;
        }
        //El metodo cambiar status sera para buscar la tarea y poder cambiar su status
        public void Cambiarstatus()
        {
            frmStatus estado = new frmStatus();
            estado.ShowDialog();
            string N = estado.txtNombre.Text;
            //Se recorre las filas del datagrid poder hacer la condicion que deseamos
            foreach (DataGridViewRow row in dgtvLista.Rows)
            {
                //Si la tarea que buscamos coincide con alguno de los nombres en las filas 
                if (N == Convert.ToString(row.Cells["Nombre"].Value))// se usa row.cells para buscar en la columna llama "Nombre"
                {
                    //El valor de la fila donde se enccontro en la celda 1 cambiara su estado segun el puesto por el usuario
                    //row.index se usa para fijar el valor donde se encontro el nombre de la tarea
                    dgtvLista.Rows[row.Index].Cells[1].Value = estado.txtStatus.Text; break;//Se usa el break para cuando se encuentre se salga del foreach
                }

            }
        }
        //Se usa el metodo lista tarea para mostrar los detalles de la tarea que busquemos
        public void ListaTareas()
        {
            frmDetalles detalles = new frmDetalles();
            //Se utiliza el mismo concepto de busqueda por el foreach 
            foreach (DataGridViewRow row in dgtvLista.Rows)
            {
                //si el nombre coincide con alguno de la columna "Nombre"
                if (txtBuscar.Text == Convert.ToString(row.Cells["Nombre"].Value))
                {
                    //Se pasaran los valores ya asignados en dgtvLista al dgtvTarea 
                    detalles.dgtvTarea.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value);
                    break;



                }

            }
            //Se muestra el formulario una vez la operacion termine para evitar errores de logica
            detalles.ShowDialog();

        }

    }
}
