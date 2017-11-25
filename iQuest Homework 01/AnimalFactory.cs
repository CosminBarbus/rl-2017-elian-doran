using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ElianDoran.iQuest.Homework01
{
    /// <summary>
    /// Provides methods for obtaining instances of <see cref="IAnimal"/> implementations.
    /// </summary>
    public static class AnimalFactory
    {
        /// <summary>
        /// Returns a <see cref="List{}"/> containing new instances of all the <see cref="IAnimal"/> implementations.
        /// The search is limited to the namespace given by the <paramref name="searchNamespace"/> parameter.
        /// </summary>
        /// <param name="searchNamespace">The .NET namespace the search will be limited to.</param>
        /// <returns>A <see cref="List{}"/> of <see cref="IAnimal"/>.</returns>
        public static List<IAnimal> ObtainByReflection(string searchNamespace)
        {
            var classes =
                from t in Assembly.GetExecutingAssembly().GetTypes()
                where t.Namespace == searchNamespace && t.IsClass
                select (IAnimal)(t.GetConstructor(Type.EmptyTypes).Invoke(null));

            return classes.ToList();
        }
    }
}
