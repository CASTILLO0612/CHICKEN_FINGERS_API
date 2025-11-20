using CHICKEN_FINGERS.Models;

namespace CHICKEN_FINGERS.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<Usuario?> ValidarUsuarioAsync(string nombreUsuario, string contrasena);
        string GenerarToken(Usuario usuario);
    }
}
