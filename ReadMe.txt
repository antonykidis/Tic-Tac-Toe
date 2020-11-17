
<img src="https://drive.google.com/file/d/1d1ZAe2a5MuJfluOHQphjVdU63PdBP4H6/view?usp=sharing" alt="TicTacToe" width="500" height="333">
<br>
This project contains a single tic-tac-toe.cs file which is an original
code by Bradley L Jones, from Teach Yourself C# In 21 Days book.
Originally this game was written using Single file. where Logic, and design embeded in a single file.
In the book you were compiling the file, and getting the .exe out of it.
You can still use the single code file.
1.Download external C# Compiler from https://www.mono-project.com/docs/getting-started/install/windows/ 
2.Open "OpenCommandPromt.exe" type csc tic-tac-toe.cs and press Enter.
This will generate tic-tac-toe.exe file.
3.Open tic-tac-toe.exe to play the game.

IMPORTANT!
Before you Compile the tic-tac-toe.cs, Uncomment the Main() method at line 266 to make it work. 
The Main() method was commented in purpose to override compilation errors in the main project.

	Main Project
	The main project was written from scratch using a separation of Design, and Logic.
	1.Program.cs file Contains Main() method, which is the main enttry of the programm.
	2.TicTacToeFinal.cs Contains All the logic needed for the game.
	3.TicTacToeFinal.Designer.cs Contains InitializeComponent() method where all the Design code is located
	  This code was created Using Graffic Interface. The mouse click wiring were created inside graffic designer.
	   this.btnTopLeft.Click += new System.EventHandler(this.btnTicTac_Click);
   To make it work simply press F5 to compile and run the programm.

