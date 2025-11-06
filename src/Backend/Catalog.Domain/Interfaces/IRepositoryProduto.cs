using Catalog.Domain.Entities;
namespace Catalog.Domain.Interfaces
{
    public interface IRepositoryProduto
    {
        Task<Produto> ObterPorIdAsync(Guid id);
        Task<IEnumerable<Produto>> ObterTodosAsync();
        Task AdicionarAsync(Produto produto);
        Task AtualizarAsync(Produto produto);
        Task RemoverAsync(Guid id);
    }
}
