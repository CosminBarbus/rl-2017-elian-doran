using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ElianDoran.iQuest.Homework01
{
    /// <summary>
    /// Finds all subclasses of the <see cref="Animal"/> class by means of reflection and creates an instance of them.
    /// </summary>
    public class AnimalFactory
    {
        /// <summary>
        /// Returns a <see cref="List{}"/> containing new instances of all the <see cref="Animal"/> classes.
        /// The animals are loaded through reflection of the <see cref="iQuest.Homework01.Animals"/> namespace.
        /// </summary>
        /// <returns>A <see cref="List{}"/> of <see cref="Animal"/></returns>
        public static List<Animal> ObtainByReflection()
        {
            var classes =
                from t in Assembly.GetExecutingAssembly().GetTypes()
                where t.Namespace == "ElianDoran.iQuest.Homework01.Animals" && t.IsClass
                select (Animal)(t.GetConstructor(Type.EmptyTypes).Invoke(null));

            return classes.ToList();
        }
    }
}
