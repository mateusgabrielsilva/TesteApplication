
namespace TesteApplication.Services.UsuariosService
{
    public interface IUsuarioService
    {
        List<Usuarios> GetAllUsers();
        Usuarios GetSingleUsers(int id);
        List<Usuarios> AddUsers(Usuarios usuario);
        List<Usuarios> UpdateUsers(int id, Usuarios request);
        List<Usuarios> DeleteUsers(int id);
    }
}
