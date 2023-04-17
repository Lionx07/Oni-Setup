using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace oni_setup
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
            label2.Text = "Loanding Profile...";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadpanel.Width += 3;

            if(loadpanel.Width >= 300)
            {
                label2.Text = "Searching System Data...";
            }

            if (loadpanel.Width >= 550)
            {
                label2.Text = "Almost There...";
            }

            if (loadpanel.Width >= 700)
            {
                label2.Text = "Completed!";
            }

            if (loadpanel.Width >= 800)
            {
                timer1.Stop();
                MainForm mainForm = new MainForm();

                mainForm.Show();
                this.Hide();                              
            }
        }
    }
}
