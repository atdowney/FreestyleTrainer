using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace FreestyleTrainer
{
    public partial class FreestyleTrainer : Form
    {
        private HashSet<string> usedRhymes = new HashSet<string>(); //Used to track all used rhyming words

        public FreestyleTrainer()
        {
            InitializeComponent();

            _NewWordBtn.Click += _NewWordBtn_Click;
            _NewRhymeBtn.Click += _NewRhymeBtn_Click;

        }

        private async void _NewRhymeBtn_Click(object sender, EventArgs e)
        {
            
            string word = _WordTbx.Text; //Get the word from the text box

            List<string> rhymingWords = await GetRhymingWords(word); //Get all words that rhyme

            //User has requested as many rhymes as are available 
            if(usedRhymes.Count == rhymingWords.Count)
            {
                MessageBox.Show("No more rhymes, please try new word");
            }

            //Show the user the rhyming words
            DisplayRhymingWords(rhymingWords);
        }

        private async void _NewWordBtn_Click(object sender, EventArgs e)
        {
            usedRhymes.Clear();
            _RhymesListbx.Items.Clear();

        }

        private async Task<List<string>> GetRhymingWords(string word)
        {
            WordFetcher wordFetcher = new WordFetcher();

            return await wordFetcher.GetRhymingWordsAsync(word);
        }

        private void DisplayRhymingWords(List<string> rhymingWords)
        {
            _RhymesListbx.Items.Clear();


            foreach (string rhyme in rhymingWords)
            {
                if(!usedRhymes.Contains(rhyme))
                {
                    _RhymesListbx.Items.Add(rhyme);
                    usedRhymes.Add(rhyme);

                    if (_RhymesListbx.Items.Count >= _RhymesAmount.Value)
                    {
                        break;
                    }

                }
                
            }


        }
    }
}
