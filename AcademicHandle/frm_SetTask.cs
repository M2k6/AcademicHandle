using System.Windows.Forms;

namespace AcademicHandle
{
    public partial class frm_SetTask : Form
    {
        public frm_SetTask()
        {
            InitializeComponent();
        }

        private void frm_SetTask_Load(object sender, System.EventArgs e)
        {

        }

        private void DetailedTimeTableOpen_Click(object sender, System.EventArgs e)
        {
            DetailedTimeTable detailedTimeTable = new DetailedTimeTable();
            detailedTimeTable.ShowDialog();
        }
    }
}
