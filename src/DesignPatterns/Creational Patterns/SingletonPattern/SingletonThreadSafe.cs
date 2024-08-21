using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class SingletonThreadSafe
    {
        SingletonThreadSafe() { }

        private static readonly object _lock = new object();

        private static SingletonThreadSafe instance = null;

        public static SingletonThreadSafe Instance
        {
            get
            {
                lock(_lock )
                {
                    if ( instance == null )
                    {
                        instance = new SingletonThreadSafe();
                    }
                    return instance;
                }
            }
        }
    }
}
