using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApi.Data.Abstract
{
    public interface IGenericRepo<TEntity> where TEntity: class
    {
       IEnumerable<TEntity> GetList();
       TEntity Get(string slug);
       void Update(TEntity obj);
       void Insert(TEntity obj);
    }
}
