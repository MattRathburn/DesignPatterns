using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Console.WriteLine("Client: Executing client code with a real subject");
            RealSubject realSubject = new RealSubject();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing client code with a proxy:");
            Proxy proxy = new Proxy(realSubject);
            client.ClientCode(proxy);
        }
    }
}
