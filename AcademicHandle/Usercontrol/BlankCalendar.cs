using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicHandle.Usercontrol
{
    public partial class BlankCalendar : UserControl
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public string Status { get; set; }
        public bool IsToday { get; set; }
        public BlankCalendar()
        {
            InitializeComponent();
        }
        public void DisplayToday()
        {
            lb_Date.Text = Day.ToString();
            lb_Status.Text = Status;
            if (IsToday == true) lb_Date.ForeColor = Color.Red;
        }

        private void BlankCalendar_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(168, 209, 223);
        }

        private void BlankCalendar_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lb_Date_Click(object sender, EventArgs e)
        {
            frm_SetTask a = new frm_SetTask(Year, Month, Day);
            a.Show();
        }
    }
}
