using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Board;
namespace WinGame15
{
    public partial class FormGame : Form
    {

        const int size = 4;
        Game game;
        Dialogs.WinDialog windialog;
        Dialogs.LeaderboardDialog leaderboard;


        public FormGame()
        {

            InitializeComponent();
            game = new Game(size);
            HideBtn();

        }

        private void Btn00_Click(object sender, EventArgs e)
        {

            if (game.Solved()) return;
            Button button = (Button)sender;                   //Btn00
            int x = int.Parse(button.Name.Substring(3, 1));
            int y = int.Parse(button.Name.Substring(4, 1));
            game.PressAt(x, y);
            ShowBtn();
            if (game.Solved())
            {

                timer1.Enabled = false;
                string Finish = "Game finished in " + game.CurentInfo.Moves 
                    + " moves |" + game.GetTime(game.CurentInfo.Time) + "| time";
                windialog = new Dialogs.WinDialog(Finish);
                windialog.ShowDialog();
                textBox1.Visible = true;
                label1.Visible = true;
                game.Info.Add(game.CurentInfo);
                game.SaveInfo();
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                MessageBox.Show("Name box is empty", "ERROR",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            game.CurentInfo = new RowInfo(textBox1.Text, 0, 0);
            textBox1.Visible = false;
            label1.Visible = false;

            if (timer1.Enabled == false)
                timer1.Enabled = true;
            game.Start(10);
            //game.Start(1000 + DateTime.Now.DayOfYear);
            ShowBtn();

        }
        void HideBtn()
        {
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    ShowDigitAt(0, x, y);
            LbMoves.Text = "Welcome to Game 15";
        }
        void ShowBtn()
        {
            for (int x = 0; x < size; x++)
                for (int y = 0; y < size; y++)
                    ShowDigitAt(game.GetDigitAt(x, y), x, y);
            LbMoves.Text = game.CurentInfo.Moves + " moves";
        }
        void ShowDigitAt(int digit, int x, int y)
        {
            Button button = (Button)Controls["Btn" + x + y];
            button.Text = digit.ToString();
            button.Visible = digit > 0;
        }

        private void BtnLeaderboard_Click(object sender, EventArgs e)
        {

        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            leaderboard = new Dialogs.LeaderboardDialog(game);
            leaderboard.Show();

        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label2.Text = game.GetTime(game.CurentInfo.Time++);
        }


    }
}
