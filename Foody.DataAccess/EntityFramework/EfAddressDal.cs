
using Foody.DataAccess.Abstract;
using Foody.DataAccess.Context;
using Foody.DataAccess.Repositories;
using Foody.Entities.Concrete;

namespace Foody.DataAccess.EntityFramework
{
    public class EfAddressDal : GenericRepositories<Address>, IAddressDal
    {
        public EfAddressDal(FoodyContext context) : base(context)
        {
        }
    }
    
}