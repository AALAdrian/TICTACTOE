using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIC_TAC_TOE
{
    public partial class TICTACTOE : Form
    {
        bool turn = true;
        List<string> moves = new List<string>();

        public TICTACTOE()
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
                moves.Add("X");
            }
            else
            {
                btn.Text = "O";
                btn.Enabled = false;
                turn = true;
                textBox2.Text = "TURN: X";
                moves.Add("O");
            }
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }
    }
}
