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
    public partial class frm_Workspace_Items : Form
    {
        public frm_Workspace_Items()
        {
            InitializeComponent();
            panell_container.Width = this.Width-10;
            panell_container.Height = this.Height-20;
        }

        private void frm_Workspace_Items_SizeChanged(object sender, EventArgs e)
        {
            
            panell_container.Width = this.Width-10;
            panell_container.Height = this.Height - 20;
        }

        private void tab_Music_SizeChanged(object sender, EventArgs e)
        {
            lstMusic_Data.Width = tab_Music.Width - 10;
            
        }

        private void lstMusic_Data_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void lstMusic_Data_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
    }
}
