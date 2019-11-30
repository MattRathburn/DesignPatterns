using SingletonDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingletonDesignPattern.Data
{
  public class DbInitializer
  {
    public static void Initialize(AppDbContext context)
    {
      context.Database.EnsureCreated();

      if(context.Guitars.Any())
      {
        return;
      }

      var guitars = new Guitars[]
      {
        new Guitars{Id = 1, Name = "Telecaster"},
        new Guitars{Id = 2, Name = "Stratocaster"},
        new Guitars{Id = 3, Name = "Les Paul"}
      };

      foreach (Guitars g in guitars)
      {
        context.Guitars.Add(g);
      }

      context.SaveChanges();
    }
  }
}
