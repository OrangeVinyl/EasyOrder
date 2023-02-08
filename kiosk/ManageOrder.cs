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
    public partial class ManageOrder : Form
    {
        public ManageOrder()
        {
            InitializeComponent();
        }

        public int o_id = 0;
        private void ManageOrder_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
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
            string strqry = "select order_id from order_list where order_state = '0' and rownum<2";
            OracleCommand comm = new OracleCommand(strqry, conn);
            OracleDataReader sr = comm.ExecuteReader();

            if (sr.Read())
            {
                o_id = Convert.ToInt32(sr[0].ToString());

                string commandString = "select order_id,order_state from order_list where order_id = " + o_id.ToString();
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
                        item.SubItems.Add("처리전");
                    }
                    listView1.Items.Add(item);
                }
            }

            

            sr.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count>0)
            {
                string connectionString = "User Id=dbp1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                OracleConnection conn = new OracleConnection(connectionString);
                conn.Open();
                string strqry = "update order_list set order_state=1 where order_id=:o_id";
                OracleCommand comm = new OracleCommand(strqry, conn);
                comm.Parameters.Add("o_id", OracleDbType.Int32);
                comm.Parameters["o_id"].Value = o_id;
                comm.ExecuteReader();

                MessageBox.Show("처리되었습니다", "주문관리");
                ManageOrder_Load(sender, e);  
            }
            else
            {
                MessageBox.Show("처리할 주문이 없습니다", "주문관리");
            }
            

            
        }
    }
}
