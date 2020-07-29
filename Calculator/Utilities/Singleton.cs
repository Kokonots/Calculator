using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Utilities
{
    // Games like to use Singletons.
    abstract class Singleton<T> where T : Singleton<T>, new()
    {
        private static readonly T instance = new T();

        public static T Instance
        {
            get { return instance; }
        }
    }
}
