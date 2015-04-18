using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Diagnostics;
using MyApp.Core.Interface.Common;

namespace MyApp.Core.Common
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _context;
        public DbContext Context
        {
            get { return _context; }
            set
            {
                _context = value;
                if (AppHelper.IsDebugMode)
                    this._context.Database.Log = a => Debug.WriteLine(a);
            }
        }

        public string ConnectionString
        {
            get { return Context.Database.Connection.ConnectionString; }
            set { Context.Database.Connection.ConnectionString = value; }
        }

        public void Dispose()
        {
            Context.Dispose();
        }

        public virtual void Save()
        {
            CheckBeforeSaveChange();

            try
            {
                Context.SaveChanges();
            }
            catch (DbEntityValidationException ex) { }

        }

        //http://stackoverflow.com/questions/3918128/how-to-auto-update-the-modified-property-on-a-entity-in-entity-framework-4-when
        private void CheckBeforeSaveChange()
        {
            //do something
        }

        private void TrackAndLogChangeData(DateTime now, Guid userId)
        {
            //do something
        }
    }
}
