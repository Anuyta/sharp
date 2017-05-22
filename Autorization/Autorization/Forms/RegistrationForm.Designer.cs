namespace Autorization
{
    partial class Registration
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.gbInfoAutorization = new System.Windows.Forms.GroupBox();
            this.tbRepeatPas = new System.Windows.Forms.TextBox();
            this.tbNewPas = new System.Windows.Forms.TextBox();
            this.tbNewLog = new System.Windows.Forms.TextBox();
            this.epLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPersonalData = new System.Windows.Forms.GroupBox();
            this.tbNewEmail = new System.Windows.Forms.TextBox();
            this.tbNewName = new System.Windows.Forms.TextBox();
            this.tbNewSurname = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.epPas = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRepeatPas = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.gbInfoAutorization.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLogin)).BeginInit();
            this.gbPersonalData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRepeatPas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 17);
            label1.TabIndex = 0;
            label1.Text = "Логин:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 75);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 17);
            label2.TabIndex = 3;
            label2.Text = "Пароль:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 129);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(150, 17);
            label3.TabIndex = 4;
            label3.Text = "Повторить пароль:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 17);
            label4.TabIndex = 0;
            label4.Text = "Фамилия:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(10, 75);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(43, 17);
            label5.TabIndex = 1;
            label5.Text = "Имя:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(7, 129);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(57, 17);
            label6.TabIndex = 2;
            label6.Text = "e-mail:";
            // 
            // gbInfoAutorization
            // 
            this.gbInfoAutorization.Controls.Add(this.tbRepeatPas);
            this.gbInfoAutorization.Controls.Add(label3);
            this.gbInfoAutorization.Controls.Add(label2);
            this.gbInfoAutorization.Controls.Add(this.tbNewPas);
            this.gbInfoAutorization.Controls.Add(this.tbNewLog);
            this.gbInfoAutorization.Controls.Add(label1);
            this.gbInfoAutorization.Location = new System.Drawing.Point(12, 27);
            this.gbInfoAutorization.Name = "gbInfoAutorization";
            this.gbInfoAutorization.Size = new System.Drawing.Size(258, 185);
            this.gbInfoAutorization.TabIndex = 0;
            this.gbInfoAutorization.TabStop = false;
            this.gbInfoAutorization.Text = "Информация авторизации";
            // 
            // tbRepeatPas
            // 
            this.tbRepeatPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRepeatPas.Location = new System.Drawing.Point(7, 146);
            this.tbRepeatPas.Name = "tbRepeatPas";
            this.tbRepeatPas.PasswordChar = '*';
            this.tbRepeatPas.Size = new System.Drawing.Size(208, 30);
            this.tbRepeatPas.TabIndex = 5;
            this.tbRepeatPas.Leave += new System.EventHandler(this.tbTextBox_Leave);
            // 
            // tbNewPas
            // 
            this.tbNewPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewPas.Location = new System.Drawing.Point(7, 91);
            this.tbNewPas.Name = "tbNewPas";
            this.tbNewPas.PasswordChar = '*';
            this.tbNewPas.Size = new System.Drawing.Size(208, 30);
            this.tbNewPas.TabIndex = 2;
            this.tbNewPas.Leave += new System.EventHandler(this.tbTextBox_Leave);
            // 
            // tbNewLog
            // 
            this.tbNewLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewLog.Location = new System.Drawing.Point(7, 37);
            this.tbNewLog.Name = "tbNewLog";
            this.tbNewLog.Size = new System.Drawing.Size(208, 30);
            this.tbNewLog.TabIndex = 1;
            this.tbNewLog.Leave += new System.EventHandler(this.tbTextBox_Leave);
            // 
            // epLogin
            // 
            this.epLogin.BlinkRate = 0;
            this.epLogin.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epLogin.ContainerControl = this;
            // 
            // gbPersonalData
            // 
            this.gbPersonalData.Controls.Add(this.tbNewEmail);
            this.gbPersonalData.Controls.Add(this.tbNewName);
            this.gbPersonalData.Controls.Add(this.tbNewSurname);
            this.gbPersonalData.Controls.Add(label6);
            this.gbPersonalData.Controls.Add(label5);
            this.gbPersonalData.Controls.Add(label4);
            this.gbPersonalData.Location = new System.Drawing.Point(308, 27);
            this.gbPersonalData.Name = "gbPersonalData";
            this.gbPersonalData.Size = new System.Drawing.Size(258, 185);
            this.gbPersonalData.TabIndex = 1;
            this.gbPersonalData.TabStop = false;
            this.gbPersonalData.Text = "Личные данные";
            // 
            // tbNewEmail
            // 
            this.tbNewEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewEmail.Location = new System.Drawing.Point(10, 146);
            this.tbNewEmail.Name = "tbNewEmail";
            this.tbNewEmail.Size = new System.Drawing.Size(208, 30);
            this.tbNewEmail.TabIndex = 5;
            this.tbNewEmail.Leave += new System.EventHandler(this.tbTextBox_Leave);
            // 
            // tbNewName
            // 
            this.tbNewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewName.Location = new System.Drawing.Point(10, 91);
            this.tbNewName.Name = "tbNewName";
            this.tbNewName.Size = new System.Drawing.Size(208, 30);
            this.tbNewName.TabIndex = 4;
            // 
            // tbNewSurname
            // 
            this.tbNewSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewSurname.Location = new System.Drawing.Point(10, 37);
            this.tbNewSurname.Name = "tbNewSurname";
            this.tbNewSurname.Size = new System.Drawing.Size(208, 30);
            this.tbNewSurname.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(363, 228);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(98, 27);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(467, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 27);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(19, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(308, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "* - поля для обязательного заполнения";
            // 
            // epPas
            // 
            this.epPas.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPas.ContainerControl = this;
            // 
            // epRepeatPas
            // 
            this.epRepeatPas.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epRepeatPas.ContainerControl = this;
            // 
            // epEmail
            // 
            this.epEmail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epEmail.ContainerControl = this;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 268);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.gbPersonalData);
            this.Controls.Add(this.gbInfoAutorization);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.gbInfoAutorization.ResumeLayout(false);
            this.gbInfoAutorization.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epLogin)).EndInit();
            this.gbPersonalData.ResumeLayout(false);
            this.gbPersonalData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRepeatPas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfoAutorization;
        private System.Windows.Forms.TextBox tbRepeatPas;
        private System.Windows.Forms.TextBox tbNewPas;
        private System.Windows.Forms.TextBox tbNewLog;
        private System.Windows.Forms.ErrorProvider epLogin;
        private System.Windows.Forms.GroupBox gbPersonalData;
        private System.Windows.Forms.TextBox tbNewEmail;
        private System.Windows.Forms.TextBox tbNewName;
        private System.Windows.Forms.TextBox tbNewSurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider epPas;
        private System.Windows.Forms.ErrorProvider epRepeatPas;
        private System.Windows.Forms.ErrorProvider epEmail;
    }
}