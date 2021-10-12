using E_commerce.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_commerce.Repositories
{
    public interface IProdutoRepository
    {
        Task SaveProdutos(List<Livro> livros);
        Task<IList<Produto>> GetProdutos();
    }
}