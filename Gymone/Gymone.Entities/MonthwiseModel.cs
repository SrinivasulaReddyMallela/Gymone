using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;

namespace Gymone.Entities
{
    public class MonthwiseModel
    {
        public string MonthID { get; set; }
        public IEnumerable<SelectListItem> MonthNameList { get; set; }
    }
}
