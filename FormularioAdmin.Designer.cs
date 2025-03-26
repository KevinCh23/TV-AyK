namespace TV_AyK
{
    partial class FormularioAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTituloPelicula;
        private System.Windows.Forms.TextBox txtGeneroPelicula;
        private System.Windows.Forms.TextBox txtValoracionPelicula;
        private System.Windows.Forms.CheckBox chkVistaPelicula;
        private System.Windows.Forms.CheckBox chkGustadaPelicula;
        private System.Windows.Forms.Button btnAgregarPelicula;
        private System.Windows.Forms.Button btnEliminarPelicula;
        private System.Windows.Forms.TextBox txtTituloSerie;
        private System.Windows.Forms.TextBox txtGeneroSerie;
        private System.Windows.Forms.TextBox txtValoracionSerie;
        private System.Windows.Forms.CheckBox chkVistaSerie;
        private System.Windows.Forms.CheckBox chkGustadaSerie;
        private System.Windows.Forms.Button btnAgregarSerie;
        private System.Windows.Forms.Button btnEliminarSerie;
        private System.Windows.Forms.Button btnCerrarSesion;


        // Método para liberar los recursos utilizados por el formulario
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Método para inicializar los componentes del formulario
        private void InitializeComponent()
        {
            this.txtTituloPelicula = new System.Windows.Forms.TextBox();
            this.txtGeneroPelicula = new System.Windows.Forms.TextBox();
            this.txtValoracionPelicula = new System.Windows.Forms.TextBox();
            this.chkVistaPelicula = new System.Windows.Forms.CheckBox();
            this.chkGustadaPelicula = new System.Windows.Forms.CheckBox();
            this.btnAgregarPelicula = new System.Windows.Forms.Button();
            this.btnEliminarPelicula = new System.Windows.Forms.Button();
            this.txtTituloSerie = new System.Windows.Forms.TextBox();
            this.txtGeneroSerie = new System.Windows.Forms.TextBox();
            this.txtValoracionSerie = new System.Windows.Forms.TextBox();
            this.chkVistaSerie = new System.Windows.Forms.CheckBox();
            this.chkGustadaSerie = new System.Windows.Forms.CheckBox();
            this.btnAgregarSerie = new System.Windows.Forms.Button();
            this.btnEliminarSerie = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // txtTituloPelicula
            // 
            this.txtTituloPelicula.Location = new System.Drawing.Point(12, 12);
            this.txtTituloPelicula.Name = "txtTituloPelicula";
            this.txtTituloPelicula.Size = new System.Drawing.Size(200, 20);
            this.txtTituloPelicula.TabIndex = 0;
            this.txtTituloPelicula.PlaceholderText = "Título";

            // 
            // txtGeneroPelicula
            // 
            this.txtGeneroPelicula.Location = new System.Drawing.Point(12, 38);
            this.txtGeneroPelicula.Name = "txtGeneroPelicula";
            this.txtGeneroPelicula.Size = new System.Drawing.Size(200, 20);
            this.txtGeneroPelicula.TabIndex = 1;
            this.txtGeneroPelicula.PlaceholderText = "Género";

            // 
            // txtValoracionPelicula
            // 
            this.txtValoracionPelicula.Location = new System.Drawing.Point(12, 64);
            this.txtValoracionPelicula.Name = "txtValoracionPelicula";
            this.txtValoracionPelicula.Size = new System.Drawing.Size(200, 20);
            this.txtValoracionPelicula.TabIndex = 2;
            this.txtValoracionPelicula.PlaceholderText = "Valoración";

            // 
            // chkVistaPelicula
            // 
            this.chkVistaPelicula.Location = new System.Drawing.Point(12, 90);
            this.chkVistaPelicula.Name = "chkVistaPelicula";
            this.chkVistaPelicula.Size = new System.Drawing.Size(200, 20);
            this.chkVistaPelicula.TabIndex = 3;
            this.chkVistaPelicula.Text = "Vista";

            // 
            // chkGustadaPelicula
            // 
            this.chkGustadaPelicula.Location = new System.Drawing.Point(12, 116);
            this.chkGustadaPelicula.Name = "chkGustadaPelicula";
            this.chkGustadaPelicula.Size = new System.Drawing.Size(200, 20);
            this.chkGustadaPelicula.TabIndex = 4;
            this.chkGustadaPelicula.Text = "Gustada";

            // 
            // btnAgregarPelicula
            // 
            this.btnAgregarPelicula.Location = new System.Drawing.Point(12, 142);
            this.btnAgregarPelicula.Name = "btnAgregarPelicula";
            this.btnAgregarPelicula.Size = new System.Drawing.Size(200, 23);
            this.btnAgregarPelicula.TabIndex = 5;
            this.btnAgregarPelicula.Text = "Agregar Película";
            this.btnAgregarPelicula.UseVisualStyleBackColor = true;
            this.btnAgregarPelicula.Click += new System.EventHandler(this.btnAgregarPelicula_Click);

            // 
            // btnEliminarPelicula
            // 
            this.btnEliminarPelicula.Location = new System.Drawing.Point(12, 171);
            this.btnEliminarPelicula.Name = "btnEliminarPelicula";
            this.btnEliminarPelicula.Size = new System.Drawing.Size(200, 23);
            this.btnEliminarPelicula.TabIndex = 6;
            this.btnEliminarPelicula.Text = "Eliminar Película";
            this.btnEliminarPelicula.UseVisualStyleBackColor = true;
            this.btnEliminarPelicula.Click += new System.EventHandler(this.btnEliminarPelicula_Click);

            // 
            // txtTituloSerie
            // 
            this.txtTituloSerie.Location = new System.Drawing.Point(12, 200);
            this.txtTituloSerie.Name = "txtTituloSerie";
            this.txtTituloSerie.Size = new System.Drawing.Size(200, 20);
            this.txtTituloSerie.TabIndex = 7;
            this.txtTituloSerie.PlaceholderText = "Título";

            // 
            // txtGeneroSerie
            // 
            this.txtGeneroSerie.Location = new System.Drawing.Point(12, 226);
            this.txtGeneroSerie.Name = "txtGeneroSerie";
            this.txtGeneroSerie.Size = new System.Drawing.Size(200, 20);
            this.txtGeneroSerie.TabIndex = 8;
            this.txtGeneroSerie.PlaceholderText = "Género";

            // 
            // txtValoracionSerie
            // 
            this.txtValoracionSerie.Location = new System.Drawing.Point(12, 252);
            this.txtValoracionSerie.Name = "txtValoracionSerie";
            this.txtValoracionSerie.Size = new System.Drawing.Size(200, 20);
            this.txtValoracionSerie.TabIndex = 9;
            this.txtValoracionSerie.PlaceholderText = "Valoración";

            // 
            // chkVistaSerie
            // 
            this.chkVistaSerie.Location = new System.Drawing.Point(12, 278);
            this.chkVistaSerie.Name = "chkVistaSerie";
            this.chkVistaSerie.Size = new System.Drawing.Size(200, 20);
            this.chkVistaSerie.TabIndex = 10;
            this.chkVistaSerie.Text = "Vista";

            // 
            // chkGustadaSerie
            // 
            this.chkGustadaSerie.Location = new System.Drawing.Point(12, 304);
            this.chkGustadaSerie.Name = "chkGustadaSerie";
            this.chkGustadaSerie.Size = new System.Drawing.Size(200, 20);
            this.chkGustadaSerie.TabIndex = 11;
            this.chkGustadaSerie.Text = "Gustada";

            // 
            // btnAgregarSerie
            // 
            this.btnAgregarSerie.Location = new System.Drawing.Point(12, 330);
            this.btnAgregarSerie.Name = "btnAgregarSerie";
            this.btnAgregarSerie.Size = new System.Drawing.Size(200, 23);
            this.btnAgregarSerie.TabIndex = 12;
            this.btnAgregarSerie.Text = "Agregar Serie";
            this.btnAgregarSerie.UseVisualStyleBackColor = true;
            this.btnAgregarSerie.Click += new System.EventHandler(this.btnAgregarSerie_Click);

            // 
            // btnEliminarSerie
            // 
            this.btnEliminarSerie.Location = new System.Drawing.Point(12, 359);
            this.btnEliminarSerie.Name = "btnEliminarSerie";
            this.btnEliminarSerie.Size = new System.Drawing.Size(200, 23);
            this.btnEliminarSerie.TabIndex = 13;
            this.btnEliminarSerie.Text = "Eliminar Serie";
            this.btnEliminarSerie.UseVisualStyleBackColor = true;
            this.btnEliminarSerie.Click += new System.EventHandler(this.btnEliminarSerie_Click);

            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 388);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(200, 23);
            this.btnCerrarSesion.TabIndex = 14;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);

            // 
            // FormularioAdmin
            // 
            this.ClientSize = new System.Drawing.Size(284, 423);
            this.Controls.Add(this.txtTituloPelicula);
            this.Controls.Add(this.txtGeneroPelicula);
            this.Controls.Add(this.txtValoracionPelicula);
            this.Controls.Add(this.chkVistaPelicula);
            this.Controls.Add(this.chkGustadaPelicula);
            this.Controls.Add(this.btnAgregarPelicula);
            this.Controls.Add(this.btnEliminarPelicula);
            this.Controls.Add(this.txtTituloSerie);
            this.Controls.Add(this.txtGeneroSerie);
            this.Controls.Add(this.txtValoracionSerie);
            this.Controls.Add(this.chkVistaSerie);
            this.Controls.Add(this.chkGustadaSerie);
            this.Controls.Add(this.btnAgregarSerie);
            this.Controls.Add(this.btnEliminarSerie);
            this.Controls.Add(this.btnCerrarSesion);
            this.Name = "FormularioAdmin";
            this.Load += new System.EventHandler(this.FormularioAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}


