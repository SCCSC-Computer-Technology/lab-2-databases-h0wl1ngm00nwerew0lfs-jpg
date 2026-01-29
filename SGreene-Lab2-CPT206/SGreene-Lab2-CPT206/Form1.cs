//Sebastian Greene
//CPT 206
//Lab 2


using SGreene_Lab2_CPT206.CityDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGreene_Lab2_CPT206
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //This should loads data into the 'cityDBDataSet.City' table. You can move, or remove it,

            this.cityTableAdapter.Fill(this.cityDBDataSet.City);
            cityDataGridView.DataSource = cityBindingSource;
        }

        private void lowestBtn_Click(object sender, EventArgs e)
        {
            //this should take ad find the lowest popualtion using min and allow me to place it in the abel
            var minPopulation = cityDBDataSet.City.AsEnumerable().Min(row => row.Field<int>("Population"));
          
            //this shoudl change the label to display the lowest pop
            labelLowest.Text = "Lowest Population:" + minPopulation;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void highestBtn_Click(object sender, EventArgs e)
        {
            //this should let me use the Max to find the highest popualtion in the table
            var maxPopulation = cityDBDataSet.City.AsEnumerable().Max(row => row.Field<int>("Population"));
        
            //this should make it where it displays the highest popualtion
            labelHighest.Text = "Highest Population: "+ maxPopulation;
        }

        private void averageBtn_Click(object sender, EventArgs e)
        {
            var averagePopulation = cityDBDataSet.City.AsEnumerable().Average(row => row.Field<int>("Population"));
    

            //this should cahnge the label to display the average pop

            labelAverage.Text = "Average Popualtion:" + averagePopulation;
        }

        private void totalBtn_Click(object sender, EventArgs e)
        {
            var totalPopulation = cityDBDataSet.City.AsEnumerable().Sum(row => row.Field<int>("Population"));
   
            //this hsould change the label to show the total pop
            labelTotal.Text = "Total Popaltion:" + totalPopulation;
        }

        private void nameBtn_Click(object sender, EventArgs e)
        {

            //thankfully ordering by name can be done automatically by DESC. Or alphabatically is done naturally by descending order
            cityBindingSource.Sort = "City DESC";
        }

        private void popAscendingBtn_Click(object sender, EventArgs e)
        {
            //thanks to this being dtaabase and sql I should be able to use ASC to sort it in oascending order
            cityBindingSource.Sort = "Population ASC";
        }

        private void popDescendingbtn_Click(object sender, EventArgs e)
        {
            // once again thanks to database and sql DESC should sort it descending
            cityBindingSource.Sort = "Population DESC";
        }



        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxcity.Text) || string.IsNullOrWhiteSpace(txtBoxstate.Text) || string.IsNullOrWhiteSpace(txtBoxpop.Text))
            {
                //this should tell them to actuallt put someing in the text box

                MessageBox.Show("Please enter your data.");

                return;
            }

            //this checks for the user actually putting in something that works for pop
            else if (!int.TryParse(txtBoxpop.Text.Trim(), out int population))
            {
                MessageBox.Show("Please enter an actual valid number for population, please.");

                return;
            }

            //some double checking to make sure the use for sure cant place anything negative
            else if (population < 0)
            {
                MessageBox.Show("You can not put a negative for the popualtion.");

                return;
            }

            DataRow newRow = cityDBDataSet.City.NewRow();

            newRow["City"] = txtBoxcity.Text.Trim();

            newRow["State"] = txtBoxstate.Text.Trim();

            newRow["Population"] = population;

            //where the magic actually happens for adding the user data to the table
            cityDBDataSet.City.Rows.Add(newRow);

            //now to set it in place for the entrie thing
            cityTableAdapter.Update(cityDBDataSet.City);


            MessageBox.Show("New entery added.");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            //if done rgiht this should remove the current selected row
            if (cityBindingSource.Current != null)
            {
                cityBindingSource.RemoveCurrent();

                //this should update the entrie thing to fully remove it for good
                cityTableAdapter.Update(cityDBDataSet.City);
            }
        }
    }
}
