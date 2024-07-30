
using Foody.DataAccess.Abstract;
using Foody.DataAccess.Context;
using Foody.DataAccess.Repositories;
using Foody.Entities.Concrete;

namespace Foody.DataAccess.EntityFramework
{
    public class EfSliderDal : GenericRepositories<Slider>, ISliderDal
    {
        public EfSliderDal(FoodyContext context) : base(context)
        {
        }
    }
    
}