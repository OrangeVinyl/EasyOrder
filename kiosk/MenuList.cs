using ADOForm;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Oracle.DataAccess.Client;//ADO.Net 개체 참조
using System.Xml.Linq;
using System.Diagnostics;
using System.Drawing;
using System.IO;

namespace kiosk
{
    public partial class MenuList : Form
    {
        public MenuList()
        {
            InitializeComponent();
            btnEditMenu.Visible = false;
            btnDeleteMenu.Visible = false;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            StocklistView.Items.Clear();
            string connectionString = "User Id=dbp1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
            OracleConnection myConnection = new OracleConnection(connectionString);
            string commandString = "select product.product_id, product.product_name, stock_quantity.product_quantity from product join stock_quantity on product.product_id = stock_quantity.product_id order by product.product_id";
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
                }
                StocklistView.Items.Add(item);
            }
        }
        
        private void ManageStock_Load(object sender, EventArgs e)
        {
            //column 자동 간격
            StocklistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            System.Windows.Forms.ListView.ColumnHeaderCollection cc = StocklistView.Columns;
            for (int i = 0; i < cc.Count; i++)
            {
                int colWidth = StocklistView.Width/(cc.Count);
                if (colWidth > cc[i].Width)
                {
                    cc[i].Width = colWidth;
                }
            }
        }

        private void StocklistView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StocklistView.SelectedItems.Count != 0)
            {
                btnEditMenu.Visible = true;
                btnDeleteMenu.Visible = true;

            }
            else
            {
                btnEditMenu.Visible = false;
                btnDeleteMenu.Visible = false;

            }
        }

        private void btnEditQuantity_Click(object sender, EventArgs e)
        {
            if (StocklistView.SelectedItems.Count != 0)
            {
                ManageMenu manageMenu = new ManageMenu();
                int SelectRow = StocklistView.SelectedItems[0].Index;
                manageMenu.getProductId(StocklistView.Items[SelectRow].SubItems[0].Text, StocklistView.Items[SelectRow].SubItems[2].Text); // 상품id와 재고를 매개변수로 보냄
                manageMenu.Owner = this;
                manageMenu.ShowDialog();
                manageMenu.Dispose();
                button1_Click(sender, e);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeleteMenu_Click(object sender, EventArgs e)
        {
            if (StocklistView.SelectedItems.Count != 0)
            {
                int SelectRow = StocklistView.SelectedItems[0].Index;
                string connectionString = "User Id=dbp1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                OracleConnection conn = new OracleConnection(connectionString);
                conn.Open();
                string strqry = "delete from product where product_id=:p_id";
                OracleCommand comm = new OracleCommand(strqry, conn);

                comm.Parameters.Add("p_id", OracleDbType.Int16);
                comm.Parameters["p_id"].Value = StocklistView.Items[SelectRow].SubItems[0].Text;
                OracleDataReader sr = comm.ExecuteReader();
                sr.Close();
                conn.Close();

                button1_Click(sender, e);
                MessageBox.Show("메뉴가 정상적으로 삭제되었습니다.", "메뉴삭제");
            }
        }

    }
}
