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





    public partial class TrangChu : Form
    {
        public string abc;
        Khachhang kh;
        
        public TrangChu()
        {
            InitializeComponent();
            kh = new Khachhang();
            //_kh = KH;
           

        }
        public TrangChu(Khachhang KH)
        {
            InitializeComponent();
            kh = new Khachhang(KH);
            txbHoTen.Text = KH.HoTen();
            txbSDT.Text = KH.SDT();
            txbDiaChi.Text = KH.DiaChi();
            

        }
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-S43LD1IU;Initial Catalog=QLDT1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        /*
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "Select * from Khach_Hang where TaiKhoan=N'" + txbTaiKhoan.Text + "'and password = N'" + txbPas.Text + "'" ;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }*/
        private void Form1_Load(object sender, EventArgs e)
        {
            cbbDoiTac.Items.Clear();
            connection = new SqlConnection(str);
            connection.Open();
            // loaddata();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select TenDoiTac from DoiTac";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            abc = (String)(cbbDoiTac.SelectedItem);

            foreach(DataRow dr in dt.Rows)
            {
                cbbDoiTac.Items.Add(dr["TenDoiTac"].ToString());
                
            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LWDoiTac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txbHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //txbHoTen.ReadOnly = true;
            //int i;
            //i = dataGridView1.CurrentRow.Index;
            //txbHoTen.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            //txbDiaChi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            //txbCCCD.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }

        private void txbHoTen_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bntDoiTac_Click(object sender, EventArgs e)
        {
            string temp = cbbDoiTac.SelectedItem.ToString();
            //MessageBox.Show(cbbDoiTac.SelectedItem.ToString());
            ThucDon p = new ThucDon(temp);
            p.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }
        public void LoadComboBox()
        {
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }

    public class Khachhang
    {
        private int _IDKH;
        private string _Email;
        private string _HoTen;
        private string _SDT;
        private string _DiaChi;
        private string _TaiKhoan;
        private string _MatKhau;

        public Khachhang()
        {

            _Email = string.Empty;
            _HoTen = string.Empty;
            _SDT = string.Empty;
            _DiaChi = string.Empty;
            _TaiKhoan = string.Empty;
            _MatKhau = string.Empty;
        }
        public Khachhang(int IDKH, string HoTen, string Email, string DiaChi, string SDT, string TaiKhoan, string MatKhau)
        {
            _IDKH = IDKH;
            _Email = Email;
            _HoTen = HoTen;
            _SDT = SDT;
            _DiaChi = DiaChi;
            _TaiKhoan = TaiKhoan;
            _MatKhau = MatKhau;
        }
        public Khachhang(Khachhang kh)
        {
            _IDKH = kh._IDKH;
            _Email = kh._Email;
            _HoTen = kh._HoTen;
            _SDT = kh._SDT;
            _DiaChi = kh._DiaChi;
            _TaiKhoan = kh._TaiKhoan;
            _MatKhau = kh._MatKhau;
        }


       
        public string HoTen() { return _HoTen; }
        public string DiaChi() { return _DiaChi; }
        public string SDT()
        {
            return _SDT;
        }

       
        

    }
    
    
}
