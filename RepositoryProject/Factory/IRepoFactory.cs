using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryProject.Models;
using RepositoryProject.Repositories;

namespace RepositoryProject.Factory
{
    public interface IRepoFactory
    {
        IRepositories<T> CreateRepo<T>() where T : CommonAttributes;
    }
}
