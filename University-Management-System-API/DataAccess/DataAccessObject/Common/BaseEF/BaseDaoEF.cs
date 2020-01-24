﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Management_System_API.DataAccess.DataAccessObject.Common
{
    public abstract class BaseDaoEF<TEntity, TPK> : IBaseDao<TEntity,TPK>
        where TEntity : Persistent
    {
        protected readonly UniversityManagementSystemContext _dbContext;

        public BaseDaoEF(UniversityManagementSystemContext dbContext)
        {
            this._dbContext = dbContext;
        }

        /// <summary>
        /// Function to delete an entity from the database by id .
        /// </summary>
        /// <param name="id">entity's id</param>
        public void Delete(TPK id)
        {
            TEntity entity = _dbContext.Set<TEntity>().Find(id);

            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Function to delete an entity from the database by entity .
        /// </summary>
        /// <param name="entity">entity</param>
        public void Delete(TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);

            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Function to delete entities from the database by list from the id .
        /// </summary>
        /// <param name="idList">list of id</param>
        public void Delete(List<TPK> idList)
        {
            idList.ForEach(e => Delete(e));
        }

        /// <summary>
        /// Function to find entities from the database by list from the entities .
        /// </summary>
        /// <returns>List of entities found</returns>
        public List<TEntity> Find()
        {
            return _dbContext.Set<TEntity>()
                .ToList();
        }

        /// <summary>
        /// Function to find an entity from the database by id .
        /// </summary>
        /// <param name="id">entity's id</param>
        /// <returns>The entity found</returns>
        public TEntity Find(TPK id)
        {
            return _dbContext.Set<TEntity>()
                .Find(id);
        }

        /// <summary>
        /// Function to find entities from the database by field .
        /// </summary>
        /// <param name="field">The name of the field</param>
        /// <param name="value">field value</param>
        /// <returns>List of entities found</returns>
        public List<TEntity> Find(string field, string value)
        {
            TEntity entity = _dbContext.Set<TEntity>().SingleOrDefault();

            foreach (var item in entity.GetType().GetProperties())
            {
                if (item.Name.Equals(field, StringComparison.OrdinalIgnoreCase))
                {
                    field = item.Name;
                }
            }

            return _dbContext.Set<TEntity>()
                .ToList()
                .Where(entity =>
                     entity.GetType().GetProperty(field)
                    .GetValue(entity, null)
                    .ToString()
                    .Equals(value))
                    .ToList();
        }

        /// <summary>
        /// Function to find an entity from the database by field name .
        /// </summary>
        /// <param name="name">The entity name field</param>
        /// <returns>The entity found</returns>
        public TEntity FindByName(string name)
        {
            return _dbContext.Set<TEntity>()
                .Find(name);
        }

        /// <summary>
        /// Function to find an entity from the database by field code .
        /// </summary>
        /// <param name="code">The entity code field</param>
        /// <returns>The entity found</returns>
        public TEntity FindByCode(string code)
        {
            return _dbContext.Set<TEntity>()
                .Find(code);
        }

        /// <summary>
        /// Function to save the new entity to the database .
        /// </summary>
        /// <param name="entity">an entity</param>
        /// <returns>The saved entity</returns>
        public TEntity Save(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);

            _dbContext.SaveChanges();

            return entity;
        }

        /// <summary>
        /// Function to save the new list of entities to the database .
        /// </summary>
        /// <param name="entity">List of entities</param>
        /// <returns>The saved list of entities</returns>
        public List<TEntity> Save(List<TEntity> entity)
        {
            entity.ForEach(e => _dbContext.Set<TEntity>().Add(e));

            _dbContext.SaveChanges();

            return entity;
        }

        /// <summary>
        /// Function to update entity to the database .
        /// </summary>
        /// <param name="entity">an entity</param>
        /// <returns>The updated entity</returns>
        public TEntity Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;

            _dbContext.SaveChanges();

            return entity;
        }

        /// <summary>
        /// Function to update list of entitie to the database .
        /// </summary>
        /// <param name="entity">List of entities</param>
        /// <returns>The updated list of entities</returns>
        public List<TEntity> Update(List<TEntity> entity)
        {
            entity.ForEach(e => Update(e));

            return entity;
        }
    }
}