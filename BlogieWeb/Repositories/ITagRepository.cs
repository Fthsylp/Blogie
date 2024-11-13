using BlogieWeb.Models.Domain;

namespace BlogieWeb.Repositories
{
    public interface ITagRepository
    {
        Task<IEnumerable<Tag>> GetAllAsync(); // To be able to iterate over a list like a foreach does we use Enumerable 

        Task<Tag?> GetAsync(Guid id); // Single item

        Task<Tag> AddAsync(Tag tag);

        Task<Tag?> UpdateAsync(Tag tag);

        Task<Tag?> DeleteAsync(Guid id);
    }
}
