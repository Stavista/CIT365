﻿using System;
using static MegaDesk_3_SamanthaStavast.Desk;

namespace MegaDesk_3_SamanthaStavast
{
    public class DeskQuote
    {
        public int rush;
        public double quotePrice = 200;
        public string date;
        public Desk desk;
         
        private string userName;

        public DeskQuote(int rush, string userName, Desk desk)
        {
            this.rush = rush;
            this.userName = userName;
            this.desk = desk;
            this.date = DateTime.Now.ToShortDateString();
        }

        public string UserName { get => userName; set => userName = value; }

        private int calculateRushPrice(int rush, int size)
        {
            switch (rush)
            {
                case 3:
                    if (size < 1000)
                    {
                        return 60;
                    }
                    else if (size > 1000 && size < 2000)
                    {
                        return 70;
                    }
                    else if (size > 2000)
                    {
                        return 80;
                    }
                    break;
                case 5:
                    if (size < 1000)
                    {
                        return 40;
                    }
                    else if (size > 1000 && size < 2000)
                    {
                        return 50;
                    }
                    else if (size > 2000)
                    {
                        return 60;
                    }
                    break;
                case 7:
                    if (size < 1000)
                    {
                        return 30;
                    }
                    else if (size > 1000 && size < 2000)
                    {
                        return 35;
                    }
                    else if (size > 2000)
                    {
                        return 40;
                    }
                    break;
                default:
                    break;
            }
            return 0;
        }

        private int calculateSurfacePrice(Material surface)
        {
            switch (surface)
            {
                case Material.Pine:
                    return 50;
                case Material.Laminate:
                    return 100;
                case Material.Veneer:
                    return 125;
                case Material.Oak:
                    return 200;
                case Material.Rosewood:
                    return 300;
                default:
                    return 0;
            }
        }

        public double calculateQuotePrice()
        {
            if (desk == null) //if there's no desk return
            {
                return -1;
            }
            else if (!desk.CheckConstraints()) //if the sizes aren't valid -> return
            {
                return -1;
            }

            quotePrice += desk.getSize(); //find area since it's $1 per sq in
            quotePrice += (desk.drawers * 50);
            quotePrice += (calculateSurfacePrice(desk.surfaceMaterial));
            quotePrice += calculateRushPrice(rush, desk.getSize());

            return quotePrice;
        }
    }
}
