﻿using Crt.Data.Database.Entities;
using System.Threading.Tasks;

namespace Crt.Data.Database
{
    public interface IUnitOfWork
    {
        bool Commit();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Commit()
        {
            return _dbContext.SaveChanges() >= 0;
        }
    }
}
