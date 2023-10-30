using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piano
{
    public partial class BillsDetails : Form
    {
        public BillsDetails()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            toolStripTextBox4.Text = Cons.maHDtextBox;
            toolStripTextBox4.ForeColor = Cons.textColor;
            toolStripTextBox5.Text = Cons.maNCtextBox;
            toolStripTextBox5.ForeColor = Cons.textColor;
            toolStripTextBox6.Text = Cons.soLuongTextBox;
            toolStripTextBox6.ForeColor = Cons.textColor;
        }
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        void check(ToolStripTextBox textBox)
        {
            if (textBox.Text.Length == 0)
            {
                if (textBox.Name == "toolStripTextBox4")
                {
                    textBox.Text = Cons.maHDtextBox;
                    MessageBox.Show(Cons.maHDtextBox);
                }
                else if (textBox.Name == "toolStripTextBox5")
                {
                    textBox.Text = Cons.maNCtextBox;
                }
                else
                {
                    textBox.Text = Cons.soLuongTextBox;
                }
            }
            else
            {
                MessageBox.Show("Textbox");
            }
        }
        //Đám event Leave vô dụng r 
        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {
            toolStripTextBox4.Text = string.Empty;
        }

        private void toolStripTextBox4_Leave(object sender, EventArgs e)
        {
            check((ToolStripTextBox)sender);
        }

        private void toolStripTextBox5_Click(object sender, EventArgs e)
        {
            toolStripTextBox5.Text = string.Empty;
        }

        private void toolStripTextBox5_Leave(object sender, EventArgs e)
        {
            check((ToolStripTextBox)sender);
        }

        private void toolStripTextBox6_Click(object sender, EventArgs e)
        {
            toolStripTextBox6.Text = string.Empty;
        }

        private void toolStripTextBox6_Leave(object sender, EventArgs e)
        {
            check((ToolStripTextBox)sender);
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {
            if (toolStripTextBox4.Text == string.Empty)
            {
                toolStripTextBox4.Text = Cons.maHDtextBox;
            }
            else if (toolStripTextBox5.Text == string.Empty)
            {
                toolStripTextBox5.Text = Cons.maNCtextBox;
            }
            else if (toolStripTextBox6.Text == string.Empty)
            {
                toolStripTextBox6.Text = Cons.soLuongTextBox;
            }
            else
            {
                return;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
