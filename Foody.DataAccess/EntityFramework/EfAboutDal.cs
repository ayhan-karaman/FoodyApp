
using Foody.DataAccess.Abstract;
using Foody.DataAccess.Context;
using Foody.DataAccess.Repositories;
using Foody.Entities.Concrete;

namespace Foody.DataAccess.EntityFramework
{
    public class EfAboutDal : GenericRepositories<About>, IAboutDal
    {
        public EfAboutDal(FoodyContext context) : base(context)
        {
        }
    }
    
}