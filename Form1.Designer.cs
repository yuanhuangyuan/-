
namespace NL_4_Debugger_Test
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.butCANConnect = new System.Windows.Forms.Button();
            this.timerCANRec = new System.Windows.Forms.Timer(this.components);
            this.timerFrame_0x2a5 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label48 = new System.Windows.Forms.Label();
            this.textBox93 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textBox57 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox67 = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.label78 = new System.Windows.Forms.Label();
            this.textBox71 = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.接收显示 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxCanChannel = new System.Windows.Forms.ComboBox();
            this.labelCanChannel = new System.Windows.Forms.Label();
            this.labelCanAdapter = new System.Windows.Forms.Label();
            this.comboBoxCanAdapter = new System.Windows.Forms.ComboBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.textBox92 = new System.Windows.Forms.TextBox();
            this.groupBox4.SuspendLayout();
            this.接收显示.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butCANConnect
            // 
            this.butCANConnect.BackColor = System.Drawing.SystemColors.ControlLight;
            this.butCANConnect.Location = new System.Drawing.Point(129, 39);
            this.butCANConnect.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.butCANConnect.Name = "butCANConnect";
            this.butCANConnect.Size = new System.Drawing.Size(119, 35);
            this.butCANConnect.TabIndex = 4;
            this.butCANConnect.Text = "连接";
            this.butCANConnect.UseVisualStyleBackColor = false;
            this.butCANConnect.Click += new System.EventHandler(this.butCANConnect_Click);
            // 
            // timerCANRec
            // 
            this.timerCANRec.Interval = 5;
            this.timerCANRec.Tick += new System.EventHandler(this.timerCANRec_Tick);
            // 
            // timerFrame_0x2a5
            // 
            this.timerFrame_0x2a5.Interval = 300;
            this.timerFrame_0x2a5.Tick += new System.EventHandler(this.timerFrame_0x2a5_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.groupBox4.Controls.Add(this.textBox92);
            this.groupBox4.Controls.Add(this.label48);
            this.groupBox4.Controls.Add(this.textBox93);
            this.groupBox4.Controls.Add(this.label54);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.textBox28);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.panel7);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.comboBox6);
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBox21);
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.textBox19);
            this.groupBox4.Controls.Add(this.label70);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.textBox57);
            this.groupBox4.Controls.Add(this.textBox18);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.groupBox4.Location = new System.Drawing.Point(325, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox4.Size = new System.Drawing.Size(398, 1354);
            this.groupBox4.TabIndex = 87;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "  标定参数 / CALIBRATION  ";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label48.Location = new System.Drawing.Point(48, 691);
            this.label48.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(79, 15);
            this.label48.TabIndex = 509;
            this.label48.Text = "ExvOnMin";
            // 
            // textBox93
            // 
            this.textBox93.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox93.Location = new System.Drawing.Point(138, 616);
            this.textBox93.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox93.Name = "textBox93";
            this.textBox93.ReadOnly = true;
            this.textBox93.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox93.Size = new System.Drawing.Size(108, 30);
            this.textBox93.TabIndex = 508;
            this.textBox93.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label54.Location = new System.Drawing.Point(48, 626);
            this.label54.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(79, 15);
            this.label54.TabIndex = 507;
            this.label54.Text = "ExvOnMax";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(265, 160);
            this.button4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 35);
            this.button4.TabIndex = 434;
            this.button4.Text = "恢复全部参数";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox28
            // 
            this.textBox28.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox28.Location = new System.Drawing.Point(139, 251);
            this.textBox28.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox28.Name = "textBox28";
            this.textBox28.ReadOnly = true;
            this.textBox28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox28.Size = new System.Drawing.Size(108, 30);
            this.textBox28.TabIndex = 429;
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(20, 264);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 15);
            this.label14.TabIndex = 428;
            this.label14.Text = "ExvForceCtrl";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(138, 160);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 35);
            this.button3.TabIndex = 359;
            this.button3.Text = "读全部参数";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(265, 114);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 35);
            this.button2.TabIndex = 358;
            this.button2.Text = "读取参数";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel7
            // 
            this.panel7.AutoSize = true;
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel7.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel7.Location = new System.Drawing.Point(425, 21);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel7.Name = "panel7";
            this.panel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel7.Size = new System.Drawing.Size(0, 0);
            this.panel7.TabIndex = 346;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(138, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 235;
            this.button1.Text = "设置参数";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6.Location = new System.Drawing.Point(136, 28);
            this.textBox6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox6.MaxLength = 52767;
            this.textBox6.Name = "textBox6";
            this.textBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox6.Size = new System.Drawing.Size(235, 30);
            this.textBox6.TabIndex = 500;
            this.textBox6.Text = "0";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(35, 38);
            this.label27.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(71, 15);
            this.label27.TabIndex = 341;
            this.label27.Text = "参数设置";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(39, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 340;
            this.label8.Text = "地址选择";
            // 
            // comboBox6
            // 
            this.comboBox6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(138, 76);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(235, 25);
            this.comboBox6.TabIndex = 338;
            this.comboBox6.Text = "CompInitTim";
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel3.Location = new System.Drawing.Point(9, 22);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel3.Size = new System.Drawing.Size(0, 0);
            this.panel3.TabIndex = 208;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(208, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 83;
            this.label6.Text = "0x18FF7320";
            // 
            // textBox21
            // 
            this.textBox21.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox21.Location = new System.Drawing.Point(139, 470);
            this.textBox21.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox21.Size = new System.Drawing.Size(108, 30);
            this.textBox21.TabIndex = 352;
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label31.Location = new System.Drawing.Point(48, 477);
            this.label31.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(88, 15);
            this.label31.TabIndex = 351;
            this.label31.Text = "ExvChgTim";
            // 
            // textBox19
            // 
            this.textBox19.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox19.Location = new System.Drawing.Point(139, 397);
            this.textBox19.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox19.Size = new System.Drawing.Size(108, 30);
            this.textBox19.TabIndex = 348;
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label70.Location = new System.Drawing.Point(50, 550);
            this.label70.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(79, 15);
            this.label70.TabIndex = 359;
            this.label70.Text = "PtTarTsh";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label29.Location = new System.Drawing.Point(39, 404);
            this.label29.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(97, 15);
            this.label29.TabIndex = 347;
            this.label29.Text = "ExvInitVal";
            // 
            // textBox57
            // 
            this.textBox57.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox57.Location = new System.Drawing.Point(139, 543);
            this.textBox57.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox57.Name = "textBox57";
            this.textBox57.ReadOnly = true;
            this.textBox57.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox57.Size = new System.Drawing.Size(108, 30);
            this.textBox57.TabIndex = 360;
            this.textBox57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox18
            // 
            this.textBox18.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox18.Location = new System.Drawing.Point(139, 324);
            this.textBox18.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox18.Size = new System.Drawing.Size(108, 30);
            this.textBox18.TabIndex = 344;
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(38, 331);
            this.label28.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(97, 15);
            this.label28.TabIndex = 343;
            this.label28.Text = "ExvInitTim";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(1551, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 233;
            // 
            // panel10
            // 
            this.panel10.AutoSize = true;
            this.panel10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel10.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel10.Location = new System.Drawing.Point(175, 575);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel10.Name = "panel10";
            this.panel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel10.Size = new System.Drawing.Size(0, 0);
            this.panel10.TabIndex = 232;
            // 
            // panel9
            // 
            this.panel9.AutoSize = true;
            this.panel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel9.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel9.Location = new System.Drawing.Point(175, 592);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel9.Name = "panel9";
            this.panel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel9.Size = new System.Drawing.Size(0, 0);
            this.panel9.TabIndex = 231;
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel8.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel8.Location = new System.Drawing.Point(948, 678);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel8.Name = "panel8";
            this.panel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel8.Size = new System.Drawing.Size(0, 0);
            this.panel8.TabIndex = 230;
            // 
            // textBox67
            // 
            this.textBox67.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox67.Location = new System.Drawing.Point(161, 39);
            this.textBox67.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox67.Name = "textBox67";
            this.textBox67.ReadOnly = true;
            this.textBox67.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox67.Size = new System.Drawing.Size(108, 30);
            this.textBox67.TabIndex = 82;
            this.textBox67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label76.Location = new System.Drawing.Point(17, 46);
            this.label76.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(134, 15);
            this.label76.TabIndex = 160;
            this.label76.Text = "CHILLER低压压力";
            // 
            // textBox69
            // 
            this.textBox69.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox69.Location = new System.Drawing.Point(161, 101);
            this.textBox69.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox69.Name = "textBox69";
            this.textBox69.ReadOnly = true;
            this.textBox69.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox69.Size = new System.Drawing.Size(108, 30);
            this.textBox69.TabIndex = 194;
            this.textBox69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label78.Location = new System.Drawing.Point(17, 109);
            this.label78.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(134, 15);
            this.label78.TabIndex = 195;
            this.label78.Text = "CHILLER出口温度";
            // 
            // textBox71
            // 
            this.textBox71.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox71.Location = new System.Drawing.Point(161, 226);
            this.textBox71.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox71.Name = "textBox71";
            this.textBox71.ReadOnly = true;
            this.textBox71.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox71.Size = new System.Drawing.Size(108, 30);
            this.textBox71.TabIndex = 196;
            this.textBox71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label80.Location = new System.Drawing.Point(80, 234);
            this.label80.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(71, 15);
            this.label80.TabIndex = 197;
            this.label80.Text = "高压压力";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(215, 423);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 206;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // 接收显示
            // 
            this.接收显示.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.接收显示.Controls.Add(this.textBox3);
            this.接收显示.Controls.Add(this.label2);
            this.接收显示.Controls.Add(this.label4);
            this.接收显示.Controls.Add(this.textBox5);
            this.接收显示.Controls.Add(this.label7);
            this.接收显示.Controls.Add(this.textBox7);
            this.接收显示.Controls.Add(this.textBox9);
            this.接收显示.Controls.Add(this.textBox11);
            this.接收显示.Controls.Add(this.label18);
            this.接收显示.Controls.Add(this.textBox14);
            this.接收显示.Controls.Add(this.label22);
            this.接收显示.Controls.Add(this.label23);
            this.接收显示.Controls.Add(this.textBox16);
            this.接收显示.Controls.Add(this.panel2);
            this.接收显示.Controls.Add(this.textBox67);
            this.接收显示.Controls.Add(this.panel1);
            this.接收显示.Controls.Add(this.panel9);
            this.接收显示.Controls.Add(this.panel10);
            this.接收显示.Controls.Add(this.label80);
            this.接收显示.Controls.Add(this.textBox71);
            this.接收显示.Controls.Add(this.label78);
            this.接收显示.Controls.Add(this.label76);
            this.接收显示.Controls.Add(this.textBox69);
            this.接收显示.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.接收显示.Location = new System.Drawing.Point(16, 244);
            this.接收显示.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.接收显示.Name = "接收显示";
            this.接收显示.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.接收显示.Size = new System.Drawing.Size(300, 912);
            this.接收显示.TabIndex = 234;
            this.接收显示.TabStop = false;
            this.接收显示.Text = "EXV";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(161, 351);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox3.Size = new System.Drawing.Size(108, 30);
            this.textBox3.TabIndex = 235;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(53, 356);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 240;
            this.label2.Text = "EXV目标开度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(21, 483);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 15);
            this.label4.TabIndex = 265;
            this.label4.Text = "EXV当前运行状态";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox5.Location = new System.Drawing.Point(161, 164);
            this.textBox5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox5.Size = new System.Drawing.Size(108, 30);
            this.textBox5.TabIndex = 249;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(64, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 250;
            this.label7.Text = "系统过热度";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox7.Location = new System.Drawing.Point(161, 597);
            this.textBox7.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox7.Size = new System.Drawing.Size(108, 30);
            this.textBox7.TabIndex = 247;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox9.Location = new System.Drawing.Point(161, 289);
            this.textBox9.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox9.Size = new System.Drawing.Size(108, 30);
            this.textBox9.TabIndex = 236;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox11.Location = new System.Drawing.Point(161, 476);
            this.textBox11.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox11.Size = new System.Drawing.Size(108, 30);
            this.textBox11.TabIndex = 264;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(5, 425);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(146, 15);
            this.label18.TabIndex = 252;
            this.label18.Text = "EXV当前初始化状态";
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox14.Location = new System.Drawing.Point(161, 414);
            this.textBox14.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox14.Size = new System.Drawing.Size(108, 30);
            this.textBox14.TabIndex = 248;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(80, 545);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(71, 15);
            this.label22.TabIndex = 245;
            this.label22.Text = "生命信号";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(53, 296);
            this.label23.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 15);
            this.label23.TabIndex = 239;
            this.label23.Text = "EXV实际开度";
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox16.Location = new System.Drawing.Point(161, 537);
            this.textBox16.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox16.Size = new System.Drawing.Size(108, 30);
            this.textBox16.TabIndex = 242;
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(36)))), ((int)(((byte)(50)))));
            this.groupBox1.Controls.Add(this.comboBoxCanChannel);
            this.groupBox1.Controls.Add(this.labelCanChannel);
            this.groupBox1.Controls.Add(this.labelCanAdapter);
            this.groupBox1.Controls.Add(this.comboBoxCanAdapter);
            this.groupBox1.Controls.Add(this.panel19);
            this.groupBox1.Controls.Add(this.butCANConnect);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.panel11);
            this.groupBox1.Controls.Add(this.panel12);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(299, 223);
            this.groupBox1.TabIndex = 235;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  控制指令 / CONTROL COMMAND  ";
            // 
            // comboBoxCanChannel
            // 
            this.comboBoxCanChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCanChannel.FormattingEnabled = true;
            this.comboBoxCanChannel.Location = new System.Drawing.Point(129, 126);
            this.comboBoxCanChannel.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCanChannel.Name = "comboBoxCanChannel";
            this.comboBoxCanChannel.Size = new System.Drawing.Size(118, 28);
            this.comboBoxCanChannel.TabIndex = 439;
            // 
            // labelCanChannel
            // 
            this.labelCanChannel.AutoSize = true;
            this.labelCanChannel.ForeColor = System.Drawing.Color.White;
            this.labelCanChannel.Location = new System.Drawing.Point(16, 130);
            this.labelCanChannel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCanChannel.Name = "labelCanChannel";
            this.labelCanChannel.Size = new System.Drawing.Size(84, 20);
            this.labelCanChannel.TabIndex = 440;
            this.labelCanChannel.Text = "图莫斯通道";
            // 
            // labelCanAdapter
            // 
            this.labelCanAdapter.AutoSize = true;
            this.labelCanAdapter.ForeColor = System.Drawing.Color.White;
            this.labelCanAdapter.Location = new System.Drawing.Point(31, 88);
            this.labelCanAdapter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCanAdapter.Name = "labelCanAdapter";
            this.labelCanAdapter.Size = new System.Drawing.Size(72, 20);
            this.labelCanAdapter.TabIndex = 438;
            this.labelCanAdapter.Text = "CAN设备";
            // 
            // comboBoxCanAdapter
            // 
            this.comboBoxCanAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCanAdapter.FormattingEnabled = true;
            this.comboBoxCanAdapter.Location = new System.Drawing.Point(129, 82);
            this.comboBoxCanAdapter.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCanAdapter.Name = "comboBoxCanAdapter";
            this.comboBoxCanAdapter.Size = new System.Drawing.Size(118, 28);
            this.comboBoxCanAdapter.TabIndex = 437;
            this.comboBoxCanAdapter.SelectedIndexChanged += new System.EventHandler(this.comboBoxCanAdapter_SelectedIndexChanged);
            // 
            // panel19
            // 
            this.panel19.AutoSize = true;
            this.panel19.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel19.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel19.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel19.Location = new System.Drawing.Point(869, 21);
            this.panel19.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel19.Name = "panel19";
            this.panel19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel19.Size = new System.Drawing.Size(0, 0);
            this.panel19.TabIndex = 426;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Location = new System.Drawing.Point(129, 170);
            this.button5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 35);
            this.button5.TabIndex = 425;
            this.button5.Text = "发送信号";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel11
            // 
            this.panel11.AutoSize = true;
            this.panel11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel11.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel11.Location = new System.Drawing.Point(596, 21);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel11.Name = "panel11";
            this.panel11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel11.Size = new System.Drawing.Size(0, 0);
            this.panel11.TabIndex = 346;
            // 
            // panel12
            // 
            this.panel12.AutoSize = true;
            this.panel12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel12.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel12.Location = new System.Drawing.Point(9, 22);
            this.panel12.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel12.Name = "panel12";
            this.panel12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel12.Size = new System.Drawing.Size(0, 0);
            this.panel12.TabIndex = 208;
            // 
            // textBox92
            // 
            this.textBox92.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox92.Location = new System.Drawing.Point(138, 689);
            this.textBox92.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox92.Name = "textBox92";
            this.textBox92.ReadOnly = true;
            this.textBox92.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox92.Size = new System.Drawing.Size(108, 30);
            this.textBox92.TabIndex = 510;
            this.textBox92.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(754, 893);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.接收显示);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel8);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "冰箱上位机";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.接收显示.ResumeLayout(false);
            this.接收显示.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butCANConnect;
        private System.Windows.Forms.Timer timerCANRec;
        private System.Windows.Forms.Timer timerFrame_0x2a5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox67;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.TextBox textBox69;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.TextBox textBox71;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox 接收显示;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox57;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCanAdapter;
        private System.Windows.Forms.ComboBox comboBoxCanAdapter;
        private System.Windows.Forms.Label labelCanChannel;
        private System.Windows.Forms.ComboBox comboBoxCanChannel;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox textBox93;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.TextBox textBox92;
    }
}

