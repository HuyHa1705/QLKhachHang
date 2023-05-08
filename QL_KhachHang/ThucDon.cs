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
    public partial class ThucDon : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-S43LD1IU;Initial Catalog=QLDT1;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        

        public string abc;
        void loaddata()
        {
            DataTable thucDon = new DataTable();

            command = connection.CreateCommand();
            //MessageBox.Show(abc);
            command.CommandText = "select ctta.TENMON, ctta.GIA, ctta.SoLuongDat from CHITIETMONAN ctta, THUCDON td, DOITAC dt where dt.IDTHUCDON = td.IDTHUCDON AND ctta.IDTHUCDON = TD.IDTHUCDON and dt.TENDOITAC = '" + abc +"'";
            adapter.SelectCommand = command;
            thucDon.Clear(); 
            adapter.Fill(thucDon);
            dataGridView1.DataSource = thucDon;
        }
        public ThucDon(string _abc)
        {
            
            InitializeComponent();
            abc = _abc;
        }
       

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaMon.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            txbMaMon.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtGia.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtSLMon.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();


        }

        private void ThucDon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMaMon_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
