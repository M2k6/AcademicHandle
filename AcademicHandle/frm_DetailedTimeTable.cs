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
        int GetID(int variable) 
        {
            return variable;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if ((int)dt_DatePicker.Value.Year < (int)DateTime.Now.Year ||
                (int)dt_DatePicker.Value.Month < (int)DateTime.Now.Year && (int)dt_DatePicker.Value.Year == (int)DateTime.Now.Year ||
                (int)dt_DatePicker.Value.Day < (int) DateTime.Now.Day && (int)dt_DatePicker.Value.Month < (int)DateTime.Now.Year && (int)dt_DatePicker.Value.Year == (int)DateTime.Now.Year||
                (int)dt_DatePicker.Value.Day < (int)DateTime.Now.Day && (int)dt_DatePicker.Value.Month < (int)DateTime.Now.Year && (int)dt_DatePicker.Value.Year == (int)DateTime.Now.Year && ((int)dt_HourPicker.Value*60 + (int)dt_MinutePicker.Value)< ((int)DateTime.Now.Hour*60+(int)DateTime.Now.Minute))
            MessageBox.Show("Thời gian bạn nhập không hợp lệ","Thông báo!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txt_Name.Text == null || txt_Name.Text == "" || txt_description.Text == null || txt_description.Text == "")
            {
                MessageBox.Show("Bạn cần phải điền đủ thông tin","Thông báo!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                DateTime DatetimeClick = new DateTime(dt_DatePicker.Value.Year, dt_DatePicker.Value.Month, dt_DatePicker.Value.Day, Convert.ToInt32(dt_HourPicker.Value), Convert.ToInt32(dt_MinutePicker.Value), 00);
                string sqlAddDetailDay = "insert into task_detail (id,ask_name, description, create_date, level, status, purpose_relation) values (N'" + txt_Name.Text + "', N'" + txt_description.Text + "', '" + DatetimeClick + "',N'" + drop_levelimportant.Text + "', 1," + drop_aim.Text + ")";
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
}
