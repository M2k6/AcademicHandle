using AcademicHandle.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Senders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicHandle.Usercontrol
{
    public partial class BlankCalendar : UserControl
    {
        // Properties field
        MissionDateTime mission_date = new MissionDateTime();

        private int _day;

        public int Day
        {
            get { return _day; }
            set 
            {
                _day = value;
            }
        }

        private int _month;

        public int Month
        {
            get { return _month; }
            set 
            {
                _month = value;
            }
        }

        private int _year;

        public int Year
        {
            get { return _year; }
            set 
            {
                _year = value;
                
            }
        }

        public string Status { get; set; }
        public bool IsToday { get; set; }
        
        private bool _isClick = false;

        public bool IsClick
        {
            get { return _isClick; }
            set 
            {
                _isClick = value;
                mission_date.IsChecked = _isClick;
                OnChecking(mission_date);
            }
        }

        /// 
        public BlankCalendar()
        {
            InitializeComponent();
        }
        public void DisplayToday()
        {
            lb_Date.Text = Day.ToString();
            lb_Status.Text = Status;
            if (IsToday == true) lb_Date.ForeColor = Color.Red;
        }

        private void BlankCalendar_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(168, 209, 223);
        }

        private void BlankCalendar_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(Year, Month, Day);
            mission_date.DateForSetup = dt;
            IsClick= true;
        }

        private void BlankCalendar_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        // Event Field
        public event EventHandler<MissionDateTime> CheckChanged;
        public virtual void OnChecking(MissionDateTime checker)
        {
            CheckChanged.Invoke(this, checker);
        }
        //

    }
}
