using ZumbieLab.Data;
using ZumbieLab.Models;

namespace ZumbieLab.Repositories
{
    public class SportRepository : ISportRepository
    {
        private readonly DataBaseContext _dataBaseContext;

        public SportRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public SportModel Create(SportModel sport)
        {
            _dataBaseContext.Sport.Add(sport);
            _dataBaseContext.SaveChanges();
            return sport;
        }

        public bool Delete(long id)
        {
            SportModel deleteSport = Get(id);

            if (deleteSport == null)
                throw new Exception("Esporte inválido ou inexistente");

            _dataBaseContext.Remove(deleteSport);
            _dataBaseContext.SaveChanges();

            return true;
        }

        public SportModel Get(long id)
        {
            return _dataBaseContext.Sport.FirstOrDefault(x => x.Id == id);
        }

        public List<SportModel> GetAll()
        {
            return _dataBaseContext.Sport.ToList();
        }

        public SportModel Update(SportModel Sport)
        {
            SportModel updateSport = Get(Sport.Id);

            if (updateSport == null)
                throw new Exception("Jogo inválido ou inexistente");

            updateSport.Description = Sport.Description;

            _dataBaseContext.Update(updateSport);
            _dataBaseContext.SaveChanges();
            return updateSport;
        }
    }
}