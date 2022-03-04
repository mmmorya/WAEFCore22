using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WAEFCore22.AppCode.Connections;
using WAEFCore22.AppCode.Interface.Repos;
using WAEFCore22.Models.DbClassess;

namespace WAEFCore22.AppCode.BusinessLogic.Repos
{
    public class GenericRepository : IGenericRepository
    {
        private readonly AppDbContext _dbContext;

        public GenericRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public async Task<IEnumerable<T>> FindAsync<T>(Expression<Func<T, bool>> expression) where T : class
        {
            try
            {
                return await _dbContext.Set<T>().Where(expression).ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<T> SingleOrDefaultAsync<T>(Expression<Func<T, bool>> expression) where T : class
        {
            return await _dbContext.Set<T>().SingleOrDefaultAsync(expression);
        }

        public void Add<T>(T entity) where T : class
        {
            _dbContext.Set<T>().Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void Delete<T>(T entity) where T : class
        {
            _dbContext.Set<T>().Remove(entity);
        }

        public async Task<IEnumerable<T>> FindAllRecords<T>() where T : class
        {
            
            try
            {
                var result = await Task.FromResult(_dbContext.Set<T>());
                return result.ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<IEnumerable<T>> FindAllRecords1<T>() where T : class
        {
            try
            {
                return await _dbContext.Set<T>().ToListAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
