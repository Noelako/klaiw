using fudiasasdagonounremlks;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace fudiasasgadonounremlks
{
    internal class coord
    {
        private int x;
        private int y;

        public int X { get { return x; } }
        public int Y { get { return y; } }
        
        public coord(int x, int y)
        {
            this.x = x;
            this.y= y;
            
        
        }
        public override bool Equals(object? obj)
        {
            if ((obj == null) || !GetType().Equals(obj.GetType()))
                return false;

            coord other = (coord)obj;
            return x == other.x && y== other.y;

        }

        
        public void ApplyMove(direction direction)
        {
            switch(direction)
            {
                case direction.left:
                    x--;
                    break;
                case direction.right:
                    x++;
                    
                    break;
                case direction.up:
                    y--;
                    break;
                case direction.down:
                    y++;
                    break;
            }
        }

    }
}
