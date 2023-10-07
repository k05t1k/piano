namespace Piano
{
    internal class Program
    {
        private static int[] octave;
        private static int[] first_octave = new int[] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
        private static int[] second_octave = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
        private static int[] third_octave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };

        static void InfoKeyInput(ConsoleKeyInfo key)
        {
            // code for octave input key
            switch (key.Key)
            {
                case ConsoleKey.F1:
                    octave = first_octave;
                    Console.WriteLine("\noctave: 1");
                    break;
                case ConsoleKey.F2:
                    octave = second_octave;
                    Console.WriteLine("\noctave: 2");
                    break;
                case ConsoleKey.F3:
                    octave = third_octave;
                    Console.WriteLine("\noctave: 3");
                    break;
                case ConsoleKey.F10:
                    Console.WriteLine("\nfor exit press enter");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }

            // code for piano buttons input
            switch (key.Key)
            {
                case ConsoleKey.A:
                    Console.Beep(octave[0], 200);
                    break;
                case ConsoleKey.W:
                    Console.Beep(octave[1], 200);
                    break;
                case ConsoleKey.S:
                    Console.Beep(octave[2], 200);
                    break;
                case ConsoleKey.E:
                    Console.Beep(octave[3], 200);
                    break;
                case ConsoleKey.D:
                    Console.Beep(octave[4], 200);
                    break;
                case ConsoleKey.F:
                    Console.Beep(octave[5], 200);
                    break;
                case ConsoleKey.T:
                    Console.Beep(octave[6], 200);
                    break;
                case ConsoleKey.G:
                    Console.Beep(octave[7], 200);
                    break;
                case ConsoleKey.Y:
                    Console.Beep(octave[8], 200);
                    break;
                case ConsoleKey.H:
                    Console.Beep(octave[9], 200);
                    break;
                case ConsoleKey.U:
                    Console.Beep(octave[10], 200);
                    break;
                case ConsoleKey.J:
                    Console.Beep(octave[11], 200);
                    break;
            }
        }

        static void Main(string[] args)
        {
            // input info
            Console.WriteLine("piano");
            Console.WriteLine("for switch octave use f1, f2, f3");
            Console.WriteLine("black buttons: W E T Y U");
            Console.WriteLine("white buttons: A S D F G H J");

            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey();
                InfoKeyInput(key);
            }
        }
    }
}

