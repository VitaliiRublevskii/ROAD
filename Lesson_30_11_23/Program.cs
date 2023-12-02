


string[] roadR = {
                "               |            |             ",
                "               |  W  |      |             ",
                "          *    |  W         |             ",
                "          * *  |     |      |  * * *      ",
                "                              @           ",
                "--------------               -------------",
                "                                  B       ",
                "  -  -  -  -  -              -  -  -  -  -",
                "   M  M  M                                ",
                "--------------               -------------",
                "             @                            ",
                "        * * *  |           |  * *         ",
                "               |     |   A |    *         ",
                "               |           |              ",
                "               |     |   A |              "  };

string[] roadR1 = {
                "               |            |             ",
                "               |     |      |             ",
                "               |            |             ",
                "          * *  |  W  |      |  * * *      ",
                "                             @            ",
                "--------- * --    W          -------------",
                "                                  B       ",
                "  -  -  -  -  -              -  -  -  -  -",
                "  M  M  M                                 ",
                "--------------           A   --- * -------",
                "             @                            ",
                "        * * *  |         A |   * *        ",
                "               |     |     |              ",
                "               |           |              ",
                "               |     |     |              "  };

string[] roadR2 = {
                "               |            |             ",
                "               |     |      |             ",
                "               |            |             ",
                "            *  |     |      |  * * *      ",
                "                             @            ",
                "--------- * --    W          -------------",
                "          *              A        B       ",
                "  -  -  -  -  -              -  -  -  -  -",
                "   M  M  M        W              *        ",
                "--------------           A   --- * -------",
                "             @                            ",
                "        * * *  |           |   *          ",
                "               |     |     |              ",
                "               |           |              ",
                "               |     |     |              "   };

string[] roadR3 = {
                "               |            |             ",
                "               |     |      |             ",
                "               |            |             ",
                "            *  |     |   A  |  * * *      ",
                "                             @            ",
                "--------------               -------------",
                "          *              A        B       ",
                "  -  -  - *-  -              -  -* -  -  -",
                "   M  M  M        W              *        ",
                "--------------               -------------",
                "             @                            ",
                "        * * *  |  W        |   *          ",
                "               |     |     |              ",
                "               |           |              ",
                "               |     |     |              " };

string[] roadR4 = {
                "               |         A  |             ",
                "               |     |      |             ",
                "               |            |             ",
                "            *  |     |   A  |  * * *      ",
                "                             @            ",
                "--------------               --- * -------",
                "                                 *B       ",
                "  -  -  -  -  -              -  -  -  -  -",
                "   M  M  M *                              ",
                "---------- * -              -------------",
                "             @                            ",
                "        * * *  |  W        |   *          ",
                "               |     |     |              ",
                "               |           |              ",
                "               |  W  |     |              " };

void goRight ()
{
    Console.Clear();
    printRight(roadR);
    Thread.Sleep(1000);
    Console.Clear();

    printRight(roadR1);
    Thread.Sleep(1000);
    Console.Clear();

    printRight(roadR2);
    Thread.Sleep(1000);
    Console.Clear();

    printRight(roadR3);
    Thread.Sleep(1000);
    Console.Clear();

    printRight(roadR4);
    Thread.Sleep(1000);
    Console.Clear();

    printRight(roadR);
}

void printRight(String[] s)
{
    for (int i = 0; i < s.Length; i++)
    {
        if (i == 4)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s[i]);
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        else if (i == 10)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s[i]);
            Console.ForegroundColor = ConsoleColor.White;
        }
        else { Console.WriteLine(s[i]); }
    }
    Console.WriteLine ();
}







string[] roadL = {
                "               |            |             ",
                "               |  W  |      |             ",
                "          *    |  W         |             ",
                "          * *  |     |      |  * * *      ",
                "                              @           ",
                "--------------               -------------",
                "                                  B       ",
                "  -  -  -  -  -              -  -  -  -  -",
                "   M  M  M                                ",
                "--------------               -------------",
                "             @                            ",
                "        * * *  |           |  * *         ",
                "               |     |   A |    *         ",
                "               |           |              ",
                "               |     |   A |              " };

string[] roadL1 = {
                "               |            |             ",
                "               |  W  |      |             ",
                "          *    |  W         |             ",
                "            *  *     |      *  * *        ",
                "                              @           ",
                "--------------               -------------",
                "                            B             ",
                "  -  -  -  -  -              -  -  -  -  -",
                "      M   M     M                         ",
                "--------------               -------------",
                "             @                            ",
                "          * *  *           *  *           ",
                "               |     |   A |    *         ",
                "               |           |              ",
                "               |     |   A |              " };

string[] roadL2 = {
                "               |            |             ",
                "               |  W  |      |             ",
                "          *    |  W         |             ",
                "               *   * |  *   *  *          ",
                "                              @           ",
                "--------------               -------------",
                "                      B                   ",
                "  -  -  -  -  -              -  -  -  -  -",
                "         M     M    M                    ",
                "--------------               -------------",
                "             @                            ",
                "            *  *  *     *  *              ",
                "               |     |   A |    *         ",
                "               |           |              ",
                "               |     |   A |              " };

string[] roadL3 = {
                "               |            |             ",
                "               |  W  |      |             ",
                "          *    |  W         |             ",
                "                  * *|* * *               ",
                "                              @           ",
                "--------------               -------------",
                "               B                          ",
                "  -  -  -  -  -              -  -  -  -  -",
                "              M    M      M               ",
                "--------------               -------------",
                "             @                            ",
                "              *  * *  * *                 ",
                "               |     |   A |    *         ",
                "               |           |              ",
                "               |     |   A |              " };

string[] roadL4 = {
                "               |            |             ",
                "               |  W  |      |             ",
                "          *    |  W         |             ",
                "          *  *   *   |      * *           ",
                "                              @           ",
                "--------------               -------------",
                "   B                                      ",
                "  -  -  -  -  -              -  -  -  -  -",
                "                            M   M      M  ",
                "--------------               -------------",
                "             @                            ",
                "             *  *         *  * *          ",
                "               |     |   A |    *         ",
                "               |           |              ",
                "               |     |   A |              " };

void goLeft()
{
    Console.Clear();
    printLeft(roadL);
    Thread.Sleep(1000);
    Console.Clear();

    printLeft(roadL1);
    Thread.Sleep(1000);
    Console.Clear();

    printLeft(roadL2);
    Thread.Sleep(1000);
    Console.Clear();

    printLeft(roadL3);
    Thread.Sleep(1000);
    Console.Clear();

    printLeft(roadL4);
    Thread.Sleep(1000);
    Console.Clear();

    printLeft(roadL);
}

void printLeft(String[] s)
{
    for (int i = 0; i < s.Length; i++)
    {
        if (i == 4)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s[i]);
            Console.ForegroundColor = ConsoleColor.White;
        }
        
        else if (i == 10)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s[i]);
            Console.ForegroundColor = ConsoleColor.White;
        }
        else { Console.WriteLine(s[i]); }
    }
    Console.WriteLine();
}



string[] roadRgame1 = {
                "               |            |             ",
                "               |  W  |      |     ?       ",
                "          *    |  W         |  <----      ",
                "          * *  |     |      |  * * *      ",
                "                              @           ",
                "--------------               -------------",
                "                                  B       ",
                "  -  -  -  -  -              -  -  -  -  -",
                "   M  M  M                                ",
                "--------------               -------------",
                "             @                            ",
                "        * * *  |           |  * *         ",
                "       ---->   |     |   A |    *         ",
                "         ?     |           |              ",
                "               |     |   A |              "  };

string[] roadRgameWin1 = {
                "               |            |             ",
                "               |     |      |     ?       ",
                "               |  W         |  <----      ",
                "            *  |     |      |  * * *      ",
                "                              @           ",
                "--------------    W          -- * --------",
                "           *      |      ^        B       ",
                "  -  -  -  -  -   |      |   -  -  -  -  -",
                "   M  M  M *      V      |      *         ",
                "--------------           A   -------------",
                "             @                            ",
                "        * * *  |           |  *           ",
                "       ---->   |     |   A |              ",
                "         ?     |           |              ",
                "               |     |     |              "  };

string[] roadRgameLose1 = {
                "               |            |             ",
                "               |  W  |      |     ?       ",
                "          *    |  W         |  <----      ",
                "          * *  |     |      |  * * *      ",
                "                              @           ",
                "--------------    |          -------------",
                "                  |               B       ",
                "  -  -  -  -  -   V      ^   -  -  -  -  -",
                "   M  M  M               |                ",
                "--------------           |   -------------",
                "             @           *  <----         ",
                "               |       **A*|    *         ",
                "       ---->   |     |   A |    *         ",
                "         ?     |           |              ",
                "               |     |   A |              "  };

string[] roadRgame2 = {
                "               |            |             ",
                "       |       |  W  |      |        |    ",
                "       |  *    |  W         |    *   |    ",
                "       V  * *  |     |      |  * * * V    ",
                "                              @           ",
                "--------------               -------------",
                "                                  B       ",
                "  -  -  -  -  -              -  -  -  -  -",
                "   M  M  M                                ",
                "--------------               -------------",
                "             @                            ",
                "        * * *  |           |  * *         ",
                "               |     |   A |    *         ",
                "               |           |              ",
                "               |     |   A |              "  };

string[] roadRgameWin2 = {
                "               |            |             ",
                "       |       |  W  |      |        |    ",
                "       |       |  W         |        |    ",
                "       V    *  |     |      |  *   * V    ",
                "                              @           ",
                "--------------               -------------",
                "           *                     * B      ",
                "  -  -  -  -  -              -  -  -  -  -",
                "   M  M  M *                     *        ",
                "--------------               -------------",
                "             @                            ",
                "        * * *  |           |  * *         ",
                "               |     |   A |    *         ",
                "               |           |              ",
                "               |     |   A |              "  };

string[] roadLgame3 = {
                "               |            |             ",
                "               |  W  |      |    ?        ",
                "          *    |  W         |  <----      ",
                "          * *  |     |      |  * * *      ",
                "                              @           ",
                "--------------               -------------",
                "                                  B       ",
                "  -  -  -  -  -              -  -  -  -  -",
                "   M  M  M                                ",
                "--------------               -------------",
                "             @                            ",
                "        * * *  |           |  * *         ",
                "       ---->   |     |   A |    *         ",
                "         ?     |           |              ",
                "               |     |   A |              "  };

string[] roadLgameWin3 = {
                "               |            |             ",
                "               |  W  |      |    ?        ",
                "          *    |  W         |  <----      ",
                "          * *  |   * | *  * |             ",
                "                              @           ",
                "--------------               -------------",
                "             <---          B              ",
                "  -  -  -  -  -              -  -  -  -  -",
                "          M       M       M    --->       ",
                "--------------               -------------",
                "             @                            ",
                "               |  ** *  ** |              ",
                "       ---->   |     |   A |    *         ",
                "         ?     |           |              ",
                "               |     |   A |              "  };

string[] roadLgame4 = {
                "               |            |             ",
                "       |       |  W  |      |             ",
                "       |  *    |  W         |             ",
                "       V  * *  |     |      |  * * *      ",
                "                              @           ",
                "--------------               -------------",
                "                                  B       ",
                "  -  -  -  -  -              -  -  -  -  -",
                "   M  M  M                                ",
                "--------------               -------------",
                "             @                     ^      ",
                "        * * *  |           |  * *  |      ",
                "               |     |   A |    *  |      ",
                "               |           |              ",
                "               |     |   A |              "  };

string[] roadLgameLose4 = {
                "               |            |             ",
                "       |       |  W  |      |             ",
                "       |       |  W         |             ",
                "       V    *  |     |      |  * * *      ",
                "                              @           ",
                "---------- * -               -------------",
                "    <---            B                     ",
                "  -  -  -  -  -              -  -  -  -  -",
                "                 M        M     M* --->   ",
                "--------------               --- * -------",
                "             @                     ^      ",
                "        * * *  |           |  *    |      ",
                "               |     |   A |       |      ",
                "               |           |              ",
                "               |     |   A |              "  };

string[] roadRgameWin4 = {
                "               |            |             ",
                "       |       |  W  |      |             ",
                "       |  *    |  W         |             ",
                "       V  * *  |     |      |  * * *      ",
                "                              @           ",
                "--------------               -------------",
                "           <---      B                    ",
                "  -  -  -  -  -              -  -  -  -  -",
                "       M        M        M     --->       ",
                "--------------               -------------",
                "             @                            ",
                "        * * *  |           |  * *  ^      ",
                "               |     |   A |    *  |      ",
                "               |           |       |      ",
                "               |     |   A |              "  };

string[] roadRgame5 = {
                "               |            |             ",
                "      |        |  W  |      |             ",
                "      |   *    |  W         |    *        ",
                "      V   * *  |     |      |  * *        ",
                "                              @           ",
                "--------------               -------------",
                "                                  B       ",
                "  -  -  -  -  -              -  -  -  -  -",
                "   M  M  M                                ",
                "--------------               -------------",
                "             @                            ",
                "        * * *  |           |    *  ^      ",
                "               |     |   A |    *  |      ",
                "               |           |       |      ",
                "               |     |   A |              "  };

string[] roadRgameWin5 = {
                "               |            |             ",
                "      |        |     |   ^  |             ",
                "      |   *    |  W      |  |    *        ",
                "      V   * *  |     |   |  |  * *        ",
                "                              @           ",
                "--------------    W      A   -------------",
                "                                  B       ",
                "  -  -  -  -  -   |          -  -  -  -  -",
                "   M  M  M        |                       ",
                "--------------    V      A   -------------",
                "             @                            ",
                "        * * *  |           |    *  ^      ",
                "               |     |     |    *  |      ",
                "               |           |       |      ",
                "               |     |     |              "  };


Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n\tДвижение по правилам дорожного движения выглядит так:");
Console.ForegroundColor = ConsoleColor.White;
Thread.Sleep(2000);
int count = 0;
while (count < 1)
{
    Thread.Sleep(2000);
    goRight();
    goLeft();
    count++;
}

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(" Хотите сыграть в игру 'ПЕШЕХОД' ? ");
Console.WriteLine(" ПРАВИЛА ИГРЫ : сделайте выбор, идти пешеходу в направлении стрелки или нет");
Console.WriteLine(" Если пешеход попадет под машину - вы проиграли.");
Console.WriteLine(" Ваш выбор (1 - да, 2 - нет)");
Console.ForegroundColor = ConsoleColor.White;
int choice = int.Parse(Console.ReadLine());
int choiceGame = 0, countGame = 0, point = 0, time = 2000;


switch (choice)
{
    case 1:
        {
            Console.WriteLine("Для выхода из игры введите '0'");
            Console.WriteLine("У Вас 5 попыток!");
            Console.WriteLine("ГОТОВЫ ? (если да, нажмите любую кнопку,  нет - нажмите  0)");
            choiceGame = int.Parse(Console.ReadLine());

            while (countGame < 5)
            {
                Console.Clear();
                Console.WriteLine("\t\tРАУНД  1");
                printRight(roadRgame1);
                Thread.Sleep(time);
                Console.Clear();
                Console.WriteLine("Ваш выбор (1 - идти, 2 - не идти)");
                choiceGame = int.Parse(Console.ReadLine());
                if (choiceGame == 1)
                {
                    printRight(roadRgameLose1);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Пешехода СБИЛИ!!!");
                    Console.WriteLine("ВЫ ПРОИГРАЛИ");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                if (choiceGame == 2)
                {
                    printRight(roadRgameWin1);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("ПРАВИЛЬНО!     Пешеходы остались живы!!!");
                    Thread.Sleep(time);
                    Console.ForegroundColor = ConsoleColor.White;
                    countGame++;
                    point++;
                }
                


                Console.Clear();
                Console.WriteLine("\t\tРАУНД  2");
                printRight(roadRgame2);
                Thread.Sleep(time);
                Console.Clear();
                Console.WriteLine("Ваш выбор (1 - идти, 2 - не идти)");
                choiceGame = int.Parse(Console.ReadLine());
                if (choiceGame == 1)
                {
                    printRight(roadRgameWin2);
                    Thread.Sleep(time);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("ПРАВИЛЬНО!       Пешеходы остались живы!!!");
                    Thread.Sleep(time);
                    Console.ForegroundColor = ConsoleColor.White;
                    countGame++;
                    point++;
                }
                if (choiceGame == 2)
                {
                    printRight(roadRgameWin2);
                    Thread.Sleep(time);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("НЕ  ПРАВИЛЬНО.      Пешеходам МОЖНО переходить!!!");
                    Console.WriteLine("ВЫ НЕ угадали");
                    Thread.Sleep(time);
                    Console.ForegroundColor = ConsoleColor.White;
                    countGame++;
                }

                Console.Clear();
                Console.WriteLine("\t\tРАУНД  3");
                printLeft(roadLgame3);
                Thread.Sleep(time);
                Console.Clear();
                Console.WriteLine("Ваш выбор (1 - идти, 2 - не идти)");
                choiceGame = int.Parse(Console.ReadLine());
                if (choiceGame == 1)
                {
                    printLeft(roadLgameWin3);
                    Thread.Sleep(time);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("ПРАВИЛЬНО!       Пешеходы остались живы!!!");
                    Thread.Sleep(time);
                    Console.ForegroundColor = ConsoleColor.White;
                    countGame++;
                    point++;
                }
                if (choiceGame == 2)
                {
                    printLeft(roadLgameWin3);
                    Thread.Sleep(time);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("НЕ  ПРАВИЛЬНО.      Пешеходам МОЖНО переходить!!!");
                    Console.WriteLine("ВЫ НЕ угадали");
                    Thread.Sleep(time);
                    Console.ForegroundColor = ConsoleColor.White;
                    countGame++;
                }

                Console.Clear();
                Console.WriteLine("\t\tРАУНД  4");
                printLeft(roadLgame4);
                Thread.Sleep(time);
                Console.Clear();
                Console.WriteLine("Ваш выбор (1 - идти, 2 - не идти)");
                choiceGame = int.Parse(Console.ReadLine());
                if (choiceGame == 1)
                {
                    printLeft(roadLgameLose4);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Пешехода СБИЛИ!!!");
                    Console.WriteLine("ВЫ ПРОИГРАЛИ");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                if (choiceGame == 2)
                {
                    printLeft(roadRgameWin4);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("ПРАВИЛЬНО!     Пешеходы остались живы!!!");
                    Thread.Sleep(time);
                    Console.ForegroundColor = ConsoleColor.White;
                    countGame++;
                    point++;
                }


                Console.Clear();
                Console.WriteLine("\t\tРАУНД  5");
                printRight(roadRgame5);
                Thread.Sleep(time);
                Console.Clear();
                Console.WriteLine("Ваш выбор (1 - идти, 2 - не идти)");
                choiceGame = int.Parse(Console.ReadLine());
                if (choiceGame == 1)
                {
                    printRight(roadRgameWin5);
                    Thread.Sleep(time);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("ПРАВИЛЬНО!       Пешеходы остались живы!!!");
                    Thread.Sleep(time);
                    Console.ForegroundColor = ConsoleColor.White;
                    countGame++;
                    point++;
                }
                if (choiceGame == 2)
                {
                    printRight(roadRgameWin5);
                    Thread.Sleep(time);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("НЕ  ПРАВИЛЬНО.      Пешеходам МОЖНО переходить!!!");
                    Console.WriteLine("ВЫ НЕ угадали");
                    Thread.Sleep(time);
                    Console.ForegroundColor = ConsoleColor.White;
                    countGame++;
                }
                Console.WriteLine($"Вы набрали  {point} очков ");

                if (choiceGame == 0) { break; }

            }
        }
        break;
    case 2:  break;

    default: Console.WriteLine("Некорректный выбор"); break;
}

