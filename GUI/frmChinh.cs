namespace QLBanPiano
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            frmGioiThieu about = new frmGioiThieu();
            about.Show();
        }

        private void btnTaoMoi_ButtonClick(object sender, EventArgs e)
        {

        }
    }
}