using System;

namespace Repetition
{
  public class StrongHero : Hero
  {
    public StrongHero()
    {
      hp = 1000;
      
    }

    public override void Run()
    {
      X += 3;
    }
  }
}
