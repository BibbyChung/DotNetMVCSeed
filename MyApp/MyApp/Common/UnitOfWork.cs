using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using MyApp.Interface.Common;
using MyApp.Models.Entities;

namespace MyApp.Common
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private DbContext _context;

        public UnitOfWork(DbContext context)
        {
            this._context = context;
            if (AppHelper.IsDebugMode)
                this._context.Database.Log = a => Debug.WriteLine(a);
        }

        public T GetMyAppContext<T>() where T : DbContext
        {
            return this._context as T;
        }

        public string ConnectionString
        {
            get { return _context.Database.Connection.ConnectionString; }
            set { _context.Database.Connection.ConnectionString = value; }
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public virtual void Save()
        {
            CheckBeforeSaveChange();

            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException ex) { }

        }

        //http://stackoverflow.com/questions/3918128/how-to-auto-update-the-modified-property-on-a-entity-in-entity-framework-4-when
        private void CheckBeforeSaveChange()
        {
            //do something
        }
    }
}
