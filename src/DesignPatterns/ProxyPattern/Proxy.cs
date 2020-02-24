using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    class Proxy : ISubject
    {
        private RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            _realSubject = realSubject;
        }

        public void Request()
        {
            if(this.CheckAccess())
            {
                this._realSubject = new RealSubject();
                this._realSubject.Request();

                this.LogAccess();
            }
        }

        public bool CheckAccess()
        {
            Console.WriteLine("Proxy: Checking access prior to firing real request");
            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: Logging the time of the request: {0}", DateTime.Now);
        }
    }
}
