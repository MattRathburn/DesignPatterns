using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class Client
    {
        public void ClientCode(ISubject subject)
        {
            subject.Request();
        }
    }
}
