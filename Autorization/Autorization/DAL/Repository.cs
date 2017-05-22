using Autorization.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Autorization.DAL
{
    static class Repository
    {
        static List<User> users;

        static Repository()
        {
            //users = new List<User>()
            //{
            //    new User() { Log = "log1", Pass = "pas1", Email = "log1email@mail.ru", Name = "user1" },
            //    new User() { Log = "log2", Pass = "pas2", Email = "log2email@ya.ru", Name = "user2" },
            //    new User() { Log = "log3", Pass = "pas3", Email = "log3email@tut.by", Name = "user3" },
            //    new User() { Log = "log4", Pass = "pas4", Email = "log4email@gmail.com", Name = "user4" }
            //};
        }

        #region MYMETHODS
        /// <summary>
        /// Записывает в файл коллекцию всех пользователей в системе
        /// </summary>
        /// <param name="users">коллекция всех пользователей</param>
        public static void SaveToBase(List<User> users)
        {
            using (FileStream file = new FileStream("users.txt", FileMode.Create))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                binFormat.Serialize(file, users);
            }
        }

        /// <summary>
        /// Позволяет получить коллекцию пользователей в системе
        /// </summary>
        /// <returns>коллекцию пользователей</returns>
        public static List<User> OpenBase()
        {
            using (FileStream file = new FileStream("users.txt", FileMode.Open))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                users = (List<User>)binFormat.Deserialize(file);
            }
            return users;
        }
        #endregion       
    }
}
