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
    public partial class OrderDetail : Form
    {
        public OrderDetail()
        {
            InitializeComponent();
        }

        public int tot_price = 0;

        public void getList(ListView listview)
        {
            int cnt = 0;
            foreach (ListViewItem item in listview.Items)
            {
                listView1.Items.Add((ListViewItem)item.Clone());
                int tot = Convert.ToInt32(listView1.Items[cnt].SubItems[1].Text) * Convert.ToInt32(listView1.Items[cnt].SubItems[2].Text);
                tot_price += tot;
                listView1.Items[cnt].SubItems.Add(Convert.ToString(tot));
                cnt++;
            }

            txtTot.Text = "총 금액 : " + tot_price.ToString() + "원";
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Visible = true;
        }


        private void OrderDetail_Load(object sender, EventArgs e)
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
        }

        private void txtTot_Click(object sender, EventArgs e)
        {

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Point point = new Point();
            point.parseList(listView1, tot_price,"cash");
            point.Owner = this;
            point.ShowDialog();
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Point point = new Point();
            point.parseList(listView1, tot_price, "card");
            point.Owner = this;
            point.ShowDialog();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PointPay pointpay = new PointPay();
            pointpay.parseList(listView1, tot_price, "point");
            pointpay.Owner = this;
            pointpay.ShowDialog();
        }
    }
}
