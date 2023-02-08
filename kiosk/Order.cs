using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosk
{
    public partial class Order : Form
    {
        
        public Order()
        {
            InitializeComponent();
        }

        public int menu_index = 0; // 메뉴 인덱스
        public int max_index = 0; // 메뉴 최대 인덱스

        public List<String> menu1_desc = new List<string>() { "", "","" };
        public List<String> menu2_desc = new List<string>() { "", "","" };
        public List<String> menu3_desc = new List<string>() { "", "" ,""};
        public List<String> menu4_desc = new List<string>() { "", "", "" };
        public List<String> menu5_desc = new List<string>() { "", "", "" };
        public List<String> menu6_desc = new List<string>() { "", "", "" };

        private void Order_Load(object sender, EventArgs e)
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


            MenuImage1.Image = null;
            MenuImage2.Image = null;
            MenuImage3.Image = null;
            MenuImage4.Image = null;
            MenuImage5.Image = null;
            MenuImage6.Image = null;
            string connectionString = "User Id=dbp1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            string strqry = "select count(product_id) from product";
            OracleCommand comm = new OracleCommand(strqry, conn);

            OracleDataReader sr = comm.ExecuteReader();
            while (sr.Read())
            {
                max_index = Convert.ToInt32(sr[0].ToString()) / 7;
            }

            string strqry2 = "SELECT PRODUCT_IMG,product_name,product_price,product_id FROM(SELECT ROWNUM AS RNUM, A.* FROM ( product ) A WHERE ROWNUM <= :end_index ) WHERE RNUM >= :start_index order by product_id";
            OracleCommand comm2 = new OracleCommand(strqry2, conn);
            comm2.Parameters.Add("end_index", OracleDbType.Int32);
            comm2.Parameters["end_index"].Value = menu_index * 6 + 6;
            comm2.Parameters.Add("start_index", OracleDbType.Int32);
            comm2.Parameters["start_index"].Value = menu_index * 6 + 1;

            
            OracleDataReader sr2 = comm2.ExecuteReader();
            int cnt = 0;
            while (sr2.Read())
            {
                cnt++;
                if (cnt <= 6)
                {
                    byte[] ImageData = new byte[0];
                    ImageData = sr2.IsDBNull(0) ? null : sr2.GetOracleBlob(0).Value;
                    MemoryStream memStm = new MemoryStream(ImageData);
                    if (ImageData != null)
                    {
                        string strqry3 = "select product_quantity from stock_quantity where stock_quantity.product_id =:p_id";
                        OracleCommand comm3 = new OracleCommand(strqry3, conn);
                        comm3.Parameters.Add("p_id", OracleDbType.Int16);
                        comm3.Parameters["p_id"].Value = sr2[3].ToString();
                        OracleDataReader sr3 = comm3.ExecuteReader();
                        sr3.Read();
                        if (cnt==1) { 
                            MenuImage1.Image = Image.FromStream(memStm);
                            menu1_desc[0] = sr2[1].ToString();
                            menu1_desc[1] = sr2[2].ToString();
                            menu1_desc[2] = sr3[0].ToString();
                        }
                        if (cnt == 2) { 
                            MenuImage2.Image = Image.FromStream(memStm);
                            menu2_desc[0] = sr2[1].ToString();
                            menu2_desc[1] = sr2[2].ToString();
                            menu2_desc[2] = sr3[0].ToString();
                        }
                        if (cnt == 3) { 
                            MenuImage3.Image = Image.FromStream(memStm);
                            menu3_desc[0] = sr2[1].ToString();
                            menu3_desc[1] = sr2[2].ToString();
                            menu3_desc[2] = sr3[0].ToString();
                        }
                        if (cnt == 4) {
                            MenuImage4.Image = Image.FromStream(memStm);
                            menu4_desc[0] = sr2[1].ToString();
                            menu4_desc[1] = sr2[2].ToString();
                            menu4_desc[2] = sr3[0].ToString();
                        }
                        if (cnt == 5) { 
                            MenuImage5.Image = Image.FromStream(memStm);
                            menu5_desc[0] = sr2[1].ToString();
                            menu5_desc[1] = sr2[2].ToString();
                            menu5_desc[2] = sr3[0].ToString();
                        }
                        if (cnt == 6) { 
                            MenuImage6.Image = Image.FromStream(memStm);
                            menu6_desc[0] = sr2[1].ToString();
                            menu6_desc[1] = sr2[2].ToString();
                            menu6_desc[2] = sr3[0].ToString();
                        }
                    }
                }



         
            }
            sr.Close();
            sr2.Close();
            conn.Close();

        }

        private void MenuImage1_Click(object sender, EventArgs e)
        {
            if (MenuImage1.Image!=null)
            {

                if (Convert.ToInt32(menu1_desc[2])>0) 
                {
                    Boolean isExists = false;
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].Text == menu1_desc[0])
                        {
                            listView1.Items[i].SubItems[2].Text = Convert.ToString(Convert.ToInt32(listView1.Items[i].SubItems[2].Text) + 1);
                            isExists = true;
                        }
                    }

                    if (!isExists)
                    {
                        ListViewItem items = new ListViewItem(menu1_desc[0]);
                        items.SubItems.Add(menu1_desc[1]);
                        items.SubItems.Add("1");
                        listView1.Items.Add(items);
                    }
                    menu1_desc[2] = Convert.ToString(Convert.ToInt32(menu1_desc[2]) - 1);
                }
                else
                {
                    MessageBox.Show("재고가 부족합니다");
                }

            }
        }


        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(menu_index !=0)
            {
                menu_index--;
                Order_Load(sender, e);
            }
            else
            {
                MessageBox.Show("첫 페이지입니다!","페이지 오류");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (menu_index < max_index)
            {
                menu_index++;
                Order_Load(sender, e);
            }
            else
            {
                MessageBox.Show("마지막 페이지입니다!","페이지 오류");
            }
        }

        private void MenuImage2_Click(object sender, EventArgs e)
        {
            if (MenuImage2.Image != null)
            {

                if (Convert.ToInt32(menu2_desc[2]) > 0)
                {
                    Boolean isExists = false;
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].Text == menu2_desc[0])
                        {
                            listView1.Items[i].SubItems[2].Text = Convert.ToString(Convert.ToInt32(listView1.Items[i].SubItems[2].Text) + 1);
                            isExists = true;
                        }
                    }

                    if (!isExists)
                    {
                        ListViewItem items = new ListViewItem(menu2_desc[0]);
                        items.SubItems.Add(menu2_desc[1]);
                        items.SubItems.Add("1");
                        listView1.Items.Add(items);
                    }
                    menu2_desc[2] = Convert.ToString(Convert.ToInt32(menu2_desc[2]) - 1);
                }
                else
                {
                    MessageBox.Show("재고가 부족합니다");
                }

            }
        }

        private void MenuImage3_Click(object sender, EventArgs e)
        {
            if (MenuImage3.Image != null)
            {

                if (Convert.ToInt32(menu3_desc[2]) > 0)
                {
                    Boolean isExists = false;
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].Text == menu3_desc[0])
                        {
                            listView1.Items[i].SubItems[2].Text = Convert.ToString(Convert.ToInt32(listView1.Items[i].SubItems[2].Text) + 1);
                            isExists = true;
                        }
                    }

                    if (!isExists)
                    {
                        ListViewItem items = new ListViewItem(menu3_desc[0]);
                        items.SubItems.Add(menu3_desc[1]);
                        items.SubItems.Add("1");
                        listView1.Items.Add(items);
                    }
                    menu3_desc[2] = Convert.ToString(Convert.ToInt32(menu3_desc[2]) - 1);
                }
                else
                {
                    MessageBox.Show("재고가 부족합니다");
                }

            }
        }

        private void MenuImage4_Click(object sender, EventArgs e)
        {
            if (MenuImage4.Image != null)
            {

                if (Convert.ToInt32(menu4_desc[2]) > 0)
                {
                    Boolean isExists = false;
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].Text == menu4_desc[0])
                        {
                            listView1.Items[i].SubItems[2].Text = Convert.ToString(Convert.ToInt32(listView1.Items[i].SubItems[2].Text) + 1);
                            isExists = true;
                        }
                    }

                    if (!isExists)
                    {
                        ListViewItem items = new ListViewItem(menu4_desc[0]);
                        items.SubItems.Add(menu4_desc[1]);
                        items.SubItems.Add("1");
                        listView1.Items.Add(items);
                    }
                    menu4_desc[2] = Convert.ToString(Convert.ToInt32(menu4_desc[2]) - 1);
                }
                else
                {
                    MessageBox.Show("재고가 부족합니다");
                }

            }
        }

        private void MenuImage5_Click(object sender, EventArgs e)
        {
            if (MenuImage5.Image != null)
            {

                if (Convert.ToInt32(menu5_desc[2]) > 0)
                {
                    Boolean isExists = false;
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].Text == menu5_desc[0])
                        {
                            listView1.Items[i].SubItems[2].Text = Convert.ToString(Convert.ToInt32(listView1.Items[i].SubItems[2].Text) + 1);
                            isExists = true;
                        }
                    }

                    if (!isExists)
                    {
                        ListViewItem items = new ListViewItem(menu5_desc[0]);
                        items.SubItems.Add(menu5_desc[1]);
                        items.SubItems.Add("1");
                        listView1.Items.Add(items);
                    }
                    menu5_desc[2] = Convert.ToString(Convert.ToInt32(menu5_desc[2]) - 1);
                }
                else
                {
                    MessageBox.Show("재고가 부족합니다");
                }

            }
        }

        private void MenuImage6_Click(object sender, EventArgs e)
        {
            if (MenuImage6.Image != null)
            {

                if (Convert.ToInt32(menu6_desc[2]) > 0)
                {
                    Boolean isExists = false;
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].Text == menu6_desc[0])
                        {
                            listView1.Items[i].SubItems[2].Text = Convert.ToString(Convert.ToInt32(listView1.Items[i].SubItems[2].Text) + 1);
                            isExists = true;
                        }
                    }

                    if (!isExists)
                    {
                        ListViewItem items = new ListViewItem(menu6_desc[0]);
                        items.SubItems.Add(menu6_desc[1]);
                        items.SubItems.Add("1");
                        listView1.Items.Add(items);
                    }
                    menu6_desc[2] = Convert.ToString(Convert.ToInt32(menu6_desc[2]) - 1);
                }
                else
                {
                    MessageBox.Show("재고가 부족합니다");
                }

            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                int SelectRow = listView1.SelectedItems[0].Index;
                string SelectMenu = listView1.Items[SelectRow].SubItems[0].Text;


                if (menu1_desc[0] == SelectMenu) { MenuImage1_Click(sender, e); }
                if (menu2_desc[0] == SelectMenu) { MenuImage2_Click(sender, e); }
                if (menu3_desc[0] == SelectMenu) { MenuImage3_Click(sender, e); }
                if (menu4_desc[0] == SelectMenu) { MenuImage4_Click(sender, e); }
                if (menu5_desc[0] == SelectMenu) { MenuImage5_Click(sender, e); }
                if (menu6_desc[0] == SelectMenu) { MenuImage6_Click(sender, e); }
            }
                
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                int SelectRow = listView1.SelectedItems[0].Index;
                string SelectMenu = listView1.Items[SelectRow].SubItems[0].Text;

                if (listView1.Items[SelectRow].SubItems[2].Text == "1") 
                {
                    listView1.Items.RemoveAt(SelectRow);
                }
                else 
                { 
                    listView1.Items[SelectRow].SubItems[2].Text = Convert.ToString(Convert.ToInt32(listView1.Items[SelectRow].SubItems[2].Text) + -1); 
                }
                if (menu1_desc[0] == SelectMenu) { menu1_desc[2] = Convert.ToString(Convert.ToInt32(menu1_desc[2]) + 1); }
                if (menu2_desc[0] == SelectMenu) { menu2_desc[2] = Convert.ToString(Convert.ToInt32(menu2_desc[2]) + 1); }
                if (menu3_desc[0] == SelectMenu) { menu3_desc[2] = Convert.ToString(Convert.ToInt32(menu3_desc[2]) + 1); }
                if (menu4_desc[0] == SelectMenu) { menu4_desc[2] = Convert.ToString(Convert.ToInt32(menu4_desc[2]) + 1); }
                if (menu5_desc[0] == SelectMenu) { menu5_desc[2] = Convert.ToString(Convert.ToInt32(menu5_desc[2]) + 1); }
                if (menu6_desc[0] == SelectMenu) { menu6_desc[2] = Convert.ToString(Convert.ToInt32(menu6_desc[2]) + 1); }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count != 0)
            {

           
                this.Visible = false;
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.getList(listView1);
                orderDetail.Owner = this;
                orderDetail.ShowDialog();
            }
            else
            {
                MessageBox.Show("선택된 메뉴가 없습니다.","주문 오류");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
            this.Close();
        }

    }
}
