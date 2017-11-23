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

        /// <summary>
        /// Returns a <see cref="List{}"/> containing new instances of all the <see cref="Animal"/> classes.
        /// The animals are loaded through reflection of the <see cref="iQuest.Homework01.Animals"/> namespace.
        /// </summary>
        /// <returns>A <see cref="List{}"/> of <see cref="Animal"/></returns>
        public static List<Animal> GetAllAnimals() {
            var classes =
                from t in Assembly.GetExecutingAssembly().GetTypes()
                where t.Namespace == "ElianDoran.iQuest.Homework01.Animals" && t.IsClass
                select (Animal)(t.GetConstructor(Type.EmptyTypes).Invoke(null));

            return classes.ToList();
        }

        /// <summary>
        /// Returns a <see cref="string"/> that represents the current <see cref="Animal"/>.
        /// </summary>
        /// <returns>A <see cref="string"/> that represents the current <see cref="Animal"/>.</returns>
        public override string ToString()
        {
            return String.Format("The {0} makes {1}.", Name, Sound);
        }
    }
}
