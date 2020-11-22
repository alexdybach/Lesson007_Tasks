using System;
using System.Text;

namespace Lesson007_Task2
{
    class Program
    {
        static void Exit(int passengerCount, ref int freeSeats)
        {
            freeSeats += passengerCount;
            if (freeSeats >= 21)
            {
                freeSeats = 21;
                Console.WriteLine("Маршрутка порожня!");
            }
            else
                Console.WriteLine($"Залишилося вільних місць: {freeSeats}");
        }
        static void Enter(int passengerCount, ref int freeSeats)
        {
            if (passengerCount > freeSeats)
            {
                Console.WriteLine("Вільних місць не достатньо! Всі не зможуть зайти");
                //passengerCount = freeSeats;
            }
            int[] fare = new int[passengerCount];
            bool[] benefits = new bool[passengerCount];

            Console.WriteLine("Оплатіть проїзд!\nВартість без пільг = 7 грн.; з пільгами = 3 грн.");
            int b;


            //while (freeSeats > 0 || i < passengerCount)
            for (int i = 0; i < passengerCount; i++)
            {
                if (freeSeats > 0)
                {
                    Console.Write($"{i + 1})\t");
                    Console.WriteLine("Пільги?\nТак = 1 / Ні = 0");
                    b = int.Parse(Console.ReadLine());
                    if (b == 1)
                        benefits[i] = true;
                    else if (b == 0)
                        benefits[i] = false;
                    else
                        Console.WriteLine("Error!");
                    Console.WriteLine("Оплата :");
                    fare[i] = int.Parse(Console.ReadLine());
                    if ((benefits[i] == true && fare[i] == 3) || (benefits[i] == false && fare[i] == 7))
                    {
                        freeSeats--;
                        Console.WriteLine($"Вільних місць залишилось: {freeSeats}");
                    }
                    else
                    {
                        Console.WriteLine("Оплата не вірна! В маршрутку не допущено!");
                    }
                }
                else
                    Console.WriteLine($"Вільних місць не залишилось!");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int stopCount = 5;
            int stop = 1;
            int option;
            int freeSeats = 21;
            int passengerCount;

            Console.WriteLine("Введіть початкову к-сть людей в маршрутці (<=21):");
            freeSeats -= int.Parse(Console.ReadLine());
            Console.WriteLine($"Вільних місць залишилось: {freeSeats}");

            while (stop <= stopCount)
            {
                while (true)
                {
                    Console.WriteLine($"Зупинка  *{stop}*\nВисадка(1)/Посадка(2):");
                    option = int.Parse(Console.ReadLine());

                    if (option == 1 || option == 2)
                        break;
                }
                switch (option)
                {
                    case 1:
                        {
                            if (freeSeats < 21)
                            {
                                Console.Write($"Людей в маршрутці = {21 - freeSeats}\nВиходять : ");
                                passengerCount = int.Parse(Console.ReadLine());
                                Exit(passengerCount, ref freeSeats);
                            }
                            else
                                Console.WriteLine("Маршрутка порожня!");
                            break;
                        }
                    case 2:
                        {
                            if (freeSeats > 0)
                            {
                                Console.WriteLine($"Вільних місць залишилось: {freeSeats}\nЗаходять : ");
                                passengerCount = int.Parse(Console.ReadLine());
                                Enter(passengerCount, ref freeSeats);
                            }
                            break;
                        }
                }
                stop++;
            }
            Console.WriteLine("\t* КІНЕЦЬ МАРШРУТУ *");
        }
    }
}
