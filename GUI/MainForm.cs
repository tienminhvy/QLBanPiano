using DoAn;

namespace QLBanPiano
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        Form f = null;

        private Form AddNewForm(Form f)
        {
            // Clear all forms
            if (mainPanel.Controls.Count > 0)
                mainPanel.Controls[0].Dispose();
            mainPanel.Controls.Clear();
            // End
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.Show();
            mainPanel.Controls.Add(f);
            return f;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void dsPianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = AddNewForm(new Product());
        }
    }
}