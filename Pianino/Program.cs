namespace Pianino
{
    internal class Program
    {
        static int[] Octava1 = { 32, 34, 36, 38, 41, 43, 46, 49, 51, 55, 58, 61 };
        static int[] Octava2 = { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
        static int[] Octava3 = { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите октаву нажатием F1, F2, F3");
            while (true)
            {
                int[] result = Octava();
                if (result == Octava1)
                {
                    Console.WriteLine("Вы выбрали первую октаву");
                    Sound(result);
                }
                if (result == Octava2)
                {
                    Console.WriteLine("Вы выбрали вторую октаву");
                    Sound(result);
                }
                if (result == Octava3)
                {
                    Console.WriteLine("Вы выбрали третью октаву");
                    Sound(result);
                }
            }
        }
             static int[] Octava()
             {
                int[] a = new int[12];
                ConsoleKeyInfo klavisha = Console.ReadKey();
                if (klavisha.Key == ConsoleKey.F1)
                {
                    Console.WriteLine("Выбана первая октава");
                    a = Octava1;
                    return a;
                }
                else if (klavisha.Key == ConsoleKey.F2)
                {
                    Console.WriteLine("Выбана вторая октава");
                    a = Octava2;
                    return a;
                }
                else if (klavisha.Key == ConsoleKey.F3)
                {
                    Console.WriteLine("Выбана третья октава");
                    a = Octava3;
                    return a;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Выберите откаву клавишами F1, F2, F3");
                    return a;
                }
             }
            static int[] Sound(int[] a)
            {
                while (true)
                {
                    ConsoleKey Klavisha2 = Console.ReadKey().Key;
                    switch (Klavisha2)
                    {
                        case ConsoleKey.D:
                            Console.Beep(a[0], 400);
                            Console.Clear();
                            continue;
                            break;
                        case ConsoleKey.R:
                            Console.Beep(a[1], 400);
                            Console.Clear();
                            continue;
                            break;
                        case ConsoleKey.F:
                            Console.Beep(a[2], 400);
                            Console.Clear();
                            continue;
                            break;
                        case ConsoleKey.T:
                            Console.Beep(a[3], 400);
                            Console.Clear();
                            continue;
                            break;
                        case ConsoleKey.G:
                            Console.Beep(a[4], 400);
                            Console.Clear();
                            continue;
                            break;
                        case ConsoleKey.H:
                            Console.Beep(a[5], 400);
                            Console.Clear();
                            continue;
                            break;
                        case ConsoleKey.U:
                            Console.Beep(a[6], 400);
                            Console.Clear();
                            continue;
                            break;
                        case ConsoleKey.J:
                            Console.Beep(a[7], 400);
                            Console.Clear();
                            continue;
                            break;
                        case ConsoleKey.I:
                            Console.Beep(a[8], 400);
                            Console.Clear();
                            continue;
                            break;
                        case ConsoleKey.K:
                            Console.Beep(a[9], 400);
                            Console.Clear();
                            continue;
                            break;
                        case ConsoleKey.O:
                            Console.Beep(a[10], 400);
                            Console.Clear();
                            continue;
                            break;
                        case ConsoleKey.L:
                            Console.Beep(a[11], 400);
                            Console.Clear();
                            continue;
                            break;
                        case ConsoleKey.F1:
                            a = Octava1;
                            return a;
                            break;
                        case ConsoleKey.F2:
                            a = Octava2;
                            return a;
                            break;
                        case ConsoleKey.F3:
                            a = Octava3;
                            return a;
                            break;
                        default:
                            Console.Clear();
                            continue;
                            break;
                    }
                }
            }
    }
}