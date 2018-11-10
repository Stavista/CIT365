
using System;

namespace MegaDesk_3_SamanthaStavast
{
    public class Desk
    {
        public int
           width,
           depth,
           drawers;
        public enum Material
        {
            Pine,
            Laminate,
            Veneer,
            Oak,
            Rosewood
        };

        public Material surfaceMaterial;

        public Desk(int width, int depth, int drawers, Material surfaceMaterial)
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;
            this.surfaceMaterial = (Material)surfaceMaterial;
        }

        public bool CheckConstraints()
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

        internal string getSurfaceString(Material incomingMaterial)
        {
            switch (incomingMaterial)
            {
                case Material.Pine:
                    return "Pine";
                case Material.Laminate:
                    return "Laminate";
                case Material.Veneer:
                    return "Veneer";
                case Material.Oak:
                    return "Oak";
                case Material.Rosewood:
                    return "Rosewood";
                default:
                    return "unknown";
            }
        }

        public int getSize()
        {
            return (width * depth);
        }
    }
}
