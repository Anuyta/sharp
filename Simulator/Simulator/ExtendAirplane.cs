using SimulatorLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    /// <summary>
    /// Метод для обработки клавиш управления и изменения соответствующих параметров 
    /// </summary>
    static class ExtendAirplane
    {
        /// <summary>
        /// Метод, который позволяет изменять характеристики высоты и скорости
        /// </summary>
        /// <param name="plane"></param>
        public static void FlightControl(this Airplane plane)
        {        
            Console.WriteLine("\nНажмите клавишу управления");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();
            if (keyInfo.Modifiers.ToString() != "0" && keyInfo.Modifiers == ConsoleModifiers.Shift)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.RightArrow: plane.Speed += 150;
                        break;
                    case ConsoleKey.LeftArrow: plane.Speed -= 150;
                        break;
                    case ConsoleKey.UpArrow: plane.Height += 500;
                        break;
                    case ConsoleKey.DownArrow: plane.Height -= 500;
                        break;
                    default: throw new AppException("Нажата неверная клавиша");
                }
            }
            else
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.RightArrow: plane.Speed += 50;
                        break;
                    case ConsoleKey.LeftArrow: plane.Speed -= 50;
                        break;
                    case ConsoleKey.UpArrow: plane.Height += 250;
                        break;
                    case ConsoleKey.DownArrow: plane.Height -= 250;
                        break;
                    default: throw new AppException("Нажата неверная клавиша");
                }
            }
            
        }

        /// <summary>
        /// Метод отображающий на экран кол-во штрафных очков от каждого диспетчера
        /// </summary>
        /// <param name="plane"></param>
        public static void ShowPenalty(this Airplane plane)
        {
            for (int i = 0; i < plane.Dispatcher.Count; i++)
            {
                Console.WriteLine("{0} - penalty: {1}", plane.Dispatcher[i].Name, plane.Dispatcher[i].Penalty);
            }
        }
    }
}
