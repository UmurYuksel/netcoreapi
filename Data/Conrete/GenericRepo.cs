using MyApi.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Data.Conrete
{
    public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : class
    {
        private readonly ProjectCon _db;

        public GenericRepo(ProjectCon db) => _db = db;

        public virtual IEnumerable<TEntity> GetList() => _db.Set<TEntity>();

        public virtual TEntity Get(string slug) => _db.Set<TEntity>().Find(slug);

        public virtual void Update(TEntity obj)
        {
            _db.Update<TEntity>(obj);
            _db.SaveChanges();
        }

        public virtual void Insert(TEntity obj)
        {
            _db.Add<TEntity>(obj);
            _db.SaveChanges();
        }

    }
}
