using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int TARGET_SNAKE_LENGTH;
            int result;

            TARGET_SNAKE_LENGTH = 10;

            Console.SetBufferSize(80, 25);
            
            Walls walls = new Walls(80, 25);
            walls.Draw();

            ShowMenu();

            while (true)
            {
                ConsoleKeyInfo action = Console.ReadKey();
                if (action.Key == ConsoleKey.S)
                {
                    Console.Clear();
                    walls.Draw();
                    result = 0;

                    Point p = new Point(40, 12, '*');
                    Snake snake = new Snake(p, 5, Direction.LEFT);
                    snake.Draw();

                    FoodCreator foodCreator = new FoodCreator(80, 25, '&');
                    Point food = foodCreator.CreateFood();
                    food.Draw();

                    while (true)
                    {

                        if (walls.IsHit(snake) || snake.IsHitTail())
                        {
                            result = 0;
                            break;
                        }
                        if (snake.GetLength() >= TARGET_SNAKE_LENGTH)
                        {
                            result = 1;
                            break;
                        }
                        if (snake.Eat(food))
                        {
                            food = foodCreator.CreateFood();
                            food.Draw();
                        }
                        else
                        {
                            snake.Move();
                        }

                        Thread.Sleep(300);

                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo key = Console.ReadKey();
                            snake.HandleKey(key.Key);
                        }              
                    }
                    Console.Clear();
                    walls.Draw();
                    ShowMenu();
                    if (result==1)
                        ShowMessage("ПОЗДРАВЛЯЕМ! ВЫ ВЫИГРАЛИ.");
                    else 
                        ShowMessage("ВЫ ПРОИГРАЛИ. ПОПРОБУЙТЕ ЕЩЁ РАЗ.");
                }
                else if (action.Key == ConsoleKey.E)
                {
                    break;
                }
            }

            
/*
            Console.SetCursorPosition(32, 12);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===============");
            Console.SetCursorPosition(33, 13);
            Console.WriteLine("ИГРА ОКОНЧЕНА");
            Console.SetCursorPosition(32, 14);
            Console.WriteLine("===============");
            Console.ReadLine();
            */
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(32, 12);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===============");
            Console.SetCursorPosition(34, 13);
            Console.WriteLine("ИГРА ЗМЕЙКА");
            Console.SetCursorPosition(34, 14);
            Console.WriteLine("S - Старат");
            Console.SetCursorPosition(34, 15);
            Console.WriteLine("E - Выход");
            Console.SetCursorPosition(32, 16);
            Console.WriteLine("===============");
        }

        static void ShowMessage(String mes)
        {
            Console.SetCursorPosition(25, 5);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mes);
        }

    }
}
