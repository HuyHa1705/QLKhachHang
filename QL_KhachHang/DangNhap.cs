using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QL_KhachHang
{
    public partial class DangNhap : Form
    {
        private object txbMatKhau;

        public DangNhap()
        {

            SqlConnection connection;
            SqlCommand command;
            string str = @"Data Source=LAPTOP-S43LD1IU;Initial Catalog=QLDT1;Integrated Security=True";
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-S43LD1IU;Initial Catalog=QLDT1;Integrated Security=True");
            SqlDataAdapter da = new SqlDataAdapter("Select * from KHACHHANG where TaiKhoan=N'" + txbTaiKhoan.Text + "'and MatKhau = N'" + txbPas.Text + "'", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Khachhang kh = new Khachhang((int)dt.Rows[0]["IDKH"],(String)dt.Rows[0]["Email"],(String)dt.Rows[0]["HoTen"], (String)dt.Rows[0]["SDT"],(String)dt.Rows[0]["DiaChi"], 
                          (String)dt.Rows[0]["TaiKhoan"], (String)dt.Rows[0]["MatKhau"]);
                
                this.Hide();
                QL_KhachHang.TrangChu f = new TrangChu(kh);
                f.Show();
                
             

                
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin đăng nhập!");
            }


        }

        private void F_Logout(object sender, EventArgs e)
        {

            (sender as QL_KhachHang.TrangChu).Close();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
