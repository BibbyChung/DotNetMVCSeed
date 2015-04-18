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
        public IList<ProductDto> GetAllProductData()
        {
            var provider = AppHelper.CastleWindsorContainer.Resolve<IProductProvider>();
            return provider.GetAllData();
        }
    }
}
