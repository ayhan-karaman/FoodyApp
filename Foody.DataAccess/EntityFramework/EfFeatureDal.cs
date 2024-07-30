
using Foody.DataAccess.Abstract;
using Foody.DataAccess.Context;
using Foody.DataAccess.Repositories;
using Foody.Entities.Concrete;

namespace Foody.DataAccess.EntityFramework
{
    public class EfFeatureDal : GenericRepositories<Feature>, IFeatureDal
    {
        public EfFeatureDal(FoodyContext context) : base(context)
        {
        }
    }
    
}