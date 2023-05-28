using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace cafe_management
{
    public partial class splash : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int ntoprect,
            int RightRect,
            int nbottomRect,
            int nWidthEllipse,
            int nHeightEllipse

            );



        public splash()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            Progressbar1.Value = 0;
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Progressbar1.Value += 1;
            Progressbar1.Text = Progressbar1.Value.ToString() + "%";

            if(Progressbar1.Value == 100)
            {
                timer1.Enabled = false;
                Login lg = new Login();
                lg.Show();
                this.Hide();
            }
        }
    }
}
