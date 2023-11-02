using FiapStoreMinimalApi.Entities;

namespace FiapStoreMinimalApi.Interfaces
{
    public interface IUsuarioRepository
    {
        IList<Usuario> ObterTodosUsuarios();
        Usuario ObterUsuarioPorId(int id);
        void CadastrarUsuario(Usuario usuario);
        void AlterarUsuario(Usuario usuario);
        void DeletarUsuario(int id);
    }
}
