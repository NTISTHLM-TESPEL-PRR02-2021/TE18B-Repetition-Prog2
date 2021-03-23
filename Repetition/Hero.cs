using System;

namespace Repetition
{
  public class Hero
  {
    public static Random generator = new Random();

    protected int hp;
    // protected int x;
    protected int y;

    public int X { get; set; }

    public int Hp
    {
      get
      {
        return hp;
      }
      set
      {
        hp = value;
        if (hp < 0)
        {
          hp = 0;
        }
      }
    }

    public void SetHp(int value)
    {
      hp = value;
      if (hp < 0)
      {
        hp = 0;
      }
    }

    public int GetHp()
    {
      return hp;
    }


    public Hero()
    {
      hp = 100;
      X = 50;
      y = 50;
    }

    public virtual void Run()
    {
      X += 10;
      if (y < 0)
      {
        hp = 0;
      }
    }
  }
}
