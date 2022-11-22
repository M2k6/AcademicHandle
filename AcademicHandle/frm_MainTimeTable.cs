using AcademicHandle.Usercontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicHandle
{
    public partial class frm_MainTimeTable : Form
    {
        int temp_month, temp_year;
        public frm_MainTimeTable()
        {
            InitializeComponent();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            panel_Calendar.Controls.Clear();
            BlankCalendar timeTable_Day = new BlankCalendar();
            DisplayDate(temp_year - 1, temp_month - 1);
            panel_Calendar.Controls.Add(timeTable_Day);
        }

        private void btnAfter_Click(object sender, EventArgs e)
        {
            panel_Calendar.Controls.Clear();
            BlankCalendar timeTable_Day = new BlankCalendar();
            DisplayDate(temp_year + 1, temp_month + 1);
            panel_Calendar.Controls.Add(timeTable_Day);
        }

        private void frm_MainTimeTable_Load(object sender, EventArgs e)
        {
            DisplayDate(DateTime.Now.Year, DateTime.Now.Month);
            temp_month = DateTime.Now.Month;
            temp_year = DateTime.Now.Year;
        }
        private void DisplayDate(int year, int month)
        {
            panel_Calendar.Controls.Clear();
            int days = DateTime.DaysInMonth(year, month);
            for (int i = 0; i < days; i++)
            {
                BlankCalendar timeTable_Day = new BlankCalendar();
                timeTable_Day.Day = i;
                if (month == DateTime.Now.Month && year == DateTime.Now.Year && i == DateTime.Now.Day)
                    timeTable_Day.DisplayToday();
                panel_Calendar.Controls.Add(timeTable_Day);
            }
        }
    }
}
