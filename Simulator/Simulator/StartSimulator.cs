using SimulatorLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    static class StartSimulator
    {
        #region FIELDS
        static bool takeOff; //взлёт
        static bool landing; //возможность посадки
        static Airplane airplane;
        static Dispatcher disp1;
        static Dispatcher disp2;
        #endregion

        #region CONSTRUCTOR
        static StartSimulator()
        {
            takeOff = false;
            landing = false;
            airplane = new Airplane();
            disp1 = new Dispatcher("disp1");
            disp2 = new Dispatcher("disp2");
            airplane.Dispatcher.Add(disp1);
            airplane.Dispatcher.Add(disp2);
            airplane.updateSpeed += disp1.GetRecommendedHeight;
            airplane.updateHeight += disp1.GetRecommendedHeight;
            airplane.updateSpeed += disp2.GetRecommendedHeight;
            airplane.updateHeight += disp2.GetRecommendedHeight;
        }
        #endregion

        #region METHODS
        public static void Start()
        {
            try
            {
                if (airplane.Dispatcher.Count < 2)
                    throw new AppException("Самолёт не может взлететь, недостаточно диспетчеров для навигации полёта ");
                else
                {
                    ShowRules();
                    airplane.Speed = 0;
                    airplane.Height = 0;
                    Console.WriteLine("Самолёт готов к взлёту!\nКоличество диспетчеров = {0}, начальная скорость = {1}, начальная высота = {2}", airplane.Dispatcher.Count, airplane.Speed, airplane.Height);                    
                }

                bool check = true;
                while (check == true)
                {
                    int pointMenu = Menu();
                    switch (pointMenu)
                    {
                        case 1: Console.WriteLine("Введите имя диспетчера");
                            string disp = Console.ReadLine();
                            Dispatcher disp3 = new Dispatcher(disp);
                            airplane.Dispatcher.Add(disp3);
                            Console.WriteLine("Диспетчер добавлен");
                            airplane.updateSpeed += disp3.GetRecommendedHeight;
                            airplane.updateHeight += disp3.GetRecommendedHeight;
                            break;
                        case 2:
                            {
                                if (airplane.Dispatcher.Count == 2)
                                {
                                    Console.WriteLine("Для навигации полёта необходимо минимум 2 диспетчера");
                                    break;
                                }                                    
                                Console.WriteLine("Введите имя диспетчера");
                                string dispDel = Console.ReadLine();
                                int index = airplane.Dispatcher.IndexOf(airplane.Dispatcher.Find(e => e.Name.Equals(dispDel) == true));
                                if (index != -1)
                                {
                                    airplane.AllPenalty += airplane.Dispatcher[index].Penalty;
                                    airplane.Dispatcher.RemoveAt(index);
                                    Console.WriteLine("Диспетчер удален! штрафные баллы сохранены!");
                                }
                                else
                                    Console.WriteLine("Введенный диспетчер не найден");
                            }
                            break;
                        case 3:
                            if (StartSimulator.Flight(airplane) == false)
                                check = false;
                            break;
                        case -1: throw new AppException("Нажата неверная клавиша");
                    }
                }                
                
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);                
            }            
        }

        /// <summary>
        /// Главный метод полёта.
        /// Для взлёта необходимо набрать скорость 50 км/ч и высоту 250 м!
        /// Когда скорость превысит 50 км/ч диспетчера начнут управлять самолётом!
        /// </summary>
        /// <param name="airplane"></param>
        /// <returns>true - если самолёт еще не набрал максимальную скорость (1000 км/ч), false - если набрал</returns>
        private static bool Flight(Airplane airplane)
        {
            airplane.FlightControl();
            if (takeOff == false && airplane.Speed < 50 & airplane.Height > 0)
                throw new AppException("Нельзя взлететь, не набрав минимальную скорость 50 км/ч");
            airplane.ChangeStat();
            if (takeOff == true)
            {
                string mes = string.Empty;
                for (int i = 0; i < airplane.Dispatcher.Count; i++)
                    airplane.Dispatcher[i].SetPenalty(airplane.Height, airplane.Speed, ref mes);
                if (string.IsNullOrEmpty(mes) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(mes);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                airplane.ShowPenalty();
            }            
            Console.WriteLine("\n**********************************************");
            Console.WriteLine(airplane);
            if (landing == false & ((airplane.Speed >= 50 & airplane.Speed <= 150) & airplane.Height == 0))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Наберите высоту! Иначе самолёт разобьется!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (landing == true && airplane.Speed == 0 & airplane.Height == 0)
            {
                Console.WriteLine("Самолёт полностью остановлен!");
                CharactPilot(airplane);
                return false;
            }
            else if (landing == true & airplane.Speed == 50)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Самолёт приземляется, диспетчеры больше его не контролируют!");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 0; i < airplane.Dispatcher.Count; i++)
                {
                    airplane.updateSpeed -= airplane.Dispatcher[i].GetRecommendedHeight;
                    airplane.updateHeight -= airplane.Dispatcher[i].GetRecommendedHeight;
                }
            }
            else if (airplane.Speed >= 50 & airplane.Height > 0)
            {                
                airplane.ChangeStat();
                for (int i = 0; i < airplane.Dispatcher.Count; i++)
                    Console.WriteLine(airplane.Dispatcher[i]);                

                if (airplane.Speed >= 1000)
                    landing = true;
                
                takeOff = true;                       
            }
            if (landing == true & ((airplane.Speed >= 50 & airplane.Speed <= 150) & airplane.Height != 0))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Снизьте высоту! Иначе самолёт разобьется!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return true;
        }

        /// <summary>
        /// Отображает правила тренажёра
        /// </summary>
        private static void ShowRules()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Управление происходит клавишами-стрелками:");
            Console.WriteLine("Для изменения скорости");
            Console.WriteLine("Right (+50км/ч)");
            Console.WriteLine("Left (-50км/ч)");
            Console.WriteLine("shift + Right (+150км/ч)");
            Console.WriteLine("shift + Left (-150км/ч)");
            Console.WriteLine("Для изменения высоты");
            Console.WriteLine("Up (+250м)");
            Console.WriteLine("Down (-250м)");
            Console.WriteLine("shift + Up (+500м)");
            Console.WriteLine("shift + Down (-500м)");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Метод, моделирующий меню
        /// </summary>
        /// <returns>пункт меню или -1, если пользователь ввёл неверный символ</returns>
        private static int Menu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1.Добавить диспетчера");
            Console.WriteLine("2.Удалить диспетчера");
            Console.WriteLine("3.Начать/продолжить полёт");
            Console.ForegroundColor = ConsoleColor.White;
            int choise;
            if (Int32.TryParse(Console.ReadLine(), out choise))
                return choise;
            else
                return - 1;
        }

        /// <summary>
        /// Метод выдающий характеристику пилоту после удачного прохождения тренажёра
        /// </summary>
        /// <param name="plane"></param>
        private static void CharactPilot(Airplane plane)
        {
            for (int i = 0; i < plane.Dispatcher.Count; i++)
                plane.AllPenalty += plane.Dispatcher[i].Penalty;
            Console.WriteLine("Общее кол-во штрафных баллов = {0}", plane.AllPenalty);
            if (plane.AllPenalty <= 1000)            
                Console.WriteLine("Пилот блестяще справился со своей задачей!");
            else if (plane.AllPenalty > 1000 & plane.AllPenalty <= 1500)
                Console.WriteLine("Пилот хорошо справился со своей задачей!");
            else 
                Console.WriteLine("Пилот справился со своей задачей, но ему необходимо больше практики!");
        }
        #endregion
    }
}
