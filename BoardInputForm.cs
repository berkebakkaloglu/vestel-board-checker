using System;
using System.Windows.Forms;

namespace SimpleDrawer
{
    public partial class BoardInputForm : Form
    {
        OutputForm outputForm;

        public BoardInputForm()
        {
            InitializeComponent();
        }

        private void moveToOutputButton_Click(object sender, EventArgs e)
        {
            if (!widthInputBox.Text.Equals("") && !heightInputBox.Text.Equals(""))
            {
                Hide();

                int boardWidth = Int32.Parse(widthInputBox.Text);
                int boardHeight = Int32.Parse(heightInputBox.Text);

                outputForm = new OutputForm(boardWidth, boardHeight);
                outputForm.Show();
            }
        }

        private void BoardInputForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
