using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ProductManagementSystem.Core.Services;
using ProductManagementSystem.Core.UnitOfWorks;
using ProductManagementSystem.Core.Repositories;


namespace ProductManagementSystem.Core.Services
{
    public interface IGenericService<T> where T : class
    {
        Task<T> GetByIdAsync(int Id);

        Task<IEnumerable<T>> GetAllAsync ();

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

        IQueryable<T> Where (Expression<Func<T, bool>> expression);

        Task<T> AddAsync(T entity);

        Task <IEnumerable<T>>AddRangeAsync(IEnumerable<T> entities);   

        Task UpdateAsync(T entity);

        Task RemoveAsync(T entity);    

        Task RemoveRangeAsync(IEnumerable<T> entities);



    }
}
