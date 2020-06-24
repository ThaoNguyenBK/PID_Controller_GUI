namespace PID_Controller
{
    partial class Form1
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
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.PbConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CbSecCom = new System.Windows.Forms.ComboBox();
            this.LbStatus = new System.Windows.Forms.Label();
            this.Com = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PbSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtKd = new System.Windows.Forms.TextBox();
            this.txtKi = new System.Windows.Forms.TextBox();
            this.txtKp = new System.Windows.Forms.TextBox();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.PbMode = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.PbExit = new System.Windows.Forms.Button();
            this.checkBoxSpeed = new System.Windows.Forms.CheckBox();
            this.checkBoxPosition = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(18, 201);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1090, 437);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // PbConnect
            // 
            this.PbConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PbConnect.Location = new System.Drawing.Point(87, 39);
            this.PbConnect.Name = "PbConnect";
            this.PbConnect.Size = new System.Drawing.Size(96, 23);
            this.PbConnect.TabIndex = 1;
            this.PbConnect.Text = "Connect";
            this.PbConnect.UseVisualStyleBackColor = true;
            this.PbConnect.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select COM";
            // 
            // CbSecCom
            // 
            this.CbSecCom.FormattingEnabled = true;
            this.CbSecCom.Location = new System.Drawing.Point(87, 12);
            this.CbSecCom.Name = "CbSecCom";
            this.CbSecCom.Size = new System.Drawing.Size(96, 21);
            this.CbSecCom.TabIndex = 3;
            // 
            // LbStatus
            // 
            this.LbStatus.AutoSize = true;
            this.LbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbStatus.Location = new System.Drawing.Point(10, 71);
            this.LbStatus.Name = "LbStatus";
            this.LbStatus.Size = new System.Drawing.Size(85, 13);
            this.LbStatus.TabIndex = 4;
            this.LbStatus.Text = "Disconnected";
            // 
            // Com
            // 
            this.Com.BaudRate = 115200;
            this.Com.Handshake = System.IO.Ports.Handshake.XOnXOff;
            this.Com.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.OnCom);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LbStatus);
            this.groupBox1.Controls.Add(this.CbSecCom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PbConnect);
            this.groupBox1.Location = new System.Drawing.Point(5, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 95);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(26, 19);
            this.txtReceive.Multiline = true;
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(115, 50);
            this.txtReceive.TabIndex = 6;
            this.txtReceive.TextChanged += new System.EventHandler(this.txtReceive_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtReceive);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(221, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 87);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receive";
            // 
            // PbSend
            // 
            this.PbSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PbSend.Location = new System.Drawing.Point(16, 45);
            this.PbSend.Name = "PbSend";
            this.PbSend.Size = new System.Drawing.Size(91, 31);
            this.PbSend.TabIndex = 8;
            this.PbSend.Text = "Send";
            this.PbSend.UseVisualStyleBackColor = true;
            this.PbSend.Click += new System.EventHandler(this.PbSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(16, 19);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(91, 20);
            this.txtSend.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtKd);
            this.groupBox3.Controls.Add(this.txtKi);
            this.groupBox3.Controls.Add(this.txtKp);
            this.groupBox3.Controls.Add(this.txtSend);
            this.groupBox3.Controls.Add(this.btnDecrease);
            this.groupBox3.Controls.Add(this.PbSend);
            this.groupBox3.Controls.Add(this.PbMode);
            this.groupBox3.Controls.Add(this.btnIncrease);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(405, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(451, 139);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Control";
            // 
            // txtKd
            // 
            this.txtKd.Location = new System.Drawing.Point(294, 99);
            this.txtKd.Name = "txtKd";
            this.txtKd.Size = new System.Drawing.Size(74, 20);
            this.txtKd.TabIndex = 21;
            // 
            // txtKi
            // 
            this.txtKi.Location = new System.Drawing.Point(163, 99);
            this.txtKi.Name = "txtKi";
            this.txtKi.Size = new System.Drawing.Size(74, 20);
            this.txtKi.TabIndex = 20;
            // 
            // txtKp
            // 
            this.txtKp.Location = new System.Drawing.Point(53, 99);
            this.txtKp.Name = "txtKp";
            this.txtKp.Size = new System.Drawing.Size(68, 20);
            this.txtKp.TabIndex = 19;
            // 
            // btnDecrease
            // 
            this.btnDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrease.Location = new System.Drawing.Point(127, 44);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(55, 32);
            this.btnDecrease.TabIndex = 18;
            this.btnDecrease.Text = "-";
            this.btnDecrease.UseVisualStyleBackColor = true;
            this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
            // 
            // PbMode
            // 
            this.PbMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PbMode.Location = new System.Drawing.Point(209, 44);
            this.PbMode.Name = "PbMode";
            this.PbMode.Size = new System.Drawing.Size(90, 32);
            this.PbMode.TabIndex = 11;
            this.PbMode.Text = "Mode";
            this.PbMode.UseVisualStyleBackColor = true;
            this.PbMode.Click += new System.EventHandler(this.PbMode_Click);
            // 
            // btnIncrease
            // 
            this.btnIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrease.Location = new System.Drawing.Point(127, 11);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(55, 32);
            this.btnIncrease.TabIndex = 17;
            this.btnIncrease.Text = "+";
            this.btnIncrease.UseVisualStyleBackColor = true;
            this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(355, 44);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(90, 32);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // PbExit
            // 
            this.PbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PbExit.Location = new System.Drawing.Point(1029, 644);
            this.PbExit.Name = "PbExit";
            this.PbExit.Size = new System.Drawing.Size(79, 34);
            this.PbExit.TabIndex = 12;
            this.PbExit.Text = "EXIT";
            this.PbExit.UseVisualStyleBackColor = true;
            this.PbExit.Click += new System.EventHandler(this.PbExit_Click);
            // 
            // checkBoxSpeed
            // 
            this.checkBoxSpeed.AutoSize = true;
            this.checkBoxSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSpeed.Location = new System.Drawing.Point(699, 30);
            this.checkBoxSpeed.Name = "checkBoxSpeed";
            this.checkBoxSpeed.Size = new System.Drawing.Size(62, 17);
            this.checkBoxSpeed.TabIndex = 15;
            this.checkBoxSpeed.Text = "Speed";
            this.checkBoxSpeed.UseVisualStyleBackColor = true;
            // 
            // checkBoxPosition
            // 
            this.checkBoxPosition.AutoSize = true;
            this.checkBoxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPosition.Location = new System.Drawing.Point(769, 30);
            this.checkBoxPosition.Name = "checkBoxPosition";
            this.checkBoxPosition.Size = new System.Drawing.Size(71, 17);
            this.checkBoxPosition.TabIndex = 16;
            this.checkBoxPosition.Text = "Position";
            this.checkBoxPosition.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(611, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Select Mode:";
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Kp :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(139, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Ki :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Kd :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxPosition);
            this.Controls.Add(this.checkBoxSpeed);
            this.Controls.Add(this.PbExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button PbConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbSecCom;
        private System.Windows.Forms.Label LbStatus;
        private System.IO.Ports.SerialPort Com;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button PbSend;
        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button PbMode;
        private System.Windows.Forms.Button PbExit;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox checkBoxSpeed;
        private System.Windows.Forms.CheckBox checkBoxPosition;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtKd;
        private System.Windows.Forms.TextBox txtKi;
        private System.Windows.Forms.TextBox txtKp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

