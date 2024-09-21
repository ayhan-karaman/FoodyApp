
using Foody.Entities.Concrete;

namespace Foody.Business.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TProductListWithCategory();
    }
}