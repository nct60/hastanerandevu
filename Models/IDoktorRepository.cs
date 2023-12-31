using System.Drawing;

namespace Hastaneuygulama.Models
{
    public interface IDoktorRepository : IRepository<Doktor> //extends
    {
        void Guncelle(Doktor doktorInterface);
        void Kaydet();
    }
}
