using ArchTest.Domain.Entities;

namespace ArchTest.Application.Interfaces;

public interface IUserService
{
    User GetById(Guid id);
    IEnumerable<User> GetAll();
    void Add(User user);
    void Update(User user);
    void Delete(Guid id);

    Task<User> GetByIdAsync(Guid id);
    Task<IEnumerable<User>> GetAllAsync();
    Task AddAsync(User user);
    Task UpdateAsync(User user);
    Task DeleteAsync(Guid id);
}
