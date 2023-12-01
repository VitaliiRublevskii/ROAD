
/*
void sv (int time = 2000)
{
    while (true)
    {
        char w = char.Parse(Console.ReadLine());
        if (w == 'w')
            time = 0;
        Console.Clear();
        Thread.Sleep(time);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Red");

        Console.ReadLine();
        if (w == 'w')
            time = 0;
        Console.Clear();
        Thread.Sleep(time);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Yellow");

        Console.ReadLine();
        if (w == 'w')
            time = 0;
        Console.Clear();
        Thread.Sleep(time);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Green");
        Console.ForegroundColor = ConsoleColor.White;

        Console.ReadLine();
        if (w == 'w')
            time = 0;
        Console.Clear();
        Thread.Sleep(time);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Yellow");
    }
}

sv();
*/



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
        else { Console.WriteLine(s[i]); }

    }
    Console.WriteLine ();
}

goRight();





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


        if (i == 10)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s[i]);
            Console.ForegroundColor = ConsoleColor.White;
        }
        else { Console.WriteLine(s[i]); }

    }
    Console.WriteLine();
}

goLeft();







//  int at = roadR[4].IndexOf("@", roadR.Length);