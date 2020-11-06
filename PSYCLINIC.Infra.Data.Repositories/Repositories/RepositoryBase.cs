using Microsoft.EntityFrameworkCore;
using PSYCLINIC.Domain.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PSYCLINIC.Infra.Data.Repositories.Repositories {
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>, IDisposable where TEntity : class {
        private readonly SqlContext sqlContext;
        public RepositoryBase(SqlContext sqlContext) {
            this.sqlContext = sqlContext;
        }
        public virtual void Add(TEntity obj) {
            try {
                sqlContext.Set<TEntity>().Add(obj);
                sqlContext.SaveChanges();
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public virtual TEntity GetById(int id) {
            return sqlContext.Set<TEntity>().Find(id);
        }
        public virtual IEnumerable<TEntity> GetAll() {
            return sqlContext.Set<TEntity>().ToList();
        }
        public virtual void Update(TEntity obj) {
            try {
                sqlContext.Entry(obj).State = EntityState.Modified;
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public virtual void Remove(TEntity obj) {
            try {
                sqlContext.Set<TEntity>().Remove(obj);
                sqlContext.SaveChanges();
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        public virtual void Dispose() {
            sqlContext.Dispose();
        }
    }
}
