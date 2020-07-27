using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulate_load_Progress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            //simulating the load progress
            progressBar1.Value = progressBar1.Value + 1;

            if(progressBar1.Value == 99)//if progressbar is fully loaded stop the process and reset it
            {
                progressBar1.Value = progressBar1.Value - 99;//reset progress
                timer1.Stop();//stop after reset the process
                //after loading the full progress bar do something
                MessageBox.Show("progress has been completed", "sometitle");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //start simulating
            timer1.Start();
        }
    }
}
