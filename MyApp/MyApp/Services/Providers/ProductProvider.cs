using System;
using System.Collections.Generic;
using MyApp.Common;
using MyApp.Interface.Services.Providers;
using MyApp.Models.Entities;
using System.Linq;

namespace MyApp.Services.Providers
{
    public class ProductProvider : IProductProvider
    {
        public IList<Products> GetAllData()
        {
            var db = new UnitOfWork();
            return db.NorthwindContent.Products.ToList();
        }
    }
}