using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.Core
{
    public interface IUnitOfWork
    {
        void Save();
        void Dispose(bool disposing);
        void Dispose();
    }
}
