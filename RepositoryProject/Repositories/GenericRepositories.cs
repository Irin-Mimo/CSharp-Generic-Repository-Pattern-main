using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryProject.Models;

namespace RepositoryProject.Repositories
{
    public class GenericRepositories<T> : IRepositories<T> where T : CommonAttributes
    {
        private readonly IList<T> data;
        public GenericRepositories()
        {
            this.data = new List<T>();
        }
        public void Add(T entity)
        {
            this.data.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                this.data.Add(entity);

            }
        }

        public void Delete(int id)
        {
            var entity = this.data.FirstOrDefault(x => x.Id == id);
            if(entity!=null)
            {
                this.data.Remove(entity);
            }
        }

        public T Get(int id)
        {
            return this.data.FirstOrDefault(x => x.Id == id);
        }

        public List<T> GetALl()
        {
            return this.data.ToList();
        }

        public void Update(T entity)
        {
            int u = this.data.IndexOf(entity);
            this.data.RemoveAt(u);
            this.data.Add(entity);
        }
    }
}
