using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boostpanel
{
    public partial class alerts : Form
    {
        private static int value;

        private int interval;

        public enum AlertType
        {
            success,
            info,
            warning,
            error
        }

        private void alerts_Load(object sender, EventArgs e)
        {
            int num2 = (value = (base.Top = Screen.PrimaryScreen.Bounds.Height - base.Height - 50));
            base.Opacity = 0.0;
            base.Top = Screen.PrimaryScreen.Bounds.Height - base.Height - 5;
            base.Left = Screen.PrimaryScreen.Bounds.Width - base.Width - 10;
            timer2.Enabled = true;
            timer2.Start();
        }

        public static void Show(string message, AlertType type)
        {
            new alerts(message, type).Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            timer3.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (base.Top > value)
            {
                if (base.Opacity < 90.0)
                {
                    base.Opacity += 0.08;
                }
                base.Top += interval;
                interval--;
            }
            else
            {
                timer2.Stop();
                base.Opacity = 90.0;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (base.Opacity > 0.0)
            {
                base.Opacity -= 0.05;
            }
            else
            {
                Close();
            }
        }

        public alerts(string message, AlertType type)
        {
            InitializeComponent();
            base.ShowInTaskbar = false;
            switch (type)
            {
                case AlertType.success:
                    BackColor = Color.Indigo;
                    label1.Text = message;
                    break;
                case AlertType.error:
                    BackColor = Color.IndianRed;
                    label1.Text = message;
                    break;
            }
        }
    }
}
