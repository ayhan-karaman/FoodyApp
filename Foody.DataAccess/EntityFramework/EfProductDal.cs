
using Foody.DataAccess.Abstract;
using Foody.DataAccess.Context;
using Foody.DataAccess.Repositories;
using Foody.Entities.Concrete;

namespace Foody.DataAccess.EntityFramework
{
    public class EfProductDal : GenericRepositories<Product>, IProductDal
    {
        public EfProductDal(FoodyContext context) : base(context)
        {
        }
    }
    
}