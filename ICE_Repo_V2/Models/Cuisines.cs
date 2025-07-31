using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Repo_V2.Models
{
    public class Cuisines
    {
        public int CuisineId { get; set; }
        public string CuisineName { get; set; }
        public int CountryId { get; set; } /* Foreign key to Countries table */
        public string Description { get; set; }

    }
}
