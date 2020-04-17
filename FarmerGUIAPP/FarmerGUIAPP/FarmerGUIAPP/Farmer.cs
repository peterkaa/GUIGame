using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FarmerGUIAPP
{
    class Farmer
    {
        private ArrayList northBank = new ArrayList();
        private ArrayList southBank = new ArrayList();
        private Direction farmer;

        public ArrayList NorthBank { get => northBank; set => northBank = value; }
        public ArrayList SouthBank { get => southBank; set => southBank = value; }
        public Direction TheFarmer { get => farmer; set => farmer = value; }

        public enum Direction
        {
            North,
            South
        }

        public Farmer()
        {
            northBank.Add("FOX");
            northBank.Add("CHICKEN");
            northBank.Add("GRAIN");
            
            farmer = Direction.North;

        }

        public bool Move(string moveditem)
        {
            bool wrongmove = false;//checks for wrong moves

            switch (moveditem)
            {
                case ("CHICKEN"):
                    if (NorthBank.Contains("CHICKEN") && TheFarmer == Direction.North)
                    {
                        NorthBank.Remove("CHICKEN");
                        SouthBank.Add("CHICKEN");
                        TheFarmer = Direction.South;

                    }
                    else if (SouthBank.Contains("CHICKEN") && TheFarmer == Direction.South)
                    {
                        SouthBank.Remove("CHICKEN");
                        NorthBank.Add("CHICKEN");
                        TheFarmer = Direction.North;
                    }
                    else
                    {
                        wrongmove = true;//sets wrongmove to true
                    }
                    break;

                case ("FOX"):
                    if (NorthBank.Contains("FOX") && TheFarmer == Direction.North)
                    {
                        NorthBank.Remove("FOX");
                        SouthBank.Add("FOX");
                        TheFarmer = Direction.South;

                    }
                    else if (SouthBank.Contains("FOX") && TheFarmer == Direction.South)
                    {
                        SouthBank.Remove("FOX");
                        NorthBank.Add("FOX");
                        TheFarmer = Direction.North;
                    }
                    else
                    {
                        wrongmove = true;//sets wrongmove to true
                    }
                    break;

                case ("GRAIN"):
                    if (NorthBank.Contains("GRAIN") && TheFarmer == Direction.North)
                    {
                        NorthBank.Remove("GRAIN");
                        SouthBank.Add("GRAIN");
                        TheFarmer = Direction.South;

                    }
                    else if (SouthBank.Contains("GRAIN") && TheFarmer == Direction.South)
                    {
                        SouthBank.Remove("GRAIN");
                        NorthBank.Add("GRAIN");
                        TheFarmer = Direction.North;
                    }
                    else
                    {
                        wrongmove = true;//sets wrongmove to true
                    }

                    break;

                case (""):
                    if (TheFarmer == Direction.North)
                    {
                        TheFarmer = Direction.South;
                    }
                    else if (TheFarmer == Direction.South)
                    {
                        TheFarmer = Direction.North;
                    }
                    break;
            }

            return wrongmove;//returns a boolean variable indicating if move was right or wrong
        }

        public int AnimalAteFood()
        {
            int eaten = 1;

            if (NorthBank.Contains("FOX") && NorthBank.Contains("CHICKEN") && TheFarmer == Direction.South)
            {
                eaten = 2; //Fox ate chicken
            }

            else if (SouthBank.Contains("FOX") && SouthBank.Contains("CHICKEN") && TheFarmer == Direction.North)
            {
                eaten = 2; //Fox ate chicken
            }

            else if (NorthBank.Contains("CHICKEN") && NorthBank.Contains("GRAIN") && TheFarmer == Direction.South)
            {
                eaten = 3; //Chicken ate grain
            }

            else if (SouthBank.Contains("CHICKEN") && SouthBank.Contains("GRAIN") && TheFarmer == Direction.North)
            {
                eaten = 3; //Chicken ate grain
            }


            return eaten;
        }

        public bool DetermineWin()
        {
            bool win = false;//passes a false to win the gameover method to keep the loop going

            if (SouthBank.Contains("CHICKEN") && SouthBank.Contains("FOX") && SouthBank.Contains("GRAIN") && TheFarmer == Direction.South)
            {
                win = true;//passes a true to win in the gameover method to increment counter;
            }

            return win;
        }

       
    }
}

