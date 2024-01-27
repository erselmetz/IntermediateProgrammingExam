using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuantumCrust_Innovations
{
    internal class Price
    {
        /*Pizza Prices Dynamic*/
        public double QuantumVeggieFussion = 0;
        public double NanoMushroomMeltdown = 0;
        public double RobboBBQBlast = 0;
        public double InterstellarInferno = 0;
        public double initialPizza = 0;

        /*Drinks Prices Dynamic*/
        public double GalacticElixirs = 0;
        public double NeonFusionFizz = 0;
        public double QuantumQuencher = 0;
        public double InfinityInfusions = 0;
        public double ZeroGravityBrews = 0;
        public double CosmicMixologyCocktails = 0;
        public double initialDrinks = 0;

        /*Dessert Static*/
        public double NanobiteNutellaNebulaBites = 29.99;
        public double QuantumBerryParadoxTart = 59.99;
        public double InterdimensionalIceCreamSundae = 39.99;
        public double GalacticPuddingPops = 89.99;
        public double initialDessert = 69.99;

        /* cart */
        public double finalPrice = 0;

        //Pizza Price or size
        public void setPizzaSmall()
        {
            this.QuantumVeggieFussion = 79.99;
            this.NanoMushroomMeltdown = 59.99;
            this.RobboBBQBlast = 84.99;
            this.InterstellarInferno = 89.99;
        }

        public void setPizzaMedium()
        {
            this.QuantumVeggieFussion = 95.99;
            this.NanoMushroomMeltdown = 71.99;
            this.RobboBBQBlast = 101.99;
            this.InterstellarInferno = 107.99;
        }

        public void setPizzaLarge()
        {
            this.QuantumVeggieFussion = 151.99;
            this.NanoMushroomMeltdown = 113.99;
            this.RobboBBQBlast = 161.99;
            this.InterstellarInferno = 170.99;
        }

        //Drinks Price or size
        public void setDrinksSmall()
        {
            this.GalacticElixirs = 49;
            this.NeonFusionFizz = 39;
            this.QuantumQuencher = 40;
            this.InfinityInfusions = 40;
            this.ZeroGravityBrews = 50;
            this.CosmicMixologyCocktails = 70;
        }

        public void setDrinksMedium()
        {
            this.GalacticElixirs = 59.8;
            this.NeonFusionFizz = 46.8;
            this.QuantumQuencher = 48;
            this.InfinityInfusions = 48;
            this.ZeroGravityBrews = 60;
            this.CosmicMixologyCocktails = 84;
        }

        public void setDrinksLarge()
        {
            this.GalacticElixirs = 84;
            this.NeonFusionFizz = 74.1;
            this.QuantumQuencher = 76;
            this.InfinityInfusions = 76;
            this.ZeroGravityBrews = 95;
            this.CosmicMixologyCocktails = 133;
        }
    }
}
