using AcademicHandle.Usercontrol;
using Calender;
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
            if (temp_month - 1 == 0)
            {
                temp_month = 12;
                DisplayDate(temp_year-1,temp_month);
            }
            else 
            {
                DisplayDate(temp_year, temp_month - 1);
                temp_month -= 1;
            }
            
        }

        private void btnAfter_Click(object sender, EventArgs e)
        {
            panel_Calendar.Controls.Clear();
            if (temp_month + 1 == 13)
            {
                temp_month = 1;
                DisplayDate(temp_year + 1, temp_month);
            }
            else
            {
                DisplayDate(temp_year, temp_month + 1);
                temp_month += 1;
            }
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
            txtDateCalender.Text = $"Tháng {month}, Năm {year}";
            for (int i = 1; i <= days; i++)
            {
                DataTable dt = new DataTable();
                string date = year.ToString() +"-"+ month.ToString() +"-"+ i.ToString() + " 00:00:00";
                string date1 = year.ToString() +"-"+ month.ToString() +"-"+ i.ToString() + " 23:59:00";
                string sqlGetStatus = "select status from task_detail where create_date >= '"+ date + "' and create_date <= '"+ date1 + "'";
                dt = (new DataProvider()).executeQuery(sqlGetStatus);
                
                BlankCalendar timeTable_Day = new BlankCalendar();
                timeTable_Day.Day = i;
                if (dt.Rows.Count > 0)
                {
                    timeTable_Day.Status = "Có việc";
                } else
                {
                    timeTable_Day.Status = "Rảnh";
                }
                timeTable_Day.DisplayToday();
                if (month == DateTime.Now.Month && year == DateTime.Now.Year && i == DateTime.Now.Day)
                    timeTable_Day.DisplayToday();
                panel_Calendar.Controls.Add(timeTable_Day);
            }
        }
    }
}
