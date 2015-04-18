using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Common;
using MyApp.Interface.Services;
using MyApp.Interface.Services.Providers;
using MyApp.Models.DTO;
using MyApp.Models.Entities;
using MyApp.Services.Providers;

namespace MyApp.Services
{
    public class ProductService : IProductService
    {
        private IProductProvider provider;
        public ProductService(IProductProvider provider)
        {
            this.provider = provider;
        }

        public IList<ProductDto> GetAllProductData()
        {

            return provider.GetAllData();
        }
    }
}
