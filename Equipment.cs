﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGrupparbete6
{
    public class Equipment
    {
        public Random Rnd { get; set; }
        public Hero Hero { get; set; }

        public string Name { get; set; }

        public int Defence { get; set; }
        public int LowDefence { get; set; }
        public int HighDefence { get; set; }

        public int HP { get; set; }
        public int LowHP { get; set; }
        public int HighHp { get; set; }

        public int LowDamage { get; set; }
        public int HighDamage { get; set; }

        public int CritChance { get; set; }
        public int LowCrit { get; set; }
        public int HighCrit { get; set; }

        

        public Equipment(Hero hero)
        {
            Hero = hero;
        }
        public Equipment()
        {

        }


        public void DressTheHero()
        {
            Weapon myWeapon = new Weapon();
            CheckStuff(myWeapon);
            Helmet myHelmet = new Helmet();
            CheckStuff(myHelmet);
            Armor myArmor = new Armor();
            CheckStuff(myArmor);
            Console.WriteLine("Tryck för att fortsätta.\n");
            Console.ReadLine();
            Console.Clear();
            Hero.Weapon = myWeapon;
            Hero.Helmet = myHelmet;
            Hero.Armor = myArmor;
            
        }

        public static Enemy DressTheEnemy(Enemy enemy)
        {
            Weapon myWeapon = new Weapon();
            CheckStuff(myWeapon);
            Helmet myHelmet = new Helmet();
            CheckStuff(myHelmet);
            Armor myArmor = new Armor();
            CheckStuff(myArmor);
            Console.WriteLine("Tryck för att fortsätta.\n");
            Console.ReadLine();
            Console.Clear();
            enemy.Weapon = myWeapon;
            enemy.Helmet = myHelmet;
            enemy.Armor = myArmor;
            return enemy;


        }

        public static void CheckStuff(Equipment equipment)
        {
            Console.WriteLine($"Type: {equipment.Name}");

            if (equipment is Weapon)
            {

                Console.WriteLine($"Damage: {equipment.LowDamage} - {equipment.HighDamage}");
                Console.WriteLine($"Crit Chance: {equipment.CritChance} %");
            }

            else
            {
                Console.WriteLine($"Defence: {equipment.Defence}");
                Console.WriteLine($"Extra stuff: {equipment.HP} HP");
            }

            Console.WriteLine();

        }
    }

    public class Weapon : Equipment
    {


        public Weapon()
        {
            Name = "Sword";

            LowDamage = 25;
            HighDamage = 50;

            LowCrit = 1;
            HighCrit = 10;
            //CritChance = Generator.RandomNumber(LowCrit, HighCrit, Rnd);
            CritChance = Generator.RandomNumber(LowCrit, HighCrit);
        }
    }

    public class Protection : Equipment
    {

    }

    public class Helmet : Protection
    {
        public Helmet()
        {
            Name = "Helmet";

            LowDefence = 3;
            HighDefence = 10;
            Defence = Generator.RandomNumber(LowDefence, HighDefence);

            LowHP = 5;
            HighHp = 12;
            HP = Generator.RandomNumber(LowHP, HighHp);

        }
    }

    public class Armor : Protection
    {
        public Armor()
        {
            Name = "Armor";

            LowDefence = 10;
            HighDefence = 25;
            Defence = Generator.RandomNumber(LowDefence, HighDefence);

            LowHP = 10;
            HighHp = 20;
            HP = Generator.RandomNumber(LowHP, HighHp);
        }
    }
}
