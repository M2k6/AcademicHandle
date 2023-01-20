using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademicHandle.Model
{
    public class MissionDateTime
    {
		private bool _isChecked;

		public bool IsChecked
		{
			get { return _isChecked; }
			set { _isChecked = value; }
		}
		private DateTime _dateforsetup;

		public DateTime DateForSetup
		{
			get { return _dateforsetup; }
			set { _dateforsetup = value; }
		}


	}
}
