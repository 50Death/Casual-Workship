namespace OnlineClassCheats
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_ResolutionSelector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_ExplorerSelector = new System.Windows.Forms.ComboBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Adv = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mouseX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mouseY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_color = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_saveX1 = new System.Windows.Forms.TextBox();
            this.tb_saveY1 = new System.Windows.Forms.TextBox();
            this.tb_saveColor1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_saveX2 = new System.Windows.Forms.TextBox();
            this.tb_saveY2 = new System.Windows.Forms.TextBox();
            this.tb_saveColor2 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tb_saveX3 = new System.Windows.Forms.TextBox();
            this.tb_saveY3 = new System.Windows.Forms.TextBox();
            this.tb_saveColor3 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.tb_saveX4 = new System.Windows.Forms.TextBox();
            this.tb_saveY4 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.tb_saveColor4 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label31 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "----------------------- 菜 单 -----------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "显示模式";
            // 
            // cb_ResolutionSelector
            // 
            this.cb_ResolutionSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ResolutionSelector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_ResolutionSelector.FormattingEnabled = true;
            this.cb_ResolutionSelector.Items.AddRange(new object[] {
            "1920×1080(undo)",
            "2560×1080"});
            this.cb_ResolutionSelector.Location = new System.Drawing.Point(113, 91);
            this.cb_ResolutionSelector.Name = "cb_ResolutionSelector";
            this.cb_ResolutionSelector.Size = new System.Drawing.Size(121, 20);
            this.cb_ResolutionSelector.TabIndex = 2;
            this.cb_ResolutionSelector.SelectedIndexChanged += new System.EventHandler(this.cb_ResolutionSelector_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "浏览器";
            // 
            // cb_ExplorerSelector
            // 
            this.cb_ExplorerSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ExplorerSelector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_ExplorerSelector.FormattingEnabled = true;
            this.cb_ExplorerSelector.Items.AddRange(new object[] {
            "请先选择显示模式"});
            this.cb_ExplorerSelector.Location = new System.Drawing.Point(113, 179);
            this.cb_ExplorerSelector.Name = "cb_ExplorerSelector";
            this.cb_ExplorerSelector.Size = new System.Drawing.Size(121, 20);
            this.cb_ExplorerSelector.TabIndex = 4;
            this.cb_ExplorerSelector.SelectedIndexChanged += new System.EventHandler(this.cb_ExplorerSelector_SelectedIndexChanged);
            // 
            // btn_Start
            // 
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Start.Location = new System.Drawing.Point(57, 343);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(220, 48);
            this.btn_Start.TabIndex = 5;
            this.btn_Start.Text = "开始";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "360,460";
            // 
            // btn_Adv
            // 
            this.btn_Adv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Adv.Location = new System.Drawing.Point(289, 399);
            this.btn_Adv.Name = "btn_Adv";
            this.btn_Adv.Size = new System.Drawing.Size(55, 22);
            this.btn_Adv.TabIndex = 7;
            this.btn_Adv.Text = "高级>>";
            this.btn_Adv.UseVisualStyleBackColor = true;
            this.btn_Adv.Click += new System.EventHandler(this.btn_Adv_Click);
            // 
            // btn_About
            // 
            this.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_About.Location = new System.Drawing.Point(1, 399);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(53, 22);
            this.btn_About.TabIndex = 8;
            this.btn_About.Text = "关于";
            this.btn_About.UseVisualStyleBackColor = true;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 396);
            this.label5.TabIndex = 9;
            this.label5.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n" +
    "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "当前鼠标X坐标";
            // 
            // mouseX
            // 
            this.mouseX.Location = new System.Drawing.Point(457, 9);
            this.mouseX.Name = "mouseX";
            this.mouseX.Size = new System.Drawing.Size(40, 21);
            this.mouseX.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "当前鼠标Y坐标";
            // 
            // mouseY
            // 
            this.mouseY.Location = new System.Drawing.Point(637, 9);
            this.mouseY.Name = "mouseY";
            this.mouseY.Size = new System.Drawing.Size(40, 21);
            this.mouseY.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "指针对应颜色";
            // 
            // tb_color
            // 
            this.tb_color.Location = new System.Drawing.Point(451, 40);
            this.tb_color.Name = "tb_color";
            this.tb_color.Size = new System.Drawing.Size(230, 21);
            this.tb_color.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(367, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(317, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "----------------------------------------------------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(370, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "保存值1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(424, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "X：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(561, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 12);
            this.label12.TabIndex = 19;
            this.label12.Text = "Y：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(404, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 20;
            this.label13.Text = "颜色：";
            // 
            // tb_saveX1
            // 
            this.tb_saveX1.Location = new System.Drawing.Point(451, 80);
            this.tb_saveX1.Name = "tb_saveX1";
            this.tb_saveX1.Size = new System.Drawing.Size(55, 21);
            this.tb_saveX1.TabIndex = 21;
            // 
            // tb_saveY1
            // 
            this.tb_saveY1.Location = new System.Drawing.Point(590, 80);
            this.tb_saveY1.Name = "tb_saveY1";
            this.tb_saveY1.Size = new System.Drawing.Size(55, 21);
            this.tb_saveY1.TabIndex = 22;
            // 
            // tb_saveColor1
            // 
            this.tb_saveColor1.Location = new System.Drawing.Point(452, 108);
            this.tb_saveColor1.Name = "tb_saveColor1";
            this.tb_saveColor1.Size = new System.Drawing.Size(210, 21);
            this.tb_saveColor1.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(367, 132);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(317, 12);
            this.label14.TabIndex = 24;
            this.label14.Text = "----------------------------------------------------";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(368, 148);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 25;
            this.label15.Text = "保存值2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(422, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 12);
            this.label16.TabIndex = 26;
            this.label16.Text = "X：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(561, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 12);
            this.label17.TabIndex = 27;
            this.label17.Text = "Y：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(404, 174);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 28;
            this.label18.Text = "颜色：";
            // 
            // tb_saveX2
            // 
            this.tb_saveX2.Location = new System.Drawing.Point(451, 144);
            this.tb_saveX2.Name = "tb_saveX2";
            this.tb_saveX2.Size = new System.Drawing.Size(55, 21);
            this.tb_saveX2.TabIndex = 29;
            // 
            // tb_saveY2
            // 
            this.tb_saveY2.Location = new System.Drawing.Point(590, 144);
            this.tb_saveY2.Name = "tb_saveY2";
            this.tb_saveY2.Size = new System.Drawing.Size(55, 21);
            this.tb_saveY2.TabIndex = 30;
            // 
            // tb_saveColor2
            // 
            this.tb_saveColor2.Location = new System.Drawing.Point(451, 171);
            this.tb_saveColor2.Name = "tb_saveColor2";
            this.tb_saveColor2.Size = new System.Drawing.Size(230, 21);
            this.tb_saveColor2.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(367, 195);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(317, 12);
            this.label19.TabIndex = 32;
            this.label19.Text = "----------------------------------------------------";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(368, 211);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 12);
            this.label20.TabIndex = 33;
            this.label20.Text = "保存值3：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(422, 211);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 12);
            this.label21.TabIndex = 34;
            this.label21.Text = "X：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(561, 211);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(23, 12);
            this.label22.TabIndex = 35;
            this.label22.Text = "Y：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(404, 238);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 12);
            this.label23.TabIndex = 36;
            this.label23.Text = "颜色：";
            // 
            // tb_saveX3
            // 
            this.tb_saveX3.Location = new System.Drawing.Point(451, 208);
            this.tb_saveX3.Name = "tb_saveX3";
            this.tb_saveX3.Size = new System.Drawing.Size(55, 21);
            this.tb_saveX3.TabIndex = 37;
            // 
            // tb_saveY3
            // 
            this.tb_saveY3.Location = new System.Drawing.Point(590, 208);
            this.tb_saveY3.Name = "tb_saveY3";
            this.tb_saveY3.Size = new System.Drawing.Size(55, 21);
            this.tb_saveY3.TabIndex = 38;
            // 
            // tb_saveColor3
            // 
            this.tb_saveColor3.Location = new System.Drawing.Point(451, 235);
            this.tb_saveColor3.Name = "tb_saveColor3";
            this.tb_saveColor3.Size = new System.Drawing.Size(230, 21);
            this.tb_saveColor3.TabIndex = 39;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(367, 259);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(317, 12);
            this.label24.TabIndex = 40;
            this.label24.Text = "----------------------------------------------------";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(368, 275);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 12);
            this.label25.TabIndex = 41;
            this.label25.Text = "保存值4：";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(422, 275);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(23, 12);
            this.label26.TabIndex = 42;
            this.label26.Text = "X：";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(561, 275);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(23, 12);
            this.label27.TabIndex = 43;
            this.label27.Text = "Y：";
            // 
            // tb_saveX4
            // 
            this.tb_saveX4.Location = new System.Drawing.Point(451, 272);
            this.tb_saveX4.Name = "tb_saveX4";
            this.tb_saveX4.Size = new System.Drawing.Size(55, 21);
            this.tb_saveX4.TabIndex = 44;
            // 
            // tb_saveY4
            // 
            this.tb_saveY4.Location = new System.Drawing.Point(590, 272);
            this.tb_saveY4.Name = "tb_saveY4";
            this.tb_saveY4.Size = new System.Drawing.Size(55, 21);
            this.tb_saveY4.TabIndex = 45;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(406, 302);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(41, 12);
            this.label28.TabIndex = 46;
            this.label28.Text = "颜色：";
            // 
            // tb_saveColor4
            // 
            this.tb_saveColor4.Location = new System.Drawing.Point(451, 299);
            this.tb_saveColor4.Name = "tb_saveColor4";
            this.tb_saveColor4.Size = new System.Drawing.Size(230, 21);
            this.tb_saveColor4.TabIndex = 47;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(607, 400);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 12);
            this.label29.TabIndex = 48;
            this.label29.Text = "Version: 1.0";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(370, 399);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(143, 12);
            this.label30.TabIndex = 49;
            this.label30.Text = "Powered by: xX50DeathXx";
            // 
            // btn_Save
            // 
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Save.Location = new System.Drawing.Point(457, 343);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(155, 41);
            this.btn_Save.TabIndex = 50;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(160, 235);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 12);
            this.label31.TabIndex = 51;
            this.label31.Text = "保存";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 256);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 52;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(344, 421);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.tb_saveColor4);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.tb_saveY4);
            this.Controls.Add(this.tb_saveX4);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.tb_saveColor3);
            this.Controls.Add(this.tb_saveY3);
            this.Controls.Add(this.tb_saveX3);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tb_saveColor2);
            this.Controls.Add(this.tb_saveY2);
            this.Controls.Add(this.tb_saveX2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb_saveColor1);
            this.Controls.Add(this.tb_saveY1);
            this.Controls.Add(this.tb_saveX1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_color);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mouseY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mouseX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.btn_Adv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.cb_ExplorerSelector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_ResolutionSelector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "网课助手（V1.0）";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_ResolutionSelector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_ExplorerSelector;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Adv;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox mouseX;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox mouseY;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tb_color;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox tb_saveX1;
        public System.Windows.Forms.TextBox tb_saveY1;
        public System.Windows.Forms.TextBox tb_saveColor1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox tb_saveX2;
        public System.Windows.Forms.TextBox tb_saveY2;
        public System.Windows.Forms.TextBox tb_saveColor2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        public System.Windows.Forms.TextBox tb_saveX3;
        public System.Windows.Forms.TextBox tb_saveY3;
        public System.Windows.Forms.TextBox tb_saveColor3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        public System.Windows.Forms.TextBox tb_saveX4;
        public System.Windows.Forms.TextBox tb_saveY4;
        public System.Windows.Forms.Label label28;
        public System.Windows.Forms.TextBox tb_saveColor4;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

