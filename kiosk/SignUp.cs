using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Oracle.DataAccess.Client;


namespace kiosk
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.MaxLength = 4;
            textBox2.PasswordChar = '*';
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text.Length==4) 
            {
                    string connectionString = "User Id=dbp1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                    OracleConnection conn = new OracleConnection(connectionString);
                    conn.Open();
                    string strqry = "insert into customer values (c_id.nextval,:c_phone,:c_password,'0')";
                    OracleCommand comm = new OracleCommand(strqry, conn);


                    comm.Parameters.Add("c_phone", OracleDbType.NVarchar2, 11);
                    comm.Parameters["c_phone"].Value = textBox1.Text;

                    comm.Parameters.Add("c_password", OracleDbType.NVarchar2, 4);
                    comm.Parameters["c_password"].Value = textBox2.Text;

                    comm.ExecuteReader();

                    conn.Close();

                    MessageBox.Show("회원가입이 정상적으로 완료되었습니다.", "회원가입 완료");
                    button1_Click(sender, e);
            }
            else
            {
                MessageBox.Show("전화번호와 비밀번호를 입력해주세요", "회원가입 오류");
            }
            
        }
    }
}