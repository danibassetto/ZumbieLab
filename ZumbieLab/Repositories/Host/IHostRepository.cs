using ZombieLab.Models;

namespace ZombieLab.Repositories
{
    public interface IHostRepository
    {
        HostModel Create(HostModel Host);
        bool Delete(long id);
        HostModel Get(long id);
        List<HostModel> GetAll();
        HostModel Update(HostModel Host);
    }
}