using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {
        public VehicleUi()
        {
            InitializeComponent();
        }

        Vehicle vehicle = new Vehicle();

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (! String.IsNullOrEmpty(vehicleNameTextBox.Text) && !String.IsNullOrEmpty(regNoTextBox.Text))
            {
                vehicle.GetName = vehicleNameTextBox.Text;
                vehicle.GetRegNo = regNoTextBox.Text;

                vehicleNameTextBox.Clear();
                regNoTextBox.Clear();

            }
            else
            {
                MessageBox.Show("Feild Can't be Empty  ");
            }

            

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(speedTextBox.Text))
            {
                vehicle.GetSpeed = Convert.ToDouble(speedTextBox.Text);
                vehicle.AddSpeedToList();
                speedTextBox.Clear();

            }

            else
            {
                MessageBox.Show("Speed Cant be empty ");
            }

        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
           
                minSpeedTextBox.Text = vehicle.MinSpeed().ToString();
                maxSpeedTextBox.Text = vehicle.MaxSpeed().ToString();
                averageSpeedTextBox.Text = vehicle.AverageSpeed().ToString();
           
        }
    }

}
