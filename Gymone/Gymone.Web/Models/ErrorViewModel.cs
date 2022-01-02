using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymone.Web.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

        public string ErrorMessage { get; set; }
    }
}
