
namespace Foody.Business.Abstract
{
    public interface IGenericService<T>
    {
        void TInsert(T entity);
        void TUpdate(T entity);
        void TDelete(int id);
        List<T> TGetAll();
        T TGetById(int id);
    }
}