
using Foody.Business.Abstract;
using Foody.DataAccess.Abstract;
using Foody.Entities.Concrete;
using System.Linq;
namespace Foody.Business.Concrete
{
    public class CategoryManger : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManger(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(int id)
        {
            _categoryDal.Delete(id);
        }

        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll().OrderBy(x => x.Id).ToList();
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void TInsert(Category entity)
        {
            _categoryDal.Insert(entity);
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}