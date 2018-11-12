using Sample.Concurrency.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Concurrency.Data.UnitsOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        //ProductsRepository Products { get; }

        void Update<T>(T entity) where T : BaseEntity;

        int Save();
        Task<int> SaveAsync();

        IDatabaseTransaction BeginTransaction { get; }
    }

}
