using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WAEFCore22.AppCode.Interface.Repos
{
    public interface IGenericRepository
    {
        Task<IEnumerable<T>> FindAsync<T>(Expression<Func<T, bool>> expression) where T : class;
        Task<T> SingleOrDefaultAsync<T>(Expression<Func<T, bool>> expression) where T : class;
        Task<IEnumerable<T>> FindAllRecords<T>() where T : class;
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
    }
}
