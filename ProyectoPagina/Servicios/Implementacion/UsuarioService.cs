using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProyectoPagina.Models;
using ProyectoPagina.Servicios.Contrato;

namespace ProyectoPagina.Servicios.Implementacion
{
    public class UsuarioService : IUsuarioService
    {
        private readonly DbProyectoContext _dbContext;

        public UsuarioService(DbProyectoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Usuario> GetUsuario(string correo, string contra)
        {
            Usuario usuario_encontrado = await _dbContext.Usuarios.Where(u=> u.Correo == correo && u.Contra == contra).FirstOrDefaultAsync();

            return usuario_encontrado;
        }

        public async Task<Usuario> SaveUsuario(Usuario modelo)
        {
            _dbContext.Usuarios.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return modelo;
        }
    }
}
