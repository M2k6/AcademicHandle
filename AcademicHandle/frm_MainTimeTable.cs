﻿using AcademicHandle.Model;
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

        private void btnWorkSpaceOpen_Click(object sender, EventArgs e)
        {
            panel_Container.BringToFront();
            panel_Container.Controls.Clear();
            frm_Workspace frm = new frm_Workspace();
            frm.TopLevel = false;
            frm.MoveBackMainFrm += Frm_MoveBackMainFrm;
            panel_Container.Controls.Add(frm);
            frm.Show();
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
                timeTable_Day.CheckChanged += TimeTable_Day_CheckChanged;
                timeTable_Day.Day = i;
                timeTable_Day.Month = month;
                timeTable_Day.Year = year;
                foreach (DataRow row in dt.Rows)
                {
                    timeTable_Day.Status = "Có việc";
                }
                timeTable_Day.DisplayToday();
                if (month == DateTime.Now.Month && year == DateTime.Now.Year && i == DateTime.Now.Day)
                    timeTable_Day.DisplayToday();
                panel_Calendar.Controls.Add(timeTable_Day);
            }
        }
        private void TimeTable_Day_CheckChanged(object sender, MissionDateTime e)
        {
            if (e.IsChecked == true)
            {
                frm_SetTask newfrm = new frm_SetTask(e.DateForSetup.Year,e.DateForSetup.Month,e.DateForSetup.Day);
                panel_Container.BringToFront();
                panel_Container.Controls.Clear();
                newfrm.TopLevel = false;
                newfrm.MoveBackMainFrm += Newfrm_MoveBackMainFrm1;
                panel_Container.Controls.Add(newfrm);
                newfrm.Show();
            }
        }

        private void Frm_MoveBackMainFrm(object sender, EventArgs e)
        {
            panel_Container.Controls.Clear();
            panel_Container.SendToBack();
        }

        private void Newfrm_MoveBackMainFrm1(object sender, EventArgs e)
        {
            panel_Container.Controls.Clear();
            panel_Container.SendToBack();
        }
    }
}
