using QLBanPiano.BUS;
using QLBanPiano.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanPiano
{
    public partial class frmDangNhap : Form
    {
        bool formExpand;

        int curWid = 0, curHeight = 0;
        public frmDangNhap()
        {
            InitializeComponent();
            Init();
        }
        void Init()
        {
            userTextBox.Text = Piano.Cons.userText;
            userTextBox.Font = Piano.Cons.textBoxFont;
            //userTextBox.ForeColor = Piano.Cons.loginColor;
            pwdTextBox.Text = Piano.Cons.pwdText;
            pwdTextBox.Font = Piano.Cons.loginFont;
            //pwdTextBox.ForeColor = Piano.Cons.loginColor;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Coi như ko thấy j nha 
        private void LoginForm_ClientSizeChanged(object sender, EventArgs e)
        {

            //MessageBox.Show("Form size changed");
            //MessageBox.Show(this.Size.ToString());
            //MessageBox.Show(widthChanged.ToString());
            /*if (widthChanged < 0)//Thu nhỏ
            {
                if ((widthChanged * (-1)) % 2 == 1)
                {
                    MessageBox.Show(widthChanged.ToString());
                    newWidth += 1;
                    widthChanged -= 1;
                    newWidth += widthChanged / 2;
                    newHeight = leftPadding.Height;
                    leftPadding.Size = new Size(leftPadding.Width + newWidth, newHeight);
                    rightPadding.Size = new Size(rightPadding.Width + (newWidth - 1), rightPadding.Height);
                    if (heightChanged % 2 == 1)
                    {
                        newHeight += 1;
                        newHeight += heightChanged / 2;

                    }
                    else
                    {

                    }
                }
                else
                {
                    newWidth += widthChanged / 2;
                    newHeight = leftPadding.Height;
                    leftPadding.Size = new Size(leftPadding.Width + newWidth, newHeight);
                    rightPadding.Size = new Size(rightPadding.Width + (newWidth - 1), rightPadding.Height);
                }
            }*/
            /*else//Phóng to ra nè
            {
                if (widthChanged % 2 == 1)
                {
                    MessageBox.Show(newWidth.ToString());
                    newWidth += 1;
                    widthChanged -= 1;
                    newWidth += widthChanged / 2;
                    newHeight = leftPadding.Height;
                    formPanel.Location = new Point(formPanel.Location.X + newWidth, formPanel.Location.Y);
                    leftPadding.Size = new Size(leftPadding.Width + newWidth, newHeight);
                    rightPadding.Size = new Size(rightPadding.Width + newWidth - 1, rightPadding.Height);
                    /*if (heightChanged % 2 == 1)
                    {
                        newHeight += 1;
                        heightChanged -= 1;
                        newHeight += heightChanged / 2;
                        newWidth = topPadding.Width;
                        formPanel.Location = new Point(formPanel.Location.X, formPanel.Location.Y + newHeight);
                        topPadding.Size = new Size(topPadding.Width, newHeight + topPadding.Height);
                        botPadding.Size = new Size(botPadding.Width, newHeight + botPadding.Height);

                    }
                    else
                    {
                        newHeight += heightChanged / 2;
                        newWidth = topPadding.Width;
                        formPanel.Location = new Point(formPanel.Location.X, formPanel.Location.Y + newHeight);
                        topPadding.Size = new Size(topPadding.Width, newHeight + topPadding.Height);
                        botPadding.Size = new Size(botPadding.Width, newHeight + botPadding.Height);
                    }*/
            /*}
            else
            {
                newWidth += widthChanged / 2;
                newHeight = leftPadding.Height;
                formPanel.Location = new Point(formPanel.Location.X + newWidth, formPanel.Location.Y);
                leftPadding.Size = new Size(leftPadding.Width + newWidth, newHeight);
                rightPadding.Size = new Size(rightPadding.Width + newWidth - 1, rightPadding.Height);

            }
        }*/
        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {

        }

        private void mainPanel_Resize(object sender, EventArgs e)
        {
            /*int widthChanged = 0;
            int heightChanged = 0;
            int newWid = 0, newHe = 0;
            if (this.WindowState == FormWindowState.Minimized)
            {
                MessageBox.Show(curWid + " & " + curHeight);
                MessageBox.Show("Minimize");
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                widthChanged = this.Size.Width - curWid;
                heightChanged = this.Size.Height - curWid;
                MessageBox.Show(curWid + " & " + curHeight);
                if(widthChanged %2 == 1)
                {
                    newWid += 1;
                    widthChanged -= 1;
                    newWid += widthChanged / 2;
                    leftPadding.Width += newWid;
                    rightPadding.Width += (newWid-1);
                    curWid = this.Width;
                    curHeight = this.Height;
                }else if(widthChanged %2 == 0)
                {
                    newWid += widthChanged / 2;
                    leftPadding.Width += newWid;
                    rightPadding.Width += newWid;
                    curWid = this.Width;
                }
                MessageBox.Show("Maximize" + ": " + widthChanged + "&" + heightChanged);
            }
            else
            {
                widthChanged = this.Size.Width - curWid;
                heightChanged = this.Size.Width - curHeight;
                if ((widthChanged * (-1)) % 2 == 1)
                {
                    newWid += -1;
                    widthChanged -= -1;
                    newWid += widthChanged / 2;
                    leftPadding.Width += newWid;
                    rightPadding.Width += (newWid + 1);
                    curHeight = this.Height;
                    curWid = this.Width;

                } else if ((widthChanged * (-1)) % 2 == 0)
                {

                }
                MessageBox.Show("Normal");
                MessageBox.Show(curWid + " & " + curHeight);
                MessageBox.Show(widthChanged + " & " + heightChanged);
            }*/


        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //curWid = this.Width;
            //curHeight = this.Height;
        }

        private void userTextBox_Click(object sender, EventArgs e)
        {
            userTextBox.Text = string.Empty;
        }

        private void userTextBox_Leave(object sender, EventArgs e)
        {
            if (userTextBox.Text == string.Empty)
            {
                userTextBox.Text = Piano.Cons.userText;
            }
        }

        private void pwdTextBox_Click(object sender, EventArgs e)
        {
            pwdTextBox.Text = string.Empty;
        }

        private void pwdTextBox_Leave(object sender, EventArgs e)
        {
            if (pwdTextBox.Text == string.Empty)
            {
                pwdTextBox.Text = Piano.Cons.pwdText;
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoanBUS tkBUS = new TaiKhoanBUS();
            if (tkBUS.DangNhap(userTextBox.Text, pwdTextBox.Text))
            {
                frmChinh.username = userTextBox.Text;
                frmChinh.nhanvien_id = tkBUS.GiaTriTruong("nhanvien_id", "tenDangNhap = N'" + userTextBox.Text + "'").ToString();
                frmChinh.dsQuyen = tkBUS.dsQuyen(frmChinh.username);
                Form f = new frmChinh(this);
                f.ShowDialog();
            }
        }
    }
}
