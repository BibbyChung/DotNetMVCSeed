using System;
using System.Collections.Generic;
using MyApp.Common;
using MyApp.Interface.Services.Providers;
using MyApp.Models.Entities;
using System.Linq;
using MyApp.Interface.Common;
using MyApp.Models.DTO;

namespace MyApp.Services.Providers
{
    public class ProductProvider : IProductProvider
    {
        private IUnitOfWork db;
        public ProductProvider(IUnitOfWork db)
        {
            this.db = db;
        }

        public IList<ProductDto> GetAllData()
        {
            return db.GetMyAppContext<Northwind>().Products.Select(a => new
            {
                a.ProductName,
                a.UnitPrice,
                a.Order_Details.Count
            })
            .ToList()
            .Select(a => new ProductDto()
            {
                ProductName = a.ProductName,
                UnitPrice = a.UnitPrice,
                Count = a.Count
            }).ToList()
            ;

        }
    }
}