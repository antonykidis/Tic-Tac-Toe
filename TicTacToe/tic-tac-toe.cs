//A Code by Bradley L Jones From Teach Yourself C# In 21 Days.
//TicTac.cs - Simple Windows Tic Tac Toe program.
//To compile this game please use Open Mono Command prompt(Google it)
//Use csc command to compile tic-tac-toe.cs file. Type csc tic-tac-toe.cs and hit enter. You will get the .exe file.
//Double click the exe file to run the program.
//IMPORTANT!
//Uncomment the Main() method at line 266 to make it work. 
//This was commented in purpose to override compilation errors in the main project.

//TicTacToeFinal it is a final re written programm fromscratch
//-----------------------------------------------------------------
using System;
 using System.Drawing;
 using System.Collections;
 using System.ComponentModel;
 using System.Windows.Forms;
 using System.Data;

namespace TicTac
{
    /// <summary>
    /// Summary description for TicTac.
    /// </summary>
    public class TicTac : System.Windows.Forms.Form
    {
        // Buttons for the nine game positions:
        private System.Windows.Forms.Button btnTopLeft;
        private System.Windows.Forms.Button btnTopMiddle;
        private System.Windows.Forms.Button btnTopRight;
        private System.Windows.Forms.Button btnMiddleRight;
        private System.Windows.Forms.Button btnMiddleMiddle;
        private System.Windows.Forms.Button btnMiddleLeft;
        private System.Windows.Forms.Button btnBottomRight;
        private System.Windows.Forms.Button btnBottomMiddle;
        private System.Windows.Forms.Button btnBottomLeft;
        // Other controls for the games:
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTurn;
        private System.Windows.Forms.Panel panel1;
        // variable to keep track of turn
        private int turn = 0;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        //Constructor
        public TicTac()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnTopLeft = new Button();
            this.btnTopMiddle = new Button();
            this.btnTopRight = new Button();
            this.btnMiddleRight = new Button();
            this.btnMiddleMiddle = new Button();
            this.btnMiddleLeft = new Button();
            this.btnBottomRight = new Button();
            this.btnBottomMiddle = new Button();
            this.btnBottomLeft = new Button();
            this.btnNewGame = new Button();
            this.btnExit = new Button();
            this.btnTurn = new Button();
            this.panel1 = new Panel();
            this.SuspendLayout();
            //
            // btnTopLeft
            //
            this.btnTopLeft.Font = new System.Drawing.Font("Microsoft Sans Serif",
             20.25F,
             System.Drawing.FontStyle.Regular,
             System.Drawing.GraphicsUnit.Point,
             ((System.Byte)(0)));
            this.btnTopLeft.Location = new System.Drawing.Point(16, 16);
            this.btnTopLeft.Name = "btnTopLeft";
            this.btnTopLeft.Size = new System.Drawing.Size(64, 56);
            this.btnTopLeft.TabIndex = 0;
            this.btnTopLeft.Click +=new System.EventHandler(this.btnTicTac_Click);
            //
            // btnTopMiddle
            //
            this.btnTopMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif",
            20.25F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((System.Byte)(0)));
            this.btnTopMiddle.Location = new System.Drawing.Point(96, 16);
            this.btnTopMiddle.Name = "btnTopMiddle";
            this.btnTopMiddle.Size = new System.Drawing.Size(64, 56);
            this.btnTopMiddle.TabIndex = 1;
            this.btnTopMiddle.Click +=new System.EventHandler(this.btnTicTac_Click);
            //
            // btnTopRight
            //
            this.btnTopRight.Font = new System.Drawing.Font("Microsoft Sans Serif",
            20.25F, System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((System.Byte)(0)));
            this.btnTopRight.Location = new System.Drawing.Point(176, 16);
            this.btnTopRight.Name = "btnTopRight";
            this.btnTopRight.Size = new System.Drawing.Size(64, 56);
            this.btnTopRight.TabIndex = 2;
            this.btnTopRight.Click += new System.EventHandler(this.btnTicTac_Click);
            //
            // btnMiddleRight
            //
            this.btnMiddleRight.Font = new System.Drawing.Font("Microsoft Sans Serif",
            20.25F, System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((System.Byte)(0)));
            this.btnMiddleRight.Location = new System.Drawing.Point(176, 88);
            this.btnMiddleRight.Name = "btnMiddleRight";
            this.btnMiddleRight.Size = new System.Drawing.Size(64, 56);
            this.btnMiddleRight.TabIndex = 5;
            this.btnMiddleRight.Click += new System.EventHandler(this.btnTicTac_Click);
            //
            // btnMiddleMiddle
            //
            this.btnMiddleMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif",
            20.25F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((System.Byte)(0)));
            this.btnMiddleMiddle.Location = new System.Drawing.Point(96, 88);
            this.btnMiddleMiddle.Name = "btnMiddleMiddle";
            this.btnMiddleMiddle.Size = new System.Drawing.Size(64, 56);
            this.btnMiddleMiddle.TabIndex = 4;
            this.btnMiddleMiddle.Click += new System.EventHandler(this.btnTicTac_Click);
            //
            // btnMiddleLeft
            //
            this.btnMiddleLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.btnMiddleLeft.Location = new System.Drawing.Point(16, 88);
            this.btnMiddleLeft.Name = "btnMiddleLeft";
            this.btnMiddleLeft.Size = new System.Drawing.Size(64, 56);
            this.btnMiddleLeft.TabIndex = 3;
            this.btnMiddleLeft.Click += new System.EventHandler(this.btnTicTac_Click);
            //
            // btnBottomRight
            //
            this.btnBottomRight.Font = new System.Drawing.Font("Microsoft Sans Serif",
            20.25F, System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((System.Byte)(0)));
            this.btnBottomRight.Location = new System.Drawing.Point(176, 160);
            this.btnBottomRight.Name = "btnBottomRight";
            this.btnBottomRight.Size = new System.Drawing.Size(64, 56);
            this.btnBottomRight.TabIndex = 8;
            this.btnBottomRight.Click += new System.EventHandler(this.btnTicTac_Click);
            //
            // btnBottomMiddle
            //
            this.btnBottomMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif",
            20.25F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((System.Byte)(0)));
            this.btnBottomMiddle.Location = new System.Drawing.Point(96, 160);
            this.btnBottomMiddle.Name = "btnBottomMiddle";
            this.btnBottomMiddle.Size = new System.Drawing.Size(64, 56);
            this.btnBottomMiddle.TabIndex = 7;
            this.btnBottomMiddle.Click += new System.EventHandler(this.btnTicTac_Click);
            //
            // btnBottomLeft
            //
            this.btnBottomLeft.Font = new System.Drawing.Font("Microsoft Sans Serif",
            20.25F,
            System.Drawing.FontStyle.Regular,
            System.Drawing.GraphicsUnit.Point,
            ((System.Byte)(0)));
            this.btnBottomLeft.Location = new System.Drawing.Point(16, 160);
            this.btnBottomLeft.Name = "btnBottomLeft";
            this.btnBottomLeft.Size = new System.Drawing.Size(64, 56);
            this.btnBottomLeft.TabIndex = 6;
            this.btnBottomLeft.Click += new System.EventHandler(this.btnTicTac_Click);
            //
            // btnNewGame
            //
            this.btnNewGame.Location = new System.Drawing.Point(16, 248);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(80, 24);
            this.btnNewGame.TabIndex = 9;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            //
            // btnExit
            //
            this.btnExit.Location = new System.Drawing.Point(160, 248);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 24);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            //
            // btnTurn
            //
            this.btnTurn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurn.Font = new System.Drawing.Font("Microsoft Sans Serif",
        20.25F,
        System.Drawing.FontStyle.Regular,
       System.Drawing.GraphicsUnit.Point,
        ((System.Byte)(0)));
            this.btnTurn.Location = new System.Drawing.Point(112, 232);
            this.btnTurn.Name = "btnTurn";
            this.btnTurn.Size = new System.Drawing.Size(32, 40);
            this.btnTurn.TabIndex = 0;
            this.btnTurn.TabStop = false;
            this.btnTurn.Text = "X";
            //
            // panel1
            //
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(16, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 200);
            //
            // TicTac
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(256, 286);
            this.Controls.Add(this.btnTurn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnBottomRight);
            this.Controls.Add(this.btnBottomMiddle);
            this.Controls.Add(this.btnBottomLeft);
            this.Controls.Add(this.btnMiddleRight);
            this.Controls.Add(this.btnMiddleMiddle);
            this.Controls.Add(this.btnMiddleLeft);
            this.Controls.Add(this.btnTopRight);
            this.Controls.Add(this.btnTopMiddle);
            this.Controls.Add(this.btnTopLeft);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TicTac";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        //public static void Main()
        //{
        //    Application.Run(new TicTac());
        //}

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
                    MessageBox.Show("Game Over - X wins!","Game Over!");
                else
                    MessageBox.Show("Game Over - O wins!", "Game Over!");
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

            checkEndGame(tmpButton.Text);
        }
    }
}//--end of namespace

 // End of Listing