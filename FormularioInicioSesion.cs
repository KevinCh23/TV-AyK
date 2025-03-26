using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TV_AyK.Modelos;

namespace TV_AyK
{
    public partial class FormularioInicioSesion : Form
    {
        private List<Usuario> usuarios;

        public FormularioInicioSesion()
        {
            InitializeComponent();
            // Cargar usuarios desde el archivo CSV
            usuarios = ServicioCsv.LeerUsuarios("Datos/Usuarios.csv");

         
           

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            Usuario usuarioAutenticado = ServicioAutenticacion.Autenticar(nombreUsuario, contraseña, usuarios);

            if (usuarioAutenticado != null)
            {
                MessageBox.Show($"Usuario autenticado: {usuarioAutenticado.NombreUsuario}, Rol: {usuarioAutenticado.Rol}");

                if (usuarioAutenticado.Rol == "Admin")
                {
                    // Redirigir al formulario de administrador
                    FormularioAdmin formularioAdmin = new FormularioAdmin();
                    formularioAdmin.Show();
                    MessageBox.Show("Redirigiendo al formulario de administrador.");
                }
                else
                {
                    // Redirigir al formulario de usuario normal
                    FormularioUsuario formularioUsuario = new FormularioUsuario();
                    formularioUsuario.Show();
                    MessageBox.Show("Redirigiendo al formulario de usuario.");
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
