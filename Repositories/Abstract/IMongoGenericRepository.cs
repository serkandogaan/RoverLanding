using Rover.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Abstract
{
    public interface IMongoGenericRepository<T> where T : BaseClass
    {
        List<T> GetAll(); 

        List<T> GetbyWhere(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(string id);
        T GetByName(string name);

        T GetByID(int id);

        //string GetRoverNamebyID(int id);
        //string GetRoverAreaNamebyID(int id);
        //T GetById(string id);
    }
}
