using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(string? includeProperties = null);
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null);
        void Add(T entity);
        
        // Update is removed because some models
        // may have unique approach to updating.
        // Same goes to SaveChanges.
        // They will be implemented in other interfaces
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
