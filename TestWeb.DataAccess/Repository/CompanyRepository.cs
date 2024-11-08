﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeb.DataAccess.Data;
using TestWeb.DataAccess.Repository.IRepository;
using TestWeb.Models;

namespace TestWeb.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {

        private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}