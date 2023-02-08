using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiosk
{
    public partial class ManageMenu : Form
    {
        
        public ManageMenu()
        {
            InitializeComponent();
        }

        public string p_id; // 상품번호 전역변수
        public string p_quantity; // 상품재고 전역변수

        public void getProductId(String id,String quantity)
        {
            p_id = id;
            p_quantity = quantity;
            ManageMenu_init();
        }

        private void ManageMenu_init()
        {
            string connectionString = "User Id=dbp1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            string strqry = "select * from product where product_id=:p_id";
            OracleCommand comm = new OracleCommand(strqry, conn);

            comm.Parameters.Add("p_id", OracleDbType.Int16);
            comm.Parameters["p_id"].Value = p_id;
            OracleDataReader sr = comm.ExecuteReader();

            while(sr.Read())
            {
                
                txtMenuType.SelectedIndex = Convert.ToInt32(sr[1].ToString());
                txtMenuName.Text = sr[2].ToString();

                byte[] ImageData = new byte[0];
                ImageData = sr.GetOracleBlob(3).Value;
                MemoryStream memStm = new MemoryStream(ImageData);
                if (ImageData.Length > 0)
                {
                    MenuImage.Image = Image.FromStream(memStm);
                }
                else
                {
                    MenuImage.Image = null;
                }

                txtMenuDesc.Text = sr[4].ToString();
                txtMenuPrice.Text = sr[5].ToString();
            }
            txtQuantity.Text = p_quantity;

           





            conn.Close();
            sr.Close();
        }

     

        private void btnEditMenu_Click(object sender, EventArgs e)
        {
            byte[] imageBytes;
            if (MenuImage.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                MenuImage.Image.Save(ms, MenuImage.Image.RawFormat);
                imageBytes = ms.ToArray();
            }
            else
            {
                imageBytes = new byte[0];
            }

            string connectionString = "User Id=dbp1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            string strqry = "update product set product_name=:p_name,product_desc=:p_desc,product_price=:p_price,product_type_id=:p_type,product_img=:p_image where product_id=:p_id";
            OracleCommand comm = new OracleCommand(strqry, conn);

            comm.BindByName = true;

            comm.Parameters.Add("p_type", OracleDbType.Int16);
            comm.Parameters["p_type"].Value = txtMenuType.SelectedIndex;

            comm.Parameters.Add("p_name", OracleDbType.NVarchar2, 50);
            comm.Parameters["p_name"].Value = txtMenuName.Text.Trim();

            comm.Parameters.Add("p_image", OracleDbType.Blob);
            comm.Parameters["p_image"].Value = imageBytes;

            comm.Parameters.Add("p_desc", OracleDbType.NVarchar2, 50);
            comm.Parameters["p_desc"].Value = txtMenuDesc.Text.Trim();

            comm.Parameters.Add("p_price", OracleDbType.Int32);
            comm.Parameters["p_price"].Value = txtMenuPrice.Text.Trim();

            comm.Parameters.Add("p_id", OracleDbType.Int16);
            comm.Parameters["p_id"].Value = p_id;

            OracleDataReader sr = comm.ExecuteReader();

            string strqry2 = "update stock_quantity set product_quantity=:p_quantity where product_id=:p_id";
            OracleCommand comm2 = new OracleCommand(strqry2, conn);

            comm2.BindByName = true;    
            comm2.Parameters.Add("p_quantity", OracleDbType.Int16);
            comm2.Parameters["p_quantity"].Value = txtQuantity.Text;

            comm2.Parameters.Add("p_id", OracleDbType.Int16);
            comm2.Parameters["p_id"].Value = p_id;
            OracleDataReader sr2 = comm2.ExecuteReader();

            sr.Close();
            sr2.Close();
            conn.Close();

            MessageBox.Show("메뉴가 정상적으로 수정되었습니다.", "메뉴수정");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenuImage_Click(object sender, EventArgs e)
        {
            string imagename;
            FileDialog fldlg = new OpenFileDialog();
            // 탐색할 폴더 초기화
            fldlg.InitialDirectory = @":C\";
            // 선택할 파일 확장자 지정 (이미지 파일만 선택 가능하도록) 
            fldlg.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif";
            if (fldlg.ShowDialog() == DialogResult.OK)
            {
                imagename = fldlg.FileName;
                Bitmap newimg = new Bitmap(imagename);
                MenuImage.Image = (Image)newimg;
                MenuImage.Tag = fldlg.FileName;
            }
            fldlg = null;
        }

        private void ManageMenu_Load(object sender, EventArgs e)
        {

        }

    }
}
