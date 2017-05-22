using Autorization.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autorization.Entities
{
    [Serializable]
    public class User
    {
        #region FIELDS
        private string name;
        private string surname;
        private string log;
        private string pass;
        private string email;
        #endregion        

        #region PROPERTIES
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Log
        {
            get { return log; }
            set { log = value; }
        }

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        #endregion

        public override bool Equals(object obj)
        {
            return (log.Equals(((User)obj).log) & pass.Equals(((User)obj).pass));
        }
    }
}
