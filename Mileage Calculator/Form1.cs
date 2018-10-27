using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mileage_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool CheckValues()
        {
            UInt64 startMiles;
            UInt64 endMiles;
            Double mileageRate;
            try
            {
                startMiles = Convert.ToUInt64(startingMileageBox.Text);
                endMiles = Convert.ToUInt64(endingMileageBox.Text);
                mileageRate = Convert.ToDouble(mileageRateBox.Text);
            }
            catch (Exception)
            {
                return false;
            }
            if(Convert.ToUInt64(startingMileageBox.Text) > Convert.ToUInt64(endingMileageBox.Text))
            {
                return false; //We could handle this with a more specific error message.
            }
            return true;
        }

        private Double CalculateValueOwed()
        {
            UInt64 startMiles;
            UInt64 endMiles;
            Double mileageRate;
            
            startMiles = Convert.ToUInt64(startingMileageBox.Text);
            endMiles = Convert.ToUInt64(endingMileageBox.Text);
            mileageRate = Convert.ToDouble(mileageRateBox.Text);

            Double owed = (endMiles - startMiles) * mileageRate;

            return owed; //owed is unnecessary, but it's not like i'm short memory here and I think it's clearer.
        }

        private UInt64 CalculateTotalMilesTravelled()
        {
            UInt64 startMiles = Convert.ToUInt64(startingMileageBox.Text);
            UInt64 endMiles = Convert.ToUInt64(endingMileageBox.Text);
            return endMiles - startMiles;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!CheckValues())
            {
                MessageBox.Show("Invalid values in form.");
                return;
            }
            else
            {
                Double cashOwed = CalculateValueOwed();
                UInt64 milesTravelled = CalculateTotalMilesTravelled();
                MessageBox.Show("Total cash owed: " + cashOwed + "\n" + "Total miles travelled: " + milesTravelled);
            }

        }
    }
}
