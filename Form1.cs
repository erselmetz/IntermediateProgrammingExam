using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuantumCrust_Innovations
{
    public partial class Form1 : Form
    {
        Price price = new Price();

        public Form1()
        {
            InitializeComponent();
            radioButtonSmall.Checked = true;
            comboBox1.SelectedIndex = 0;
            listBoxDessert.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDrinks();
            updateComputation();
        }

        private void radioButtonSmall_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
            updateComputation();
        }

        private void radioButtonMedium_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
            updateComputation();
        }

        private void radioButtonLarge_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
            updateComputation();
        }

        private void checkBoxQuantumVeggieFusion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQuantumVeggieFusion.Checked)
            {
                checkBoxNanoMushromMeltdown.Enabled = false;
                checkBoxRoboBBQBlast.Enabled = false;
                checkBoxInterstellarInferno.Enabled = false;
            }
            else
            {
                checkBoxNanoMushromMeltdown.Enabled = true;
                checkBoxRoboBBQBlast.Enabled = true;
                checkBoxInterstellarInferno.Enabled = true;
            }
            updateComputation();
        }

        private void checkBoxNanoMushromMeltdown_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNanoMushromMeltdown.Checked)
            {
                checkBoxQuantumVeggieFusion.Enabled = false;
                checkBoxRoboBBQBlast.Enabled = false;
                checkBoxInterstellarInferno.Enabled = false;
            }
            else
            {
                checkBoxQuantumVeggieFusion.Enabled = true;
                checkBoxRoboBBQBlast.Enabled = true;
                checkBoxInterstellarInferno.Enabled = true;
            }
            updateComputation();
        }

        private void checkBoxRoboBBQBlast_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRoboBBQBlast.Checked)
            {
                checkBoxQuantumVeggieFusion.Enabled = false;
                checkBoxNanoMushromMeltdown.Enabled = false;
                checkBoxInterstellarInferno.Enabled = false;
            }
            else
            {
                checkBoxQuantumVeggieFusion.Enabled = true;
                checkBoxNanoMushromMeltdown.Enabled = true;
                checkBoxInterstellarInferno.Enabled = true;
            }
            updateComputation();
        }

        private void checkBoxInterstellarInferno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInterstellarInferno.Checked)
            {
                checkBoxQuantumVeggieFusion.Enabled = false;
                checkBoxNanoMushromMeltdown.Enabled = false;
                checkBoxRoboBBQBlast.Enabled = false;
            }
            else
            {
                checkBoxQuantumVeggieFusion.Enabled = true;
                checkBoxNanoMushromMeltdown.Enabled = true;
                checkBoxRoboBBQBlast.Enabled = true;
            }
            updateComputation();
        }

        private void listBoxDessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDessert();
            updateComputation();
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            clearPizza();
            clearDrinks();
            clearDessert();
            textBoxAmount.Text = "0";
            textBoxPayment.Text = "0";
            textBoxChange.Text = "0";
        }

        private void labelComputer_Click(object sender, EventArgs e)
        {
            updateComputation();
        }

        private void updateSize()
        {
            if (radioButtonSmall.Checked) price.setSmall();
            else if (radioButtonMedium.Checked) price.setMedium();
            else if (radioButtonLarge.Checked) price.setLarge();
            else radioButtonSmall.Checked = true;
        }
        private void updatePizza()
        {
            if (checkBoxQuantumVeggieFusion.Checked) price.initialPizza = price.QuantumVeggieFussion;
            else if (checkBoxNanoMushromMeltdown.Checked) price.initialPizza = price.NanoMushroomMeltdown;
            else if (checkBoxRoboBBQBlast.Checked) price.initialPizza = price.RobboBBQBlast;
            else if (checkBoxInterstellarInferno.Checked) price.initialPizza = price.InterstellarInferno;
            else price.initialPizza = 0;
        }
        private void updateDrinks()
        {
            string text = comboBox1.Text;
            if (text == "Galactic Elixirs") price.initialDrinks = price.GalacticElixirs;
            else if (text == "Neon Fusion Fizz") price.initialDrinks = price.NeonFusionFizz;
            else if (text == "Quantum Quencher") price.initialDrinks = price.QuantumQuencher;
            else if (text == "Infinity Infusions") price.initialDrinks = price.InfinityInfusions;
            else if (text == "Zero - Gravity Brews") price.initialDrinks = price.ZeroGravityBrews;
            else if (text == "Cosmic Mixology Cocktails") price.initialDrinks = price.CosmicMixologyCocktails;
            else if (text == "No Drinks") price.initialDrinks = 0;
        }

        private void updateDessert()
        {
            string text = listBoxDessert.Text;
            if (text == "Nanobite Nutella Nebula Bites") price.initialDessert = price.NanobiteNutellaNebulaBites;
            else if (text == "QuantumBerry Paradox Tart") price.initialDessert = price.QuantumBerryParadoxTart;
            else if (text == "Interdimensional Ice Cream Sundae") price.initialDessert = price.InterdimensionalIceCreamSundae;
            else if (text == "Galactic Pudding Pops") price.initialDessert = price.GalacticPuddingPops;
            else if (text == "No Dessert") price.initialDessert = 0;
        }


        private void updateComputation()
        {
            updateSize();
            updatePizza();
            updateDrinks();
            updateDessert();
            price.initialPrice = price.initialPizza + price.initialDrinks + price.initialDessert;
            textBoxAmount.Text = Convert.ToString(price.initialPrice);
        }

        private void clearPizza()
        {
            checkBoxQuantumVeggieFusion.Checked = false;
            checkBoxNanoMushromMeltdown.Checked = false;
            checkBoxRoboBBQBlast.Checked = false;
            checkBoxInterstellarInferno.Checked = false;
        }

        private void clearDrinks()
        {
            comboBox1.SelectedIndex = 0;
        }

        private void clearDessert()
        {
            listBoxDessert.SelectedIndex = 0;
        }
    }
}
