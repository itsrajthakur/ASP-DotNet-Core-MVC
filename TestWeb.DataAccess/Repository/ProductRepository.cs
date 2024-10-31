using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TestWeb.DataAccess.Repository.IRepository;
using TestWeb.DataAccess.Data;
using TestWeb.DataAccess.Repository;
using TestWeb.Models;

namespace TestWeb.DataAccess.Repository
{
    public class ProductRpository : Repository<Product>, IProductRepository
    {

        private ApplicationDbContext _db;
        public ProductRpository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
