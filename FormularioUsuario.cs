using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TV_AyK.Modelos;

namespace TV_AyK
{
    public partial class FormularioUsuario : Form
    {
        private List<Pelicula> peliculas;
        private List<Serie> series;

        public FormularioUsuario()
        {
            InitializeComponent();
            peliculas = ServicioCsv.LeerPeliculas("datos/Peliculas.csv");
            series = ServicioCsv.LeerSeries("datos/Series.csv");
            Console.WriteLine($"Peliculas leídas: {peliculas.Count}");
            foreach (var pelicula in peliculas)
            {
                Console.WriteLine($"Título: {pelicula.Titulo}, Género: {pelicula.Genero}, Calificación: {pelicula.Valoracion}, Visto: {pelicula.Vista}, Gustada: {pelicula.Gustada}");
            }
            Console.WriteLine($"Series leídas: {series.Count}");
            foreach (var serie in series)
            {
                Console.WriteLine($"Título: {serie.Titulo}, Género: {serie.Genero}, Calificación: {serie.Valoracion}, Visto: {serie.Vista}");
            }
        }

        private void FormularioUsuario_Load(object sender, EventArgs e)
        {
            // Configuración del DataGridView de Películas
            dataGridViewPeliculas.AutoGenerateColumns = false;
            dataGridViewPeliculas.DataSource = peliculas;

            dataGridViewPeliculas.Columns.Clear();
            dataGridViewPeliculas.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Título", Name = "Titulo" });
            dataGridViewPeliculas.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Genero", HeaderText = "Género", Name = "Genero" });
            dataGridViewPeliculas.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Valoracion", HeaderText = "Calificación", Name = "Valoracion" });
            dataGridViewPeliculas.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "Vista", HeaderText = "Visto", Name = "Vista" });
            dataGridViewPeliculas.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "Gustada", HeaderText = "Gustada", Name = "Gustada" });

            dataGridViewPeliculas.CellValueChanged += DataGridViewPeliculas_CellValueChanged;
            dataGridViewPeliculas.CurrentCellDirtyStateChanged += DataGridViewPeliculas_CurrentCellDirtyStateChanged;

            // Configuración del DataGridView de Series
            dataGridViewSeries.AutoGenerateColumns = false;
            dataGridViewSeries.DataSource = series;

            dataGridViewSeries.Columns.Clear();
            dataGridViewSeries.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Titulo", HeaderText = "Título", Name = "Titulo" });
            dataGridViewSeries.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Genero", HeaderText = "Género", Name = "Genero" });
            dataGridViewSeries.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Valoracion", HeaderText = "Valoración", Name = "Valoracion" });
            dataGridViewSeries.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "Vista", HeaderText = "Vista", Name = "Vista" });
            dataGridViewSeries.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "Gustada", HeaderText = "Gustada", Name = "Gustada" });

            dataGridViewSeries.CellValueChanged += DataGridViewSeries_CellValueChanged;
            dataGridViewSeries.CurrentCellDirtyStateChanged += DataGridViewSeries_CurrentCellDirtyStateChanged;
        }

        private void DataGridViewPeliculas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewPeliculas.IsCurrentCellDirty)
            {
                dataGridViewPeliculas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DataGridViewPeliculas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var pelicula = peliculas[e.RowIndex];
                pelicula.Vista = Convert.ToBoolean(dataGridViewPeliculas.Rows[e.RowIndex].Cells["Vista"].Value);
                pelicula.Gustada = Convert.ToBoolean(dataGridViewPeliculas.Rows[e.RowIndex].Cells["Gustada"].Value);
            }
        }

        private void DataGridViewSeries_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridViewSeries.IsCurrentCellDirty)
            {
                dataGridViewSeries.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void DataGridViewSeries_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var serie = series[e.RowIndex];
                serie.Vista = Convert.ToBoolean(dataGridViewSeries.Rows[e.RowIndex].Cells["Vista"].Value);
                serie.Gustada = Convert.ToBoolean(dataGridViewSeries.Rows[e.RowIndex].Cells["Gustada"].Value);
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            ServicioCsv.EscribirPeliculas("datos/Peliculas.csv", peliculas);
            ServicioCsv.EscribirSeries("datos/Series.csv", series);
            MessageBox.Show("Cambios guardados correctamente.");
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






