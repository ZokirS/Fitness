using System;

namespace Fitness.BL.Model
{
    /// <summary>
    /// Gender
    /// </summary>
    public class Gender
    {
        /// <summary>
        /// Name of gender
        /// </summary>
        public string Name { get;  }
        /// <summary>
        /// Create new gender
        /// </summary>
        /// <param name="name"> Name of gender</param>
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Gender cannot be empty or null", nameof(name));
            }
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    
    }
}
