using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleGrupparbete6
{
    class CombatUI
    {
        public Hero Hero { get; set; }
        public Enemy Enemy { get; set; }
       
        
        public Generator Generator { get; set; }
        
        public CombatUI(Hero hero)
        {
            
            Hero = hero;
           
            
            Generator = new Generator();

        }
        
        
        

        public void Combat()
        {
            int rond = 0;
            bool combat = true;
            
            CreateEnemy(); // Skapa en ny fiende och beväpnar den
            Hero.Preparations(); // Adderar attackskada samt defence
            Enemy.Preparations();

            while (combat)
            {
                if (combat)
                {
                    rond++;
                    Console.WriteLine($"< G R O T T A N >");
                    Console.WriteLine($"<<<[ ROND {rond} ]>>>\n");
                }

                HeroAttacks(); // Hjälte anfaller

                if (Enemy.HP < 1)
                {
                    Console.WriteLine($"{Enemy.Name} is defeated.");
                    
                    combat = false;
                }

                else
                {

                    EnemyAttacks();
                    //Console.WriteLine($"\nEfter Combat-Metoden har {Hero.Name} {Hero.HP} HP kvar.\n");
                }

                if (Hero.HP < 1)
                {
                    Console.WriteLine($"{Hero.Name} as been slayed.");
                   
                    combat = false;
                }


                // Console.WriteLine($"\nEfter Combat-Metoden har {enemy.Name} {enemy.HP} HP kvar.\n");
                Console.WriteLine("===================================");
                Console.WriteLine("Tryck för att fortsätta \n");
                Console.ReadLine();
                Console.Clear();
            }
            

        }

        public void CombatTemp()
        {
            
        }

        public void CreateEnemy()
        {
            Enemy enemy = new Enemy(Hero.Level);
            enemy = Equipment.DressTheEnemy(enemy);
            Enemy = enemy;
            
        }

        public static void EnemyDefeated()
        {

        }

        public void HeroAttacks()
        {
            bool hit = HitOrMIss(); //Kollar om man träffar eller missar

            if (hit == false)
            {
                Console.WriteLine($"{Hero.Name} missed.");
            }

            HeroDamage();// Bestämmer hur hög skadan blir + crit
            ActualDamageToEnemy(); // Ser hur mycket HP som förloras genom att ta värdet på skadan minus värdet på skyddet. 
            //Det nya skadevärdet subtraheras från HP 


            Console.WriteLine($"{Hero.Name} inflicted {Hero.Damage} damage to {Enemy.Name}");
            Console.WriteLine($"{Enemy.Name} has {Enemy.HP} HP left.\n");
            

        }

        public void EnemyAttacks()
        {

            bool hit = HitOrMIss();

            if (hit == false)
            {
                Console.WriteLine($"{Enemy.Name} missed.");
                
            }

            EnemyDamage();
            ActualDamageToHero();

            Console.WriteLine($"{Enemy.Name} inflicted {Enemy.Damage} damage to {Hero.Name}");
            Console.WriteLine($"{Hero.Name} has {Hero.HP} HP left.\n");
            

        }



        public void HeroDamage()
        {
            //int critHit = Generator.OneToHundred();
            int critHit = Generator.OneToHundred();
            Hero.Damage = WeaponDamage(Hero.Weapon.LowDamage, Hero.Weapon.HighDamage);

            if (Hero.Weapon.CritChance >= critHit)
            {
                Console.WriteLine("Critical Hit!");
                Hero.Damage *= 2; // Om Critdamage
            }

            

        }

        public void EnemyDamage()
        {
            //int critHit = Generator.OneToHundred();
            int critHit = Generator.OneToHundred();
            Enemy.Damage = WeaponDamage(Enemy.Weapon.LowDamage, Enemy.Weapon.HighDamage);
            if (Enemy.Weapon.CritChance >= critHit)
            {
                Console.WriteLine("Critical Hit!");
                Enemy.Damage *= 2; // Om Critdamage
            }

            
        }
        
        public static int WeaponDamage(int lowDamage, int highDamage)
        {
            return Generator.RandomNumber(lowDamage, highDamage + 1);
        }

        public bool HitOrMIss()
        {
            //int hit = Generator.OneToHundred();
            int hit = Generator.OneToHundred();
            if (hit < Enemy.Dodge)
            {
                
                return false;
            }

            return true;
        }

        public void ActualDamageToEnemy()
        {
            
            Hero.Damage -= Enemy.Defence;

            if(Hero.Damage < 0)
            {
                Hero.Damage = 0;
            }
            Enemy.HP = Enemy.HP - Hero.Damage;
            
        }

        public void ActualDamageToHero()
        {
            Enemy.Damage -= Hero.Defence;

            if (Enemy.Damage < 0)
            {
                Enemy.Damage = 0;
            }
            Hero.HP = Hero.HP - Enemy.Damage;
        }



        public void HeroPreparations()
        {
            Hero.Defence += Hero.Helmet.Defence + Hero.Armor.Defence;
            Hero.HP += Hero.Helmet.HP + Hero.Armor.HP;

        }

        public void EnemyPreparations()
        {
            Enemy.Defence += Enemy.Helmet.Defence + Enemy.Armor.Defence;
            Enemy.HP += Enemy.Helmet.HP + Enemy.Armor.HP;
            
        }

        
    }
}
