using AcademicHandle.Model;
using Calender;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicHandle
{
    public partial class frm_DetailedTimeTable : Form
    {
        TimeTableProperty data_timetable;
        public frm_DetailedTimeTable()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime DatetimeClick = new DateTime(dt_DatePicker.Value.Year, dt_DatePicker.Value.Month, dt_DatePicker.Value.Day, Convert.ToInt32(dt_HourPicker.Value), Convert.ToInt32(dt_MinutePicker.Value), 00);
            string sqlAddDetailDay = "insert into task_detail (task_name, description, create_date, level, status) values (N'"+ txt_Name .Text+ "', N'"+ txt_description.Text+ "', '"+DatetimeClick+ "',N'"+ drop_aim.Text + "', 1)";
            if ((new DataProvider()).executeNonQuery(sqlAddDetailDay))
            {
                MessageBox.Show("Add successfully", "Thông báo");
                frm_Main f = new frm_Main();
                this.Hide();
                f.Show();
            }
        }
    }
}
