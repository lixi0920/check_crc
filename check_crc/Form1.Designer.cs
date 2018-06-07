namespace check_crc
{
    partial class CRC
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRC));
            this.GB_ES = new System.Windows.Forms.GroupBox();
            this.bt_crc = new System.Windows.Forms.Button();
            this.tb_send = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_org = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_data4 = new System.Windows.Forms.ComboBox();
            this.cbx_data3 = new System.Windows.Forms.ComboBox();
            this.cbx_data2 = new System.Windows.Forms.ComboBox();
            this.tb_org_send = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_data1 = new System.Windows.Forms.ComboBox();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GB_ES.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_ES
            // 
            this.GB_ES.Controls.Add(this.bt_crc);
            this.GB_ES.Controls.Add(this.tb_send);
            this.GB_ES.Location = new System.Drawing.Point(-1, 0);
            this.GB_ES.Name = "GB_ES";
            this.GB_ES.Size = new System.Drawing.Size(488, 47);
            this.GB_ES.TabIndex = 0;
            this.GB_ES.TabStop = false;
            this.GB_ES.Text = "CRC计算";
            // 
            // bt_crc
            // 
            this.bt_crc.Location = new System.Drawing.Point(342, 12);
            this.bt_crc.Name = "bt_crc";
            this.bt_crc.Size = new System.Drawing.Size(80, 31);
            this.bt_crc.TabIndex = 1;
            this.bt_crc.Text = "计算CRC";
            this.bt_crc.UseVisualStyleBackColor = true;
            this.bt_crc.Click += new System.EventHandler(this.bt_crc_Click);
            // 
            // tb_send
            // 
            this.tb_send.Location = new System.Drawing.Point(6, 12);
            this.tb_send.Multiline = true;
            this.tb_send.Name = "tb_send";
            this.tb_send.Size = new System.Drawing.Size(275, 31);
            this.tb_send.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_org);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbx_data4);
            this.groupBox1.Controls.Add(this.cbx_data3);
            this.groupBox1.Controls.Add(this.cbx_data2);
            this.groupBox1.Controls.Add(this.tb_org_send);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbx_data1);
            this.groupBox1.Controls.Add(this.cbx_type);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "组报文";
            // 
            // bt_org
            // 
            this.bt_org.Location = new System.Drawing.Point(336, 66);
            this.bt_org.Name = "bt_org";
            this.bt_org.Size = new System.Drawing.Size(75, 23);
            this.bt_org.TabIndex = 13;
            this.bt_org.Text = "组合";
            this.bt_org.UseVisualStyleBackColor = true;
            this.bt_org.Click += new System.EventHandler(this.bt_org_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "data4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "data3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(181, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "data2";
            // 
            // cbx_data4
            // 
            this.cbx_data4.FormattingEnabled = true;
            this.cbx_data4.Location = new System.Drawing.Point(354, 36);
            this.cbx_data4.Name = "cbx_data4";
            this.cbx_data4.Size = new System.Drawing.Size(57, 20);
            this.cbx_data4.TabIndex = 7;
            // 
            // cbx_data3
            // 
            this.cbx_data3.FormattingEnabled = true;
            this.cbx_data3.Location = new System.Drawing.Point(269, 36);
            this.cbx_data3.Name = "cbx_data3";
            this.cbx_data3.Size = new System.Drawing.Size(55, 20);
            this.cbx_data3.TabIndex = 6;
            // 
            // cbx_data2
            // 
            this.cbx_data2.FormattingEnabled = true;
            this.cbx_data2.Location = new System.Drawing.Point(183, 36);
            this.cbx_data2.Name = "cbx_data2";
            this.cbx_data2.Size = new System.Drawing.Size(55, 20);
            this.cbx_data2.TabIndex = 5;
            // 
            // tb_org_send
            // 
            this.tb_org_send.Location = new System.Drawing.Point(22, 66);
            this.tb_org_send.Name = "tb_org_send";
            this.tb_org_send.Size = new System.Drawing.Size(280, 21);
            this.tb_org_send.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "data1";
            // 
            // cbx_data1
            // 
            this.cbx_data1.FormattingEnabled = true;
            this.cbx_data1.Location = new System.Drawing.Point(100, 36);
            this.cbx_data1.Name = "cbx_data1";
            this.cbx_data1.Size = new System.Drawing.Size(51, 20);
            this.cbx_data1.TabIndex = 2;
            // 
            // cbx_type
            // 
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Location = new System.Drawing.Point(22, 36);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(51, 20);
            this.cbx_type.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "设备类型";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(5, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 93);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "报文解析";
            // 
            // CRC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 242);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GB_ES);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CRC";
            this.Text = "思悦";
            this.Load += new System.EventHandler(this.CRC_Load);
            this.GB_ES.ResumeLayout(false);
            this.GB_ES.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_ES;
        private System.Windows.Forms.Button bt_crc;
        private System.Windows.Forms.TextBox tb_send;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_data1;
        private System.Windows.Forms.ComboBox cbx_type;
        private System.Windows.Forms.TextBox tb_org_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_data2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_data4;
        private System.Windows.Forms.ComboBox cbx_data3;
        private System.Windows.Forms.Button bt_org;
    }
}

