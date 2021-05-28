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
        int scorex = 0;
        int scorey = 0;
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
                Wincheck();
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
                Wincheck();
            }
        }
        void Wincheck()
        {
            //O
            if (moveso.Contains("1") & moveso.Contains("2") & moveso.Contains("3"))
            {
                Win(0);
            }
            else if (moveso.Contains("4") & moveso.Contains("5") & moveso.Contains("6"))
            {
                Win(0);
            }
            else if (moveso.Contains("7") & moveso.Contains("8") & moveso.Contains("9"))
            {
                Win(0);
            }
            else if (moveso.Contains("1") & moveso.Contains("4") & moveso.Contains("7"))
            {
                Win(0);
            }
            else if (moveso.Contains("2") & moveso.Contains("5") & moveso.Contains("8"))
            {
                Win(0);
            }
            else if (moveso.Contains("3") & moveso.Contains("6") & moveso.Contains("9"))
            {
                Win(0);
            }
            else if (moveso.Contains("6") & moveso.Contains("5") & moveso.Contains("9"))
            {
                Win(0);
            }
            else if (moveso.Contains("3") & moveso.Contains("5") & moveso.Contains("7"))
            {
                Win(0);
            }

            //X
            if (movesx.Contains("1") & movesx.Contains("2") & movesx.Contains("3"))
            {
                Win(1);
            }
            else if (movesx.Contains("4") & movesx.Contains("5") & movesx.Contains("6"))
            {
                Win(1);
            }
            else if (movesx.Contains("7") & movesx.Contains("8") & movesx.Contains("9"))
            {
                Win(1);
            }
            else if (movesx.Contains("1") & movesx.Contains("4") & movesx.Contains("7"))
            {
                Win(1);
            }
            else if (movesx.Contains("2") & movesx.Contains("5") & movesx.Contains("8"))
            {
                Win(1);
            }
            else if (movesx.Contains("3") & movesx.Contains("6") & movesx.Contains("9"))
            {
                Win(1);
            }
            else if (movesx.Contains("6") & movesx.Contains("5") & movesx.Contains("9"))
            {
                Win(1);
            }
            else if (movesx.Contains("3") & movesx.Contains("5") & movesx.Contains("7"))
            {
                Win(1);
            }

        }
        void Win(int args)
        {
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true; 
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = ""; 
            if(args == 1)
            {
                scorex += 1;
                txtScoreX.Text = ("PLAYER X SCORE" + scorex);
            }
            else if(args == 0)
            {
                scorey += 1;
                txtScoreO.Text = ("PLAYER O SCORE" + scorey);
            }
            
        }
        private void btnExit_Click(object sender, EventArgs e) => Application.Exit();

        private void btnRestart_Click(object sender, EventArgs e) => Application.Restart();
    }
}
