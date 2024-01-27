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

/*https://codeload.github.com/erselmetz/IntermediateProgrammingExam/zip/refs/heads/main
 * final Examination for Intermediate Programming
 * Ersel Metz Magbanua
 * Cedric Joel Berces
 * Ernielmark Garbin
 * Von Nathaniel Victorino
 */

namespace QuantumCrust_Innovations
{
    public partial class Form1 : Form
    {
        Price price = new Price();
        public Form1()
        {
            InitializeComponent();
            listBoxDessert.SelectedIndex = 0;
            pictureBox1.Image = Properties.Resources.icon;pictureBox2.Image = Properties.Resources.icon;
            pictureBox3.Image = Properties.Resources.icon;pictureBox4.Image = Properties.Resources.icon;
            this.BackgroundImage = Properties.Resources.bg;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDrinks();updateComputation();
        }

        private void radioButtonSmall_CheckedChanged(object sender, EventArgs e)
        {
            enabledPizza(); updateComputation();
        }

        private void radioButtonMedium_CheckedChanged(object sender, EventArgs e)
        {
            enabledPizza(); updateComputation();
        }

        private void radioButtonLarge_CheckedChanged(object sender, EventArgs e)
        {
            enabledPizza(); updateComputation();
        }

        private void checkBoxQuantumVeggieFusion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxQuantumVeggieFusion.Checked)
            {
                checkBoxNanoMushromMeltdown.Enabled = false;checkBoxRoboBBQBlast.Enabled = false;checkBoxInterstellarInferno.Enabled = false;pictureBox2.Image = Properties.Resources.Veggie;
            }
            else
            {
                checkBoxNanoMushromMeltdown.Enabled = true;checkBoxRoboBBQBlast.Enabled = true;checkBoxInterstellarInferno.Enabled = true;
                setPizzaDefaultIcon();
            }updateComputation();
        }

        private void checkBoxNanoMushromMeltdown_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNanoMushromMeltdown.Checked){checkBoxQuantumVeggieFusion.Enabled = false;checkBoxRoboBBQBlast.Enabled = false;checkBoxInterstellarInferno.Enabled = false;pictureBox2.Image = Properties.Resources.NanoMushroomMeltdown;}
            else{checkBoxQuantumVeggieFusion.Enabled = true;checkBoxRoboBBQBlast.Enabled = true;checkBoxInterstellarInferno.Enabled = true;setPizzaDefaultIcon();}
            updateComputation();
        }

        private void checkBoxRoboBBQBlast_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRoboBBQBlast.Checked){checkBoxQuantumVeggieFusion.Enabled = false;checkBoxNanoMushromMeltdown.Enabled = false;checkBoxInterstellarInferno.Enabled = false;pictureBox2.Image = Properties.Resources.RoboBBQBlast;}
            else{checkBoxQuantumVeggieFusion.Enabled = true;checkBoxNanoMushromMeltdown.Enabled = true;checkBoxInterstellarInferno.Enabled = true;setPizzaDefaultIcon();}
            updateComputation();
        }

        private void checkBoxInterstellarInferno_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInterstellarInferno.Checked){checkBoxQuantumVeggieFusion.Enabled = false;checkBoxNanoMushromMeltdown.Enabled = false;checkBoxRoboBBQBlast.Enabled = false;pictureBox2.Image = Properties.Resources.InterstellarInferno;}
            else{checkBoxQuantumVeggieFusion.Enabled = true;checkBoxNanoMushromMeltdown.Enabled = true;checkBoxRoboBBQBlast.Enabled = true;setPizzaDefaultIcon();}
            updateComputation();
        }

        private void listBoxDessert_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDessert();updateComputation();
        }

        private void labelClear_Click(object sender, EventArgs e)
        {
            disabledPizza(); clearPizza(); clearDrinks(); clearDessert();pictureBox1.Image = Properties.Resources.icon;price.clear();updateComputation();
            textBoxAmount.Text = "₱ 0"; textBoxPayment.Text = "₱ 0"; textBoxChange.Text = "₱ 0";textBoxChange.ForeColor = Color.DarkTurquoise;
        }

        private void labelComputer_Click(object sender, EventArgs e)
        {
            updateComputation();
        }

        private void updatePizzaSize()
        {
            if (radioButtonSmall.Checked){pictureBox1.Image = Properties.Resources.Small;price.setPizzaSmall();}
            else if (radioButtonMedium.Checked){pictureBox1.Image = Properties.Resources.Medium;price.setPizzaMedium();}
            else if (radioButtonLarge.Checked){pictureBox1.Image = Properties.Resources.Large;price.setPizzaLarge();}
            else { RadioButtonNone.Checked = true; }
        }
        private void updatePizza()
        {
            if (checkBoxQuantumVeggieFusion.Checked) price.initialPizza = price.QuantumVeggieFussion;
            else if (checkBoxNanoMushromMeltdown.Checked) price.initialPizza = price.NanoMushroomMeltdown;
            else if (checkBoxRoboBBQBlast.Checked) price.initialPizza = price.RobboBBQBlast;
            else if (checkBoxInterstellarInferno.Checked) price.initialPizza = price.InterstellarInferno;
            else price.initialPizza = 0;
        }

        private void updateDrinksSize()
        {
            if (NanoBiteDrinks.Checked) price.setDrinksSmall();
            else if (QuantumQuotaDrinks.Checked) price.setDrinksMedium();
            else if (GalacticFeastDrinks.Checked) price.setDrinksLarge();
            else comboBox1.SelectedIndex = 0;
        }
        private void updateDrinks()
        {
            updateDrinksSize();
            string text = comboBox1.Text;
            if (text == "Galactic Elixirs") { price.initialDrinks = price.GalacticElixirs; pictureBox3.Image = Properties.Resources.GalacticElexirs; }
            else if (text == "Neon Fusion Fizz") { price.initialDrinks = price.NeonFusionFizz; pictureBox3.Image = Properties.Resources.NeonFusionFizz; }
            else if (text == "Quantum Quencher") { price.initialDrinks = price.QuantumQuencher; pictureBox3.Image = Properties.Resources.QuantumQuencher; }
            else if (text == "Infinity Infusions") { price.initialDrinks = price.InfinityInfusions; pictureBox3.Image = Properties.Resources.InfinityInfusions; }
            else if (text == "Zero Gravity Brews") { price.initialDrinks = price.ZeroGravityBrews; pictureBox3.Image = Properties.Resources.ZeroGravityBrews; }
            else if (text == "Cosmic Mixology Cocktails") { price.initialDrinks = price.CosmicMixologyCocktails; pictureBox3.Image = Properties.Resources.Cocktail; }
            else if (text == "No Drinks") { price.initialDrinks = 0; pictureBox3.Image = Properties.Resources.icon; }
        }

        private void updateDessert()
        {
            string text = listBoxDessert.Text;
            if (text == "Nanobite Nutella Nebula Bites"){ price.initialDessert = price.NanobiteNutellaNebulaBites; pictureBox4.Image = Properties.Resources.NanoBitesNebulla; }
            else if (text == "QuantumBerry Paradox Tart"){ price.initialDessert = price.QuantumBerryParadoxTart; pictureBox4.Image = Properties.Resources.QuantumBerryPradoxTart; }
            else if (text == "Interdimensional Ice Cream Sundae"){ price.initialDessert = price.InterdimensionalIceCreamSundae; pictureBox4.Image = Properties.Resources.IceCreamSundae; }
            else if (text == "Galactic Pudding Pops"){ price.initialDessert = price.GalacticPuddingPops; pictureBox4.Image = Properties.Resources.GlacticPudding; }
            else if (text == "No Dessert"){ price.initialDessert = 0; pictureBox4.Image = Properties.Resources.icon; }
        }

        private void updateComputation()
        {
            updatePizzaSize();updatePizza();updateDrinksSize();updateDrinks();updateDessert();
            price.finalPrice = price.initialPizza + price.initialDrinks + price.initialDessert;
            textBoxAmount.Text = "₱ " + Convert.ToString(price.finalPrice);
            showPizzaPrice.Text = "Pizza : ₱ " + Convert.ToString(price.initialPizza);
            showDrinksPrice.Text = "Drinks ₱ " + Convert.ToString(price.initialDrinks);
            showDessertPrice.Text = "Dessert : ₱ " + Convert.ToString(price.initialDessert);
            if (textBoxPayment.Text != "₱ 0")
            {
                string paymentText = textBoxPayment.Text.Remove(0, 2);
                double payment = Convert.ToDouble(paymentText); float change = Convert.ToSingle(payment - price.finalPrice);
                textBoxChange.Text = "₱ " + Convert.ToString(change);
                if (change < 0) textBoxChange.ForeColor = Color.Red;else if (change > 0) textBoxChange.ForeColor = Color.Green;
            }
        }

        private void clearPizza()
        {
            checkBoxQuantumVeggieFusion.Checked = false;checkBoxNanoMushromMeltdown.Checked = false;checkBoxRoboBBQBlast.Checked = false;checkBoxInterstellarInferno.Checked = false;RadioButtonNone.Checked = true;disabledPizza();
        }

        private void clearDrinks()
        {
            NanoBiteDrinks.Checked = false;QuantumQuotaDrinks.Checked = false;GalacticFeastDrinks.Checked = false;
        }

        private void clearDessert()
        {
            listBoxDessert.SelectedIndex = 0;
        }

        private void NanoBiteDrinks_CheckedChanged(object sender, EventArgs e)
        {
            if (NanoBiteDrinks.Checked == true){QuantumQuotaDrinks.Checked = false;GalacticFeastDrinks.Checked = false;}updateComputation();
        }

        private void QuantumQuotaDrinks_CheckedChanged(object sender, EventArgs e)
        {
            if (QuantumQuotaDrinks.Checked == true){NanoBiteDrinks.Checked = false;GalacticFeastDrinks.Checked = false;}updateComputation();
        }

        private void GalacticFeastDrinks_CheckedChanged(object sender, EventArgs e)
        {
            if (GalacticFeastDrinks.Checked == true){NanoBiteDrinks.Checked = false;QuantumQuotaDrinks.Checked = false;}updateComputation();
        }

        private void setPizzaDefaultIcon()
        {
            pictureBox2.Image = Properties.Resources.icon;
        }
        private void enabledPizza()
        {
            checkBoxQuantumVeggieFusion.Enabled = true;
            checkBoxNanoMushromMeltdown.Enabled = true;
            checkBoxRoboBBQBlast.Enabled = true;
            checkBoxInterstellarInferno.Enabled = true;
        }
        private void disabledPizza()
        {
            checkBoxQuantumVeggieFusion.Enabled = false;
            checkBoxNanoMushromMeltdown.Enabled = false;
            checkBoxRoboBBQBlast.Enabled = false;
            checkBoxInterstellarInferno.Enabled = false;
        }
    }
}