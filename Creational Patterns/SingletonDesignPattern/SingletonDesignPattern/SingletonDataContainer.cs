using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
  public class SingletonDataContainer : ISingletonContainer
  {
    private Dictionary<string, int> _capitals = new Dictionary<string, int>();

    private SingletonDataContainer()
    {
      Console.WriteLine("Initializing Singleton Object");

      var elements = File.ReadAllLines("capitals.txt");
      for(int i = 0; i < elements.Length; i+=2)
      {
        _capitals.Add(elements[i], int.Parse(elements[i + 1]));
      }
    }

    public int GetPopulation(string name)
    {
      return _capitals[name];
    }

    public int GetNumber(string name)
    {
      throw new NotImplementedException();
    }

    public string GetString(string name)
    {
      throw new NotImplementedException();
    }

    private static Lazy<SingletonDataContainer> instance = new Lazy<SingletonDataContainer>(() => new SingletonDataContainer());

    public static SingletonDataContainer Instance => instance.Value;
  }
}
