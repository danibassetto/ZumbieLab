using ZumbieLab.Data;
using ZumbieLab.Models;

namespace ZumbieLab.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly DataBaseContext _dataBaseContext;

        public GameRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public GameModel Create(GameModel game)
        {
            _dataBaseContext.Game.Add(game);
            _dataBaseContext.SaveChanges();
            return game;
        }

        public bool Delete(long id)
        {
            GameModel deleteGame = Get(id);

            if (deleteGame == null)
                throw new Exception("Jogo inválido ou inexistente");

            _dataBaseContext.Remove(deleteGame);
            _dataBaseContext.SaveChanges();

            return true;
        }

        public GameModel Get(long id)
        {
            return _dataBaseContext.Game.FirstOrDefault(x => x.Id == id);
        }

        public List<GameModel> GetAll()
        {
            return _dataBaseContext.Game.ToList();
        }

        public GameModel Update(GameModel Game)
        {
            GameModel updateGame = Get(Game.Id);

            if (updateGame == null)
                throw new Exception("Jogo inválido ou inexistente");

            updateGame.Name = Game.Name;

            _dataBaseContext.Update(updateGame);
            _dataBaseContext.SaveChanges();
            return updateGame;
        }
    }
}