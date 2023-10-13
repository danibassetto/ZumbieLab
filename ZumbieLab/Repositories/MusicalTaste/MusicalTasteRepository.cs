using ZumbieLab.Data;
using ZumbieLab.Models;

namespace ZumbieLab.Repositories
{
    public class MusicalTasteRepository : IMusicalTasteRepository
    {
        private readonly DataBaseContext _dataBaseContext;

        public MusicalTasteRepository(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }

        public MusicalTasteModel Create(MusicalTasteModel musicalTaste)
        {
            _dataBaseContext.MusicalTaste.Add(musicalTaste);
            _dataBaseContext.SaveChanges();
            return musicalTaste;
        }

        public bool Delete(long id)
        {
            MusicalTasteModel deleteMusicalTaste = Get(id);

            if (deleteMusicalTaste == null)
                throw new Exception("Gosto musical inválido ou inexistente");

            _dataBaseContext.Remove(deleteMusicalTaste);
            _dataBaseContext.SaveChanges();

            return true;
        }

        public MusicalTasteModel Get(long id)
        {
            return _dataBaseContext.MusicalTaste.FirstOrDefault(x => x.Id == id);
        }

        public List<MusicalTasteModel> GetAll()
        {
            return _dataBaseContext.MusicalTaste.ToList();
        }

        public MusicalTasteModel Update(MusicalTasteModel MusicalTaste)
        {
            MusicalTasteModel updateMusicalTaste = Get(MusicalTaste.Id);

            if (updateMusicalTaste == null)
                throw new Exception("Gosto musical inválido ou inexistente");

            updateMusicalTaste.Description = MusicalTaste.Description;

            _dataBaseContext.Update(updateMusicalTaste);
            _dataBaseContext.SaveChanges();
            return updateMusicalTaste;
        }
    }
}