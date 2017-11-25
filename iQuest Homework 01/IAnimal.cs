using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ElianDoran.iQuest.Homework01
{
    /// <summary>
    /// The physical representation of a type of animal. This class is abstract.
    /// </summary>
    public interface IAnimal
    {
        /// <summary>
        /// The name of the <see cref="IAnimal"/> (i.e. dog). The Get accessor must be overriden in derived class to provide the name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// An onomatopoeia representing the sound this <see cref="IAnimal"/> makes.
        /// </summary>
        string Sound { get; }
    }
}
