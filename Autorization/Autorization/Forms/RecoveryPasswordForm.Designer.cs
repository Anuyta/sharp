namespace Autorization.Forms
{
    partial class RecoveryPasswordForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRepeatNewPasReset = new System.Windows.Forms.TextBox();
            this.tbNewPassReset = new System.Windows.Forms.TextBox();
            this.tbEmailForReset = new System.Windows.Forms.TextBox();
            this.btnOkRecov = new System.Windows.Forms.Button();
            this.btnCancelRecov = new System.Windows.Forms.Button();
            this.epEmailForRecov = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNewPasForRecov = new System.Windows.Forms.ErrorProvider(this.components);
            this.epRepeatNewPasForRecov = new System.Windows.Forms.ErrorProvider(this.components);
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epEmailForRecov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNewPasForRecov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRepeatNewPasForRecov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(23, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(164, 24);
            label1.TabIndex = 1;
            label1.Text = "Введите e-mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(23, 110);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(156, 24);
            label2.TabIndex = 2;
            label2.Text = "Новый пароль:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(23, 192);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(268, 24);
            label3.TabIndex = 4;
            label3.Text = "Повторите новый пароль:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRepeatNewPasReset);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.tbNewPassReset);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.tbEmailForReset);
            this.groupBox1.Location = new System.Drawing.Point(20, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(336, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tbRepeatNewPasReset
            // 
            this.tbRepeatNewPasReset.Location = new System.Drawing.Point(23, 221);
            this.tbRepeatNewPasReset.Name = "tbRepeatNewPasReset";
            this.tbRepeatNewPasReset.PasswordChar = '*';
            this.tbRepeatNewPasReset.Size = new System.Drawing.Size(281, 30);
            this.tbRepeatNewPasReset.TabIndex = 5;
            this.tbRepeatNewPasReset.Leave += new System.EventHandler(this.tbTextBox_Leave);
            // 
            // tbNewPassReset
            // 
            this.tbNewPassReset.Location = new System.Drawing.Point(23, 139);
            this.tbNewPassReset.Name = "tbNewPassReset";
            this.tbNewPassReset.PasswordChar = '*';
            this.tbNewPassReset.Size = new System.Drawing.Size(281, 30);
            this.tbNewPassReset.TabIndex = 3;
            this.tbNewPassReset.Leave += new System.EventHandler(this.tbTextBox_Leave);
            // 
            // tbEmailForReset
            // 
            this.tbEmailForReset.Location = new System.Drawing.Point(23, 63);
            this.tbEmailForReset.Margin = new System.Windows.Forms.Padding(5);
            this.tbEmailForReset.Name = "tbEmailForReset";
            this.tbEmailForReset.Size = new System.Drawing.Size(281, 30);
            this.tbEmailForReset.TabIndex = 0;
            this.tbEmailForReset.Leave += new System.EventHandler(this.tbTextBox_Leave);
            // 
            // btnOkRecov
            // 
            this.btnOkRecov.Location = new System.Drawing.Point(104, 314);
            this.btnOkRecov.Name = "btnOkRecov";
            this.btnOkRecov.Size = new System.Drawing.Size(123, 33);
            this.btnOkRecov.TabIndex = 1;
            this.btnOkRecov.Text = "OK";
            this.btnOkRecov.UseVisualStyleBackColor = true;
            this.btnOkRecov.Click += new System.EventHandler(this.btnOkRecov_Click);
            // 
            // btnCancelRecov
            // 
            this.btnCancelRecov.Location = new System.Drawing.Point(233, 314);
            this.btnCancelRecov.Name = "btnCancelRecov";
            this.btnCancelRecov.Size = new System.Drawing.Size(123, 33);
            this.btnCancelRecov.TabIndex = 2;
            this.btnCancelRecov.Text = "Отмена";
            this.btnCancelRecov.UseVisualStyleBackColor = true;
            this.btnCancelRecov.Click += new System.EventHandler(this.btnCancelRecov_Click);
            // 
            // epEmailForRecov
            // 
            this.epEmailForRecov.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epEmailForRecov.ContainerControl = this;
            // 
            // epNewPasForRecov
            // 
            this.epNewPasForRecov.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epNewPasForRecov.ContainerControl = this;
            // 
            // epRepeatNewPasForRecov
            // 
            this.epRepeatNewPasForRecov.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epRepeatNewPasForRecov.ContainerControl = this;
            // 
            // RecoveryPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 359);
            this.Controls.Add(this.btnCancelRecov);
            this.Controls.Add(this.btnOkRecov);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RecoveryPasswordForm";
            this.Text = "Восстановление пароля";
            this.Load += new System.EventHandler(this.RecoveryPasswordForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epEmailForRecov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNewPasForRecov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epRepeatNewPasForRecov)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbRepeatNewPasReset;
        private System.Windows.Forms.TextBox tbNewPassReset;
        private System.Windows.Forms.TextBox tbEmailForReset;
        private System.Windows.Forms.Button btnOkRecov;
        private System.Windows.Forms.Button btnCancelRecov;
        private System.Windows.Forms.ErrorProvider epEmailForRecov;
        private System.Windows.Forms.ErrorProvider epNewPasForRecov;
        private System.Windows.Forms.ErrorProvider epRepeatNewPasForRecov;
    }
}