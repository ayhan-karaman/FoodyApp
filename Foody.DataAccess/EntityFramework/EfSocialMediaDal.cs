
using Foody.DataAccess.Abstract;
using Foody.DataAccess.Context;
using Foody.DataAccess.Repositories;
using Foody.Entities.Concrete;

namespace Foody.DataAccess.EntityFramework
{
    public class EfSocialMediaDal : GenericRepositories<SocialMedia>, ISocialMediaDal
    {
        public EfSocialMediaDal(FoodyContext context) : base(context)
        {
        }
    }
    
}