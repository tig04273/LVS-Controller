namespace LVSController
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Comlist = new System.Windows.Forms.ListBox();
            this.ComBox = new System.Windows.Forms.TextBox();
            this.ComStatus = new System.Windows.Forms.TextBox();
            this.CH1Bar = new System.Windows.Forms.TrackBar();
            this.CH1Num = new System.Windows.Forms.TextBox();
            this.CH2Bar = new System.Windows.Forms.TrackBar();
            this.CH3Bar = new System.Windows.Forms.TrackBar();
            this.CH4Bar = new System.Windows.Forms.TrackBar();
            this.CH2Num = new System.Windows.Forms.TextBox();
            this.CH3Num = new System.Windows.Forms.TextBox();
            this.CH4Num = new System.Windows.Forms.TextBox();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.isOpend = new System.Windows.Forms.Button();
            this.CH1Off = new System.Windows.Forms.Button();
            this.CH2Off = new System.Windows.Forms.Button();
            this.CH3Off = new System.Windows.Forms.Button();
            this.CH4Off = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CH1Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CH2Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CH3Bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CH4Bar)).BeginInit();
            this.SuspendLayout();
            // 
            // Comlist
            // 
            this.Comlist.FormattingEnabled = true;
            this.Comlist.ItemHeight = 18;
            this.Comlist.Location = new System.Drawing.Point(17, 18);
            this.Comlist.Margin = new System.Windows.Forms.Padding(4);
            this.Comlist.Name = "Comlist";
            this.Comlist.Size = new System.Drawing.Size(170, 454);
            this.Comlist.TabIndex = 0;
            this.Comlist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComlistMouseClick);
            // 
            // ComBox
            // 
            this.ComBox.Location = new System.Drawing.Point(197, 18);
            this.ComBox.Margin = new System.Windows.Forms.Padding(4);
            this.ComBox.Name = "ComBox";
            this.ComBox.ReadOnly = true;
            this.ComBox.Size = new System.Drawing.Size(141, 28);
            this.ComBox.TabIndex = 3;
            // 
            // ComStatus
            // 
            this.ComStatus.Location = new System.Drawing.Point(197, 58);
            this.ComStatus.Margin = new System.Windows.Forms.Padding(4);
            this.ComStatus.Name = "ComStatus";
            this.ComStatus.ReadOnly = true;
            this.ComStatus.Size = new System.Drawing.Size(141, 28);
            this.ComStatus.TabIndex = 4;
            this.ComStatus.Text = "CLOSE";
            // 
            // CH1Bar
            // 
            this.CH1Bar.LargeChange = 51;
            this.CH1Bar.Location = new System.Drawing.Point(197, 106);
            this.CH1Bar.Margin = new System.Windows.Forms.Padding(4);
            this.CH1Bar.Maximum = 255;
            this.CH1Bar.Name = "CH1Bar";
            this.CH1Bar.Size = new System.Drawing.Size(276, 69);
            this.CH1Bar.SmallChange = 5;
            this.CH1Bar.TabIndex = 5;
            this.CH1Bar.ValueChanged += new System.EventHandler(this.CH1Bar_ValueChanged);
            // 
            // CH1Num
            // 
            this.CH1Num.Location = new System.Drawing.Point(481, 106);
            this.CH1Num.Margin = new System.Windows.Forms.Padding(4);
            this.CH1Num.Name = "CH1Num";
            this.CH1Num.Size = new System.Drawing.Size(63, 28);
            this.CH1Num.TabIndex = 6;
            // 
            // CH2Bar
            // 
            this.CH2Bar.LargeChange = 51;
            this.CH2Bar.Location = new System.Drawing.Point(197, 183);
            this.CH2Bar.Margin = new System.Windows.Forms.Padding(4);
            this.CH2Bar.Maximum = 255;
            this.CH2Bar.Name = "CH2Bar";
            this.CH2Bar.Size = new System.Drawing.Size(276, 69);
            this.CH2Bar.SmallChange = 5;
            this.CH2Bar.TabIndex = 7;
            this.CH2Bar.ValueChanged += new System.EventHandler(this.CH2Bar_ValueChanged);
            // 
            // CH3Bar
            // 
            this.CH3Bar.LargeChange = 51;
            this.CH3Bar.Location = new System.Drawing.Point(197, 260);
            this.CH3Bar.Margin = new System.Windows.Forms.Padding(4);
            this.CH3Bar.Maximum = 255;
            this.CH3Bar.Name = "CH3Bar";
            this.CH3Bar.Size = new System.Drawing.Size(276, 69);
            this.CH3Bar.SmallChange = 5;
            this.CH3Bar.TabIndex = 8;
            this.CH3Bar.ValueChanged += new System.EventHandler(this.CH3Bar_ValueChanged);
            // 
            // CH4Bar
            // 
            this.CH4Bar.LargeChange = 51;
            this.CH4Bar.Location = new System.Drawing.Point(197, 336);
            this.CH4Bar.Margin = new System.Windows.Forms.Padding(4);
            this.CH4Bar.Maximum = 255;
            this.CH4Bar.Name = "CH4Bar";
            this.CH4Bar.Size = new System.Drawing.Size(276, 69);
            this.CH4Bar.SmallChange = 5;
            this.CH4Bar.TabIndex = 9;
            this.CH4Bar.ValueChanged += new System.EventHandler(this.CH4Bar_ValueChanged);
            // 
            // CH2Num
            // 
            this.CH2Num.Location = new System.Drawing.Point(481, 183);
            this.CH2Num.Margin = new System.Windows.Forms.Padding(4);
            this.CH2Num.Name = "CH2Num";
            this.CH2Num.Size = new System.Drawing.Size(63, 28);
            this.CH2Num.TabIndex = 10;
            // 
            // CH3Num
            // 
            this.CH3Num.Location = new System.Drawing.Point(481, 260);
            this.CH3Num.Margin = new System.Windows.Forms.Padding(4);
            this.CH3Num.Name = "CH3Num";
            this.CH3Num.Size = new System.Drawing.Size(63, 28);
            this.CH3Num.TabIndex = 11;
            // 
            // CH4Num
            // 
            this.CH4Num.Location = new System.Drawing.Point(481, 336);
            this.CH4Num.Margin = new System.Windows.Forms.Padding(4);
            this.CH4Num.Name = "CH4Num";
            this.CH4Num.Size = new System.Drawing.Size(63, 28);
            this.CH4Num.TabIndex = 12;
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Enabled = false;
            this.DisconnectBtn.Location = new System.Drawing.Point(481, 15);
            this.DisconnectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(124, 34);
            this.DisconnectBtn.TabIndex = 2;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(349, 15);
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(124, 34);
            this.ConnectBtn.TabIndex = 1;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // isOpend
            // 
            this.isOpend.Location = new System.Drawing.Point(211, 421);
            this.isOpend.Name = "isOpend";
            this.isOpend.Size = new System.Drawing.Size(97, 24);
            this.isOpend.TabIndex = 13;
            this.isOpend.Text = "isOpen?";
            this.isOpend.UseVisualStyleBackColor = true;
            this.isOpend.Visible = false;
            this.isOpend.Click += new System.EventHandler(this.isOpend_Click);
            // 
            // CH1Off
            // 
            this.CH1Off.Location = new System.Drawing.Point(552, 106);
            this.CH1Off.Name = "CH1Off";
            this.CH1Off.Size = new System.Drawing.Size(53, 28);
            this.CH1Off.TabIndex = 14;
            this.CH1Off.Text = "Off";
            this.CH1Off.UseVisualStyleBackColor = true;
            this.CH1Off.Click += new System.EventHandler(this.CH1Off_Click);
            // 
            // CH2Off
            // 
            this.CH2Off.Location = new System.Drawing.Point(552, 183);
            this.CH2Off.Name = "CH2Off";
            this.CH2Off.Size = new System.Drawing.Size(53, 28);
            this.CH2Off.TabIndex = 15;
            this.CH2Off.Text = "Off";
            this.CH2Off.UseVisualStyleBackColor = true;
            this.CH2Off.Click += new System.EventHandler(this.CH2Off_Click);
            // 
            // CH3Off
            // 
            this.CH3Off.Location = new System.Drawing.Point(552, 260);
            this.CH3Off.Name = "CH3Off";
            this.CH3Off.Size = new System.Drawing.Size(53, 28);
            this.CH3Off.TabIndex = 16;
            this.CH3Off.Text = "Off";
            this.CH3Off.UseVisualStyleBackColor = true;
            this.CH3Off.Click += new System.EventHandler(this.CH3Off_Click);
            // 
            // CH4Off
            // 
            this.CH4Off.Location = new System.Drawing.Point(552, 336);
            this.CH4Off.Name = "CH4Off";
            this.CH4Off.Size = new System.Drawing.Size(53, 28);
            this.CH4Off.TabIndex = 17;
            this.CH4Off.Text = "Off";
            this.CH4Off.UseVisualStyleBackColor = true;
            this.CH4Off.Click += new System.EventHandler(this.CH4Off_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 482);
            this.Controls.Add(this.CH4Off);
            this.Controls.Add(this.CH3Off);
            this.Controls.Add(this.CH2Off);
            this.Controls.Add(this.CH1Off);
            this.Controls.Add(this.isOpend);
            this.Controls.Add(this.CH4Num);
            this.Controls.Add(this.CH3Num);
            this.Controls.Add(this.CH2Num);
            this.Controls.Add(this.CH4Bar);
            this.Controls.Add(this.CH3Bar);
            this.Controls.Add(this.CH2Bar);
            this.Controls.Add(this.CH1Num);
            this.Controls.Add(this.CH1Bar);
            this.Controls.Add(this.ComStatus);
            this.Controls.Add(this.ComBox);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.Comlist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "PN-4012";
            ((System.ComponentModel.ISupportInitialize)(this.CH1Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CH2Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CH3Bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CH4Bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Comlist;
        private System.Windows.Forms.TextBox ComBox;
        private System.Windows.Forms.TextBox ComStatus;
        private System.Windows.Forms.TrackBar CH1Bar;
        private System.Windows.Forms.TextBox CH1Num;
        private System.Windows.Forms.TrackBar CH2Bar;
        private System.Windows.Forms.TrackBar CH3Bar;
        private System.Windows.Forms.TrackBar CH4Bar;
        private System.Windows.Forms.TextBox CH2Num;
        private System.Windows.Forms.TextBox CH3Num;
        private System.Windows.Forms.TextBox CH4Num;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Button isOpend;
        private System.Windows.Forms.Button CH1Off;
        private System.Windows.Forms.Button CH2Off;
        private System.Windows.Forms.Button CH3Off;
        private System.Windows.Forms.Button CH4Off;
    }
}

