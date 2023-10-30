using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanPiano.GUI.SubForm
{
    public partial class EmployeeFrm : Form
    {
        public EmployeeFrm()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            LinkAccount linkAccount = new LinkAccount();
            linkAccount.Show();

        }
    }
}
