﻿using Microsoft.EntityFrameworkCore;
using MVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVC.Repo
{
    public class Repository<T> : IRepository<T> where T : Category
    {

        private readonly ApplicationDbContext _db;
        private DbSet<T> entities;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetById(long id)
        {
            return entities.SingleOrDefault(s => s.Id == id);
        }

        public void Insert(T entity)
        {
           if(entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entities.Add(entity);
            _db.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            
            _db.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entities.Remove(entity);
            _db.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entities.Remove(entity);
        }

        public void SaveChanges()
        {
            _db.SaveChanges();
        } 
    }
}