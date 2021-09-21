using SimpleGrupparbete6.Classes;
using System;
using System.Security.Cryptography;

namespace SimpleGrupparbete6
{
    class Program
    {
        static void Main(string[] args)
        {
            UI gameUI = new UI();

            gameUI.StartUI();
            /*
             bool gogo = true;
             while (gogo)
             {
             }
            */


            Console.ReadLine();
            

        }

        
       

        
    }
    
    /*
    public class Equipment
    {
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
    }

    public class Weapon : Equipment
    {
       

        public Weapon(Random rnd)
        {
            Name = "Sword";

            LowDamage = 5;
            HighDamage = 15;

            LowCrit = 1;
            HighCrit = 10;
            CritChance = Program.RandomNumber(LowCrit, HighCrit, rnd);
        }
    }

    public class Protection : Equipment
    {

    }

    public class Helmet : Protection
    {
        public Helmet(Random rnd)
        {
            Name = "Helmet";

            LowDefence = 3;
            HighDefence = 10;
            Defence = Program.RandomNumber(LowDefence, HighDefence, rnd);

            LowHP = 5;
            HighHp = 12;
            HP = Program.RandomNumber(LowHP, HighHp, rnd);
                
        } 
    }

    public  class Armor : Protection
    {
        public Armor (Random rnd)
        {
            Name = "Armor";

            LowDefence = 10;
            HighDefence = 25;
            Defence = Program.RandomNumber(LowDefence, HighDefence, rnd);

            LowHP = 10;
            HighHp = 20;
            HP = Program.RandomNumber(LowHP, HighHp, rnd);
        }
    }
    */
    
}
