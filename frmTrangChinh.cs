using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class frmTrangChinh : Form
    {
        public int id = 0;
        public void showtt()
        {
            tspTuyChon.Enabled = true;
            DanhMucToolStripMenuItem.Enabled = true;
            QuanLyToolStripMenuItem.Enabled = true;
            BanHangToolStripMenuItem.Enabled = true;
        }
        public frmTrangChinh()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tslbPhieuMS_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmTrangChinh_Load(object sender, EventArgs e)
        {
            //PictureBox pb = new PictureBox();
            //pb.Image = Image.FromFile(@"D:\DuyThaiIT\Công Nghệ .NET\DeTaiNhom_QuanLyNhaSach\QuanLyNhaSach\QuanLyNhaSach\Icon\homeslide8.png");
            //pb.SizeMode = PictureBoxSizeMode.AutoSize;
            //this.Controls.Add(pb);
            //this.Size = pb.Size;
            pictureBox1.ImageLocation = @"C:\Users\Admin\Desktop\Đồ án NET\DeTaiNhom_QuanLyNhaSach\QuanLyNhaSach\QuanLyNhaSach\Icon\homeslide8.png";
            AnTT();
            panel2.Enabled = false; 
        }

        private void sachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinSach formtts = new frmThongTinSach();
            formtts.Show();
        }

        private void loaisachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiSach formls = new frmLoaiSach();
            formls.Show();
        }

        private void tslbNCC_Click(object sender, EventArgs e)
        {
            frmNhaCungCap formncc = new frmNhaCungCap();
            formncc.Show();
        }

        private void tslbKhachHang_Click(object sender, EventArgs e)
        {
            frmDanhSachKH formkh = new frmDanhSachKH();
            formkh.Show();
        }

        private void tslbPhieuBS_Click(object sender, EventArgs e)
        {
            frmPhieuBanSach formpbs = new frmPhieuBanSach();
            formpbs.Show();
        }

        private void tsbtDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTrangChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void khachhangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachKH formkh = new frmDanhSachKH();
            formkh.Show();
        }

        private void nhacungcapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhaCungCap formncc = new frmNhaCungCap();
            formncc.Show();
        }

        private void nhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachNV formnv = new frmDanhSachNV();
            formnv.Show();
        }

        private void phieubansachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuBanSach formpbs = new frmPhieuBanSach();
            formpbs.Show();
        }

        private void tslbThongTinS_Click(object sender, EventArgs e)
        {
            frmThongTinSach formpbs = new frmThongTinSach();
            formpbs.Show();
        }

        private void dangnhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true; 
        }

        public void AnTT()
        {
            tspTuyChon.Enabled = false;
            DanhMucToolStripMenuItem.Enabled = false;
            QuanLyToolStripMenuItem.Enabled = false;
            BanHangToolStripMenuItem.Enabled = false;
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string pass = txtPass.Text;
            if (String.Compare(id, "admin", true) == 0 && String.Compare(pass, "admin", true) == 0)
            {
                showtt();
                label3.Text = "Đã đăng nhập";
                txtID.Enabled = false;
                txtPass.Enabled = false;
                label1.Enabled = false;
                label2.Enabled = false;
                Login.Enabled = false;
                label3.ForeColor = Color.Green;
            }
        }

        private void dangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrangChinh a = new frmTrangChinh();
            a.Show();
            this.Dispose(false);
        }
    }
}
