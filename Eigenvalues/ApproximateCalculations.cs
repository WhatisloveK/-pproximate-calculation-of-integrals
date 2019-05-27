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
        public ApproximateCalculations()
        {
            InitializeComponent();
            InitializeDataGridView(2, 2);
        }
        private void InitializeDataGridView(int rows, int columns)
        {
            dataGridView1.ColumnCount = columns;
            dataGridView1.ColumnHeadersVisible = true;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;


            for (int i = 0; i < columns; ++i)
            {
                dataGridView1.Columns[i].Width = 64;
                dataGridView1.Columns[i].Name = (i + 1).ToString();
            }

            dataGridView1.RowCount = rows + 2;
            dataGridView1.RowHeadersVisible = true;

            DataGridViewCellStyle rowHeaderStyle = new DataGridViewCellStyle();
            rowHeaderStyle.BackColor = Color.Beige;
            rowHeaderStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            dataGridView1.RowHeadersDefaultCellStyle = rowHeaderStyle;

            //f = new Class26BasedSys();
            
            dataGridView1.Rows[0].HeaderCell.Value = "X";
            dataGridView1.Rows[0].ReadOnly = false;
            
            dataGridView1.Rows[rows-1].HeaderCell.Value = "";
            dataGridView1.Rows[rows-1].ReadOnly = true;
            dataGridView1.Rows[rows].HeaderCell.Value = "F";

            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            dataGridView1.RowHeadersWidth = 64;
            
        }

        private double function(double x)
        {
            return 0;
        }

        private void buttonSize_Click(object sender, EventArgs e)
        {

            InitializeDataGridView(2, (int)numericUpDownRows.Value);
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
        private double ExecuteTrapeze(double[] list)
        {
            return 0;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            double[] polinomialCoeff = new double[(int)numericUpDownRows.Value];
            for (int j = 0; j < dataGridView1.ColumnCount; j++)
            {
                polinomialCoeff[j] = Double.Parse(dataGridView1.Rows[0].Cells[j].Value.ToString());
            }

            if (!radioButtonSqure.Checked)
            {
                ExecuteSqure(polinomialCoeff);
            }
            else
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    //listX[j] = ChebyshovPolinomial(j,dataGridView1.ColumnCount);
                    //listF[j] = Double.Parse(dataGridView1.Rows[2].Cells[j].Value.ToString());
                }
            }
            
            string res = "";
            for(int i = 0; i < listX.Length; i++)
            {
                int j = 0;
                double k = denominator[i] * listF[i];
                res += ((k > 0 ? ((i != 0) ? '+' : ' ') : '-'));
                res += Math.Abs(Math.Round(k,4));
                while (j < listX.Length)
                {
                    if (i != j)
                    {
                        res += "(x " + (listX[j]>0 ? '-' : '+')+" "+Math.Abs(Math.Round(listX[j],4)) + ")";
                    }
                    j++;
                }
                res += "\n";
            }
            label2.Text = res;
        }

        
    }
}
