using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TV_AyK.Modelos;

namespace TV_AyK
{
    public partial class FormularioAdmin : Form
    {
        private List<Pelicula> peliculas;
        private List<Serie> series;

        public FormularioAdmin()
        {
            InitializeComponent();
            peliculas = ServicioCsv.LeerPeliculas("datos/Peliculas.csv");
            series = ServicioCsv.LeerSeries("datos/Series.csv");
        }

        private void FormularioAdmin_Load(object sender, EventArgs e)
        {
            // Lógica para cargar el formulario de administrador
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            // Lógica para agregar usuario
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            // Lógica para eliminar usuario
        }

        private void btnAgregarPelicula_Click(object sender, EventArgs e)
        {
            // Leer los datos de entrada del usuario
            string titulo = txtTituloPelicula.Text;
            string genero = txtGeneroPelicula.Text;
            double valoracion = double.Parse(txtValoracionPelicula.Text);
            bool vista = chkVistaPelicula.Checked;
            bool gustada = chkGustadaPelicula.Checked;

            // Crear una nueva instancia de Pelicula
            Pelicula nuevaPelicula = new Pelicula
            {
                Titulo = titulo,
                Genero = genero,
                Valoracion = valoracion,
                Vista = vista,
                Gustada = gustada
            };

            // Agregar la nueva película a la lista de películas
            peliculas.Add(nuevaPelicula);

            // Escribir la lista actualizada de películas en el archivo CSV
            ServicioCsv.EscribirPeliculas("datos/Peliculas.csv", peliculas);

            MessageBox.Show("Película agregada correctamente.");
        }

        private void btnEliminarPelicula_Click(object sender, EventArgs e)
        {
            // Leer el título de la película a eliminar
            string titulo = txtTituloPelicula.Text;

            // Buscar y eliminar la película de la lista de películas
            Pelicula peliculaAEliminar = peliculas.FirstOrDefault(p => p.Titulo == titulo);
            if (peliculaAEliminar != null)
            {
                peliculas.Remove(peliculaAEliminar);

                // Escribir la lista actualizada de películas en el archivo CSV
                ServicioCsv.EscribirPeliculas("datos/Peliculas.csv", peliculas);

                MessageBox.Show("Película eliminada correctamente.");
            }
            else
            {
                MessageBox.Show("Película no encontrada.");
            }
        }

        private void btnAgregarSerie_Click(object sender, EventArgs e)
        {
            // Leer los datos de entrada del usuario
            string titulo = txtTituloSerie.Text;
            string genero = txtGeneroSerie.Text;
            double valoracion = double.Parse(txtValoracionSerie.Text);
            bool vista = chkVistaSerie.Checked;
            bool gustada = chkGustadaSerie.Checked;

            // Crear una nueva instancia de Serie
            Serie nuevaSerie = new Serie
            {
                Titulo = titulo,
                Genero = genero,
                Valoracion = valoracion,
                Vista = vista,
                Gustada = gustada
            };

            // Agregar la nueva serie a la lista de series
            series.Add(nuevaSerie);

            // Escribir la lista actualizada de series en el archivo CSV
            ServicioCsv.EscribirSeries("datos/Series.csv", series);

            MessageBox.Show("Serie agregada correctamente.");
        }

        private void btnEliminarSerie_Click(object sender, EventArgs e)
        {
            // Leer el título de la serie a eliminar
            string titulo = txtTituloSerie.Text;

            // Buscar y eliminar la serie de la lista de series
            Serie serieAEliminar = series.FirstOrDefault(s => s.Titulo == titulo);
            if (serieAEliminar != null)
            {
                series.Remove(serieAEliminar);

                // Escribir la lista actualizada de series en el archivo CSV
                ServicioCsv.EscribirSeries("datos/Series.csv", series);

                MessageBox.Show("Serie eliminada correctamente.");
            }
            else
            {
                MessageBox.Show("Serie no encontrada.");
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Redirigir al formulario de inicio de sesión
            FormularioInicioSesion formularioInicioSesion = new FormularioInicioSesion();
            formularioInicioSesion.Show();
            this.Close();
        }
    }
}

