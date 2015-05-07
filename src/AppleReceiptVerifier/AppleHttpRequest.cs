using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AppleReceiptVerifier.Interfaces;
using System.Net.Http;

namespace AppleReceiptVerifier
{
    /// <summary>
    /// Apple Http Request
    /// </summary>
    internal class AppleHttpRequest : IAppleHttpRequest
    {
        /// <summary>
        /// Gets the response.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="postData">The data to be posted.</param>
        /// <returns>
        /// response as string
        /// </returns>
        public async Task<string> GetResponseAsync(Uri url, string postData)
        {
            var client = new HttpClient();
            var response = await client.PostAsync(url, new StringContent(postData));
            return await response.Content.ReadAsStringAsync();
        }
    }
}
