using SimpleGrupparbete6;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Threading;

namespace SimpleGrupparbete6.Classes
{
    internal class UI
    {
        public CombatUI CombatUI { get; set; }
        public Grid GameGrid { get; set; }
        public Hero Hero { get; set; }
        public Enemy Enemy { get; set; }
        public Random Rnd { get; set; }
        public bool StopGame { get; set; }
        private Coordinate NewPlayerLocation;
        private Coordinate CurrentPlayerLocation { get; set; }
        public UI()
        {
            GameGrid = new Grid();
            Hero = new Hero();

            StopGame = false;
            NewPlayerLocation = new Coordinate();
            CombatUI = new CombatUI(Hero);

        }

        

        public void StartUI()
        {

            Equipment equipment = new Equipment(Hero);
            equipment.DressTheHero();
            
            GameGrid.GenerateGrid(Hero.Location.Row, Hero.Location.Col);
            GameGrid.PrintGrid();
            while (!StopGame)
            {
                MovePlayer();
               
            }
        }

        private void MovePlayer()
        {
            var keyPressed = Console.ReadKey(true).Key;
            switch (keyPressed)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    NewPlayerLocation.SetCoordinate(Hero.Location.Row - 1, Hero.Location.Col);
                    Move();
                    break;

                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    NewPlayerLocation.SetCoordinate(Hero.Location.Row + 1, Hero.Location.Col);
                    Move();
                    break;

                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    NewPlayerLocation.SetCoordinate(Hero.Location.Row, Hero.Location.Col - 1);
                    Move();
                    break;

                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    NewPlayerLocation.SetCoordinate(Hero.Location.Row, Hero.Location.Col + 1);
                    Move();
                    break;

                case ConsoleKey.Escape:
                    Console.SetCursorPosition(0, 19);
                    StopGame = true;
                    break;
            }
        }

        private void Move()
        {
            
            if (NewPlayerLocation.Row == 3 && NewPlayerLocation.Col == 3)
            {
                
                Console.Clear();
                
                CombatUI.Combat();
                
                StopGame = true;
               
            }

            
            else if ((NewPlayerLocation.Row >= 0
                && NewPlayerLocation.Row < GameGrid.GameGrid.Length))
            {
                if (!(GameGrid.GameGrid[NewPlayerLocation.Row][NewPlayerLocation.Col] == '_' ||
                GameGrid.GameGrid[NewPlayerLocation.Row][NewPlayerLocation.Col] == '|'))
                {
                    Console.SetCursorPosition(Hero.Location.Col, Hero.Location.Row);
                    Console.Write('*');
                    Console.SetCursorPosition(NewPlayerLocation.Col, NewPlayerLocation.Row);
                    Console.Write('@');
                    Hero.Location.SetCoordinate(NewPlayerLocation.Row, NewPlayerLocation.Col);
                }
            }
        }

        
       
        


    }
}