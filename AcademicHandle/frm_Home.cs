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
    public partial class frm_Home : Form
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public frm_Home()
        {
            InitializeComponent();
        }

        public frm_Home(int height, int width)
        {
            InitializeComponent();
            panel_Container.Height = height;
            panel_Container.Width = width;
        }

        private void btnKnowledgeRevise_Click(object sender, EventArgs e)
        {
            
        }


        private void btnEvaluation_Aim_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnMainTimeTable_Click(object sender, EventArgs e)
        {
            frm_MainTimeTable frm = new frm_MainTimeTable();
            panel_Container.BringToFront();
            panel_Container.Controls.Clear();
            frm.TopLevel = false;
            //frm.Dock = DockStyle.Fill;
            panel_Container.Controls.Add(frm);
            frm.Show();
        }

    }
}
