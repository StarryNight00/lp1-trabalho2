using System;
using System.Collections.Generic;
using System.Text;

namespace HumanVsZombies
{
    class Player : Agents
    {
        // Empty Contructor
        public Player(AgentType type, int id, int posX, int posY) : base(type, id, posX, posY) { }

        public void MovePlayer(Board board)
        {
            int newX = PosX;
            int newY = PosY;

            ConsoleKeyInfo keyInfo;
            keyInfo = Console.ReadKey();
            switch (keyInfo.Key)
            {
                // diagonal left baixo
                case ConsoleKey.NumPad1:
                    newX--;
                    newY++;
                    break;
                // down
                case ConsoleKey.NumPad2:
                    newY++;
                    break;
                // diagonal right baixo
                case ConsoleKey.NumPad3:
                    newX++;
                    newY++;
                    break;
                // left
                case ConsoleKey.NumPad4:
                    newX--;
                    break;
                // right
                case ConsoleKey.NumPad6:
                    newX++;
                    break;
                // diagonal left up
                case ConsoleKey.NumPad7:
                    newX--;
                    newY--;
                    break;
                // up
                case ConsoleKey.NumPad8:
                    newY--;
                    break;
                // diagonal right up
                case ConsoleKey.NumPad9:
                    newX++;
                    newY--;
                    break;
            }
        }
    }
    public override string ToString()
    {
        // Create temporary string 
        // Check if its Human or Zombie
        string temp;
        if (MyType == AgentType.human)
            temp = "H";
        else
            temp = "Z";
        return string.Format(temp + $"{Id:D2}");
    }
}
