using System;
using System.Collections.Generic;

namespace Repetition
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
        x Klasser och instanser
        x Metoder i klasser + algoritmer
        x Synlighet (public/private)
        x Arv
        x Generiska klasser
        x "Objektorientering"
        x Inkapsling
        x Polymorfism
      */

      List<int> grejer = new List<int>();

      Queue<int> kö = new Queue<int>();

      kö.Enqueue(77);
      int next = kö.Dequeue();


      int heroHp = 100;
      int heroX = 400;
      int heroY = 600;



      Hero theHero = new Hero();
      Hero anotherHero = theHero;

      Hero hulk = new StrongHero();

      hulk.Run();

      hulk.Hp = -60;

      Console.WriteLine(hulk.Hp);

      // hulk.hp -= 100;
      // if (hulk.hp < 0)
      // {
      //   hulk.hp = 0;
      // }


      // anotherHero.hp = 1000;
      // theHero.hp = 900;

      // Console.WriteLine(anotherHero.GetHp());
      
      Console.ReadLine();
    }
  }
}
