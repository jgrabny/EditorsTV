using System.Text;

using Helpers;

using HtmlAgilityPack;

namespace BashQuotesGenerator
{
    /// <summary>
    /// Class responsible for generating page with bash quotes.
    /// </summary>
    public class Generator
    {
        /// <summary>
        /// Generates page with new bash quote.
        /// </summary>
        public void Run()
        {
            // Invoke the HTTP GET method on random bash page.
            string result = WebMethods.HttpGet("http://bash.org.pl/random/");

            // Create new HTML doc with GET response.
            var joke = new HtmlDocument();
            joke.LoadHtml(result);

            // Extract the bash quote from the generated document.
            var node = joke.DocumentNode.SelectSingleNode("//div[@class='quote post-content post-body']");

            // Create new HTML doc usinge base.html template.
            var jokePage = new HtmlDocument();
            jokePage.Load("base.html");

            // Append the extracted bash quote to the element with 'bash' id.
            jokePage.GetElementbyId("bash").AppendChild(node);

            // Save the generated HTML doc.
            jokePage.Save("bashQuotes.html", Encoding.UTF8);
        }
    }
}
