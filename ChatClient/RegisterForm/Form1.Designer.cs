﻿namespace RegisterForm
{
    partial class regForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputID = new System.Windows.Forms.TextBox();
            this.inputPwd = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(135, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rage Italic", 13F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(38, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rage Italic", 13F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(95, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAME";
            // 
            // inputID
            // 
            this.inputID.Font = new System.Drawing.Font("굴림", 13F);
            this.inputID.Location = new System.Drawing.Point(213, 43);
            this.inputID.Name = "inputID";
            this.inputID.Size = new System.Drawing.Size(308, 32);
            this.inputID.TabIndex = 3;
            // 
            // inputPwd
            // 
            this.inputPwd.Font = new System.Drawing.Font("굴림", 13F);
            this.inputPwd.Location = new System.Drawing.Point(213, 109);
            this.inputPwd.Name = "inputPwd";
            this.inputPwd.PasswordChar = '●';
            this.inputPwd.Size = new System.Drawing.Size(308, 32);
            this.inputPwd.TabIndex = 4;
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("굴림", 13F);
            this.inputName.Location = new System.Drawing.Point(213, 175);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(308, 32);
            this.inputName.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rage Italic", 13F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(43, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(478, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sign UP";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // regForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 336);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.inputPwd);
            this.Controls.Add(this.inputID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "regForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputID;
        private System.Windows.Forms.TextBox inputPwd;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Button button1;
    }
}
