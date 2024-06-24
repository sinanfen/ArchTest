using ArchTest.Application.Interfaces;
using ArchTest.Domain.Entities;
using ArchTest.Domain.Interfaces;

namespace ArchTest.Application.Services;

public class UserService : IUserService
{
    private readonly IRepository<User> _userRepository;
    private readonly IAsyncRepository<User> _userAsyncRepository;

    public UserService(IRepository<User> userRepository, IAsyncRepository<User> userAsyncRepository)
    {
        _userRepository = userRepository;
        _userAsyncRepository = userAsyncRepository;
    }

    #region Synchronous Methods
    public User GetById(Guid id)
    {
        return _userRepository.GetById(id);
    }

    public IEnumerable<User> GetAll()
    {
        return _userRepository.GetAll();
    }

    public void Add(User user)
    {
        _userRepository.Add(user);
    }

    public void Update(User user)
    {
        _userRepository.Update(user);
    }

    public void Delete(Guid id)
    {
        _userRepository.Delete(id);
    }
    #endregion

    #region Asynchronous Methods
    public async Task<User> GetByIdAsync(Guid id)
    {
        return await _userAsyncRepository.GetByIdAsync(id);
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        return await _userAsyncRepository.GetAllAsync();
    }

    public async Task AddAsync(User user)
    {
        await _userAsyncRepository.AddAsync(user);
    }

    public async Task UpdateAsync(User user)
    {
        await _userAsyncRepository.UpdateAsync(user);
    }

    public async Task DeleteAsync(Guid id)
    {
        await _userAsyncRepository.DeleteAsync(id);
    }
    #endregion
}
