class Program
{
    static void Main(string[] args)
    {
        int position = 2;
        int when = 1;
        string Data = new List<String>() { "Выбрана дата 01.01.22", "Выбрана дата 02.02.22", "Выбрана дата 03.03.22", "Выбрана дата 04.04.22", "Выбрана дата 05.05.22" };
        string Dela = new List<String>() { "  1. Проверить работы", "  2. Сходить в магазин",
                                            "  1. Навестить друга", "  2. Заняться спортом",
                                            "  1. Проверить работы", "  2. Сходить в магазин",
                                            "  1. Погулять с собакой ", "  2. Почитать книгу",
                                            "  1. Проверить работы", "  2. Купить тетради" };

        string chivo = new List<String>() {"  Описание: Проверить работы по ААС", "  Описание: Сходить в продуктовый магазин за молоком",
                                              "  Описание: Навестить друга по соседству", "  Описание: Выйти на улицу и пробежать 1км",
                                              "  Описание: Проверить работы по компьютерным сетям", "  Описание: Выйти на улицу и сходить за хлебом",
                                              "  Описание: Выйти на улицу и выгулить собаку", "  Описание: Прочитать первый том \"война и мир\" ",
                                              "  Описание: Проверить работы по ОАИП", "  Описание: Купить тетради в клетку"
                                            };
        Console.Clear();
        Menu(when);
        Console.SetCursorPosition(0, position);
        while (true)
        {

            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.UpArrow)
            {
                position--;
                Console.Clear();
                Menu(when);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
            }
            else if (key.Key == ConsoleKey.DownArrow)
            {
                position++;
                Console.Clear();
                Menu(when);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
            }
            if (position == 1 || position == 4)
            {
                position = 2;
            }
            if (key.Key == ConsoleKey.Enter)
            {
                if (position == 2)
                {
                    kavo(when, position);
                }
                else if (position == 3)
                {
                    kavo(when, position);
                }
            }

            if (key.Key == ConsoleKey.RightArrow)
            {
                when++;
                if (when > 5)
                {
                    when--;
                }
                Console.Clear();
                Menu(when);
            }
            else if (key.Key == ConsoleKey.LeftArrow)
            {
                when--;
                if (when < 1)
                {
                    when++;
                }
                Console.Clear();
                Menu(when);
            }
        }


        void Menu(int when)
        {
            if (when == 1)
            {
                Console.Clear();
                Console.WriteLine(Data[0]);
                Console.WriteLine();
                Console.WriteLine(Dela[0]);
                Console.WriteLine(Dela[1]);

            }
            if (when == 2)
            {
                Console.Clear();
                Console.WriteLine(Data[1]);
                Console.WriteLine();
                Console.WriteLine(Dela[2]);
                Console.WriteLine(Dela[3]);

            }
            if (when == 3)
            {
                Console.Clear();
                Console.WriteLine(Data[2]);
                Console.WriteLine();
                Console.WriteLine(Dela[4]);
                Console.WriteLine(Dela[5]);

            }
            if (when == 4)
            {
                Console.Clear();
                Console.WriteLine(Data[3]);
                Console.WriteLine();
                Console.WriteLine(Dela[6]);
                Console.WriteLine(Dela[7]);

            }
            if (when == 5)
            {
                Console.Clear();
                Console.WriteLine(Data[4]);
                Console.WriteLine();
                Console.WriteLine(Dela[8]);
                Console.WriteLine(Dela[9]);
            }
        }
        void kavo(int when, int position)
        {
            if (when == 1)
            {
                if (position == 2)
                {
                    Console.Clear();
                    Console.WriteLine(Dela[0]);
                    Console.WriteLine();
                    Console.WriteLine(chivo[0]);
                    Console.WriteLine(Data[0]);
                }

                if (position == 3)
                {
                    Console.Clear();
                    Console.WriteLine(Dela[1]);
                    Console.WriteLine();
                    Console.WriteLine(chivo[1]);
                    Console.WriteLine(Data[0]);
                }
            }
            if (when == 2)
            {
                if (position == 2)
                {
                    Console.Clear();
                    Console.WriteLine(Dela[2]);
                    Console.WriteLine();
                    Console.WriteLine(chivo[2]);
                    Console.WriteLine(Data[1]);
                }

                if (position == 3)
                {
                    Console.Clear();
                    Console.WriteLine(Dela[3]);
                    Console.WriteLine();
                    Console.WriteLine(chivo[3]);
                    Console.WriteLine(Data[1]);
                }
            }
            if (when == 3)
            {
                if (position == 2)
                {
                    Console.Clear();
                    Console.WriteLine(Dela[4]);
                    Console.WriteLine();
                    Console.WriteLine(chivo[4]);
                    Console.WriteLine(Data[2]);
                }

                if (position == 3)
                {
                    Console.Clear();
                    Console.WriteLine(Dela[5]);
                    Console.WriteLine();
                    Console.WriteLine(chivo[5]);
                    Console.WriteLine(Data[2]);
                }
            }
            if (when == 4)
            {
                if (position == 2)
                {
                    Console.Clear();
                    Console.WriteLine(Dela[6]);
                    Console.WriteLine();
                    Console.WriteLine(chivo[6]);
                    Console.WriteLine(Data[3]);
                }

                if (position == 3)
                {
                    Console.Clear();
                    Console.WriteLine(Dela[7]);
                    Console.WriteLine();
                    Console.WriteLine(chivo[7]);
                    Console.WriteLine(Data[3]);
                }
            }
            if (when == 5)
            {
                if (position == 2)
                {
                    Console.Clear();
                    Console.WriteLine(Dela[8]);
                    Console.WriteLine();
                    Console.WriteLine(chivo[8]);
                    Console.WriteLine(Data[4]);
                }

                if (position == 3)
                {
                    Console.Clear();
                    Console.WriteLine(Dela[9]);
                    Console.WriteLine();
                    Console.WriteLine(chivo[9]);
                    Console.WriteLine(Data[4]);
                }
            }
        }
    }
}
}
