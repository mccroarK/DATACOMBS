using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATA_UI
{
    public partial class ActorForm : Form
    {
        public ActorForm(string info)
        {
            InitializeComponent();

            // Split info
            string[] tokens = info.Split(';');
            string[] stats = tokens[1].Split('|');

            // Display stats
            nameLBL.Text = tokens[0];
            statLB.DataSource = stats;
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            // Close the form
            Close();
        }
    }
}
