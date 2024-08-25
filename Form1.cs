using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AccountingApp
{
    public partial class Form1 : Form
    {
        //創建userlist將檔案內資料引入字串，檢查是否為登錄過的使用者
        SortedList<string, string> userlist = new SortedList<string, string>();
        string[] input = new string[2];
        int login = 0;
        string lo_user = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Login";
            TITLE.Anchor = AnchorStyles.None;
            lblUsername.Anchor = AnchorStyles.None;
            lblPassword.Anchor = AnchorStyles.None;
            txtUsername.Anchor = AnchorStyles.None;
            txtPassword.Anchor = AnchorStyles.None;
            btn1Login.Anchor = AnchorStyles.None;
            //讀user.txt檔
            string get;
            if (!File.Exists("User.txt"))
            {
                StreamWriter sw = new StreamWriter("User.txt");
                sw.Close();
            }
                StreamReader sr = new StreamReader("User.txt");
            while ((get = sr.ReadLine()) != null)
            {
                //讀入以空白鍵分開
                input = get.Split(' ');
                userlist.Add(input[0], input[1]);
            }
            sr.Close();
            //MessageBox.Show("end");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "";   //先清空textbox1的文字
            bool exist = false;
            string password = "";
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                //檢查使用者名稱是否存在，
                exist = userlist.TryGetValue(txtUsername.Text, out password);
                if (!exist)
                {
                    //跳出視窗詢問是否需要創建帳號
                    DialogResult register = MessageBox.Show("是否註冊帳號?", "未找到使用者", MessageBoxButtons.YesNo);
                    if (register == DialogResult.Yes)
                    {
                        //建立帳號後將使用者資訊存入user.txt
                        StreamWriter sw = new StreamWriter("User.txt", true);
                        userlist.Add(txtUsername.Text, txtPassword.Text);
                        exist = true;
                        login = 1;
                        sw.WriteLine(txtUsername.Text + " " + txtPassword.Text);
                        sw.Close();
                        lo_user = txtUsername.Text;
                    }
                    else
                    {
                        login = 0;
                    }
                }
                else
                {
                    if (password == txtPassword.Text)
                    {
                        //密碼正確得進入視窗

                        lo_user = txtUsername.Text;
                        login = 1;
                    }
                    else
                    {
                        //密碼錯誤即跳出視窗
                        login = -1;
                        MessageBox.Show("password error!");
                    }
                }
            }
            else
            {
                //若未輸入任何一textbox即跳出輸入訊息
                login = 0;
                if (txtUsername.Text == "" && txtPassword.Text == "") MessageBox.Show("請輸入帳號與密碼", "輸入錯誤");
                else if (txtUsername.Text == "") MessageBox.Show("請輸入帳號", "輸入錯誤");
                else MessageBox.Show("請輸入密碼", "輸入錯誤");

            }
            //產生Form2的物件，才可以使用它所提供的Method
            Form2 f = new Form2(lo_user);  
            if (login == 1)
            {
                f.ShowDialog(this);//設定Form2為Form1的上層，並開啟Form2視窗。
                txtUsername.Text = "";
                txtPassword.Text = "";
            }

            if (f.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                //若使用者在Form2按下了OK，進入這個判斷式
                //textBox1.Text = "按下了" + f.DialogResult.ToString();
                //textBox1.Text = "";
                txtPassword.Text = "";
            }
            else if (f.DialogResult == System.Windows.Forms.DialogResult.Cancel)
            {
                //若使用者在Form2按下了Cancel或者直接點選X關閉視窗，都會進入這個判斷式
                //textBox1.Text = "按下了" + f.DialogResult.ToString();
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                //textBox1.Text = "按下了" + f.DialogResult.ToString();
                txtUsername.Text = "";
                txtPassword.Text = "";
            }

            
        }



    }
   
}
