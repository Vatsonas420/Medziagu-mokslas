using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Area = double.Parse(textBox1.Text);
            double Space = double.Parse(textBox2.Text);
            double Capacity = double.Parse(textBox3.Text);
            double Thickness = double.Parse(textBox4.Text);

            double AreaPowerToo = double.Parse(textBox6.Text);
            double SpacePowerToo = double.Parse(textBox7.Text);
            double CapacityPowerToo = double.Parse(textBox8.Text);
            double ThicknessPowerToo = double.Parse(textBox9.Text);

            //double Area = 1.04;
            //double Space = 4.2;
            //double Capacity = 30;
            //double Thickness = 1.475;

            //double AreaPowerToo = -2;
            //double SpacePowerToo = -3;
            //double CapacityPowerToo = -12;
            //double ThicknessPowerToo = -3;

            Capacity = Capacity * Math.Pow(10, CapacityPowerToo);
            Space = Space * Math.Pow(10, SpacePowerToo);
            Area = Area * Math.Pow(10, AreaPowerToo);
            Thickness = Thickness * Math.Pow(10, ThicknessPowerToo);

            textBox5.Text = Calculate(Capacity, Space, Area, Thickness).ToString();
        }
        
        public double Calculate ( double c , double s , double a , double t)
        {
            
            return (c * t) / (8.85 * Math.Pow(10, -12) * a - c * (s - t));
        }
    }
}
