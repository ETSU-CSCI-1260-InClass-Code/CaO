using System;
using System.Collections.Generic;
using System.Text;

namespace CaO
{
    public class Player
    {

        //private string name;

        public string Name { get; init; }

        private int _health;
        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value < 0)
                    value = 1;

                this._health = value;
            }
        }



        //+ Player()


        public Player()
        {
            Name = "Default";
            Health = 100;
        }


        //+ Player(name:string)
        public Player(string name)
        {
            Name = name;
            Health = 100;
        }

        //+ Player(name:string, health:int)
        public Player(string name, int health)
        {
            Name = name;
            Health = health;
        }




        /*   public int GetHealh()
           {
               return health;
           }

           public void SetHealth(int health)
           {
               if(health < 0)
                   health = 1;

               this.health = health;
           }*/


    }
}
