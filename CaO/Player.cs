using System;
using System.Collections.Generic;
using System.Text;

namespace CaO
{
    public class Player
    {

        //private string name;

        public string Name { get; private set; }

        private int _health;
        public int Health
        {
            get
            {
                return _health;
            }
            private set
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

        public Player(Player p)
        {
            this.Name = p.Name;
            this._health = p.Health;
        }

        public void Rebirth()
        {
            Health = 100;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

  

        public void AllowForNameChange(string name)
        {
            this.Name = name;
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

        public override string ToString()
        {
            return $"Player {Name} has {Health} health.";
        }
    }
}
