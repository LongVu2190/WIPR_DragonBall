﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Xml.Xsl;
using DragonBall.Enums;

namespace DragonBall.Objects
{
    internal class C_Player : A_Object
    {
        public int delayShootTime { get; set; }
        public bool secondLife;
        public C_Player() 
        {
            Height = 120;
            Width = 120;
            Speed = 5;
            Health = 10;
            X = 0;
            Y = 0;
            form = 0;
            stepFrame = 0;
            secondLife = false;
            delayShootTime = 15;
            maxSlowDownFPS = 0;
            maxSlowDownFPS = 10;
            imageMovements = Directory.GetFiles("assets/player0", "*.png").ToList();
            Image = Image.FromFile(imageMovements[10]);
        }

        public void SetFrame(bool isShot, bool isTransform, Move status)
        {
            if (isShot)
            {
                startFrame = 6;
                endFrame = 8;
            }
            else if (form == 0 && isTransform)
            {
                imageMovements = Directory.GetFiles("assets/player0", "*.png").ToList();
                startFrame = 10;
                endFrame = 16;
            }
            else if (form == 0 && status == Move.Right)
            {
                startFrame = 0;
                endFrame = 2;
            }
            else if (form == 0 && status == Move.Left)
            {
                startFrame = 3;
                endFrame = 5;
            }

            else if (form == 1 && isTransform)
            {
                imageMovements = Directory.GetFiles("assets/player1", "*.png").ToList();
                startFrame = 10;
                endFrame = 17;
            }
            else if (form == 1 && status == Move.Right)
            {
                startFrame = 0;
                endFrame = 2;
            }
            else if (form == 1 && status == Move.Left)
            {
                startFrame = 3;
                endFrame = 5;
            }

            else if (form == 2 && isTransform)
            {
                imageMovements = Directory.GetFiles("assets/player2", "*.png").ToList();
                startFrame = 10;
                endFrame = 20;
            }
            else if (form == 2 && status == Move.Right)
            {
                startFrame = 0;
                endFrame = 2;
            }
            else if (form == 2 && status == Move.Left)
            {
                startFrame = 3;
                endFrame = 5;
            }

            else if (form == 3 && isTransform)
            {
                imageMovements = Directory.GetFiles("assets/player3", "*.png").ToList();
                startFrame = 10;
                endFrame = 27;
            }
            else if (form == 3 && status == Move.Right)
            {
                startFrame = 0;
                endFrame = 2;
            }
            else if (form == 3 && status == Move.Left)
            {
                startFrame = 3;
                endFrame = 5;
            }

            else if (form == 4 && isTransform)
            {
                imageMovements = Directory.GetFiles("assets/player4", "*.png").ToList();
                startFrame = 10;
                endFrame = 22;
            }
            else if (form == 4 && status == Move.Right)
            {
                startFrame = 0;
                endFrame = 2;
            }
            else if (form == 4 && status == Move.Left)
            {
                startFrame = 3;
                endFrame = 5;
            }
        }

        ~C_Player() { }
    }
}
