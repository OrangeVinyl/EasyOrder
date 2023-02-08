
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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            MenuList manageStock = new MenuList();
            manageStock.Owner = this;
            manageStock.ShowDialog();
            manageStock.Dispose();
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            AddMenu addMenu = new AddMenu();
            addMenu.Owner = this;
            addMenu.ShowDialog();
            addMenu.Dispose();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
            this.Close();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Owner = this;
            sales.ShowDialog();
            sales.Dispose();
        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {
            ManageOrder manageOrder = new ManageOrder();
            manageOrder.Owner = this;
            manageOrder.ShowDialog();
            manageOrder.Dispose();
        }
    }
}
