using System.Collections.Generic;
using System.Linq;
using TV_AyK.Modelos;

namespace TV_AyK
{
    public static class ServicioAutenticacion
    {
        public static Usuario Autenticar(string nombreUsuario, string contraseña, List<Usuario> usuarios)
        {
            return usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.Contraseña == contraseña);
        }
    }
}