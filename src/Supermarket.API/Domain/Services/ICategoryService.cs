using System.Collections.Generic;
using System.Threading.Tasks;
using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Services
{
    public interface ICategoryService
    {
         Task<IEnumerable<Category>> ListAsync();
<<<<<<< HEAD
<<<<<<< HEAD
=======
         Task<SaveCategoryResponse> SaveAsync(Category category);
         Task<SaveCategoryResponse> UpdateAsync(int id, Category category);
>>>>>>> Develop
=======
         Task<CategoryResponse> SaveAsync(Category category);
         Task<CategoryResponse> UpdateAsync(int id, Category category);
         Task<CategoryResponse> DeleteAsync(int id);
>>>>>>> Develop
    }
}