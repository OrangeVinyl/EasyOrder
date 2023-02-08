using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosk
{
    public partial class Complete : Form
    {
        public Complete()
        {
            InitializeComponent();
        }

        public int o_id = 0;
        public string o_date = "";
        public int o_tot = 0;
        public string o_method = "";

        private void Complete_Load(object sender, EventArgs e)
        {
            //column 자동 간격
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            System.Windows.Forms.ListView.ColumnHeaderCollection cc = listView1.Columns;
            for (int i = 0; i < cc.Count; i++)
            {
                int colWidth = listView1.Width / (cc.Count);
                if (colWidth > cc[i].Width)
                {
                    cc[i].Width = colWidth;
                }
            }

            string connectionString = "User Id=dbp1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            string strqry = "select o_id.currval from dual";
            OracleCommand comm = new OracleCommand(strqry, conn);
            OracleDataReader sr = comm.ExecuteReader();


            if (sr.Read())
            {
                o_id = Convert.ToInt32(sr[0].ToString());
            }

            string commandString = "select(select product_name from product where product_id = order_detail.product_id),order_price,order_count,order_count* order_price from order_detail where order_id = " + o_id.ToString();
            OracleCommand myCommand = new OracleCommand();
            OracleConnection myConnection = new OracleConnection(connectionString);
            myCommand.Connection = myConnection;
            myCommand.CommandText = commandString;
            OracleDataAdapter DBAdapter = new OracleDataAdapter();
            DBAdapter.SelectCommand = myCommand;
            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "RelTable"); //
            DataTable RelTable = DS.Tables["RelTable"];
            DataRowCollection rows = RelTable.Rows;
            foreach (DataRow dr in rows)
            {
                ListViewItem item = new ListViewItem(dr[0].ToString());
                for (int i = 1; i < RelTable.Columns.Count; i++)
                {
                    item.SubItems.Add(dr[i].ToString());
                }
                listView1.Items.Add(item);
            }

            strqry = "select order_date,order_total_price,order_method from order_list where order_id = :o_id";
            comm = new OracleCommand(strqry, conn);
            comm.Parameters.Add("o_id", OracleDbType.Int32);
            comm.Parameters["o_id"].Value = o_id;
            sr = comm.ExecuteReader();


            if (sr.Read())
            {
                o_date = sr[0].ToString().Substring(0,10);
                o_tot = Convert.ToInt32(sr[1].ToString());
                o_method = sr[2].ToString();
            }


            txtOrderNum.Text = " 주문 번호 : "+o_id.ToString();
            txtOrderDate.Text = " 주문일 : " + o_date;
            txtTotal.Text = " 주문 총액 : " + o_tot.ToString() +"원";
            txtMethod.Text = " 결제 방법 : " + o_method;

            sr.Close();
        }

        private void form_click(object sender, EventArgs e) {
            this.Visible = false;
            Main main = new Main();
            main.ShowDialog();
        }
    }
}
