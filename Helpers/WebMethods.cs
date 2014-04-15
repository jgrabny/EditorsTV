using System.IO;
using System.Net;

namespace Helpers
{
    /// <summary>
    /// Helper class for invoking the web methods.
    /// </summary>
    public class WebMethods
    {
        /// <summary>
        /// Invokes the HTTP GET method on given uri.
        /// </summary>
        /// <param name="uri">The uri on which the GET should be invoked.</param>
        /// <returns>Response for the HTTP GET method.</returns>
        public static string HttpGet(string uri)
        {
            string response = null;

            using (var webClient = new WebClient())
            {
                try
                {
                    // open and read from the supplied URI
                    var stream = webClient.OpenRead(uri);

                    if (stream != null)
                    {
                        var reader = new StreamReader(stream);
                        response = reader.ReadToEnd();
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
                catch (WebException ex)
                {
                    if (ex.Response is HttpWebResponse)
                    {
                        // Very simple error handling
                        switch (((HttpWebResponse)ex.Response).StatusCode)
                        {
                            case HttpStatusCode.NotFound:
                            case HttpStatusCode.Unauthorized:
                                response = null;
                                break;

                            default:
                                throw;
                        }
                    }
                }
            }

            return response;
        }
    }
}
