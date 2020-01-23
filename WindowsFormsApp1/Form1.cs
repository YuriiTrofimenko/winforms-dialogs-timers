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
        private int currentCountdown = 10;

        public Form1()
        {
            InitializeComponent();
            countdownLabel.Text = currentCountdown.ToString();
            countdownTextBox.Text = currentCountdown.ToString();
        }

        private void clickMeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello WinForms");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // MessageBox.Show("Window will close!");

            /* Second Form Demo */

            Form2 form2 = new Form2(this.currentCountdown);
            DialogResult result = form2.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            base.OnFormClosing(e);

            /* DialogResult result =
                MessageBox.Show(
                    "Window will close!",
                    "Warning",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1
                );
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            base.OnFormClosing(e); */
        }

        private void countdownTextBox_TextChanged(object sender, EventArgs e)
        {
            currentCountdown = Int32.Parse(countdownTextBox.Text);
            countdownLabel.Text = currentCountdown.ToString();
        }
    }
}
