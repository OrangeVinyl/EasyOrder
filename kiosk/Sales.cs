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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
            


        }

        public int tot_sales = 0;
        public int diff = 0;


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            tot_sales = 0;
            DateTime nowDate = DateTime.Now;
            nowDate = nowDate.AddMonths(diff);
            txtHead.Text = nowDate.Month + "월 매출기록";

            //column 자동 간격
            SaleslistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            System.Windows.Forms.ListView.ColumnHeaderCollection cc = SaleslistView.Columns;
            for (int i = 0; i < cc.Count; i++)
            {
                int colWidth = SaleslistView.Width / (cc.Count);
                if (colWidth > cc[i].Width)
                {
                    cc[i].Width = colWidth;
                }
            }

            SaleslistView.Items.Clear();
            string connectionString = "User Id=dbp1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
            OracleConnection myConnection = new OracleConnection(connectionString);
            string commandString = "select o_d.product_id,(select product_name from product where product_id = o_d.product_id)  ,sum(order_count),sum(order_count*order_price) from order_detail o_d where order_id in ( select order_id from order_list where order_date BETWEEN trunc (add_months(sysdate," + diff + "), 'mm') AND add_months(sysdate,"+ diff + ")) group by o_d.product_id ";
            OracleCommand myCommand = new OracleCommand();
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
                    if (i==3) {
                        tot_sales += Convert.ToInt32(dr[i].ToString());
                    }
                }
                SaleslistView.Items.Add(item);

            }





            txtTot.Text = "총 매출 : " + tot_sales.ToString() + "원";

            

        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            diff--;
            Sales_Load(sender, e);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            diff++;
            Sales_Load(sender, e);
        }
    }
}
