﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV_AyK.Modelos { 
 public class Usuario
{
    public string NombreUsuario { get; set; }
    public string Contraseña { get; set; }
    public string Rol { get; set; } // "admin" o "usuario"
}
}
