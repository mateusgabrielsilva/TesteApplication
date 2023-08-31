namespace TesteApplication.Services.UsuariosService
{
    public class UsuarioService : IUsuarioService
    {
        private static List<Usuarios> usuarios = new List<Usuarios>
        {
            new Usuarios
            {
                Id = 1,
                Nome = "Mateus Gabriel",
                Email = "mateus.gabriel@vocedm.com.br",
                Senha = "Teste123",
                Ativo = 1
            },
            new Usuarios
            {
                Id = 2,
                Nome = "Mateus Silva",
                Email = "mateus.gabriel@vocedm.com.br",
                Senha = "Teste123",
                Ativo = 1
            },
            new Usuarios
            {
                Id = 3,
                Nome = "Mateus",
                Email = "mateus.gabriel@vocedm.com.br",
                Senha = "Teste123",
                Ativo = 1
            }
        };
        public List<Usuarios> GetAllUsers()
        {
            return usuarios;
        }

        public Usuarios GetSingleUsers(int id)
        {
            var usuario = usuarios.Find(x => x.Id == id);
            if (usuario is null)
            {
                return null;
            }
            return usuario;
        }

        public List<Usuarios> AddUsers(Usuarios usuario)
        {
            usuarios.Add(usuario);
            return usuarios;
        }

        public List<Usuarios> UpdateUsers(int id, Usuarios request)
        {
            var usuario = usuarios.Find(x => x.Id == id);
            if (usuario is null)
            {
                return null;
            }

            usuario.Nome = request.Nome;
            usuario.Email = request.Email;
            usuario.Senha = request.Senha;
            usuario.Ativo = request.Ativo;

            return usuarios;
        }

        public List<Usuarios> DeleteUsers(int id)
        {
            var usuario = usuarios.Find(x => x.Id == id);
            if (usuario is null)
            {
                return null;
            }

            usuarios.Remove(usuario);

            return usuarios;
        }
    }
}
