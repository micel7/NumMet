using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numthod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region test
        // Fungsi untuk menghitung nilai persamaan
        private double Equation(double x)
        {
            return Math.Sin(x) - Math.Exp(x) - x;
        }

        // Fungsi untuk mencari akar dengan metode biseksi
        private double Bisection(double a, double b, double epsilon)
        {
            if (Equation(a) * Equation(b) >= 0)
            {
                lbHasil.Items.Add("Interval [a, b] tidak valid.");
                return double.NaN;
            }

            double c = a;

            while ((b - a) >= epsilon)
            {
                // Temukan titik tengah
                c = (a + b) / 2;

                // Hitung nilai fungsi pada titik tengah
                double fc = Equation(c);

                // Jika akar sudah ditemukan dengan toleransi yang cukup
                if (Math.Abs(fc) < epsilon)
                {
                    break;
                }

                // Ganti interval [a, b] berdasarkan nilai fungsi pada titik tengah
                if (Equation(c) * Equation(a) < 0)
                {
                    b = c;
                }
                else
                {
                    a = c;
                }
            }

            return c;
        }
        #endregion

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(tbXl.Text, out int Xl)) ;
                else { throw new ArgumentException("Xl must be a number"); }
                if (int.TryParse(tbXl.Text, out int XU)) ;
                else { throw new ArgumentException("Xu must be a number"); }

                //while (tbXl.Text > 1 && tbXl.Text < 0)
            }
            catch (Exception ex) { MessageBox.Show("Sorry, " + ex.Message); }
        }
        //kadang nt
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
