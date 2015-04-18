using System;
using System.Collections.Generic;
using MyApp.Common;
using MyApp.Interface.Services.Providers;
using MyApp.Models.Entities;
using System.Linq;
using MyApp.Models.DTO;

namespace MyApp.Services.Providers
{
    public class ProductProvider : IProductProvider
    {
        public IList<ProductDto> GetAllData()
        {
            var db = new UnitOfWork();

            return db.NorthwindContent.Products.Select(a => new
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