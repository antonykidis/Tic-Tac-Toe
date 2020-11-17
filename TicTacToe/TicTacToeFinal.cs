using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{

    //All the main logic will be presented here in TicTakToe.cs file
    //All the Design was made from sctratch in the designer mode TiCTalToe.Designer.Cs
    //Original Bradley Jones file was written in a single file, and compiled using Open Mono Command Prompt
    public partial class TicTacToeFinal : Form
    {
        //Constructor
        public TicTacToeFinal()
        {
            InitializeComponent();
        }

        //Tic Tac Toe Logic Starts here-----------------------------
        private string setText(string origText)
        {
            string tmpText = origText;
            if (origText == "X" || origText == "O")
            {
                // Already a character in section

            }
            else
            {
                tmpText = btnTurn.Text;
                if (btnTurn.Text == "X")
                {
                    btnTurn.Text = "O";
                }
                else
                {
                    btnTurn.Text = "X";
                }
                turn++; // turn successful, so count.
            }
            return tmpText;
        }

        // Check to see if game is over
        // val == character for turn.
        private void checkEndGame(string val)
        {
            bool gameover = false;

            // First check for a winner....
            if (btnTopLeft.Text == val)//first value
            {
                if (btnTopMiddle.Text == val && btnTopRight.Text == val) //Horizontal top 90 degree
                {
                    gameover = true;
                }
                if (btnMiddleLeft.Text == val && btnBottomLeft.Text == val)//vertical left 90 degrees
                {
                    gameover = true;
                }
                if (btnMiddleMiddle.Text == val && btnBottomRight.Text == val) //45 degrees from left top to right bottom

                    gameover = true;
            }

            //Vertical Middle 90 degrees
            if (btnTopMiddle.Text == val)
            {
                if (btnMiddleMiddle.Text == val && btnBottomMiddle.Text == val)
                {
                    gameover = true;
                }
            }

            //Horizontal Middle 180 degrees
            if (btnMiddleLeft.Text == val)
            {
                if (btnMiddleMiddle.Text == val && btnMiddleRight.Text == val)
                {
                    gameover = true;
                }
            }

            //Bottom Horizontal 180 dgrees
            if (btnBottomLeft.Text == val)
            {
                if (btnBottomMiddle.Text == val && btnBottomRight.Text == val)
                {
                    gameover = true;
                }
                if (btnMiddleMiddle.Text == val && btnTopRight.Text == val)//45 degrees up from left to right
                {
                    gameover = true;
                }
            }

            //Right Vertical 90 degrees
            if (btnTopRight.Text == val)
            {
                if (btnMiddleRight.Text == val && btnBottomRight.Text == val)
                {
                    gameover = true;
                }
            }

            // Check to see if game over because of win...
            if (gameover == true)
            {
                if (val == "X")
                {
                    SoundPlayWin();
                    MessageBox.Show("Game Over - X wins!", "Game Over!");
                   
                }

                else
                {
                    SoundPlayWin();
                    MessageBox.Show("Game Over - O wins!", "Game Over!");
                    
                }
            }
            else
            {
                // no winner, are all nine spaces filled?
                if (turn >= 9)
                {
                    // game over do end game stuff
                    MessageBox.Show("Game Over - No winner!");
                    gameover = true;
                }
            }

            // See if board needs reset.
            if (gameover == true)
            {
                resetGame();
            }
        }


        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewGame_Click(object sender, System.EventArgs e)
        {
            resetGame();
        }


        private void resetGame()
        {
            turn = 0;
            btnTopLeft.Text = " ";
            btnTopMiddle.Text = " ";
            btnTopRight.Text = " ";
            btnMiddleLeft.Text = " ";
            btnMiddleMiddle.Text = " ";
            btnMiddleRight.Text = " ";
            btnBottomLeft.Text = " ";
            btnBottomMiddle.Text = " ";
            btnBottomRight.Text = " ";
            btnTurn.Text = "X";
        }


        // Set X or O text on grid button
        private void btnTicTac_Click(object sender, System.EventArgs e)
        {
           
            // convert the sender object to a button:
            Button tmpButton = (Button)sender;
            // Set the text of this button:
            tmpButton.Text = setText(tmpButton.Text);
            //Play sound
            SoundClickButton();

            checkEndGame(tmpButton.Text);
        }


        //Play Sounds-------------------------------------------------
        private void SoundClickButton()
        {
            //Add using System.Media;
            SoundPlayer ButtonClickSound = new SoundPlayer(Resources.ButtonClick);
            ButtonClickSound.Play();

        }
        private void SoundPlayWin()
        {
            SoundPlayer YouWinSound = new SoundPlayer(Resources.Win);
            YouWinSound.Play();
        }



    }//End of class
}//End of namespace
