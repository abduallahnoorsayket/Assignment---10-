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

        Vehicle _vehicle;
        public VehicleUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            _vehicle = new Vehicle(vehicleNameTextBox.Text, regNoTextBox.Text);

            vehicleNameTextBox.Clear();
            regNoTextBox.Clear();

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            _vehicle.Speed = Convert.ToDouble(speedTextBox.Text);
            _vehicle.SetSpeed();

            speedTextBox.Clear();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            minSpeedTextBox.Text = _vehicle.GetMinSpeed().ToString();
            maxSpeedTextBox.Text = _vehicle.GetMaxSpeed().ToString();
            averageSpeedTextBox.Text = _vehicle.GetAverageSpeed().ToString();
        }
    }
}