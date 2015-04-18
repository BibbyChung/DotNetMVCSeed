using System.Collections.Generic;
using MyApp.Models.DTO;

namespace MyApp.Interface.Services
{
    public interface IProductService
    {
        IList<ProductDto> GetAllProductData();
    }
}