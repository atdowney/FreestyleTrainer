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
        public FreestyleTrainer()
        {
            InitializeComponent();

            _NewWordBtn.Click += _NewWordBtn_Click;

            _NewRhymeBtn.Click += _NewRhymeBtn_Click;


        }

        private async void _NewRhymeBtn_Click(object sender, EventArgs e)
        {
            string word = _WordTbx.Text; //Get the word from the text box

            List<string> rhymingWords = new List<string>();

            rhymingWords = await GetRhymingWords(word);

            DisplayRhymingWords(rhymingWords);
        }

        private async void _NewWordBtn_Click(object sender, EventArgs e)
        {

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
                _RhymesListbx.Items.Add(rhyme);

                if (_RhymesListbx.Items.Count > _RhymesAmount.Value - 1)
                {
                    break;
                }
            }


        }
    }
}
