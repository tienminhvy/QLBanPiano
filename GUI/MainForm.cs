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

        private void btnTaoMoi_ButtonClick(object sender, EventArgs e)
        {

        }
    }
}