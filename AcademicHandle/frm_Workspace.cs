using AcademicHandle.Usercontrol;
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
    public partial class frm_Workspace : Form
    {
        private MusicDragger dragger;
        public frm_Workspace()
        {
            InitializeComponent();
        }
        void SetMusicDragger()
        {
            Point MusicIcon_pointer = new Point(btnMusic.Location.X,btnMusic.Location.Y);
            
        }
        private void frm_Workspace_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string sql_command = "select * from task_detail";
            dt = (new DataProvider()).executeQuery(sql_command);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            this.dragger.Location = new Point(btnMusic.Location.X + btnMusic.Location.X,btnMusic.Location.Y);
            this.Controls.Add(this.dragger);
            this.dragger.Show();
        }
    }
}
