using Microsoft.EntityFrameworkCore;
using ProyectoPagina.Models;

namespace ProyectoPagina.Servicios.Contrato
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuario(string correo, string contra);

        Task<Usuario> SaveUsuario(Usuario modelo);
    }
}
