using System;
using System.Windows.Forms;

namespace ConsoleGame
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            Game game = new Game(this);
        }

        private void consoleKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(consoleTextBox.Text))
            {
                //handleCommand();
                Console.WriteLine(consoleTextBox.Text);
            }
        }
    }
}
