﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymone.Web.Common
{
    public class QueryStringModule
    {

        private const string PARAMETER_NAME = "Data";
        private const string ENCRYPTION_KEY = "key";
        private static ASCIIEncoding encoding;
        private static IHttpContextAccessor _httpContextAccessor;
        private readonly IDataProtector _protector;
        private readonly RequestDelegate _next;
        public QueryStringModule(IHttpContextAccessor httpContextAccessor, IDataProtectionProvider provider, RequestDelegate next)
        {
            encoding = new ASCIIEncoding();
            _httpContextAccessor = httpContextAccessor;
            _protector = provider.CreateProtector("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+");
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            List<string> ignoreEntenstions = new List<string>() { ".css", ".js", ".htm", ".html" };
            //if (!ignoreEntenstions.Contains("."+context.Request.Path.Value.Split(".").LastOrDefault()))
            //{
            if (UriHelper.GetEncodedUrl(context.Request).Contains("?"))
            {
                string contextQuery = GetAbsoluteUri().Query.ToString();
                //
                if (contextQuery.Contains(PARAMETER_NAME))
                {
                    var enc = context.Request.Query[PARAMETER_NAME];
                    enc = _protector.Unprotect(enc);
                    QueryString queryString = new QueryString(enc);
                    context.Request.QueryString = queryString;
                }
                else if (context.Request.Method == "GET")
                {
                    if (contextQuery != "")
                    {
                        string encryptedQuery = _protector.Protect(contextQuery);
                        string redirectToPagePath = context.Request.Path.Value + "?" + PARAMETER_NAME + "=" + encryptedQuery;
                        context.Response.Redirect(redirectToPagePath);
                    }
                }
            }
            await _next.Invoke(context);
            //}

        }
        #region Utils
        private static Uri GetAbsoluteUri()
        {
            var request = _httpContextAccessor.HttpContext.Request;
            UriBuilder uriBuilder = new UriBuilder();
            uriBuilder.Scheme = request.Scheme;
            uriBuilder.Host = request.Host.Host;
            uriBuilder.Path = request.Path.ToString();
            uriBuilder.Query = request.QueryString.ToString();
            return uriBuilder.Uri;
        }

        #endregion
    }

    public static class QueryStringMiddlewareExtensions
    {
        public static IApplicationBuilder UseEncryptDecryptQueryStringsMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<QueryStringModule>();
        }
    }
}
