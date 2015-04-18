using System.Collections.Generic;
using MyApp.Models.Entities;

namespace MyApp.Interface.Services.Providers
{
    public interface IProductProvider
    {
        IList<Products> GetAllData();
    }
}