using ZumbieLab.Models;

namespace ZumbieLab.Repositories
{
    public interface ISportRepository
    {
        SportModel Create(SportModel Sport);
        bool Delete(long id);
        SportModel Get(long id);
        List<SportModel> GetAll();
        SportModel Update(SportModel Sport);
    }
}