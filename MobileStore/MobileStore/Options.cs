using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore
{
    [Serializable]
    public class Options
    {
        #region FIELDS
        private string name;
        #endregion

        #region PROPERTIES
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion

        public override string ToString()
        {
            return Name;
        }

        public new bool Equals(object obj)
        {
            return name.Equals(((Options)obj).Name); 
        }
    }
}
