using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryProject.DITest;
using RepositoryProject.Factory;

namespace RepositoryProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepoFactory repoFactory = new RepoFactory();
            TestClass test = new TestClass(repoFactory);
            test.Run();
            Console.ReadKey();

              
        }
    }
}
