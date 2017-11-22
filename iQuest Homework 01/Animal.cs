using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElianDoran.iQuest.Homework01
{
    /// <summary>
    /// The physical representation of a type of animal. This class is abstract.
    /// </summary>
    abstract class Animal
    {
        /// <summary>
        /// The name of the <see cref="Animal"/> (i.e. dog). The Get accessor must be overriden in derived class to provide the name.
        /// </summary>
        public virtual string Name { get; }

        /// <summary>
        /// An onomatopoeia representing the sound this <see cref="Animal"/> makes.
        /// </summary>
        public virtual string Sound { get; }
    }
}
