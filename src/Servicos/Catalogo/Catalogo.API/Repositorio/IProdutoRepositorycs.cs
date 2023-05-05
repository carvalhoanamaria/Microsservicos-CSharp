
using Catalogo.API.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalogo.API.Repositorio
{
   public interface IProdutoRepositorycs
    {

        Task CreateProduto(Produto produto);

        Task<bool> UpdateProduto(Produto produto);

        Task<bool> DeleteProduto(Produto produto);

        Task<IEnumerable<Produto>> GetProduto();

        Task<Produto> GetProduto(string id);

        Task<IEnumerable<Produto>> GetProdutosPorNome(string nome);

        Task<IEnumerable<Produto>> GetProdutosPorCategoria(string categoria);


    }
}
