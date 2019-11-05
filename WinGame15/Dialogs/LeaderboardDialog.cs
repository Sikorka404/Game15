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
namespace WinGame15.Dialogs
{
    public partial class LeaderboardDialog : Form
    {
        int p = 0;
        Game game;
        public LeaderboardDialog(Game g)
        {
            InitializeComponent();
            game = g;

        }

        private void LeaderboardDialog_Load(object sender, EventArgs e)
        {
            DgLd.Rows.Clear();
            RowInfo cI;

            //game.Info.List.Sort(x => x.Time);
            game.Info.List.Sort((x, y) => x.Time.CompareTo(y.Time));

            for (int i = 0; i < game.Info.List.Count; i++)
            {
                cI = game.Info.List[i];
                DgLd.Rows.Add(i + 1, cI.Name, cI.Moves, game.GetTime(cI.Time));

            }

        }
    }
}
