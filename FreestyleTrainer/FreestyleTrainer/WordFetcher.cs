//**********************************************************************************
//Program: Freestyle Trainer
//Class: WordFetcher
//Description:      Used to fetch the desired words rhymes. Also to generate a list from JSON resource.
//
//Date Started: May 17 2024
//Last Updated: May 17 2024
//Author: Alex Downey
//**********************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Newtonsoft.Json;

namespace FreestyleTrainer
{
    internal class WordFetcher
    {
        //Used for when deserializing the JSON data 
        public class WordsContainer
        {
            public List<string> Words { get; set; }
        }

        private Random random = new Random();
        private static readonly HttpClient client = new HttpClient();

        /// <summary>
        /// Async method to get all of the rhyming words from b-rhymes website
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Generates a list of strings that is words from a JSON file
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetWordsFromJson()
        {
            List<string> words = new List<string>();

            try
            {
                // Read the JSON content from the resources
                string jsonContent = Properties.Resources.words;

                // Deserialize the JSON content into a WordsContainer object
                WordsContainer wordsContainer = JsonConvert.DeserializeObject<WordsContainer>(jsonContent);

                if (wordsContainer != null && wordsContainer.Words != null)
                {
                    words = wordsContainer.Words;
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine($"Error reading words from JSON: {ex.Message}");
            }

            // Shuffle the list of words
            Shuffle(words);

            foreach (string word in words)
            {
                yield return word;
            }
        }

        /// <summary>
        /// Used to shuffle the list of words
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        private void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}

