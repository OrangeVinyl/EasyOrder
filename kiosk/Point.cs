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
    public partial class Point : Form
    {
        public Point()
        {
            InitializeComponent();
        }
        
        public int tot_price = 0;
        public string method = null;
        public List<List<String>> order_items = new List<List<String>>();

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Visible = true;
        }

        public void parseList(ListView listview,int tot_prices, string methods)
        {
            int cnt = 0;

            method = methods;
            tot_price = tot_prices;
            foreach (ListViewItem item in listview.Items)
            {
                List < String> list = new List<String>();
                list.Add(item.SubItems[0].Text);
                list.Add(item.SubItems[2].Text);
                list.Add(item.SubItems[1].Text);
                list.Add(item.SubItems[3].Text);
                order_items.Insert(cnt, list);
                /*
                MessageBox.Show(order_items[cnt][0].ToString()); //메뉴명
                MessageBox.Show(order_items[cnt][1].ToString()); //가격
                MessageBox.Show(order_items[cnt][2].ToString()); //갯수
                MessageBox.Show(order_items[cnt][3].ToString()); //총액
                */
                cnt++;
            }
        }

        private void Point_Load(object sender, EventArgs e)
        {

        }



        private void btnPointOut_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text.Count() > 0)
            {
                string connectionString = "User Id=dbp1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                OracleConnection conn = new OracleConnection(connectionString);
                conn.Open();
                string strqry = "select customer_id,customer_point from customer where customer_phone = :c_phone";
                OracleCommand comm = new OracleCommand(strqry, conn);
                comm.Parameters.Add("c_phone", OracleDbType.NVarchar2, 11);
                comm.Parameters["c_phone"].Value = txtPhone.Text;
                OracleDataReader sr = comm.ExecuteReader();

                int c_id = 0;
                int c_point = 0;
                if (sr.Read())
                {
                    c_id = Convert.ToInt32(sr[0].ToString());
                    c_point = Convert.ToInt32(sr[1].ToString());
                }
                
                if (c_id==0) {
                    MessageBox.Show("회원이 존재하지 않습니다.");
                }
                else
                {
                    insertDB(c_id,c_point);

                    this.Visible = false;
                    Checkout checkout = new Checkout();
                    checkout.ShowDialog();
                    this.Close();
                }

                
            }
            else
            {
                MessageBox.Show("전화번호를 입력해주세요.");
            }
            
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            insertDB(0,0);

            this.Visible = false;
            Checkout checkout = new Checkout();
            checkout.ShowDialog();
            this.Close();
        }

        private void insertDB(int c_id,int c_point)
        {
            string connectionString = "User Id=dbp1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
            for (int i=0; i<order_items.Count; i++)
            {
                
                OracleConnection conn = new OracleConnection(connectionString);
                conn.Open();
                string strqry = "select product_id from product where product_name = :p_name";
                OracleCommand comm = new OracleCommand(strqry, conn);
                comm.Parameters.Add("p_name", OracleDbType.NVarchar2,50);
                comm.Parameters["p_name"].Value = order_items[i][0].ToString();
                OracleDataReader sr = comm.ExecuteReader();

                int p_id = 0;
                if (sr.Read())
                {
                    p_id = Convert.ToInt32(sr[0].ToString());
                }


                string strqry2 = null;

                if (i==0)
                {
                   strqry2 = "insert into order_detail values (o_id.nextval,:p_id,:p_cnt,:p_price)";
                }
                else
                {
                   strqry2 = "insert into order_detail values (o_id.currval,:p_id,:p_cnt,:p_price)";
                }
                
                OracleCommand comm2 = new OracleCommand(strqry2, conn);

                comm2.Parameters.Add("p_id", OracleDbType.Int32);
                comm2.Parameters["p_id"].Value = p_id;
                comm2.Parameters.Add("p_cnt", OracleDbType.Int32);
                comm2.Parameters["p_cnt"].Value = order_items[i][1];
                comm2.Parameters.Add("p_price", OracleDbType.Int32);
                comm2.Parameters["p_price"].Value = order_items[i][2];
                OracleDataReader sr2 = comm2.ExecuteReader();

                strqry2 = "select product_quantity from stock_quantity where stock_quantity.product_id = :p_id";
                comm2 = new OracleCommand(strqry2, conn);
                comm2.Parameters.Add("p_id", OracleDbType.Int32);
                comm2.Parameters["p_id"].Value = p_id;
                sr2 = comm2.ExecuteReader();
                sr2.Read();
                int p_quantity = Convert.ToInt32(sr2[0].ToString());

                strqry2 = "update stock_quantity set product_quantity=:p_cnt where stock_quantity.product_id = :p_id";
                comm2 = new OracleCommand(strqry2, conn);
                comm2.Parameters.Add("p_cnt", OracleDbType.Int32);
                comm2.Parameters["p_cnt"].Value = p_quantity - Convert.ToInt32(order_items[i][1]);
                comm2.Parameters.Add("p_id", OracleDbType.Int32);
                comm2.Parameters["p_id"].Value = p_id;
                sr2 = comm2.ExecuteReader();

                sr.Close();
                sr2.Close();
                conn.Close();

            }

            OracleConnection conn3 = new OracleConnection(connectionString);
            conn3.Open();
            String today = DateTime.Now.ToString("yyyy-MM-dd");

            string strqry3 = "insert into order_list values (o_id.currval,:o_date,:o_tot,'0',:c_id,:o_method)";
            OracleCommand comm3 = new OracleCommand(strqry3, conn3);

            comm3.Parameters.Add("o_date", OracleDbType.Date);
            comm3.Parameters["o_date"].Value = Convert.ToDateTime(today);
            comm3.Parameters.Add("o_tot", OracleDbType.Int32);
            comm3.Parameters["o_tot"].Value = tot_price;
            comm3.Parameters.Add("c_id", OracleDbType.Int32);
            comm3.Parameters["c_id"].Value = c_id;
            comm3.Parameters.Add("o_method", OracleDbType.NVarchar2,50);
            comm3.Parameters["o_method"].Value = method;
            OracleDataReader sr3 = comm3.ExecuteReader();

            sr3.Close();
            conn3.Close();

            OracleConnection conn4 = new OracleConnection(connectionString);
            conn4.Open();


            string strqry4 = "update customer set customer_point=:c_point where customer_id = :c_id";
            OracleCommand comm4 = new OracleCommand(strqry4, conn4);

            comm4.Parameters.Add("c_point", OracleDbType.Int32);
            comm4.Parameters["c_point"].Value = c_point + 100;
            comm4.Parameters.Add("c_id", OracleDbType.Int32);
            comm4.Parameters["c_id"].Value = c_id;
            OracleDataReader sr4 = comm4.ExecuteReader();

            sr4.Close();
            conn4.Close();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
    }
}
