using ADOForm;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kiosk
{
    public partial class AddMenu : Form
    {
        public AddMenu()
        {
            InitializeComponent();
        }

        private void AddMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            byte[] imageBytes;
            if (MenuImage.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                MenuImage.Image.Save(ms,MenuImage.Image.RawFormat);
                imageBytes = ms.ToArray();
            }
            else
            {
                imageBytes = new byte[0];
            }
            string connectionString = "User Id=dbp1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            string strqry = "insert into product values (p_id.nextval,:p_type,:p_name,:p_image,:p_desc,:p_price,'')";
            OracleCommand comm = new OracleCommand(strqry, conn);

            string strqry2 = "insert into stock_quantity values (p_id.currval,1)";
            OracleCommand comm2 = new OracleCommand(strqry2, conn);

            comm.Parameters.Add("p_type", OracleDbType.Int16);
            comm.Parameters["p_type"].Value = txtMenuType.SelectedIndex;

            comm.Parameters.Add("p_name", OracleDbType.NVarchar2,50);
            comm.Parameters["p_name"].Value = txtMenuName.Text.Trim();

            comm.Parameters.Add("p_image", OracleDbType.Blob);
            comm.Parameters["p_image"].Value = imageBytes;

            comm.Parameters.Add("p_desc", OracleDbType.NVarchar2, 50);
            comm.Parameters["p_desc"].Value = txtMenuDesc.Text.Trim();

            comm.Parameters.Add("p_price", OracleDbType.Int16);
            comm.Parameters["p_price"].Value = txtMenuPrice.Text.Trim();

            comm.ExecuteReader();
            comm2.ExecuteReader();


            conn.Close();
            MessageBox.Show("메뉴가 정상적으로 추가되었습니다.", "메뉴추가");
            this.Close();
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


    }
}
