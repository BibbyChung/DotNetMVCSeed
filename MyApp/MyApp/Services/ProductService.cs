using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.Interface.Services.Providers;
using MyApp.Models.Entities;
using MyApp.Services.Providers;

namespace MyApp.Services
{
    public class ProductService
    {
        public IList<Products> GetAllProductData()
        {
            IProductProvider p = new ProductProvider();
            return p.GetAllData();
        }
    }
}
