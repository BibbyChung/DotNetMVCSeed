using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using MyApp.Models.Entities;

namespace MyApp.Interface.Common
{
    public interface IUnitOfWork
    {
        string ConnectionString { get; set; }
        T GetMyAppContext<T>() where T : DbContext;
        void Dispose();
        void Save();
    }
}