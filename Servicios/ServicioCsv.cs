using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using TV_AyK.Modelos;

namespace TV_AyK
{
    public static class ServicioCsv
    {
        // Método para leer usuarios desde un archivo CSV

        public static List<Usuario> LeerUsuarios(string rutaArchivo)
        {
            var usuarios = new List<Usuario>();
            var lineas = File.ReadAllLines(rutaArchivo, Encoding.UTF8); 

            foreach (var linea in lineas.Skip(1)) // Saltar encabezado
            {
                var valores = linea.Split(';'); // Se usa ';' como delimitador
                if (valores.Length >= 3)
                {
                    usuarios.Add(new Usuario
                    {
                        NombreUsuario = valores[0],
                        Contraseña = valores[1],
                        Rol = valores[2]
                    });
                }
                else
                {
                   
                }
            }

            return usuarios;
        }
        // Método para escribir usuarios en un archivo CSV

        public static void EscribirUsuarios(string rutaArchivo, List<Usuario> usuarios)
        {
            var lineas = new List<string> { "NombreUsuario;Contraseña;Rol" };
            lineas.AddRange(usuarios.Select(u => $"{u.NombreUsuario};{u.Contraseña};{u.Rol}"));
            File.WriteAllLines(rutaArchivo, lineas, Encoding.UTF8); 
        }
        // Método para leer películas desde un archivo CSV

        public static List<Pelicula> LeerPeliculas(string rutaArchivo)
        {
            var peliculas = new List<Pelicula>();
            var lineas = File.ReadAllLines(rutaArchivo, Encoding.UTF8); 

            foreach (var linea in lineas.Skip(1)) // Saltar encabezado
            {
                var valores = linea.Split(';'); // Se usa ';' como delimitador
                if (valores.Length >= 4)
                {
                    try
                    {
                        var pelicula = new Pelicula
                        {
                            Titulo = valores[0],
                            Genero = valores[1],
                            Valoracion = double.Parse(valores[2].Replace(',', '.'), CultureInfo.InvariantCulture),
                            Vista = bool.Parse(valores[3]),
                            Gustada = false 
                        };
                        peliculas.Add(pelicula);
                        Console.WriteLine($"Leída película: {pelicula.Titulo}, {pelicula.Genero}, {pelicula.Valoracion}, {pelicula.Vista}, {pelicula.Gustada}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al procesar la línea: {linea}");
                        Console.WriteLine($"Excepción: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine($"Línea con formato incorrecto: {linea}");
                }
            }

            Console.WriteLine($"Películas leídas: {peliculas.Count}");
            return peliculas;
        }



        // Método para leer series desde un archivo CSV

        public static List<Serie> LeerSeries(string rutaArchivo)
        {
            var series = new List<Serie>();
            var lineas = File.ReadAllLines(rutaArchivo, Encoding.UTF8); // Asegúrate de usar UTF-8

            foreach (var linea in lineas.Skip(1)) // Saltar encabezado
            {
                var valores = linea.Split(';'); // Usar ';' como delimitador
                if (valores.Length >= 4)
                {
                    try
                    {
                        var serie = new Serie
                        {
                            Titulo = valores[0],
                            Genero = valores[1],
                            Valoracion = double.Parse(valores[2].Replace(',', '.'), CultureInfo.InvariantCulture),
                            Vista = bool.Parse(valores[3]),
                            Gustada = false 
                        };
                        series.Add(serie);
                        Console.WriteLine($"Leída serie: {serie.Titulo}, {serie.Genero}, {serie.Valoracion}, {serie.Vista}, {serie.Gustada}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al procesar la línea: {linea}");
                        Console.WriteLine($"Excepción: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine($"Línea con formato incorrecto: {linea}");
                }
            }

            Console.WriteLine($"Series leídas: {series.Count}");
            return series;
        }


        public static void EscribirPeliculas(string rutaArchivo, List<Pelicula> peliculas)
        {
            var lineas = new List<string> { "Titulo;Genero;Valoracion;Vista;Gustada" };
            lineas.AddRange(peliculas.Select(p => $"{p.Titulo};{p.Genero};{p.Valoracion.ToString(CultureInfo.InvariantCulture)};{p.Vista};{p.Gustada}"));
            File.WriteAllLines(rutaArchivo, lineas, Encoding.UTF8); 
        }

        public static void EscribirSeries(string rutaArchivo, List<Serie> series)
        {
            var lineas = new List<string> { "Titulo;Genero;Valoracion;Vista" };
            lineas.AddRange(series.Select(s => $"{s.Titulo};{s.Genero};{s.Valoracion.ToString(CultureInfo.InvariantCulture)};{s.Vista}"));
            File.WriteAllLines(rutaArchivo, lineas, Encoding.UTF8); 
        }
    }
}

