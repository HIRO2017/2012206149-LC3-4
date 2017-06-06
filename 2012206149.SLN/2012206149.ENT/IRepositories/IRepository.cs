using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2012206149.ENT.IRepositories
{
    public interface IRepository <TEntity> where TEntity : class
    {

        //creates
        //registro
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);


        //reads

        TEntity Get(int Id);
        IEnumerable<TEntity> GetAll();
        IEnumerator<TEntity> Find(Expression<Func<TEntity, bool>> predicate);


        //updates

        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);



        //delete

        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);
    }
}
