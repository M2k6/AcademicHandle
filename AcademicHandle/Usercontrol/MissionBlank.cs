using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        }

        public void Display(string name)
        {
            lbName.Text = name;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
