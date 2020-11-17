<img src="https://lh3.googleusercontent.com/WqkQCuXV4rHo1frAvdM5DbQGIs4XZmh_2tp3ioPZLuzhGG9admpZI3JjZItSZSnsv4i1beVPvYkTYaCjYe_XEhT9Nx2tgjE-8dQjoJtYYkac-M3SA6mOFiryGEyJPC28pue5M9WlvKBHAts2PkmnOCevwMDfZ41ETtkgwzLRcqRoWpQtBVVMmGKVb93LqQ2kA4zopgtCdt9uQvQgEW74QZr4Y_C9f6e7dBZ723MiA75TRTusdqwixsVvtjdZSa_zy3UEMi8HC80vomm2VJ2pXv48x88M0ABwceDf-PdH1pKZDqAeo4lDeWFNXbbpWMdwA_0EYWNxIztoueMIGm-BWv7iDhWTtiC80oG4_yLz9EUj8HeFsYcL9qk2QSPEVIDojOR8apLbACAahiKEHMsuExFMQ0ef1C65QNPHDpGw_B5NZeinHf9vdEI0HDuzAb3gOGeEmVoSa8OzMjt4Z1tK1cUZgHJiTSUrOv1f6GLQi8YG_7Oa0AqTH-GT0QCkMuHXbHIGrtcX7YthIvw_9MqCctVxt5ERVNCXEfU1IPhqT2I5J4zVgjuUSSG0ec8QjRLle316Q-dCs4-g0t-s8t-rQEvMyBDhQ6sfuO8czUIeKehSEm7pwNq1xfWXQ3kv5UC_zEmlORt9_vV-oCFO7VmgLK6rvrCtl9a9ysp0e3Dz4JMz3LArqxLlmGUV_A3fCw=w528-h544-no?authuser=0">
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
