using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int temp;
        int first,second;
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_Click(object sender, EventArgs e)
        {
            first = Convert.ToInt32(txt1.Text);
            second = Convert.ToInt32(txt2.Text);
            temp = second;
            txt2.Text = Convert.ToString(txt1.Text);
            txt1.Text = Convert.ToString(temp);

        }
    }
}
