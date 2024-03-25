using Lab3Websitebanghang.Models;

namespace Lab3Websitebanghang.Repositories
{
    public interface ICategoryRepo
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task AddAsync(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(int id);
    }
}
