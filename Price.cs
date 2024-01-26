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
        public double QuantumBerryParadoxTart = 59.9;
        public double InterdimensionalIceCreamSundae = 39.99;
        public double GalacticPuddingPops = 89.99;
        public double initialDessert = 69.99;

        /* cart */
        public double finalPrice = 0;

        //Pizza Price or size
        public void setPizzaSmall()
        {
            this.QuantumVeggieFussion = 10;
            this.NanoMushroomMeltdown = 10;
            this.RobboBBQBlast = 10;
            this.InterstellarInferno = 10;
        }

        public void setPizzaMedium()
        {
            this.QuantumVeggieFussion = 20;
            this.NanoMushroomMeltdown = 20;
            this.RobboBBQBlast = 20;
            this.InterstellarInferno = 20;
        }

        public void setPizzaLarge()
        {
            this.QuantumVeggieFussion = 30;
            this.NanoMushroomMeltdown = 30;
            this.RobboBBQBlast = 30;
            this.InterstellarInferno = 30;
        }

        //Drinks Price or size
        public void setDrinksSmall()
        {
            this.GalacticElixirs = 10;
            this.NeonFusionFizz = 10;
            this.QuantumQuencher = 10;
            this.InfinityInfusions = 10;
            this.ZeroGravityBrews = 10;
            this.CosmicMixologyCocktails = 10;
        }

        public void setDrinksMedium()
        {
            this.GalacticElixirs = 20;
            this.NeonFusionFizz = 20;
            this.QuantumQuencher = 20;
            this.InfinityInfusions = 20;
            this.ZeroGravityBrews = 20;
            this.CosmicMixologyCocktails = 20;
        }

        public void setDrinksLarge()
        {
            this.GalacticElixirs = 30;
            this.NeonFusionFizz = 30;
            this.QuantumQuencher = 30;
            this.InfinityInfusions = 30;
            this.ZeroGravityBrews = 30;
            this.CosmicMixologyCocktails = 30;
        }
    }
}
