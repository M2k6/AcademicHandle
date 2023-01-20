using AcademicHandle.Usercontrol;
using Calender;
using System;
using System.Data;
using System.Windows.Forms;

namespace AcademicHandle
{
    public partial class frm_SetTask : Form
    {
        public frm_SetTask()
        {
            //InitializeComponent();
        }

        int _year, _month, _day;
        public frm_SetTask(int year , int month, int day)
        {
            InitializeComponent();
            _year = year;
            _month = month;
            _day = day;
            Display();
        }

        public void Display()
        {
            DataTable dt = new DataTable();
            //DateTime DatetimeClick = new DateTime(year, month, 0);
            //Console.WriteLine("AAAAAA" + DatetimeClick);
            string date = _year.ToString() + "-" + _month.ToString() + "-" + _day.ToString() + " 00:00:00";
            string dateBreak = _year.ToString() + "-" + _month.ToString() + "-" + _day.ToString() + " 08:00:00";
            string dateLunch = _year.ToString() + "-" + _month.ToString() + "-" + _day.ToString() + " 16:00:00";
            string dateDinner = _year.ToString() + "-" + _month.ToString() + "-" + _day.ToString() + " 23:59:00";
            string sqlGetBreak = "select task_name from task_detail where create_date >= '" + date + "' and create_date <= '" + dateBreak + "' and status = 1";
            string sqlGetLunch = "select task_name from task_detail where create_date >= '" + dateBreak + "' and create_date <= '" + dateLunch + "' and status = 1";
            string sqlGetDinner = "select task_name from task_detail where create_date >= '" + dateLunch + "' and create_date <= '" + dateDinner + "' and status = 1";
            dt = (new DataProvider()).executeQuery(sqlGetBreak);
            

            foreach (DataRow row in dt.Rows)
            {
                MissionBlank mb = new MissionBlank();
                mb.Dock = DockStyle.Top;
                string name = row["task_name"].ToString();
                mb.Display(name);
                panel_Morning.Controls.Add(mb);
            }

            dt = (new DataProvider()).executeQuery(sqlGetLunch);
            foreach (DataRow row in dt.Rows)
            {
                MissionBlank mb1 = new MissionBlank();

                string name = row["task_name"].ToString();
                mb1.Display(name);
                panel_Afternoon.Controls.Add(mb1);
            }

            dt = (new DataProvider()).executeQuery(sqlGetDinner);
            foreach (DataRow row in dt.Rows)
            {
                MissionBlank mb2 = new MissionBlank();

                string name = row["task_name"].ToString();
                mb2.Display(name);
                panel_Evenning.Controls.Add(mb2);
            }
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            OnChecking();
        }

        private void DetailedTimeTableOpen_Click(object sender, System.EventArgs e)
        {
            frm_DetailedTimeTable detailedTimeTable = new frm_DetailedTimeTable();
            detailedTimeTable.ShowDialog();
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            panel_Morning.Controls.Clear();
            panel_Evenning.Controls.Clear();
            panel_Afternoon.Controls.Clear();
            Display();
        }
        // Event Field 
        public event EventHandler MoveBackMainFrm;
        public void OnChecking()
        {
            MoveBackMainFrm.Invoke(this, EventArgs.Empty);
        }
    }
}
