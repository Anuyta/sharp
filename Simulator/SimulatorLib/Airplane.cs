using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulatorLib
{
    public class Airplane
    {
        #region FIELDS
        private int speed;
        private int height;
        private List<Dispatcher> dispatcher;
        private int allPenalty;
        public event EventHandler updateSpeed;
        public event EventHandler updateHeight;
        #endregion

        #region PROPERTIES
        public int AllPenalty
        {
            get { return allPenalty; }
            set { allPenalty = value; }
        }       

        public List<Dispatcher> Dispatcher
        {
            get { return dispatcher; }
            set { dispatcher = value; }
        }        

        public int Speed
        {
            get 
            {
                if (speed > 150 & height == 0)
                    throw new AppException("Самолёт разбился при взлёте, т.к. не набрал минимальную высоту!");
                return speed; 
            }
            set { speed = value; }
        }
        public int Height
        {
            get 
            {
                if (speed == 0 & height > 0)
                    throw new AppException("Самолёт разбился при посадке, т.к. не снизил высоту до нуля!");
                return height; 
            }
            set { height = value; }
        }
        #endregion

        #region CONSTRUCTORS
        public Airplane()
        {            
            this.dispatcher = new List<Dispatcher>();
            this.allPenalty = 0;
        }
        #endregion

        #region METHODS
        /// <summary>
        /// Метод генерирующий событие
        /// </summary>
        protected virtual void Update()
        {
            if (updateSpeed != null)
                updateSpeed(this, EventArgs.Empty);
            if (updateHeight != null)
                updateHeight(this, EventArgs.Empty);
        }

        /// <summary>
        /// Вызов метода, генерирующего событие
        /// </summary>
        public void ChangeStat()
        {
            if ((speed >= 50 & height > 0) | (speed <= 0 & height > 0))
                Update();
        }

        public override string ToString()
        {
            return string.Format("текущая скорость = {0}, текущая высота = {1}", speed, height);
        }
        #endregion METHODS
    }
}
