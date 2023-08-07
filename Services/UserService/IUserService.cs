using online_course_platform.Models;

namespace online_course_platform.Services
{
    public interface IUserService
    {
        Task<User> GetById(int id);
        Task<User> GetByUserName(string userName);
        Task<IEnumerable<User>> GetAll();
        void Add(User user);
        User Update(int id, User newUser);
        void Delete(int id);

    }
}