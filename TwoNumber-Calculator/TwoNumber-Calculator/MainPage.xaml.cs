using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TwoNumber_Calculator
{
    public partial class MainPage : ContentPage
    {
        private double total = 0;
        private double firstNumber=0;
        private double lastNumber=0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAdd(object sender, EventArgs e)
        {
            total = Convert.ToInt32(num1.Text) + Convert.ToInt32(num2.Text);
            resultText.Text = total.ToString();
        }

        private void btnSub(object sender, EventArgs e)
        {
            total = Convert.ToInt32(num1.Text) - Convert.ToInt32(num2.Text);
            resultText.Text = total.ToString();
        }
        private void btnMul(object sender, EventArgs e)
        {
            total = Convert.ToInt32(num1.Text) * Convert.ToInt32(num2.Text);
            resultText.Text = total.ToString();
        }
        private void btnDiv(object sender, EventArgs e)
        {
            total = Convert.ToDouble(num1.Text) / Convert.ToDouble(num2.Text);
            resultText.Text = total.ToString();
        }
        private void btnAC(object sender, EventArgs e)
        {
            total = 0;
            resultText.Text = total.ToString();
            num1.Text = "";
            num2.Text = "";
        }
        private void btnPerc(object sender, EventArgs e)
        {
            total = Convert.ToDouble(num1.Text) * (Convert.ToDouble(num2.Text) *0.01);
            resultText.Text = total.ToString();
        }
        private void btnSqr(object sender, EventArgs e)
        {
            total = Math.Sqrt(Convert.ToDouble(num1.Text));
            resultText.Text = total.ToString();
        }
        private void btn2x(object sender, EventArgs e)
        {
            total += total ;
            resultText.Text = total.ToString();
        }
    }
}