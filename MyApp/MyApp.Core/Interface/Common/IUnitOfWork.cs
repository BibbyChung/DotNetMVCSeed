using System.Data.Entity;

namespace MyApp.Core.Interface.Common
{
    public interface IUnitOfWork
    {
        DbContext Context { get; set; }
        string ConnectionString { get; set; }
        void Dispose();
        void Save();
    }
}