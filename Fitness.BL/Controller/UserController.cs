using Fitness.BL.Model;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Fitness.BL.Controller
{
    /// <summary>
    /// User Controller
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// User of app
        /// </summary>
        public User User { get;}

        /// <summary>
        /// Creating new controller class
        /// </summary>
        /// <param name="user"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public UserController(string userName, string genderName, DateTime bd, double weight, double height)
        {

            var gender = new Gender(genderName);
            User = new User(userName, gender, bd, weight, height);
        }

        /// <summary>
        /// Load current user
        /// </summary>
        /// <returns> Load user</returns>
        /// <exception cref="FileLoadException"></exception>
        public UserController()
        {
            var formatter = new BinaryFormatter();
            using (var fs = new FileStream("user.dat", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
            }
        }
        /// <summary>
        /// Save user
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();
            using(var fs = new FileStream("user.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }

        
    }
}
