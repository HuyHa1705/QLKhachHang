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
   
    public partial class DangKi : Form
    {
        
        public DangKi()
        {
            InitializeComponent();

        }
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-S43LD1IU;Initial Catalog=QLDT1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
       
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * from KHACHHANG ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangKi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Ban co muon thoat chuong trinh", "canh bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            //string cccd = txbCCCD.Text;
            long ketqua;
            if (txbHoTen.Text == "")
            {
                MessageBox.Show("Hay nhap ho ten", "thong bao");
                txbHoTen.Focus();
                return;

            }
            if (txbDiaChi.Text == "")
            {
                MessageBox.Show("Hay nhap email", "thong bao");
                txbDiaChi.Focus();
                return;
            }
            /*
            if (txbCCCD.Text == "")
            {
                MessageBox.Show("Hay nhap CCCD", "thong bao");
                txbCCCD.Focus();
                return;
            }
            if (!(long.TryParse(cccd, out ketqua)))
            {
                MessageBox.Show("Hay nhap dung CCCD", "thong bao");
                txbCCCD.Focus();
                return;
            }
            if (ketqua < 0)
            {
                MessageBox.Show("CCCD khong duoc am", "thong bao");
                txbCCCD.Focus();
                return;
            }
            */
            {
               
                command = connection.CreateCommand();
                command.CommandText = "insert into KHACHHANG values('"+Increment()+ "','" + txbemail.Text  + "','" + txbHoTen.Text + "','" + txbSDT.Text+ "','" + txbDiaChi.Text +  "','" + txbTaiKhoan.Text + "','" + txbMatKhau.Text + "')";
                connection.Open();
                command.ExecuteNonQuery();
               // connection.Close();
                loaddata();
                QL_KhachHang.DangNhap f = new DangNhap();
                f.Show();
            }
            int Increment()
            {
                connection.Close();
                connection.Open();
                int var = 0;
                string sqlQuery = "SELECT TOP 1 IDKH FROM(SELECT TOP 200 IDKH  FROM KHACHHANG  ORDER BY  IDKH DESC) SQ";
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader1;
                reader1 = cmd.ExecuteReader();
                if (reader1.Read())
                {
                    var = Convert.ToInt32(reader1.GetValue(0));
                    var++;
                }
                connection.Close();
                return var;
            }





        }
        bool KiemTraNhap()
        {
        
            return true;
        }

        private void txbCCCD_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gxbThongtin_Enter(object sender, EventArgs e)
        {

        }
        private void txbTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPas_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbHoTen.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txbHoTen.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txbemail.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txbSDT.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txbDiaChi.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txbTaiKhoan.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txbMatKhau.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();

        }

        private void BtxDangNhap_Click(object sender, EventArgs e)
        {
            QL_KhachHang.DangNhap f = new DangNhap();
            f.Show();
        }

        private void txbHoTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}