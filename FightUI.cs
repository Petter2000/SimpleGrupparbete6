using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGrupparbete6
{
    class FightUI
    {
        /*
        public static void Combat()
        {



            if (enemy.HP < 1)
            {
                Console.WriteLine($"{enemy.Name} is defeated.");

            }

            else
            {
                hero.HP = EnemyAttacks(hero, enemy, rnd);
            }



            if (NewPlayerLocation.Row == 3 && NewPlayerLocation.Col == 3)
            {
                int rond = 0;
                bool combat = true;
                Console.Clear();
                Combat();
                CreateEnemy();
                /*
                Enemy enemy = new Enemy(Hero.Level);
                enemy = Program.DressTheEnemy(enemy, rnd);
                Enemy = enemy;
                Hero = HeroPreparations(Hero);
                enemy = EnemyPreparations(enemy);
                */
                /*
                while (combat)
                {
                    if (combat)
                    {
                        rond++;
                        Console.WriteLine($"< G R O T T A N >");
                        Console.WriteLine($"<<<[ ROND {rond} ]>>>\n");
                    }

                    Enemy.HP = HeroAttacks(Hero, Enemy, Rnd);

                    if (Enemy.HP < 1)
                    {
                        Console.WriteLine($"{Enemy.Name} is defeated.");
                        NewPlayerLocation.Col++;
                        combat = false;
                    }

                    else
                    {

                        Hero.HP = EnemyAttacks(Hero, Enemy, Rnd);
                        //Console.WriteLine($"\nEfter Combat-Metoden har {Hero.Name} {Hero.HP} HP kvar.\n");
                    }

                    if (Hero.HP < 1)
                    {
                        Console.WriteLine($"{Hero.Name} as been slayed.");
                        NewPlayerLocation.Col++;
                        combat = false;
                    }


                    // Console.WriteLine($"\nEfter Combat-Metoden har {enemy.Name} {enemy.HP} HP kvar.\n");
                    Console.WriteLine("===================================");
                    Console.WriteLine("Tryck för att fortsätta \n");
                    Console.ReadLine();
                    Console.Clear();
                }



                */
                /*
                Console.SetCursorPosition(Hero.Location.Col, Hero.Location.Row);
                Console.Write('*');
                Console.SetCursorPosition(NewPlayerLocation.Col, NewPlayerLocation.Row);
                Console.Write('@');
                Hero.Location.SetCoordinate(NewPlayerLocation.Row, NewPlayerLocation.Col);
                Console.ReadLine();
                Console.Clear();
                */
                /*
                StopGame = true;

            }
        }

        public void CreateEnemy()
        {
            Enemy enemy = new Enemy(Hero.Level);
            enemy = Program.DressTheEnemy(enemy, Rnd);
            Enemy = enemy;
            Hero = HeroPreparations(Hero);
            enemy = EnemyPreparations(enemy);
        }

        public static void EnemyDefeated()
        {

        }

        public static int HeroAttacks(Hero hero, Enemy enemy, Random rnd)
        {
            bool hit = HitOrMIss(enemy, hero, rnd);

            if (hit == false)
            {
                return enemy.HP;
            }

            int heroDamage = HeroDamage(hero, rnd);

            Console.WriteLine($"{hero.Name} inflicted {heroDamage} damage to {enemy.Name}");
            Console.WriteLine($"{enemy.Name} has {enemy.HP - heroDamage} HP left.\n");
            return enemy.HP - heroDamage;

        }

        public static int EnemyAttacks(Hero hero, Enemy enemy, Random rnd)
        {

            bool hit = HitOrMIss(enemy, hero, rnd);

            if (hit == false)
            {
                return enemy.HP;
            }

            int enemyDamage = EnemyDamage(enemy, rnd);

            Console.WriteLine($"{enemy.Name} inflicted {enemyDamage} damage to {hero.Name}");
            Console.WriteLine($"{hero.Name} has {hero.HP - enemyDamage} HP left.\n");
            return hero.HP - enemyDamage;




        }



        public static int HeroDamage(Hero hero, Random rnd)
        {
            int critHit = Program.OneToHundred(rnd);

            if (hero.Weapon.CritChance >= critHit)
            {
                Console.WriteLine("Critical Hit!");
                return WeaponDamage(hero.Weapon.LowDamage, hero.Weapon.HighDamage, rnd) * 2; // Om Critdamage
            }

            return WeaponDamage(hero.Weapon.LowDamage, hero.Weapon.HighDamage, rnd);

        }

        public static int EnemyDamage(Enemy enemy, Random rnd)
        {
            int critHit = Program.OneToHundred(rnd);

            if (enemy.Weapon.CritChance >= critHit)
            {
                Console.WriteLine("Critical Hit!");
                return WeaponDamage(enemy.Weapon.LowDamage, enemy.Weapon.HighDamage, rnd) * 2; // Om Critdamage
            }

            return WeaponDamage(enemy.Weapon.LowDamage, enemy.Weapon.HighDamage, rnd);

        }

        public static int WeaponDamage(int lowDamage, int highDamage, Random rnd)
        {
            return rnd.Next(lowDamage, highDamage + 1);
        }

        public static bool HitOrMIss(Enemy enemy, Hero hero, Random rnd)
        {
            int hit = Program.OneToHundred(rnd);
            if (hit < enemy.Dodge)
            {
                Console.WriteLine($"{hero.Name} missed.");
                return false;
            }

            return true;
        }

        public static Hero HeroPreparations(Hero hero)
        {
            hero.Defence += hero.Helmet.Defence + hero.Armor.Defence;
            hero.HP += hero.Helmet.HP + hero.Armor.HP;
            return hero;
        }

        public static Enemy EnemyPreparations(Enemy enemy)
        {
            enemy.Defence += enemy.Helmet.Defence + enemy.Armor.Defence;
            enemy.HP += enemy.Helmet.HP + enemy.Armor.HP;
            return enemy;
        }
        
        */


    }
}
