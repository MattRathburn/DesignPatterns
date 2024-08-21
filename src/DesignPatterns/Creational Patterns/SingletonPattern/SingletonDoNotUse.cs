using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class SingletonDoNotUse
    {
        private SingletonDoNotUse() { }

        private static SingletonDoNotUse instance = null;

        public static SingletonDoNotUse Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonDoNotUse();
                }

                return instance;
            }
        }
    }
}
