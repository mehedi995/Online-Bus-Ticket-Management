﻿using BTMEntity;
using BTMRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMService
{
    public abstract class Service<TEntity> : IService<TEntity> where TEntity : Entity
    {
        IRepository<TEntity> repo = new Repository<TEntity>();

        public List<TEntity> GetAll()
        {
            return repo.GetAll();
        }

        public TEntity Get(int id)
        {
            return repo.Get(id);
        }

        public int Insert(TEntity entity)
        {
            return repo.Insert(entity);
        }

        public int Update(TEntity entity)
        {
            return repo.Update(entity);
        }

        public int Delete(TEntity entity)
        {
            return repo.Delete(entity);
        }
    }
}
