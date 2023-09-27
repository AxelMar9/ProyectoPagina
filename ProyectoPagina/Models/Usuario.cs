using System;
using System.Collections.Generic;

namespace ProyectoPagina.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? NombreUsuario { get; set; }

    public string? Correo { get; set; }

    public string? Contra { get; set; }
}
