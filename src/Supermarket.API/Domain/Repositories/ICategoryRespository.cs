using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Repositories
{
    public interface ICategoryRepository
    {
<<<<<<< HEAD
         Task<IEnumerable<Category>> ListAsync();
=======
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category category);
        Task<Category> FindByIdAsync(int id);
        void Update(Category category);
<<<<<<< HEAD:src/Supermarket.API/Repositories/ICategoryRespository.cs
>>>>>>> Develop
=======
        void Remove(Category category);
>>>>>>> Develop:src/Supermarket.API/Domain/Repositories/ICategoryRespository.cs
    }
}