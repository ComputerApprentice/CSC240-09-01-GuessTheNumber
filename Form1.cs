using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240GuessTheNumber
{
    public partial class Form1 : Form
    {

        Random randomNumber = new Random();

        int number = 0;
        int guesses = 0;

        public Form1()
        {
            InitializeComponent();

            loadQuestions();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtEnterNumber.Text);

            guesses += 1;
            lblGuesses.Text = "You guessed " + guesses + " times ";

            if (i == number)
            {
                MessageBox.Show("Correct!");
                loadQuestions();
                txtEnterNumber.Text = "";
                guesses = 0;
            }
            else if (i < number)
            {
                MessageBox.Show("Go Higher");
            }
            else
            {
                MessageBox.Show("Go Lower");
            }
        }

        private void loadQuestions()
        {
            number = randomNumber.Next(0, 100);

            lblWhatnumber.Text = "What's the Number?";
        }
    }
}