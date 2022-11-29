using Calender;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicHandle.Usercontrol
{
    public partial class MissionBlank : UserControl
    {
        public MissionBlank()
        {
            InitializeComponent();
            if (lbName.PreferredHeight > panel1.Height)
            panel1.Height = lbName.Height+8;
        }
        public void Display(string name)
        {
            lbName.Text = name;
        }
        private void MissionBlank_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void thôngTinChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cmd = $"";
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cmd = $"delete from task_detail where task_name = N'{lbName.Text}'";
            DialogResult msg = MessageBox.Show("Bạn đã chắc chắn xóa nhiệm vụ này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                using (DataProvider conn = new DataProvider())
                {
                    conn.executeNonQuery(cmd);
                    this.Dispose();
                }
            }
        }

        private void hoànThànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string cmd = $"update task_detail set status = 0 where task_name = N'{lbName.Text}'";
            DialogResult msg = MessageBox.Show("Bạn đã chắc chắn hoàn thành công việc này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                using (DataProvider data = new DataProvider())
                {
                    data.executeNonQuery(cmd);
                    this.Dispose();
                }
            }

        }
    }
}
