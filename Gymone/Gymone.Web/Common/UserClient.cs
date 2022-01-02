using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gymone.Web.Common
{
    public partial class ApiClient
    {
        public async Task<T> ReturnQueryStringValues<T>(string ApiQueryString)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture,ApiQueryString));
            return await GetAsync<T>(requestUrl);
        }

        public async Task<string> ReturnQueryStringValues(string ApiQueryString)
        {
            var requestUrl = CreateRequestUri(string.Format(System.Globalization.CultureInfo.InvariantCulture, ApiQueryString));
            return await GetAsync(requestUrl);
        }
    }
}
