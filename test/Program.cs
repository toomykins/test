using System;
namespace test
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Player speler = new Player ();

			speler.x = 0;speler.y = 0;
			Console.WriteLine (Environment.OSVersion);
			System.Console.WriteLine("compatibility test");
			Console.Title = "Linux/Windows C# Test";
			Console.WriteLine("window height = " + Console.WindowHeight.ToString());
			Console.WriteLine("window width = " + Console.WindowWidth.ToString());
			Console.WriteLine (Console.WindowLeft.ToString());


			//Console.ReadLine();
			//Console.WindowWidth = 7;
			//long tijd;
				
		//		for (int i = 1; i <= 9; i++) {
		//		tijd = (long)(DateTime.UtcNow.Subtract (new DateTime (1970, 1, 1))).TotalMilliseconds;
		//			for (int b = Console.WindowTop; b < Console.WindowHeight; b++) {
		//				for (int n = Console.WindowLeft; n < Console.WindowWidth; n++) {
		//					Console.SetCursorPosition (n, b);
		//					Console.Write (i.ToString ());
		//				Console.Title = ((long)(DateTime.UtcNow.Subtract (new DateTime (1970, 1, 1))).TotalMilliseconds - tijd).ToString();
		//				}
		//			}
		//		}
			

			//for (int i = 1; i <= 100000; i++) {
			//	Console.SetCursorPosition (Console.WindowWidth / 2, Console.WindowHeight / 2);
			//	Console.WriteLine (i.ToString());
			//}
			//Console.ReadLine();
			//while (true) {
			//	Console.WriteLine();
			//}
			Console.BackgroundColor = ConsoleColor.Green;
				Console.ForegroundColor = ConsoleColor.Red;
			while (true) {
				
				//if (Console.KeyAvailable) {
				var key = Console.ReadKey(true);
				
					//Console.WriteLine (speler.y.ToString());
					if(key.Key.ToString() == "UpArrow") {
						speler.y = speler.y - 1;
					}
					if(key.Key.ToString() == "DownArrow") {
						speler.y = speler.y + 1;
					}
					if(key.Key.ToString() == "LeftArrow") {
						speler.x = speler.x - 1;
					}
					if(key.Key.ToString() == "RightArrow") {
						speler.x = speler.x + 1;
					}
					Console.Clear ();

                    if (speler.y != Console.WindowHeight)
                    {
						Console.Title = "x:" + speler.x.ToString () + " y:" + speler.y.ToString ();
						try{
                        	Console.SetCursorPosition(speler.x, speler.y);
						} catch(Exception) {
						}
                        Console.Write("o");
						Console.SetCursorPosition (0, Console.WindowHeight-1);
                    }

						//}

				//Console.WriteLine ("kik");
			}
		}
	}
}
