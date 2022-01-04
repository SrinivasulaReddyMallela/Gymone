using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymone.Web.Models
{
    public class PaginatedBaseData
    {
        public string sortOrder { get; set; }
        public string currentFilter { get; set; }
        public string searchString { get; set; }
        public int? pageNumber { get; set; }

    }
}
