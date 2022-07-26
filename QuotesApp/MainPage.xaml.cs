using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuotesApp
{
    public partial class MainPage : ContentPage
    {
        private readonly string[] quotes = {"A journey of a thousand miles ends with \"I FORGOT MY ___________\"",
            "RUSSIA RUSSIA RUSSIA", "My dog ate my homework", "I don't want my sandwich to be tested!",
            "Out of the four of us, most know how to cook. That means one of us does not and it's not me.",
        "To be or not to be. That's the bare bodkin."};

        public MainPage()
        {
            InitializeComponent();
        }

        void OnQuoteButtonClicked(object sender, EventArgs args)
        {
            var rand = new Random();
            int num = rand.Next(quotes.Length);
            quote.Text = quotes[num];
        }
    }
}
