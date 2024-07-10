using SistemaGestion;
using SistemaGestionBussiness;
using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNombreUsuario.Text = "";
            txtContraseña.Text = "";
            txtMail.Text = "";
            txtId.Text = "";
        }
        private void FormUsuario_Load(object sender, EventArgs e)
        {
            int idUsuario = Program.form1.idUsuario;
            if (idUsuario > 0)
            {
                
                Usuario txtUsuario = UsuarioBussiness.GetUsuarioByID(idUsuario);

                txtNombre.Text = txtUsuario.Nombre;
                txtApellido.Text = txtUsuario.Apellido;
                txtNombreUsuario.Text = txtUsuario.NombreUsuario;
                txtContraseña.Text = txtUsuario.Contraseña;
                txtMail.Text = txtUsuario.Mail;
                txtId.Text = txtUsuario.Id.ToString();
            }
            else
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtNombreUsuario.Text = "";
                txtContraseña.Text = "";
                txtMail.Text = "";
                txtId.Text = "";
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Program.form1.idProducto = 0;
            this.Close();
            Program.form1.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Id = txtId.Text;
            
            UsuarioBussiness.DeleteUsuario(int.Parse(Id));
            MessageBox.Show("Usuario Borrado");
            limpiar();
            Program.form1.idUsuario = 0;
            this.Close();
            Program.form1.Refresh();
            Program.form1.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;
            string mail = txtMail.Text;
            int idUsuario = Program.form1.idUsuario;
            Usuario nuevoUsuario = new Usuario(nombre, apellido, nombreUsuario, contraseña, mail);

            if (idUsuario > 0)
            {
     
                UsuarioBussiness.UpdateUsuario(idUsuario, nuevoUsuario);
                MessageBox.Show("Usuario Actualizado");
            }
            else
            {
                
                UsuarioBussiness.CreateUsuario(nuevoUsuario);
                MessageBox.Show("Usuario Nuevo Creado");
            }
            limpiar();
            this.Close();
            Program.form1.idUsuario = 0;
            Program.form1.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
