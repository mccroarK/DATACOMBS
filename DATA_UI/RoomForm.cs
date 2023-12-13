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
    public partial class RoomForm : Form
    {
        public RoomForm(string info)
        {
            InitializeComponent();

            // Split info by semicolons
            string[] thinginfo = info.Split(';');

            // Display info in list box
            thingLB.DataSource = thinginfo;
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
