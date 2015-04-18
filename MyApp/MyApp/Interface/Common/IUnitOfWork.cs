using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using MyApp.Models.Entities;

namespace MyApp.Interface.Common
{
    public interface IUnitOfWork
    {
        Northwind NorthwindContent { get; }
        DbContext Context { get; set; }
        string ConnectionString { get; set; }
        void Dispose();
        void Save();
    }
}