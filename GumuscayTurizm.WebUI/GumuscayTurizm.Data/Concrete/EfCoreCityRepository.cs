﻿using GumuscayTurizm.Data.Abstract;
using GumuscayTurizm.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumuscayTurizm.Data.Concrete
{
    public class EfCoreCityRepository : ICityRepository
    {
        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public Task<List<City>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<City> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<City>> GetCitiesById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
