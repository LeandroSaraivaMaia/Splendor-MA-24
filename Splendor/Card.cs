﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splendor
{
    /// <summary>
    /// class Card : attributes and methods to deal with a card
    /// </summary>
    class Card
    {
        #region Private attributes
        private Ressources ress;
        private int prestigePt;
        private int level;
        //tableau : l'index correspond à l'énumération, la valeur à la ressource requise
        private int[] price = new int[6];
        #endregion Private attributes

        #region Public attributes
        /// <summary>
        /// the precious stone that the card gives
        /// </summary>
        public Ressources Ress
        {
            get
            {
                return ress;
            }
            set
            {
                ress = value;
            }

        }

        /// <summary>
        /// number of prestige point of the card
        /// </summary>
        public int PrestigePt
        {
            get
            {
                return prestigePt;
            }
            set
            {
                prestigePt = value;
            }

        }

        /// <summary>
        /// level of the card : 1, 2 or 3
        /// </summary>
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }

        /// <summary>
        /// all the precious stones that are needed to buy the card
        /// </summary>
        public int[] Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        #endregion Public attributes

        #region Public methods

        /// <summary>
        /// displays information about the card
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string res = "";
            //If there is a prestige score, write it down
            if (prestigePt != 0)
            {
                res += "[" + prestigePt + "]";
            }

            //Write the name of the ressource of the card, if it exists (noble for example)
            if (Ress != 0)
            {
                res += " " + Enum.GetName(typeof(Ressources), Ress);
            } 

            
            res += "\t";
            res += "\r\n\r\n";
            int boucle = 0;
            
            foreach (int i in price)
            {
                
                string ressource = "";

                //If there is a ressource, write it down
                if (i != 0)
                {
                    ressource = "    ";
                    ressource += Enum.GetName(typeof(Ressources), boucle) + " ";
                    ressource += i + "\r\n";
                }
                
                res += ressource;
                boucle++;

            }
            return res;
        }
        #endregion Public methods
    }
}