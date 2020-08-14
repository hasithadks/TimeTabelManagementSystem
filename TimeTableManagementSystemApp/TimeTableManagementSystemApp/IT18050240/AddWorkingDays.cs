using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagementSystemApp.IT18050240
{
    public partial class AddWorkingDays : UserControl
    {
        private static AddWorkingDays AddWorkingDaysInstance;
        public static AddWorkingDays addWorkingDaysInstance
        {
            get
            {
                if (AddWorkingDaysInstance == null)
                    AddWorkingDaysInstance = new AddWorkingDays();
                return AddWorkingDaysInstance;

            }
        }

        public AddWorkingDays()
        {
            InitializeComponent();
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }
    }
}
