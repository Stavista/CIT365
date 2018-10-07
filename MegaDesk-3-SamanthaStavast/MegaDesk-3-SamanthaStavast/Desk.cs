using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_SamanthaStavast
{
    class Desk
    {
         public int 
            width,
            depth,
            drawers;
         public string surfaceMaterial;

        public Desk(int width, int depth, int drawers, string surfaceMaterial)
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.surfaceMaterial = surfaceMaterial;
        }

        public bool CheckConstraints ()
        {
            if (width < 24 || width > 96)
            {
                return false;
            }
            if (depth < 12 || depth > 48)
            {
                return false; 
            }
            if (drawers < 0 || drawers > 7)
            {
                return false;
            }
            return true;
        }

        public int getSize()
        {
            return (width * depth);
        }
    }
}
