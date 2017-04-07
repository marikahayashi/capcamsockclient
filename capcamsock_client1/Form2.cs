using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capcamsock_client1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer_expd1_Tick(object sender, EventArgs e)
        {
            try
            {
                Image img = ((Form1)this.Owner).get_image(
                    ((Form1)this.Owner).curCamNum );                
                this.pictureBox1.Image = img;
            }
            catch (Exception exception)
            {
            }

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.timer_expd1.Enabled = false;
            switch ( ((Form1)this.Owner).curCamNum )
            {
                case 0:
                    ((Form1)this.Owner).timer1.Enabled = true;
                    break;
                case 1:
                    ((Form1)this.Owner).timer2.Enabled = true;
                    break;
                case 2:
                    ((Form1)this.Owner).timer3.Enabled = true;
                    break;
                case 3:
                    ((Form1)this.Owner).timer4.Enabled = true;
                    break;
                default:
                    break;
            }
        }
    }
}
