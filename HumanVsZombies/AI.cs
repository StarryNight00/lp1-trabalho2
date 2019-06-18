﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HumanVsZombies
{
    /// <summary>
    /// Class AI 
    /// </summary>
    class AI : Agents
    {
        //  
        public AI(AgentType type, int id, int posX, int posY) : base(type, id, posX, posY) { }

        // 
        public void SearchForAgent(Board board)
        {
            bool toroidal = false;
            int move = 1;
            int x = PosX;
            int y = PosY;
            int newX = PosX;
            int newY = PosY;

            //
            for (int i = 1; i <= ((board.Width + board.Height)); i++)
            {
                //
                for (int j = 2; j <= 2; j++)
                {
                    if (move == 4)
                        move = 1;
                    else
                        move++;
                    //
                    for (int block = 1; block <= i; block++)
                    {
                        switch (move)
                        {
                            case 1:
                                newX++;
                                break;
                            case 2:
                                newY++;
                                break;
                            case 3:
                                newX--;
                                break;
                            case 4:
                                newY--;
                                break;
                        }
                    }
                }
            }
            toroidal = Toroidal(ref newX, ref newY, board);

            if (board.Grid[newX, newY] != null)
            {
                if (board.Grid[newX, newY].MyType != MyType)
                {
                    board.Grid[x, y] = default(Agents);
                    if (MyType == AgentType.human)
                    {
                        if (toroidal)
                        {
                            if (newX < x && newY == y)
                            {
                                x++;
                            }
                            else if (newX > x && newY == y)
                            {
                                x--;
                            }
                            else if (newX < x && newY < y)
                            {
                                x++;
                                y++;
                            }
                            else if (newX > x && newY < y)
                            {
                                x--;
                                y++;
                            }
                            else if (newX < x && newY > y)
                            {
                                x++;
                                y--;
                            }
                            else if (newX > x && newY > y)
                            {
                                x--;
                                y--;
                            }
                            else if (newX == x && newY < y)
                            {
                                y++;
                            }
                            else if (newX == x && newY > y)
                            {
                                y--;
                            }
                        }
                        else
                        {
                            if (newX < x && newY == y)
                            {
                                x++;
                            }
                            else if (newX > x && newY == y)
                            {
                                x--;
                            }
                            else if (newX < x && newY < y)
                            {
                                x++;
                                y++;
                            }
                            else if (newX > x && newY < y)
                            {
                                x--;
                                y++;
                            }
                            else if (newX < x && newY > y)
                            {
                                x++;
                                y--;
                            }
                            else if (newX > x && newY > y)
                            {
                                x--;
                                y--;
                            }
                            else if (newX == x && newY < y)
                            {
                                y++;
                            }
                            else if (newX == x && newY > y)
                            {
                                y--;
                            }
                        }
                    }
                    else
                    {
                        if (toroidal)
                        {
                            if (newX < x && newY == y)
                            {
                                x++;
                            }
                            else if (newX > x && newY == y)
                            {
                                x--;
                            }
                            else if (newX < x && newY < y)
                            {
                                x++;
                                y++;
                            }
                            else if (newX > x && newY < y)
                            {
                                x--;
                                y++;
                            }
                            else if (newX < x && newY > y)
                            {
                                x++;
                                y--;
                            }
                            else if (newX > x && newY > y)
                            {
                                x--;
                                y--;
                            }
                            else if (newX == x && newY < y)
                            {
                                y++;
                            }
                            else if (newX == x && newY > y)
                            {
                                y--;
                            }
                        }
                        else
                        {
                            if (newX < x && newY == y)
                            {
                                x--;
                            }
                            else if (newX > x && newY == y)
                            {
                                x++;
                            }
                            else if (newX < x && newY < y)
                            {
                                x--;
                                y--;
                            }
                            else if (newX > x && newY < y)
                            {
                                x++;
                                y--;
                            }
                            else if (newX < x && newY > y)
                            {
                                x--;
                                y++;
                            }
                            else if (newX > x && newY > y)
                            {
                                x++;
                                y++;
                            }
                            else if (newX == x && newY < y)
                            {
                                y--;
                            }
                            else if (newX == x && newY > y)
                            {
                                y++;
                            }
                        }
                    }

                    Toroidal(ref x, ref y, board);

                    if (board.Grid[x, y] != null &&
                            MyType == AgentType.zombie &&
                            board.Grid[x, y].MyType == AgentType.human)
                    {
                        Infection(board.Grid[newX, newY], board);
                    }
                    board.Grid[x, y] = this;

                    PosX = x;
                    PosY = y;
                    return;
                }
            }
        }
    }
}