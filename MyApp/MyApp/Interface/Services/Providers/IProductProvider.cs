using System.Collections.Generic;
using MyApp.Models.DTO;
using MyApp.Models.Entities;
using MyApp.Services.Providers;

namespace MyApp.Interface.Services.Providers
{
    public interface IProductProvider
    {
        IList<ProductDto> GetAllData();
    }
}