using ZombieLab.Models;

namespace ZombieLab.Helpers
{
    public interface ISession
    {
        void CreateUserSession(UserModel user);
        void RemoveUserSession();
        UserModel GetUserSession();
    }
}