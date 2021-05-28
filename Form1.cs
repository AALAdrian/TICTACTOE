using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TIC_TAC_TOE
{
    public partial class TicTacToe : Form
    {
        bool turn = true;
        List<string> movesx = new(9);
        List<string> moveso = new(9);
        public TicTacToe()
        {
            InitializeComponent();
        }
        private void btn_Click(object sender, EventArgs e)
        {

            Button btn = sender as Button;
            
            if (turn)
            {
                btn.Text = "X";
                btn.Enabled = false;
                turn = false;
                textBox2.Text = "TURN: O";
                var index = Regex.Replace(btn.Name, "[^.0-9]", "");
                System.Diagnostics.Debug.WriteLine(index);
                movesx.Add(index);
                System.Diagnostics.Debug.WriteLine(message: "\"" + btn.Name + "\", \"X\"");
            }
            else
            {
                btn.Text = "O";
                btn.Enabled = false;
                turn = true;
                textBox2.Text = "TURN: X";
                var index = Regex.Replace(btn.Name, "[^.0-9]", "");
                moveso.Add(index);
                System.Diagnostics.Debug.WriteLine("\"" + btn.Name + "\", \"O\"");
            }
        }
        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnRestart_Click(object sender, EventArgs e) => Application.Restart();
    }
}
