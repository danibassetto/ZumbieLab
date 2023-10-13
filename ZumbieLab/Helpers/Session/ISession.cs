using ZumbieLab.Models;

namespace ZumbieLab.Helpers
{
    public interface ISession
    {
        void CreateUserSession(UserModel user);
        void RemoveUserSession();
        UserModel GetUserSession();
    }
}