using ZumbieLab.Models;

namespace ZumbieLab.Repositories
{
    public interface IGameRepository
    {
        GameModel Create(GameModel Game);
        bool Delete(long id);
        GameModel Get(long id);
        List<GameModel> GetAll();
        GameModel Update(GameModel Game);
    }
}