using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Concurrency.Data.UnitsOfWork
{
    public interface IDatabaseTransaction : IDisposable
    {
        void Commit();

        void Rollback();
    }

}
