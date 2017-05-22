namespace Autorization
{
    partial class MainForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbPas = new System.Windows.Forms.TextBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.linkLIsForgotPass = new System.Windows.Forms.LinkLabel();
            this.linkLRegistration = new System.Windows.Forms.LinkLabel();
            this.pbMain = new System.Windows.Forms.ProgressBar();
            this.tbCheckData = new System.Windows.Forms.TextBox();
            this.lbInfoProgBar = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(8, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(188, 20);
            label1.TabIndex = 0;
            label1.Text = "Имя пользователя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 106);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 20);
            label2.TabIndex = 2;
            label2.Text = "Пароль:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(255, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Autorization.Properties.Resources.lockicon400;
            this.pictureBox1.Location = new System.Drawing.Point(10, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEnter);
            this.groupBox2.Controls.Add(this.tbPas);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(this.tbLog);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Location = new System.Drawing.Point(293, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(255, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры авторизации";
            // 
            // btnEnter
            // 
            this.btnEnter.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnEnter.FlatAppearance.BorderSize = 10;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.ForeColor = System.Drawing.Color.Red;
            this.btnEnter.Location = new System.Drawing.Point(130, 172);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(101, 33);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbPas
            // 
            this.tbPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPas.Location = new System.Drawing.Point(14, 127);
            this.tbPas.Name = "tbPas";
            this.tbPas.PasswordChar = '*';
            this.tbPas.Size = new System.Drawing.Size(234, 30);
            this.tbPas.TabIndex = 3;
            this.tbPas.TextChanged += new System.EventHandler(this.tbLogPas_TextChanged);
            // 
            // tbLog
            // 
            this.tbLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLog.Location = new System.Drawing.Point(11, 55);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(237, 30);
            this.tbLog.TabIndex = 1;
            this.tbLog.TextChanged += new System.EventHandler(this.tbLogPas_TextChanged);
            // 
            // linkLIsForgotPass
            // 
            this.linkLIsForgotPass.AutoSize = true;
            this.linkLIsForgotPass.Location = new System.Drawing.Point(23, 323);
            this.linkLIsForgotPass.Name = "linkLIsForgotPass";
            this.linkLIsForgotPass.Size = new System.Drawing.Size(161, 20);
            this.linkLIsForgotPass.TabIndex = 2;
            this.linkLIsForgotPass.TabStop = true;
            this.linkLIsForgotPass.Text = "Забыли пароль?";
            this.linkLIsForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLIsForgotPass_LinkClicked);
            // 
            // linkLRegistration
            // 
            this.linkLRegistration.AutoSize = true;
            this.linkLRegistration.Location = new System.Drawing.Point(446, 323);
            this.linkLRegistration.Name = "linkLRegistration";
            this.linkLRegistration.Size = new System.Drawing.Size(128, 20);
            this.linkLRegistration.TabIndex = 3;
            this.linkLRegistration.TabStop = true;
            this.linkLRegistration.Text = "Регистрация";
            this.linkLRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLRegistration_LinkClicked);
            // 
            // pbMain
            // 
            this.pbMain.Location = new System.Drawing.Point(13, 289);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(535, 31);
            this.pbMain.Step = 20;
            this.pbMain.TabIndex = 4;
            // 
            // tbCheckData
            // 
            this.tbCheckData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbCheckData.ForeColor = System.Drawing.Color.Red;
            this.tbCheckData.Location = new System.Drawing.Point(13, 260);
            this.tbCheckData.Name = "tbCheckData";
            this.tbCheckData.Size = new System.Drawing.Size(535, 26);
            this.tbCheckData.TabIndex = 5;
            this.tbCheckData.Text = "Проверьте введенные данные";
            this.tbCheckData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbCheckData.Visible = false;
            // 
            // lbInfoProgBar
            // 
            this.lbInfoProgBar.AutoSize = true;
            this.lbInfoProgBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbInfoProgBar.ForeColor = System.Drawing.Color.Red;
            this.lbInfoProgBar.Location = new System.Drawing.Point(143, 295);
            this.lbInfoProgBar.Name = "lbInfoProgBar";
            this.lbInfoProgBar.Size = new System.Drawing.Size(273, 20);
            this.lbInfoProgBar.TabIndex = 6;
            this.lbInfoProgBar.Text = "Идет проверка.. Подождите";
            this.lbInfoProgBar.Visible = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(578, 350);
            this.Controls.Add(this.lbInfoProgBar);
            this.Controls.Add(this.tbCheckData);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.linkLRegistration);
            this.Controls.Add(this.linkLIsForgotPass);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Авторизация...";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbPas;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.LinkLabel linkLIsForgotPass;
        private System.Windows.Forms.LinkLabel linkLRegistration;
        private System.Windows.Forms.ProgressBar pbMain;
        private System.Windows.Forms.TextBox tbCheckData;
        private System.Windows.Forms.Label lbInfoProgBar;
    }
}

