using ChuckNorrisAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorrisForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Get_Categories();
        }

        private void BtnJoke_Click(object sender, EventArgs e)
        {
            Get_Joke();
        }
        private async void Get_Joke()
        {
            Joke j = await ChuckNorrisClient.GetRandomJoke();
            RtbJoke.Text = j.JokeText;
        }

        private async void Get_Categories()
        {
            IEnumerable<string> categories = await ChuckNorrisClient.GetCategories();
            foreach (var cat in categories)
            {
                CmbCategories.Items.Add(cat);
            }
        }
    }
}
