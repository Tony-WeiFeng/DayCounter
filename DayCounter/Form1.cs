using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DayCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ye = Convert.ToInt32(TB_year.Text);
            int mo = Convert.ToInt32(TB_month.Text);
            int da = Convert.ToInt32(TB_day.Text);

            L_result.Text = dayCount(ye,mo,da).ToString();
            
        }

        static int dayCount(int y, int m, int d)
        {
            DateTime startDate = new DateTime(y,m,d);
            TimeSpan differ = DateTime.Now.Subtract(startDate);
            //int year = y;
            //int month = m;
            //int day = d;
            
            int result = differ.Days;

            return result;
        }

    }
}
