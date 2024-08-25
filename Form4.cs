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
    public partial class Form4 : Form
    {
        //Form3 categories;
        public static string formname = "Form4";

        //Form3 _records;
        Categories categories = new Categories();
        Records records = new Records();
        string user = "";
        /*public Form4(string user)
        {
            InitializeComponent();
            comboBox1.Items.Add("全");
            comboBox1.Items.Add("早餐");
            comboBox1.Items.Add("午餐");
            comboBox1.Items.Add("晚餐");
            comboBox1.Items.Add("點心");
            comboBox1.Items.Add("飲料");
            comboBox1.Items.Add("宵夜");
            comboBox1.Items.Add("汽油");
            comboBox1.Items.Add("公車");
            comboBox1.Items.Add("捷運");
            comboBox1.Items.Add("火車");
            comboBox1.Items.Add("其他 ( 交通 )");
            comboBox1.Items.Add("電影");
            comboBox1.Items.Add("衣著");
            comboBox1.Items.Add("旅遊");
            comboBox1.Items.Add("其他( 娛樂 )");
            comboBox1.Items.Add("房租");
            comboBox1.Items.Add("電信費");
            comboBox1.Items.Add("水電費");
            comboBox1.Items.Add("其他( 生活 )");
            comboBox1.Items.Add("薪資");
            comboBox1.Items.Add("獎金");
            this.user = user;
        }*/

            //建立combo box內分類的各項目
        public Form4(string user,ref Records in_record)
        {
            InitializeComponent();
            cboitem.Items.Add("全");
            cboitem.Items.Add("--------支出");
            cboitem.Items.Add("----食物");
            cboitem.Items.Add("早餐");
            cboitem.Items.Add("午餐");
            cboitem.Items.Add("晚餐");
            cboitem.Items.Add("點心");
            cboitem.Items.Add("飲料");
            cboitem.Items.Add("宵夜");
            cboitem.Items.Add("其他(食)");
            cboitem.Items.Add("----交通");
            cboitem.Items.Add("汽油");
            cboitem.Items.Add("公車");
            cboitem.Items.Add("捷運");
            cboitem.Items.Add("火車");
            cboitem.Items.Add("其他(交)");
            cboitem.Items.Add("----娛樂");
            cboitem.Items.Add("電影");
            cboitem.Items.Add("衣著");
            cboitem.Items.Add("旅遊");
            cboitem.Items.Add("其他(娛)");
            cboitem.Items.Add("----生活");
            cboitem.Items.Add("房租");
            cboitem.Items.Add("電信費");
            cboitem.Items.Add("水電費");
            cboitem.Items.Add("其他(生)");
            cboitem.Items.Add("--------收入");
            cboitem.Items.Add("薪資");
            cboitem.Items.Add("獎金");
            cboitem.Items.Add("其他(收)");

            this.records = in_record;
            this.user = user;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboitem.SelectedIndex == 0)
            {
                //將record中的數據顯示再txtrecord，透過viewintextbox實踐
                txtrecord.Text = records.ViewInTextbox();
                //清空listbox
                listbox_item.Items.Clear();
                //將record中匹配的記錄按照類添加到listbox_item
                listbox_item.Items.AddRange(records.FindInListBox(cboitem.SelectedItem.ToString(),categories).ToArray());
            }
            else
            { 
                //將record中的數據顯示再txtrecord，透過findintextbox實踐
                txtrecord.Text = records.FindInTextBox(cboitem.SelectedItem.ToString(), categories);
                Console.WriteLine(cboitem.SelectedItem.ToString());
                //清空listbox
                listbox_item.Items.Clear();
                //將record中匹配的記錄按照類添加到listbox_item
                listbox_item.Items.AddRange(records.FindInListBox(cboitem.SelectedItem.ToString(), categories).ToArray());
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "檢視帳款";
            txtrecord.Text = records.ViewInTextbox();
            listbox_item.Items.Clear();
            listbox_item.Items.AddRange(records.FindInListBox("全", categories).ToArray());
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            
            button_delete.Enabled = false;

            if (listbox_item.SelectedIndex != -1) //檢查是否有選取ListBox項目
            {
                records.Delete(listbox_item.SelectedIndex);
                listbox_item.Items.RemoveAt(listbox_item.SelectedIndex);
                //移除所選取的ListBox項目
                //listBox1.Items.Clear();
                //listBox1.Items.AddRange(records.FindInListBox("全", categories).ToArray());
            }
            else
            {
                MessageBox.Show("請先選取要刪除的項目"); //若未選取任何項目，顯示提示訊息
            }
        }

        private void button_main_Click(object sender, EventArgs e)
        {
            
        
                this.Close();
;
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //使刪除鈕有效
            button_delete.Enabled = true;
        }
    }
}
