
using Foody.Entities.Concrete;

namespace Foody.DataAccess.Abstract
{
    public interface IProductDal:IGenericDal<Product>
    {
        List<Product> ProductLisWithCategory();
    }
}