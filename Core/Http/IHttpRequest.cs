using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroGear.Mobile.Core.Http
{
    public static class Constants
    {
        const String CONTENT_TYPE_HEADER = "Content-Type";
        const String JSON_MIME_TYPE = "application/json";
    }

    /// <summary>
    /// Interface for requests to HTTP services.
    /// </summary>
    interface IHttpRequest
    {
        /// <summary>
        /// Adds HTTP header to the request
        /// </summary>
        /// <param name="key">HTTP header name</param>
        /// <param name="value">HTTP header value</param>
        /// <returns>request itself</returns>
        IHttpRequest AddHeader(string key, string value);
        

    }

    /// <summary>
    /// Interface for request to be executed.
    /// </summary>
    interface IHttpRequestToBeExecuted
    {
        
    }
}
