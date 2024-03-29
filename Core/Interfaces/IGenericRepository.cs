using Core.Entities;
using Core.specifications;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();

        Task<T> GetEntityWithSepc(ISpecification<T> spec);
        Task<IReadOnlyList<T>> ListAllAsync(ISpecification<T> spec);
        Task<int> CountAsync(ISpecification<T> spec);
    }
}