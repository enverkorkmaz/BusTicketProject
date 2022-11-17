﻿using GumuscayTurizm.Data.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Data.Concrete
{
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _dbContext;
        public EfCoreGenericRepository(DbContext dBContext)
        {
            _dbContext = dBContext;
        }
        

      

        public async Task CreateAsync(TEntity entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbContext
                .Set<TEntity>()
                .ToListAsync();
        }

        public Task<TEntity> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
