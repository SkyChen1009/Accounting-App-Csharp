namespace AccountingApp
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboitem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtrecord = new System.Windows.Forms.TextBox();
            this.listbox_item = new System.Windows.Forms.ListBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_main = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // cboitem
            // 
            this.cboitem.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboitem.FormattingEnabled = true;
            this.cboitem.Location = new System.Drawing.Point(234, 402);
            this.cboitem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboitem.Name = "cboitem";
            this.cboitem.Size = new System.Drawing.Size(294, 39);
            this.cboitem.TabIndex = 0;
            this.cboitem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(76, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "欲檢視項目";
            // 
            // txtrecord
            // 
            this.txtrecord.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtrecord.Location = new System.Drawing.Point(52, 18);
            this.txtrecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtrecord.MaximumSize = new System.Drawing.Size(562, 359);
            this.txtrecord.Multiline = true;
            this.txtrecord.Name = "txtrecord";
            this.txtrecord.Size = new System.Drawing.Size(540, 359);
            this.txtrecord.TabIndex = 4;
            // 
            // listbox_item
            // 
            this.listbox_item.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listbox_item.FormattingEnabled = true;
            this.listbox_item.ItemHeight = 23;
            this.listbox_item.Location = new System.Drawing.Point(594, 18);
            this.listbox_item.Margin = new System.Windows.Forms.Padding(0);
            this.listbox_item.Name = "listbox_item";
            this.listbox_item.Size = new System.Drawing.Size(571, 349);
            this.listbox_item.TabIndex = 5;
            this.listbox_item.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_delete
            // 
            this.button_delete.Enabled = false;
            this.button_delete.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_delete.Location = new System.Drawing.Point(594, 402);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(92, 44);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "刪除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_main
            // 
            this.button_main.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button_main.Location = new System.Drawing.Point(594, 472);
            this.button_main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_main.Name = "button_main";
            this.button_main.Size = new System.Drawing.Size(140, 43);
            this.button_main.TabIndex = 7;
            this.button_main.Text = "回首頁";
            this.button_main.UseVisualStyleBackColor = true;
            this.button_main.Click += new System.EventHandler(this.button_main_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(6, 14);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(24, 340);
            this.checkedListBox1.TabIndex = 8;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 595);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button_main);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.listbox_item);
            this.Controls.Add(this.txtrecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboitem);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboitem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtrecord;
        private System.Windows.Forms.ListBox listbox_item;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_main;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}