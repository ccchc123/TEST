
namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.conn_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.led_off_btn = new System.Windows.Forms.Button();
            this.led_on_btn = new System.Windows.Forms.Button();
            this.점등상태 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.led_txt = new System.Windows.Forms.TextBox();
            this.tmp_txt = new System.Windows.Forms.TextBox();
            this.light_txt = new System.Windows.Forms.TextBox();
            this.distance_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.점등상태.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.conn_btn);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(23, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // conn_btn
            // 
            this.conn_btn.Location = new System.Drawing.Point(103, 20);
            this.conn_btn.Name = "conn_btn";
            this.conn_btn.Size = new System.Drawing.Size(75, 23);
            this.conn_btn.TabIndex = 1;
            this.conn_btn.Text = "연결";
            this.conn_btn.UseVisualStyleBackColor = true;
            this.conn_btn.Click += new System.EventHandler(this.conn_btn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.comboBox1.Location = new System.Drawing.Point(7, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(81, 20);
            this.comboBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.led_off_btn);
            this.groupBox2.Controls.Add(this.led_on_btn);
            this.groupBox2.Location = new System.Drawing.Point(23, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // led_off_btn
            // 
            this.led_off_btn.Location = new System.Drawing.Point(103, 21);
            this.led_off_btn.Name = "led_off_btn";
            this.led_off_btn.Size = new System.Drawing.Size(75, 48);
            this.led_off_btn.TabIndex = 1;
            this.led_off_btn.Text = "OFF";
            this.led_off_btn.UseVisualStyleBackColor = true;
            // 
            // led_on_btn
            // 
            this.led_on_btn.Location = new System.Drawing.Point(7, 21);
            this.led_on_btn.Name = "led_on_btn";
            this.led_on_btn.Size = new System.Drawing.Size(75, 48);
            this.led_on_btn.TabIndex = 0;
            this.led_on_btn.Text = "ON";
            this.led_on_btn.UseVisualStyleBackColor = true;
            this.led_on_btn.Click += new System.EventHandler(this.led_on_btn_Click);
            // 
            // 점등상태
            // 
            this.점등상태.Controls.Add(this.led_txt);
            this.점등상태.Location = new System.Drawing.Point(23, 202);
            this.점등상태.Name = "점등상태";
            this.점등상태.Size = new System.Drawing.Size(200, 45);
            this.점등상태.TabIndex = 2;
            this.점등상태.TabStop = false;
            this.점등상태.Text = "점등상태";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tmp_txt);
            this.groupBox4.Location = new System.Drawing.Point(23, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 45);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "온도센서";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.light_txt);
            this.groupBox5.Location = new System.Drawing.Point(23, 343);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 45);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "조도센서";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.distance_txt);
            this.groupBox6.Location = new System.Drawing.Point(23, 417);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 45);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "초음파센서";
            // 
            // led_txt
            // 
            this.led_txt.Location = new System.Drawing.Point(19, 17);
            this.led_txt.Name = "led_txt";
            this.led_txt.Size = new System.Drawing.Size(159, 21);
            this.led_txt.TabIndex = 0;
            // 
            // tmp_txt
            // 
            this.tmp_txt.Location = new System.Drawing.Point(19, 18);
            this.tmp_txt.Name = "tmp_txt";
            this.tmp_txt.Size = new System.Drawing.Size(159, 21);
            this.tmp_txt.TabIndex = 1;
            // 
            // light_txt
            // 
            this.light_txt.Location = new System.Drawing.Point(19, 18);
            this.light_txt.Name = "light_txt";
            this.light_txt.Size = new System.Drawing.Size(159, 21);
            this.light_txt.TabIndex = 2;
            // 
            // distance_txt
            // 
            this.distance_txt.Location = new System.Drawing.Point(19, 18);
            this.distance_txt.Name = "distance_txt";
            this.distance_txt.Size = new System.Drawing.Size(159, 21);
            this.distance_txt.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 520);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.점등상태);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.점등상태.ResumeLayout(false);
            this.점등상태.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button conn_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button led_off_btn;
        private System.Windows.Forms.Button led_on_btn;
        private System.Windows.Forms.GroupBox 점등상태;
        private System.Windows.Forms.TextBox led_txt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tmp_txt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox light_txt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox distance_txt;
    }
}