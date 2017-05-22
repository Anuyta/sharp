using LogerApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Game game = new Game(2, "Trys", "Byvalyi");
                //game.Start();

                Game game = new Game(3, "Trys", "Byvalyi", "Balbes");
                game.Start();                

                //Game game = new Game(4, "Trys", "Byvalyi", "Balbes", "Necto");
                //game.Start();                

                Logger.Write(Environment.UserName, System.Reflection.MethodBase.GetCurrentMethod().Name, TypeAction.End, "Игра Окончена!");

                Console.Read();
            }
            catch (GameExceptions ex)
            {
                Console.WriteLine(ex.Message);
                Logger.Write(Environment.UserName, System.Reflection.MethodBase.GetCurrentMethod().Name, TypeAction.Exception, ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Logger.Write(Environment.UserName, System.Reflection.MethodBase.GetCurrentMethod().Name, TypeAction.Exception, ex.Message);                
            }
        }
    }
}
