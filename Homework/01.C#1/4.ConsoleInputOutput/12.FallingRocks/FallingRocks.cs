//like cars

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

struct Rock
{
    public int x;
    public int y;
    public string s;   
    public ConsoleColor color;
}
class FallingRocks
{    
    static void PrintStringOnPosition(int x, int y, string str, ConsoleColor color = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(str);
    }

    static void Main()
    {        
        int playfieldWidth = 15;
        int livesCount = 5;
        int score = 0;
        Console.BufferHeight = Console.WindowHeight = 20;
        Console.BufferWidth = Console.WindowWidth = 50;
        Rock dwarf = new Rock();
        dwarf.x = 2;
        dwarf.y = Console.WindowHeight - 1;
        dwarf.s = "0";
        dwarf.color = ConsoleColor.White;
        Random randomGenerator = new Random();        
        List<Rock> rocks = new List<Rock>();

        while (true)
        {
            bool hitten = false;
            { 
                Rock newRock = new Rock();
                newRock.color = ConsoleColor.Green;
                newRock.x = randomGenerator.Next(0, playfieldWidth);
                newRock.y = 0;
                newRock.s = "+"; 
                rocks.Add(newRock);
            }

            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);                
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.x - 1 >= 0) dwarf.x--;
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.x + 1 <= playfieldWidth) dwarf.x++;
                }
            }
            List<Rock> newList = new List<Rock>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Rock oldRock = rocks[i];
                Rock newRock = new Rock();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.s = oldRock.s;
                newRock.color = oldRock.color;
                
                if (newRock.x == dwarf.x && newRock.y == dwarf.y)
                {
                    livesCount--;
                    hitten = true;                    
                    if (livesCount <= 0)
                    {
                        PrintStringOnPosition(20, 10, "GAME OVER!", ConsoleColor.Red);
                        PrintStringOnPosition(20, 12, "Press [enter] to exit", ConsoleColor.Red);
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }
                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                }
            }
            rocks = newList;
            Console.Clear();
            foreach (Rock rock in rocks)
            {
                PrintStringOnPosition(rock.x, rock.y, rock.s, rock.color);
            }
            if (hitten)
            {
                rocks.Clear();
                PrintStringOnPosition(dwarf.x, dwarf.y, "X", ConsoleColor.Red);
            }
            else
            {
                score++;
                PrintStringOnPosition(dwarf.x, dwarf.y, dwarf.s, dwarf.color);                
            }
            PrintStringOnPosition(30, 5, "Lives:" + livesCount, ConsoleColor.Red);
            PrintStringOnPosition(30, 6, "Score:" + score, ConsoleColor.Red);
            Thread.Sleep(250);
        }
    }
}

