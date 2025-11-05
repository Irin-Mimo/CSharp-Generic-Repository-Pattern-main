using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryProject.Models;

namespace RepositoryProject.Repositories
{
    public interface IRepositories<T> where T:CommonAttributes
    {
        List<T> GetALl();
        T Get(int id);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Update(T entity);
        void Delete(int Id);
    }
}
