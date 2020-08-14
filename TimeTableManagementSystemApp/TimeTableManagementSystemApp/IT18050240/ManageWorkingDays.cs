using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagementSystemApp.IT18050240
{
    public partial class ManageWorkingDays : Form
    {
        public ManageWorkingDays()
        {
            InitializeComponent();
        }

        private void ManageWorkingDays_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addWorkingDayBtn_Click(object sender, EventArgs e)
        {
            addWorkingDayBtn.BackColor = Color.Red;
            viewTimeTableBtn.BackColor = Color.FromArgb(71, 1, 1);

            manageWorkingDayPanel.Controls.Add(AddWorkingDays.addWorkingDaysInstance);
            AddWorkingDays.addWorkingDaysInstance.BringToFront();
          
        }

        private void viewTimeTableBtn_Click(object sender, EventArgs e)
        {
            addWorkingDayBtn.BackColor = Color.FromArgb(71, 1, 1);
            viewTimeTableBtn.BackColor = Color.Red;
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void miniBtn_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
