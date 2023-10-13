using ZumbieLab.Models;

namespace ZumbieLab.Repositories
{
    public interface IMusicalTasteRepository
    {
        MusicalTasteModel Create(MusicalTasteModel MusicalTaste);
        bool Delete(long id);
        MusicalTasteModel Get(long id);
        List<MusicalTasteModel> GetAll();
        MusicalTasteModel Update(MusicalTasteModel MusicalTaste);
    }
}