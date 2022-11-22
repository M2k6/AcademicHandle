using AcademicHandle.Usercontrol;
using Calender;
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
        public frm_SetTask(int year , int month, int day)
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            //DateTime DatetimeClick = new DateTime(year, month, 0);
            //Console.WriteLine("AAAAAA" + DatetimeClick);
            string date = year.ToString() + "-" + month.ToString() + "-" + day.ToString() + " 00:00:00";
            string dateBreak = year.ToString() + "-" + month.ToString() + "-" + day.ToString() + " 08:00:00";
            string dateLunch = year.ToString() + "-" + month.ToString() + "-" + day.ToString() + " 16:00:00";
            string dateDinner = year.ToString() + "-" + month.ToString() + "-" + day.ToString() + " 23:59:00";
            string sqlGetBreak = "select task_name from task_detail where create_date >= '" + date + "' and create_date <= '" + dateBreak + "'";
            string sqlGetLunch = "select task_name from task_detail where create_date >= '" + dateBreak + "' and create_date <= '" + dateLunch + "'";
            string sqlGetDinner = "select task_name from task_detail where create_date >= '" + dateLunch + "' and create_date <= '" + dateDinner + "'";
            dt = (new DataProvider()).executeQuery(sqlGetBreak);
            MissionBlank mb = new MissionBlank();

            foreach (DataRow row in dt.Rows)
            {
                string name = row["task_name"].ToString();
                mb.Display(name);
                panel_Morning.Controls.Add(mb);
            }

            dt = (new DataProvider()).executeQuery(sqlGetLunch);
            MissionBlank mb1 = new MissionBlank();
            foreach (DataRow row in dt.Rows)
            {
                string name = row["task_name"].ToString();
                mb1.Display(name);
                panel_Afternoon.Controls.Add(mb1);
            }

            dt = (new DataProvider()).executeQuery(sqlGetDinner);
            MissionBlank mb2 = new MissionBlank();
            foreach (DataRow row in dt.Rows)
            {
                string name = row["task_name"].ToString();
                mb2.Display(name);
                panel_Evenning.Controls.Add(mb2);
            }
        }

        private void DetailedTimeTableOpen_Click(object sender, System.EventArgs e)
        {
            frm_DetailedTimeTable detailedTimeTable = new frm_DetailedTimeTable();
            detailedTimeTable.ShowDialog();
        }
    }
}
