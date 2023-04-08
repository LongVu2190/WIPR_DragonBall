﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBall
{
    public class Bullets
    {
        public Bullets()
        {

        }
        public Bullets(int x, int y, bool isMoving)
        {
            X = x;
            Y = y;
            this.isMoving = isMoving;
        }

        public Image Image { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; } = 50;
        public int Height { get; set; } = 30;
        public bool isMoving { get; set; } = false;
        public bool isHit { get; set; } = false;
    }
}
