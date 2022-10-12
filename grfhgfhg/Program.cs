using System;

class Program
{
    public static void Main(string[] args)
    {
        float[] firstOctave = new float[12];
        void ChangeOctave(ref float[] firstOctave, int ba)
        {
            ConsoleKeyInfo ba = Console.ReadKey();

            if (ba.Key == ConsoleKey.F1)
            {
                firstOctave[0] = 16.35F;
                firstOctave[1] = 17.32F;
                firstOctave[2] = 18.35F;
                firstOctave[3] = 19.45F;
                firstOctave[4] = 20.60F;
                firstOctave[5] = 21.83F;
                firstOctave[6] = 23.12F;
                firstOctave[7] = 24.50F;
                firstOctave[8] = 25.96F;
                firstOctave[9] = 27.50F;
                firstOctave[10] = 29.14F;
                firstOctave[11] = 30.87F;
                beep(Octave1);
            }
            else if (ba.Key == ConsoleKey.F2)
            {
                firstOctave[0] = 32.7F;
                firstOctave[1] = 34.65F;
                firstOctave[2] = 36.71F;
                firstOctave[3] = 38.89F;
                firstOctave[4] = 41.2F;
                firstOctave[5] = 43.65F;
                firstOctave[6] = 46.25F;
                firstOctave[7] = 49.00F;
                firstOctave[8] = 51.91F;
                firstOctave[9] = 55.00F;
                firstOctave[10] = 58.27F;
                firstOctave[11] = 61.74F;
                beep(Octave2);
            }
            else if (ba.Key == ConsoleKey.F3)
            {
                firstOctave[0] = 65.41F;
                firstOctave[1] = 69.30F;
                firstOctave[2] = 74.42F;
                firstOctave[3] = 77.78F;
                firstOctave[4] = 82.41F;
                firstOctave[5] = 87.31F;
                firstOctave[6] = 92.50F;
                firstOctave[7] = 98.00F;
                firstOctave[8] = 103.8F;
                firstOctave[9] = 110.0F;
                firstOctave[10] = 116.5F;
                firstOctave[11] = 123.5F;
                beep(Octave3);
            }
        }
        void beep(float mel)
        {
            Console.Beep(Convert.ToInt32(mel), 300);
        }
        ChangeOctave(ref firstOctave, 1);
        Console.WriteLine("Добро пожаловать в консольное пианино");
        Console.WriteLine("Для остановки программы нажмиже ESC");
        Console.WriteLine("Октава 1 - F1   Октава 2 - F2   Октава 3 - F3");
        Console.WriteLine("C# - Q,  D# - W,  F# - R,   G# - T, A# - Y");
        Console.WriteLine("C - C,  D - D,  E - E,   F - F, G - G, A - A , B - B");
        ConsoleKeyInfo but = Console.ReadKey();
        while (but.Key != ConsoleKey.Escape)
        {
            if (but.Key == ConsoleKey.F1)
            {
                ChangeOctave(ref firstOctave, 1);
            }
            else if (but.Key == ConsoleKey.F2)
            {
                ChangeOctave(ref firstOctave, 2);
            }
            else if (but.Key == ConsoleKey.F2)
            {
                ChangeOctave(ref firstOctave, 3);
            }
            else if (but.Key == ConsoleKey.Q)
            {
                beep(firstOctave[1]);
            }
            else if (but.Key == ConsoleKey.W)
            {
                beep(firstOctave[3]);
            }
            else if (but.Key == ConsoleKey.R)
            {
                beep(firstOctave[6]);
            }
            else if (but.Key == ConsoleKey.T)
            {
                beep(firstOctave[8]);
            }
            else if (but.Key == ConsoleKey.Y)
            {
                beep(firstOctave[10]);
            }
            else if (but.Key == ConsoleKey.C)
            {
                beep(firstOctave[0]);
            }
            else if (but.Key == ConsoleKey.D)
            {
                beep(firstOctave[2]);
            }
            else if (but.Key == ConsoleKey.E)
            {
                beep(firstOctave[4]);
            }
            else if (but.Key == ConsoleKey.F)
            {
                beep(firstOctave[5]);
            }
            else if (but.Key == ConsoleKey.G)
            {
                beep(firstOctave[7]);
            }
            else if (but.Key == ConsoleKey.A)
            {
                beep(firstOctave[9]);
            }
            else if (but.Key == ConsoleKey.B)
            {
                beep(firstOctave[11]);
            }
            but = Console.ReadKey();

        }
    }
}