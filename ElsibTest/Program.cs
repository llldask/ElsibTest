namespace TestElsib
{
    internal class Program
    {
        static List<int> Task1(int[] array)
        {
            List<int> list = new List<int>();

            int extra = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != i + extra)
                {
                    list.Add(i + extra);
                    extra++;
                }
            }
            return list;
        }

        static List<int> Task2(int[] array)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                    list.Add(1);
                else
                    list.Add(0);
            }
            return list;
        }

        static void PrintList(List<int> list)
        {
            foreach (int item in list)
                Console.Write(item + " ");
            Console.WriteLine();
        }

        static string Task3(string str, string symbol1, string symbol2)
        {
            string[] subs = str.Split(symbol1);
            return symbol2 + subs[1];
        }

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 4, 5, 6, 8, 10 };

            Console.WriteLine("Задание 1");
            PrintList(Task1(a));
            Console.WriteLine();

            Console.WriteLine("Задание 2");
            PrintList(Task2(a));
            Console.WriteLine();

            Console.WriteLine("Задание 3");
            Console.WriteLine(Task3("Hello morld!", "m", "w"));

        }
    }
}