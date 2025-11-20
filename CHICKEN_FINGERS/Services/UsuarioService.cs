using CHICKEN_FINGERS.DAO;
using CHICKEN_FINGERS.Models;
using CHICKEN_FINGERS.Services.Interfaces;

namespace CHICKEN_FINGERS.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly UsuarioDAO _usuarioDAO;
        private readonly JwtService _jwtService;

        public UsuarioService(UsuarioDAO usuarioDAO, JwtService jwtService)
        {
            _usuarioDAO = usuarioDAO;
            _jwtService = jwtService;
        }
        public string GenerarToken(Usuario usuario)
        {
            return _jwtService.GenerarToken(usuario);
        }

        public async Task<Usuario?> ValidarUsuarioAsync(string nombreUsuario, string contrasena)
        {
            return await _usuarioDAO.ValidarUsuarioAsync(nombreUsuario, contrasena);
        }
    }
}
