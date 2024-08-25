namespace AccountingApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TITLE = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btn1Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TITLE
            // 
            this.TITLE.AutoSize = true;
            this.TITLE.BackColor = System.Drawing.SystemColors.ControlText;
            this.TITLE.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TITLE.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TITLE.Location = new System.Drawing.Point(196, 86);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(411, 61);
            this.TITLE.TabIndex = 0;
            this.TITLE.Text = "歡迎來到簡易記帳";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsername.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUsername.Location = new System.Drawing.Point(148, 209);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(155, 35);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "使用者名稱";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtUsername.Location = new System.Drawing.Point(353, 203);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(194, 41);
            this.txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPassword.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPassword.Location = new System.Drawing.Point(232, 286);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 35);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "密碼";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPassword.Location = new System.Drawing.Point(353, 282);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(194, 45);
            this.txtPassword.TabIndex = 4;
            // 
            // btn1Login
            // 
            this.btn1Login.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn1Login.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1Login.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1Login.Location = new System.Drawing.Point(593, 368);
            this.btn1Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1Login.Name = "btn1Login";
            this.btn1Login.Size = new System.Drawing.Size(119, 43);
            this.btn1Login.TabIndex = 5;
            this.btn1Login.Text = "登入";
            this.btn1Login.UseVisualStyleBackColor = false;
            this.btn1Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AccountingApp.Properties.Resources.bgc1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 498);
            this.Controls.Add(this.btn1Login);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.TITLE);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TITLE;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btn1Login;
    }
}

