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
    public partial class Form2 : Form
    {
        private int currentCountdown = 10;
        public Form2(int _currentCountdown)
        {
            InitializeComponent();
            this.currentCountdown = _currentCountdown;
            countdownStateLabel.Text = this.currentCountdown.ToString();
            Timer timer = new Timer();
            timer.Tick += (sender, args) => {
                this.currentCountdown--;
                if (this.currentCountdown == 0)
                {
                    //Application.Exit();
                    this.DialogResult = DialogResult.OK;
                    //this.Close();
                }
                countdownStateLabel.Text = this.currentCountdown.ToString();
            };
            timer.Interval = 1000;
            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
