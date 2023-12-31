namespace Hastaneuygulama.Models
{
    public interface IDoktorBransRepository : IRepository<DoktorBrans> //extends
    {
        void Guncelle(DoktorBrans doktorBransInterface);
        void Kaydet();
    }
}
