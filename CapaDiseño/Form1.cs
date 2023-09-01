using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDiseño
{
    public partial class Form1 : Form
    {
        //Creamos instancia de la clase Procedimiento
        Procedimiento pr = new Procedimiento ();
        private string id = null;
        private bool editar = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }
        //Creamos un metodo llamado mostrarDatos
        public void MostrarDatos()
        {
            Procedimiento obj = new Procedimiento();
            dataGridView1.DataSource = obj.mostrar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(editar == false) {
                try
                {
                    pr.Insert(txtNombre.Text,txtApellido.Text,txtCargo.Text);
                    MessageBox.Show("Se agrego correctamente!!!");
                    MostrarDatos();
                }  catch(Exception ex)
                {
                    MessageBox.Show("ERROR AL INGRESAR LOS DATOS"+ex);
                }
            }
            if(editar == true)
            {
                try
                {
                    pr.Update(Convert.ToInt32(id),txtNombre.Text,txtApellido.Text,txtCargo.Text);
                    MessageBox.Show("Se han modificado los datos correctamente");
                    MostrarDatos();
                    editar = false;
                }catch(Exception ex)
                {
                    MessageBox.Show("ERROR AL INGRESAR LOS DATOS" + ex);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = dataGridView1.CurrentRow.Cells["Apellidos"].Value.ToString();
                txtCargo.Text = dataGridView1.CurrentRow.Cells["Cargo"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
                pr.Delete(Convert.ToInt32(id));
                MessageBox.Show("El registro se elimino correctamente!!!");
                MostrarDatos();
            }
            else
            {
                MessageBox.Show("ERROR AL ELIMINAR LOS DATOS!!");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCargo.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
