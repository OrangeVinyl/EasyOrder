using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosk
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Order order = new Order();
            order.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string connectionString = "User Id=dbp1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            string strqry = "select order_id from order_list where order_state = '0' and rownum<2";
            OracleCommand comm = new OracleCommand(strqry, conn);
            OracleDataReader sr = comm.ExecuteReader();

            int o_id = 0;

            if (sr.Read())
            {
                o_id = Convert.ToInt32(sr[0].ToString());
            }

            if (o_id==0)
            {
                txtOrderNum.Text = " 대기번호가 없습니다 ";
            }
            else
            {
                txtOrderNum.Text = " 대기 번호: " + o_id.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.ShowDialog();
            this.Close();
        }
    }
}
