using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Facts
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            //create instance of the NutritionForm class
            NutritionForm nutriForm = new NutritionForm();

            //create instances of food class for radio button items
            Food banana = new Food("1 banana", "100", "0.4","27");
            Food popcorn = new Food("1 cup air-popped popcorn", "35", "0.4", "6");
            Food muffin = new Food("1 lg blueberry muffin", "385", "9", "67");
            
            //find selected radio button 
            if (bananaRadioButton.Checked)
            {
                nutriForm.foodLabel.Text = banana.Name;
                nutriForm.caloriesLabel.Text = banana.Cals;
                nutriForm.fatLabel.Text = banana.Fat;
                nutriForm.carbLabel.Text = banana.Carbs;
            }
            else if (popcormRadioButton.Checked)
            {
                nutriForm.foodLabel.Text = popcorn.Name;
                nutriForm.caloriesLabel.Text = popcorn.Cals;
                nutriForm.fatLabel.Text = popcorn.Fat;
                nutriForm.carbLabel.Text = popcorn.Carbs;
            }
            else if (muffinRadioButton.Checked)
            {
                nutriForm.foodLabel.Text = muffin.Name;
                nutriForm.caloriesLabel.Text = muffin.Cals;
                nutriForm.fatLabel.Text = muffin.Fat;
                nutriForm.carbLabel.Text = muffin.Carbs;
            }

            //display the nutrition form
            nutriForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
