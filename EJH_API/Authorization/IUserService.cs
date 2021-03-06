using API.Authorization.Models;
using DataBase.Models;

namespace API.Authorization
{
    public interface IUserService
    {
        AuthResponse Authenticate(AuthRequest model);
        IEnumerable<User> GetAll();
        User GetById(Guid id);
        void Register(RegisterRequest model);
        void Update(Guid id, UpdateRequest model);
        void Delete(Guid id);
    }
}
