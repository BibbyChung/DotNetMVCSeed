using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public ProductService()
        {
            this.provider = new ProductProvider();
        }

        public IList<ProductDto> GetAllProductData()
        {
            return provider.GetAllData();
        }
    }
}
