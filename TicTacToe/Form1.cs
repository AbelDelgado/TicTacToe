using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        bool turn = true; // true = x turn, false = y turn
        int turn_Count = 0; //If by 9 turns no one wins, it's a draw


        public Form1()
        {
            InitializeComponent();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void assdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Abel Delgado", "Tic Tac Toe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if ((turn) && (b.Text == ""))
            {
                b.ForeColor = Color.Blue; 
                b.Font = new Font("MS Reference Sans Serif", 20.0f);
                b.Text = "X";
                //if (b.Text != "X")
                turn = !turn;
                turn_Count++;
            }
           
            else if (b.Text == "")
            {
                b.ForeColor = Color.Red; 
                b.Font = new Font("MS Reference Sans Serif", 20.0f);
                b.Text = "O";
                //if (b.Text != "O")
                turn = !turn;
                turn_Count++;
            }



            checkForWInner();
            whoseTurn();
            //b.Enabled = false;

        }

        private void whoseTurn()
        {
            string playerTurn = "";
            if (turn)
                playerTurn = "x";
            else
                playerTurn = "o";



            //label1.Text = playerTurn;
        }

       


        private void checkForWInner()
        {
            bool winnerFound = false;

            //horizontal boxes
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (button1.Text != ""))
                winnerFound = true;
            if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (button4.Text != ""))
                winnerFound = true;
            if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (button7.Text != ""))
                winnerFound = true;
 
            //vertical boxes
            if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (button4.Text != ""))
                winnerFound = true;
            if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (button5.Text != ""))
                winnerFound = true;
            if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (button9.Text != ""))
                winnerFound = true;

            //diagnoal boxes
            if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (button9.Text != ""))
                winnerFound = true;
            if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (button3.Text != ""))
                winnerFound = true;            

            if (winnerFound)
            {              
                    disableAllButtons();
                    String winner = "";

                    if (turn)
                        winner = "O";
                    else
                        winner = "X";
                    MessageBox.Show(winner + " Wins");                                
            }

            if (turn_Count == 9)
            {
                disableAllButtons();
                MessageBox.Show("Tie game");
            }          

        }

        private void disableAllButtons()
        {
            /*try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;

                }

            }
            catch
            {

            }
            */
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        private void stafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_Count = 0;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

        }
    }
}
