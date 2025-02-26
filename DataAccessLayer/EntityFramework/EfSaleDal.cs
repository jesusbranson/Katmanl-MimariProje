﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfSaleDal : GenericRepository<Sale>, ISaleDal
    {
        public List<Sale> GetSaleListWithProductCustomer()
        {
            using (var c = new Context())
            {
                return c.Sales.Include(x => x.Customer).Include(x => x.Product).ToList();
            }
        }
    }
}
