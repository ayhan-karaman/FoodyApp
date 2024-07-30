
using Foody.DataAccess.Abstract;
using Foody.DataAccess.Context;
using Foody.DataAccess.Repositories;
using Foody.Entities.Concrete;

namespace Foody.DataAccess.EntityFramework
{
    public class EfReviewDal : GenericRepositories<Review>, IReviewDal
    {
        public EfReviewDal(FoodyContext context) : base(context)
        {
        }
    }
    
}