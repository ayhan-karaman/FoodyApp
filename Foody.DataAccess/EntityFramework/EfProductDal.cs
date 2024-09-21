
using System.IO.Compression;
using Foody.DataAccess.Abstract;
using Foody.DataAccess.Context;
using Foody.DataAccess.Repositories;
using Foody.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Foody.DataAccess.EntityFramework
{
    public class EfProductDal : GenericRepositories<Product>, IProductDal
    {
        private readonly FoodyContext _context;
        public EfProductDal(FoodyContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> ProductLisWithCategory()
        {
            var values = _context.Products.Include(x => x.Category).ToList();
            return values;
        }
    }
    
}