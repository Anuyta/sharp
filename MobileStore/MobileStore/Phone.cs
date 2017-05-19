using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore
{
    [Serializable]
    public class Phone
    {
        #region FIELDS
        private string model;
        private decimal price;
        private string os;
        private string proc;
        private string pathPicture;
        private List<Options> options;
        #endregion

        #region PROPERTIES
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Os
        {
            get { return os; }
            set { os = value; }
        }

        public string Proc
        {
            get { return proc; }
            set { proc = value; }
        }

        public string PathPicture
        {
            get { return pathPicture; }
            set { pathPicture = value; }
        }

        public List<Options> Options
        {
            get { return options; }
            set { options = value; }
        }
        #endregion

        public override string ToString()
        {
            return string.Format("{0}. {1} - {2}. Цена {3}", Model, Os, Proc, Price);
        }
    }
}
