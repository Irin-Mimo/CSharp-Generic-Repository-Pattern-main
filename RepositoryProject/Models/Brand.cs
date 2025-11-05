using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryProject.Models
{
    public class Brand:CommonAttributes
    {
        public string CountryOfOrigin { get; set; }
        public int EstablishYear { get; set; }
        public string ParentCompany { get; set; }
        public int GlobalRanking { get; set; }
    }
}
