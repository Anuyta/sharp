using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorLib
{
    public class Dispatcher
    {
        #region FIELDS
        private string name;
        private int n; //коэффициент погоды
        private int hp; //рекомендуемая высота
        private int penalty; //штраф
        #endregion

        #region PROPERTIES
        public int Penalty
        {
            get 
            {
                if (penalty > 1000)
                    throw new AppException("пилот непригоден к полетам!");
                return penalty; 
            }
        }

        public string Name
        {
            get { return name; }
        }
        #endregion

        #region CONSTRUCTORS
        public Dispatcher(string name)
        {
            this.name = name;
            this.n = Randomer.Next(-200, 200);
            this.penalty = 0;
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Метод, моделирующий пересчет рекомендуемой высоты диспетчерами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GetRecommendedHeight(Object sender, EventArgs e)
        {
            Airplane plane = (Airplane)sender;
            if (plane.Speed <= 0)
                throw new AppException("Самолёт разбился! Скорость <= 0");
            if (plane.Height <= 0)
                throw new AppException("Самолёт разбился! Высота <= 0");
            hp = 7 * plane.Speed - n;
        }        

        /// <summary>
        /// Метод, моделирующий начисление штрафов нерадивому пилоту
        /// </summary>
        /// <param name="height">текущая высота полёта</param>
        /// <param name="speed">текущая скорость полёта</param>
        /// <param name="mes">ссылочная переменная, для передачи сообщения, если пилот превысит скорость больше максимальной (1000 км/ч)</param>
        public void SetPenalty(int height, int speed, ref string mes)
        {
            if (speed > 1000)
            {
                penalty += 100;
                mes = "Немедленно снизьте скорость!";
            }
            int delta = Math.Abs(hp - height);
            if (delta >= 300 && delta <= 600)
                penalty += 25;
            else if (delta >= 600 && delta <= 1000)
                penalty += 50;
            else if (delta > 1000)
                throw new AppException("Самолёт разбился! Разница между рекоммендуемой и текущей высотами > 1000");
        }

        public override string ToString()
        {
            return string.Format("Диспетчер {0}, рекомендуемая высота {1}", name, hp);
        }
        #endregion
    }
}
