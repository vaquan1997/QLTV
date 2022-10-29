using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class FrmMain : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

         );

        public FrmMain()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnTrangChu.Height;
            pnlNav.Top = btnTrangChu.Top;
            pnlNav.Left = btnTrangChu.Left;
            btnTrangChu.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnTrangChu.Height;
            pnlNav.Top = btnTrangChu.Top;
            pnlNav.Left = btnTrangChu.Left;
            btnTrangChu.BackColor = Color.FromArgb(46, 51, 73);

            //lbltitle.Text = "Trang chủ";
            //this.plParent.Controls.Clear();
            //frmDashBoard frm = new frmDashBoard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            //this.plParent.Controls.Add(frm);
            //frm.Show();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnKeSach.Height;
            pnlNav.Top = btnKeSach.Top;
            btnKeSach.BackColor = Color.FromArgb(46, 51, 73);
            lbltitle.Text = "Analytics";
            this.plParent.Controls.Clear();
             frmAnalytics frm = new frmAnalytics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            this.plParent.Controls.Add(frm);
            frm.Show();
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalender.Height;
            pnlNav.Top = btnCalender.Top;
            btnCalender.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSetting.Height;
            pnlNav.Top = btnSetting.Top;
            btnSetting.BackColor = Color.FromArgb(46, 51, 73);
            this.plParent.Controls.Clear();
            frmSetting frm = new frmSetting() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

            this.plParent.Controls.Add(frm);
            frm.Show();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnsettings.Height;
            pnlNav.Top = btnsettings.Top;
            btnsettings.BackColor = Color.FromArgb(46, 51, 73);
            lbltitle.Text = "Setting";
            this.plParent.Controls.Clear();
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void btnDashbord_Leave(object sender, EventArgs e)
        {
            btnTrangChu.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnKeSach.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnCalender_Leave(object sender, EventArgs e)
        {
            btnCalender.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnSetting.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnsettings_Leave(object sender, EventArgs e)
        {
            btnsettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
