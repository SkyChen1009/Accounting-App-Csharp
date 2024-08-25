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
    public partial class Form3 : Form
    {
        Categories categories = new Categories();
        Records records = new Records();
        Records old_records = new Records();
        


        private List<string> buttonTexts; // 儲存按鈕的文字
        string user = "";
        

        public Form3()
        {
            InitializeComponent();
            buttonTexts = new List<string>();   //將所有button文字加入到此字串
        }
        public Form3(string user)
        {
            InitializeComponent();
            buttonTexts = new List<string>();   //將所有button文字加入到此字串
            this.user = user;

        }
        public Form3(string user,ref Records rec)
        {
            InitializeComponent();
            buttonTexts = new List<string>();   //將所有button文字加入到此字串
            this.user = user;
            this.old_records = rec;

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "新增帳款";
            //設定日期combo box
            //將預設日期設為現在
            cboYear.Text = (DateTime.Now.Year).ToString();
            cboMonth.Text = DateTime.Now.Month.ToString();
            cboDay.Text = DateTime.Now.Day.ToString();

            //combo box年度範圍是10年前至今年
            for (int i = DateTime.Now.Year - 10; i <= DateTime.Now.Year; i++)
            {
                cboYear.Items.Add(i.ToString());
            }
            //combo box月份範圍是1月至12月
            for (int i = 1; i <= 12; i++)
            {
                cboMonth.Items.Add(i.ToString());
            }
            //判斷月份以給定當月的日期最多至30或31
            if (cboMonth.Text == "1" || cboMonth.Text == "3" || cboMonth.Text == "5" ||
                cboMonth.Text == "7" || cboMonth.Text == "8" || cboMonth.Text == "10" ||
                cboMonth.Text == "12")
            {
                for (int i = 1; i <= 31; i++)
                {
                    cboDay.Items.Add(i.ToString());
                }
            }
            if (cboMonth.Text == "4" || cboMonth.Text == "6" || cboMonth.Text == "9" ||
                cboMonth.Text == "11")
            {
                for (int i = 1; i <= 30; i++)
                {
                    cboDay.Items.Add(i.ToString());
                }
            }
            if (cboMonth.Text == "2")
            {
                for (int i = 1; i <= 29; i++)
                {
                    cboDay.Items.Add(i.ToString());
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string select = "";
            string ca = "";
            int error = 0;
            try
            {
                if (int.Parse(txtmoney.Text).GetType() != typeof(int))
                {
                    MessageBox.Show("金額輸入格式錯誤 ! (e.g. -1000)");
                }
                else
                {
                    string str = "您新增了一筆";
                    //StreamWriter sw = new StreamWriter(user, true);
                    string Time = cboYear.Text + "/" + cboMonth.Text + "/" + cboDay.Text;
                    //若早餐的radiobox有被點選
                    if (rdbbreakfast.Checked)
                    {
                        //利用+=將字串str疊加資訊
                        select = rdbbreakfast.Text;
                        ca = lblfood.Text;
                    }
                    else if (rdblunch.Checked)
                    {
                        select = rdblunch.Text;
                        ca = lblfood.Text;
                    }
                    else if (rdbdinner.Checked)
                    {
                        select = rdbdinner.Text;
                        ca = lblfood.Text;
                    }
                    else if (rdbdrink.Checked)
                    {
                        select= rdbdrink.Text;
                        ca = lblfood.Text;
                    }
                    else if (rdbsnack.Checked)
                    {
                        select= rdbsnack.Text;
                        ca = lblfood.Text;
                    }
                    else if (rdbnight.Checked)
                    {
                        select= rdbnight.Text;
                        ca = lblfood.Text;

                    }
                    else if (rdbgas.Checked)
                    {
                        select= rdbgas.Text;
                        ca = lbltraffic.Text;

                    }
                    else if (rdbbus.Checked)
                    {
                        select= rdbbus.Text;
                        ca = lbltraffic.Text;
                    }
                    else if (rdbmetro.Checked)
                    {
                        select= rdbmetro.Text;
                        ca = lbltraffic.Text;
                    }
                    else if (rdbtrain.Checked)
                    {
                        select= rdbtrain.Text;
                        ca = lbltraffic.Text;
                    }
                    else if (rdbtrafficother.Checked)
                    {
                        select= rdbtrafficother.Text;
                        ca = lbltraffic.Text;
                    }
                    else if (rdbmovie.Checked)
                    {
                        select= rdbmovie.Text;
                        ca = lblentertainment.Text;
                    }
                    else if (rdbcloth.Checked)
                    {
                        select= rdbcloth.Text;
                        ca = lblentertainment.Text;
                    }
                    else if (rdbtravel.Checked)
                    {
                        select= rdbtravel.Text;
                        ca = lblentertainment.Text;
                    }
                    else if (rdbenterother.Checked)
                    {
                        select= rdbenterother.Text;
                        ca = lblentertainment.Text;
                    }
                    else if (rdbrent.Checked)
                    {
                        select= rdbrent.Text;
                        ca = lblliving.Text;
                    }
                    else if (rdbtelecom.Checked)
                    {
                        select= rdbtelecom.Text;
                        ca = lblliving.Text;
                    }
                    else if (rdbutility.Checked)
                    {
                        select= rdbutility.Text;
                        ca = lblliving.Text;

                    }
                    else if (rdblivingother.Checked)
                    {
                        select= rdblivingother.Text;
                        ca = lblliving.Text;
                    }
                    else if (rdbsalary.Checked)
                    {
                        select= rdbsalary.Text;
                        ca = lblin.Text;
                        
                    }
                    else if (rdbbonus.Checked)
                    {
                        select= rdbbonus.Text;
                        ca = lblin.Text;
                    }
                    
                    if(!(rdbsalary.Checked || rdbbonus.Checked))
                    {
                        if (txtmoney.Text.Substring(0,1) != "-")
                        {
                            txtmoney.Text = "-" + txtmoney.Text;
                        }                        
                    }
                    else
                    {
                        if (txtmoney.Text.Substring(0, 1) == "-")
                        {
                            MessageBox.Show("金額輸入有誤 !");
                            error = 1;
                        }
                    }
                    
                    str += "\n日期 : " + Time +
                            "\n類別 : " + ca + "\n分項 : " + select + "\n金額 : " +
                            txtmoney.Text + "\n備註 : " + txtps.Text;

                    //若皆沒有發生錯誤，則記錄至records
                    if (error == 0)
                    {
                        MessageBox.Show(str);
                        records._records.Add(new Record(select, txtps.Text, int.Parse(txtmoney.Text), Time));
                        old_records._records.Add(new Record(select, txtps.Text, int.Parse(txtmoney.Text), Time));
                        MessageBox.Show(records.View());
                    }
                    //sw.WriteLine(select + " " + txtps.Text + " " + txtmoney.Text + " " + Time , true);
                    //sw.Close();

                    
                }
            }
            catch { MessageBox.Show("金額輸入格式錯誤 ! (e.g. -1000)"); }
            //按下確定鈕後會結束應用程式
            //Application.Exit();
        }

        //將以下按鈕的文字加入到buttonTexts的字串List當中
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton20_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton clickedButton = (RadioButton)sender;
            string buttonText = clickedButton.Text;
            buttonTexts.Add(buttonText);
        }
    }
}
