using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace difficultySettings
{
    public partial class Form1 : Form
    {
        string heroName;
        string difficultyLevel;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            heroName = nameInput.Text; 
            difficultyLevel = "Easy";

            easyButton.BackColor = Color.Green;
            mediumButton.BackColor = Color.White;
            hardButton.BackColor = Color.White;

        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            heroName = nameInput.Text;
            difficultyLevel = "Medium";

            mediumButton.BackColor = Color.Yellow;
            easyButton.BackColor = Color.White;
            hardButton.BackColor = Color.White;

        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            heroName = nameInput.Text;
            difficultyLevel = "Hard";

            hardButton.BackColor = Color.Red;
            easyButton.BackColor = Color.White;
            mediumButton.BackColor = Color.White;
        }

        private void beginButton_Click(object sender, EventArgs e)
        {

            nameOutput.Text = $"Welcome {heroName}!";
            messageOutput.Text = $" A true brave hero! Go forth and conquer the {difficultyLevel} path!";

        }

        private void nameInput_Load(object sender, EventArgs e)
        {

        }

        private void nameOutput_Click(object sender, EventArgs e)
        {

        }
    }
}
