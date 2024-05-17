using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace FreestyleTrainer
{
    internal class WordFetcher
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<List<string>> GetRhymingWordsAsync(string word)
        {
            List<string> rhymingWords = new List<string>();

            try
            {
                // Fetch the HTML content
                string url = $"http://www.b-rhymes.com/rhyme/word/{word}";
                var response = await client.GetStringAsync(url);

                //Console.WriteLine($"Response = {response}");

                // Load the HTML content into HtmlAgilityPack
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(response);



                // Parse the document to find the rhyming words
                var nodes = doc.DocumentNode.SelectNodes("//td[@class='word']/a");

                Console.WriteLine($"Nodes = {nodes}");

                if (nodes != null)
                {
                    foreach (var node in nodes)
                    {
                        string rhymingWord = node.InnerText.Trim();
                        rhymingWords.Add(rhymingWord);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine($"Error fetching rhyming words: {ex.Message}");
            }

            return rhymingWords;
        }
    }
}
