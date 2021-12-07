using System;

namespace Fitness.BL.Model
{
    /// <summary>
    /// User
    /// </summary>
    public class User
    {
        #region Properties
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gender
        /// </summary>
        public Gender Gender { get; }

        /// <summary>
        /// Date of Birth
        /// </summary>
        public DateTime BirthDate { get; }

        /// <summary>
        /// Weight
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        public double Height { get; set; }
        #endregion

        /// <summary>
        /// Create new user
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="gender">Gender</param>
        /// <param name="bd">Date of birth</param>
        /// <param name="weight">Weight</param>
        /// <param name="height">Height</param>
        public User(string name,
                    Gender gender,
                    DateTime bd,
                    double weight, 
                    double height)
        {
            #region Checking conditions
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Name cannot be empty or null", nameof(name));
            }

            if(gender == null)
            {
                throw new ArgumentNullException("Gender cannot be null", nameof(gender));
            }

            if (bd < DateTime.Parse("01.01.1900") || bd >= DateTime.Now)
            {
                throw new ArgumentException("Impossible birthdate", nameof(bd));
            }

            if(weight <= 0)
            {
                throw new ArgumentException("Weight cannot be below 0", nameof(weight));
            }
            if (height <= 0)
            {
                throw new ArgumentException("Height cannot be below 0", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = bd;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
