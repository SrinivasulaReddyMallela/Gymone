using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gymone.Web.Models;

namespace Gymone.Web.Common
{
    public class GridModel<T> : List<T>
    {
        public PaginatedBaseData paginatedBaseData { get; set; }
        public PaginatedList<T> paginatedlist { get; set; }
    }
}
