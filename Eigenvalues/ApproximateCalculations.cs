using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eigenvalues
{
    public partial class ApproximateCalculations : Form
    {
        double startPoint, endPoint;
        double numberOfSegments;

        public ApproximateCalculations()
        {
            InitializeComponent();
        }

        private double function(double x)
        {
            return 0;
        }

        private double MaxSecondDerivetiveTrapeze()
        {
            return 0;
        }
       

        private double ExecuteSqure(double[] list)
        {
            int n = (int)numericUpDownSegments.Value;
            double l=(double)numericUpDownLeft.Value,r=(double)numericUpDownRight.Value;
            double h = (l - r) / n;
            double res = 0;

            for(int i = 1; i <= n; i++)
            {

            }

            return 0;
        }
        private double ExecuteTrapeze()
        {
            double h = (endPoint - startPoint) / numberOfSegments;
            double res = (function(startPoint)+function(endPoint))/ 2;

            for(double i = startPoint + h; i <= endPoint; i += h)
            {
                res += function(i);
            }
            res *= h;
            res += MaxSecondDerivetiveTrapeze();

            return res;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            startPoint = (double)numericUpDownLeft.Value;
            endPoint = (double)numericUpDownRight.Value;
            numberOfSegments = (double)numericUpDownSegments.Value;
            double res;

            if (radioButtonSqure.Checked)
            {
                res=ExecuteSqure(new double[] { 2,3});
                labelAnswer.Text = res.ToString();
            }

            else if (radioButtonTrapeze.Checked)
            {
                res=ExecuteTrapeze();
                labelAnswer.Text = res.ToString(); 

            }

            else
            {
                MessageBox.Show("Choose the method of an integral calculate!");
            }
        }
    }
}
