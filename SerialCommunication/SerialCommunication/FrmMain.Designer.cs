namespace SerialCommunication
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.drpComList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drpBaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.drpParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.drpDataBits = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.drpStopBits = new System.Windows.Forms.ComboBox();
            this.btnCom = new System.Windows.Forms.Button();
            this.picComStatus = new System.Windows.Forms.PictureBox();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.txtReceiveData = new System.Windows.Forms.TextBox();
            this.txtOriginalData = new System.Windows.Forms.TextBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.cboDataType = new System.Windows.Forms.ComboBox();
            this.rbtnWeight = new System.Windows.Forms.RadioButton();
            this.rbtnDingJian = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnModbusRTU = new System.Windows.Forms.RadioButton();
            this.chkOnlyShowValue = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picComStatus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "串口";
            // 
            // drpComList
            // 
            this.drpComList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpComList.FormattingEnabled = true;
            this.drpComList.Location = new System.Drawing.Point(89, 14);
            this.drpComList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drpComList.Name = "drpComList";
            this.drpComList.Size = new System.Drawing.Size(145, 29);
            this.drpComList.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "波特率";
            // 
            // drpBaudRate
            // 
            this.drpBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpBaudRate.FormattingEnabled = true;
            this.drpBaudRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.drpBaudRate.Location = new System.Drawing.Point(89, 56);
            this.drpBaudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drpBaudRate.Name = "drpBaudRate";
            this.drpBaudRate.Size = new System.Drawing.Size(145, 29);
            this.drpBaudRate.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "校验位";
            // 
            // drpParity
            // 
            this.drpParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpParity.FormattingEnabled = true;
            this.drpParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.drpParity.Location = new System.Drawing.Point(89, 101);
            this.drpParity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drpParity.Name = "drpParity";
            this.drpParity.Size = new System.Drawing.Size(145, 29);
            this.drpParity.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 152);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "数据位";
            // 
            // drpDataBits
            // 
            this.drpDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpDataBits.FormattingEnabled = true;
            this.drpDataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6"});
            this.drpDataBits.Location = new System.Drawing.Point(89, 147);
            this.drpDataBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drpDataBits.Name = "drpDataBits";
            this.drpDataBits.Size = new System.Drawing.Size(145, 29);
            this.drpDataBits.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 198);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "停止位";
            // 
            // drpStopBits
            // 
            this.drpStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpStopBits.FormattingEnabled = true;
            this.drpStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.drpStopBits.Location = new System.Drawing.Point(89, 193);
            this.drpStopBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drpStopBits.Name = "drpStopBits";
            this.drpStopBits.Size = new System.Drawing.Size(145, 29);
            this.drpStopBits.TabIndex = 45;
            // 
            // btnCom
            // 
            this.btnCom.Enabled = false;
            this.btnCom.ForeColor = System.Drawing.Color.Black;
            this.btnCom.Location = new System.Drawing.Point(89, 237);
            this.btnCom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCom.Name = "btnCom";
            this.btnCom.Size = new System.Drawing.Size(149, 64);
            this.btnCom.TabIndex = 46;
            this.btnCom.Tag = "0";
            this.btnCom.Text = "打开串口";
            this.btnCom.UseVisualStyleBackColor = true;
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // picComStatus
            // 
            this.picComStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picComStatus.Image = global::SerialCommunication.Properties.Resources.redlight;
            this.picComStatus.Location = new System.Drawing.Point(20, 237);
            this.picComStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picComStatus.Name = "picComStatus";
            this.picComStatus.Size = new System.Drawing.Size(55, 64);
            this.picComStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picComStatus.TabIndex = 47;
            this.picComStatus.TabStop = false;
            // 
            // txtSendData
            // 
            this.txtSendData.Location = new System.Drawing.Point(254, 63);
            this.txtSendData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSendData.Multiline = true;
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(513, 34);
            this.txtSendData.TabIndex = 48;
            // 
            // btnSendData
            // 
            this.btnSendData.ForeColor = System.Drawing.Color.Black;
            this.btnSendData.Location = new System.Drawing.Point(778, 63);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(124, 34);
            this.btnSendData.TabIndex = 49;
            this.btnSendData.Text = "发 送";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // txtReceiveData
            // 
            this.txtReceiveData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReceiveData.Location = new System.Drawing.Point(254, 108);
            this.txtReceiveData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReceiveData.Multiline = true;
            this.txtReceiveData.Name = "txtReceiveData";
            this.txtReceiveData.Size = new System.Drawing.Size(648, 443);
            this.txtReceiveData.TabIndex = 48;
            // 
            // txtOriginalData
            // 
            this.txtOriginalData.Location = new System.Drawing.Point(254, 14);
            this.txtOriginalData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtOriginalData.Multiline = true;
            this.txtOriginalData.Name = "txtOriginalData";
            this.txtOriginalData.Size = new System.Drawing.Size(377, 34);
            this.txtOriginalData.TabIndex = 48;
            // 
            // btnSwitch
            // 
            this.btnSwitch.ForeColor = System.Drawing.Color.Black;
            this.btnSwitch.Location = new System.Drawing.Point(644, 14);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(124, 34);
            this.btnSwitch.TabIndex = 49;
            this.btnSwitch.Text = "转 换";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // cboDataType
            // 
            this.cboDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDataType.FormattingEnabled = true;
            this.cboDataType.Items.AddRange(new object[] {
            "Word",
            "DWord",
            "Float"});
            this.cboDataType.Location = new System.Drawing.Point(778, 17);
            this.cboDataType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDataType.Name = "cboDataType";
            this.cboDataType.Size = new System.Drawing.Size(121, 29);
            this.cboDataType.TabIndex = 37;
            // 
            // rbtnWeight
            // 
            this.rbtnWeight.AutoSize = true;
            this.rbtnWeight.Location = new System.Drawing.Point(47, 43);
            this.rbtnWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnWeight.Name = "rbtnWeight";
            this.rbtnWeight.Size = new System.Drawing.Size(60, 25);
            this.rbtnWeight.TabIndex = 50;
            this.rbtnWeight.Text = "地磅";
            this.rbtnWeight.UseVisualStyleBackColor = true;
            // 
            // rbtnDingJian
            // 
            this.rbtnDingJian.AutoSize = true;
            this.rbtnDingJian.Checked = true;
            this.rbtnDingJian.Location = new System.Drawing.Point(47, 117);
            this.rbtnDingJian.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnDingJian.Name = "rbtnDingJian";
            this.rbtnDingJian.Size = new System.Drawing.Size(60, 25);
            this.rbtnDingJian.TabIndex = 50;
            this.rbtnDingJian.TabStop = true;
            this.rbtnDingJian.Text = "顶尖";
            this.rbtnDingJian.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.rbtnWeight);
            this.groupBox1.Controls.Add(this.rbtnModbusRTU);
            this.groupBox1.Controls.Add(this.rbtnDingJian);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 311);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(223, 240);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "产品类型";
            // 
            // rbtnModbusRTU
            // 
            this.rbtnModbusRTU.AutoSize = true;
            this.rbtnModbusRTU.Location = new System.Drawing.Point(47, 191);
            this.rbtnModbusRTU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnModbusRTU.Name = "rbtnModbusRTU";
            this.rbtnModbusRTU.Size = new System.Drawing.Size(127, 25);
            this.rbtnModbusRTU.TabIndex = 50;
            this.rbtnModbusRTU.Text = "Modbus RTU";
            this.rbtnModbusRTU.UseVisualStyleBackColor = true;
            // 
            // chkOnlyShowValue
            // 
            this.chkOnlyShowValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkOnlyShowValue.AutoSize = true;
            this.chkOnlyShowValue.Checked = true;
            this.chkOnlyShowValue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOnlyShowValue.Location = new System.Drawing.Point(254, 557);
            this.chkOnlyShowValue.Name = "chkOnlyShowValue";
            this.chkOnlyShowValue.Size = new System.Drawing.Size(186, 25);
            this.chkOnlyShowValue.TabIndex = 53;
            this.chkOnlyShowValue.Text = "只显示值，不显示Hex";
            this.chkOnlyShowValue.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(924, 583);
            this.Controls.Add(this.chkOnlyShowValue);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.txtReceiveData);
            this.Controls.Add(this.txtOriginalData);
            this.Controls.Add(this.txtSendData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDataType);
            this.Controls.Add(this.drpComList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drpBaudRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drpParity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.drpDataBits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.drpStopBits);
            this.Controls.Add(this.picComStatus);
            this.Controls.Add(this.btnCom);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picComStatus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drpComList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drpBaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox drpParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox drpDataBits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox drpStopBits;
        private System.Windows.Forms.PictureBox picComStatus;
        private System.Windows.Forms.Button btnCom;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox txtReceiveData;
        private System.Windows.Forms.TextBox txtOriginalData;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.ComboBox cboDataType;
        private System.Windows.Forms.RadioButton rbtnWeight;
        private System.Windows.Forms.RadioButton rbtnDingJian;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnModbusRTU;
        private System.Windows.Forms.CheckBox chkOnlyShowValue;
    }
}