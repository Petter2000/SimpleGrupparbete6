using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGrupparbete6
{
    public class Figure
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int Damage { get; set; }
        public int Defence { get; set; }
        public int Dodge { get; set; }

        public Weapon Weapon { get; set; }
        public Helmet Helmet { get; set; }
        public Armor Armor { get; set; }

        public void Preparations()
        {
            Defence += Helmet.Defence + Armor.Defence;
            HP += Helmet.HP + Armor.HP;

        }

    }

    public class Hero : Figure
    {
        public int Experience { get; set; }
        public int ExperienceBreakpoint { get; set; }
        public Coordinate NewPlayerLocation { get; set; }
        public Coordinate Location { get; set; }
        public Hero()
        {
            Location = new Coordinate(1, 1);
            Name = "Sir Kurt";
            Level = 1;
            HP = 100;
            Dodge = 5;

        }
    }

    public class Enemy : Figure
    {
        public Enemy(int modifier)
        {
            Name = "Plattjordare";
            HP = 10 * modifier;
            Dodge = 5;
        }
    }
}
