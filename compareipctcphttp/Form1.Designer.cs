namespace compareipctcphttp
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimes = new System.Windows.Forms.TextBox();
            this.btnStat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHttp = new System.Windows.Forms.Button();
            this.btnTcp = new System.Windows.Forms.Button();
            this.btnIpc = new System.Windows.Forms.Button();
            this.txtHttp = new System.Windows.Forms.TextBox();
            this.txtTcp = new System.Windows.Forms.TextBox();
            this.txtIpc = new System.Windows.Forms.TextBox();
            this.lsbHttp = new System.Windows.Forms.ListBox();
            this.lsbTcp = new System.Windows.Forms.ListBox();
            this.lsbIpc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "调用次数";
            // 
            // txtTimes
            // 
            this.txtTimes.Location = new System.Drawing.Point(98, 22);
            this.txtTimes.Name = "txtTimes";
            this.txtTimes.Size = new System.Drawing.Size(100, 28);
            this.txtTimes.TabIndex = 1;
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(15, 85);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(90, 34);
            this.btnStat.TabIndex = 2;
            this.btnStat.Text = "开始";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "单位:刻度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "平均使用时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "每次使用时间";
            // 
            // btnHttp
            // 
            this.btnHttp.Location = new System.Drawing.Point(260, 85);
            this.btnHttp.Name = "btnHttp";
            this.btnHttp.Size = new System.Drawing.Size(90, 34);
            this.btnHttp.TabIndex = 6;
            this.btnHttp.Text = "Http";
            this.btnHttp.UseVisualStyleBackColor = true;
            this.btnHttp.Click += new System.EventHandler(this.btnHttp_Click);

            // 
            // btnTcp
            // 
            this.btnTcp.Location = new System.Drawing.Point(462, 85);
            this.btnTcp.Name = "btnTcp";
            this.btnTcp.Size = new System.Drawing.Size(90, 34);
            this.btnTcp.TabIndex = 7;
            this.btnTcp.Text = "Tcp";
            this.btnTcp.UseVisualStyleBackColor = true;
            this.btnTcp.Click += new System.EventHandler(this.btnTcp_Click);

            // 
            // btnIpc
            // 
            this.btnIpc.Location = new System.Drawing.Point(651, 85);
            this.btnIpc.Name = "btnIpc";
            this.btnIpc.Size = new System.Drawing.Size(90, 34);
            this.btnIpc.TabIndex = 8;
            this.btnIpc.Text = "Ipc";
            this.btnIpc.UseVisualStyleBackColor = true;
            this.btnIpc.Click += new System.EventHandler(this.btnIpc_Click);

            // 
            // txtHttp
            // 
            this.txtHttp.Location = new System.Drawing.Point(260, 135);
            this.txtHttp.Name = "txtHttp";
            this.txtHttp.Size = new System.Drawing.Size(90, 28);
            this.txtHttp.TabIndex = 9;
            // 
            // txtTcp
            // 
            this.txtTcp.Location = new System.Drawing.Point(462, 135);
            this.txtTcp.Name = "txtTcp";
            this.txtTcp.Size = new System.Drawing.Size(90, 28);
            this.txtTcp.TabIndex = 10;
            // 
            // txtIpc
            // 
            this.txtIpc.Location = new System.Drawing.Point(651, 135);
            this.txtIpc.Name = "txtIpc";
            this.txtIpc.Size = new System.Drawing.Size(90, 28);
            this.txtIpc.TabIndex = 11;
            // 
            // lsbHttp
            // 
            this.lsbHttp.FormattingEnabled = true;
            this.lsbHttp.ItemHeight = 18;
            this.lsbHttp.Location = new System.Drawing.Point(260, 188);
            this.lsbHttp.Name = "lsbHttp";
            this.lsbHttp.Size = new System.Drawing.Size(124, 220);
            this.lsbHttp.TabIndex = 12;
            // 
            // lsbTcp
            // 
            this.lsbTcp.FormattingEnabled = true;
            this.lsbTcp.ItemHeight = 18;
            this.lsbTcp.Location = new System.Drawing.Point(462, 188);
            this.lsbTcp.Name = "lsbTcp";
            this.lsbTcp.Size = new System.Drawing.Size(124, 220);
            this.lsbTcp.TabIndex = 13;
            // 
            // lsbIpc
            // 
            this.lsbIpc.FormattingEnabled = true;
            this.lsbIpc.ItemHeight = 18;
            this.lsbIpc.Location = new System.Drawing.Point(651, 188);
            this.lsbIpc.Name = "lsbIpc";
            this.lsbIpc.Size = new System.Drawing.Size(124, 220);
            this.lsbIpc.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 490);
            this.Controls.Add(this.lsbIpc);
            this.Controls.Add(this.lsbTcp);
            this.Controls.Add(this.lsbHttp);
            this.Controls.Add(this.txtIpc);
            this.Controls.Add(this.txtTcp);
            this.Controls.Add(this.txtHttp);
            this.Controls.Add(this.btnIpc);
            this.Controls.Add(this.btnTcp);
            this.Controls.Add(this.btnHttp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.txtTimes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "测试Remoting三种信道访问速度";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimes;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHttp;
        private System.Windows.Forms.Button btnTcp;
        private System.Windows.Forms.Button btnIpc;
        private System.Windows.Forms.TextBox txtHttp;
        private System.Windows.Forms.TextBox txtTcp;
        private System.Windows.Forms.TextBox txtIpc;
        private System.Windows.Forms.ListBox lsbHttp;
        private System.Windows.Forms.ListBox lsbTcp;
        private System.Windows.Forms.ListBox lsbIpc;
    }
}

