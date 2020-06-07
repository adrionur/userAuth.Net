using LoginApp.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Core
{
    public class UnitOfWork<T> : IDisposable, IUnitOfWork where T: class
    {
        private AppContext context = new AppContext();
        private RepositoryService<T> repo;
        public RepositoryService<T> Repo
        {
            get
            {
                return this.repo ?? new RepositoryService<T>(context);
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
