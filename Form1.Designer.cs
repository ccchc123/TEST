namespace _01BASIC
{
    partial class Form1
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
            this.PortNumber = new System.Windows.Forms.ComboBox();
            this.conn_btn = new System.Windows.Forms.Button();
            this.Led_01 = new System.Windows.Forms.Button();
            this.Led_02 = new System.Windows.Forms.Button();
            this.Led_03 = new System.Windows.Forms.Button();
            this.Led_04 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PortNumber
            // 
            this.PortNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortNumber.FormattingEnabled = true;
            this.PortNumber.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.PortNumber.Location = new System.Drawing.Point(72, 34);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(130, 20);
            this.PortNumber.TabIndex = 0;
            this.PortNumber.SelectedIndexChanged += new System.EventHandler(this.PortNumber_SelectedIndexChanged_1);
            // 
            // conn_btn
            // 
            this.conn_btn.Location = new System.Drawing.Point(258, 34);
            this.conn_btn.Name = "conn_btn";
            this.conn_btn.Size = new System.Drawing.Size(130, 22);
            this.conn_btn.TabIndex = 1;
            this.conn_btn.Text = "연결";
            this.conn_btn.UseVisualStyleBackColor = true;
            this.conn_btn.Click += new System.EventHandler(this.conn_btn_Click);
            // 
            // Led_01
            // 
            this.Led_01.Location = new System.Drawing.Point(72, 99);
            this.Led_01.Name = "Led_01";
            this.Led_01.Size = new System.Drawing.Size(130, 56);
            this.Led_01.TabIndex = 2;
            this.Led_01.Text = "Led_01 ON";
            this.Led_01.UseVisualStyleBackColor = true;
            this.Led_01.Click += new System.EventHandler(this.Led_01_Click);
            // 
            // Led_02
            // 
            this.Led_02.Location = new System.Drawing.Point(258, 99);
            this.Led_02.Name = "Led_02";
            this.Led_02.Size = new System.Drawing.Size(130, 56);
            this.Led_02.TabIndex = 3;
            this.Led_02.Text = "Led_01 OFF";
            this.Led_02.UseVisualStyleBackColor = true;
            this.Led_02.Click += new System.EventHandler(this.Led_02_Click);
            // 
            // Led_03
            // 
            this.Led_03.Location = new System.Drawing.Point(72, 188);
            this.Led_03.Name = "Led_03";
            this.Led_03.Size = new System.Drawing.Size(130, 56);
            this.Led_03.TabIndex = 4;
            this.Led_03.Text = "Led_02 ON";
            this.Led_03.UseVisualStyleBackColor = true;
            this.Led_03.Click += new System.EventHandler(this.Led_03_Click);
            // 
            // Led_04
            // 
            this.Led_04.Location = new System.Drawing.Point(258, 188);
            this.Led_04.Name = "Led_04";
            this.Led_04.Size = new System.Drawing.Size(130, 56);
            this.Led_04.TabIndex = 5;
            this.Led_04.Text = "Led_02 OFF";
            this.Led_04.UseVisualStyleBackColor = true;
            this.Led_04.Click += new System.EventHandler(this.Led_04_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(72, 250);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 48);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "MESSAGE : ";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 310);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Led_04);
            this.Controls.Add(this.Led_03);
            this.Controls.Add(this.Led_02);
            this.Controls.Add(this.Led_01);
            this.Controls.Add(this.conn_btn);
            this.Controls.Add(this.PortNumber);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PortNumber;
        private System.Windows.Forms.Button conn_btn;
        private System.Windows.Forms.Button Led_01;
        private System.Windows.Forms.Button Led_02;
        private System.Windows.Forms.Button Led_03;
        private System.Windows.Forms.Button Led_04;
        private System.Windows.Forms.TextBox textBox1;
    }
}

