using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void onBtn_Click(object sender, EventArgs e)
        {
            powerButton1.PowerOnState = true;
            resultTxtBox.Text = powerButton1.PowerOnState.ToString();
        }

        private void offBtn_Click(object sender, EventArgs e)
        {
            powerButton1.PowerOnState = false;
            resultTxtBox.Text = powerButton1.PowerOnState.ToString();
        }

        private void togBtn_Click(object sender, EventArgs e)
        {
            powerButton1.ToggleState();
            resultTxtBox.Text = powerButton1.PowerOnState.ToString();
        }

       
        private void powerButton1_PowerStateChanged(object sender, EventArgs e)
        {
            resultTxtBox.Text = sender.ToString();
        }

       


    }
}
