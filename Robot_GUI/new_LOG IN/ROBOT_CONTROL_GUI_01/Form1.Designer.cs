namespace ROBOT_CONTROL_GUI_01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Grap_btn = new System.Windows.Forms.Button();
            this.Grip_value = new System.Windows.Forms.TextBox();
            this.resetGrip = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.m1G = new System.Windows.Forms.Button();
            this.p1G = new System.Windows.Forms.Button();
            this.m10G = new System.Windows.Forms.Button();
            this.p10G = new System.Windows.Forms.Button();
            this.gripper_slider = new System.Windows.Forms.TrackBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rst4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Speed_Slider = new System.Windows.Forms.TrackBar();
            this.speed_value = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCon = new System.Windows.Forms.Button();
            this.cmbBaurate = new System.Windows.Forms.ComboBox();
            this.cmbCOMPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.reData = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.sendDataStr = new System.Windows.Forms.TextBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.p = new System.Windows.Forms.TextBox();
            this.pz = new System.Windows.Forms.Button();
            this.value_z = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RUNN_btn = new System.Windows.Forms.Button();
            this.px = new System.Windows.Forms.Button();
            this.value_y = new System.Windows.Forms.TextBox();
            this.value_x = new System.Windows.Forms.TextBox();
            this.py = new System.Windows.Forms.Button();
            this.my = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.mx = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.home_btn = new System.Windows.Forms.Button();
            this.z_pos = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rst2 = new System.Windows.Forms.Button();
            this.rst3 = new System.Windows.Forms.Button();
            this.rst1 = new System.Windows.Forms.Button();
            this.resetF = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.send_btn = new System.Windows.Forms.Button();
            this.m1_3 = new System.Windows.Forms.Button();
            this.m10_3 = new System.Windows.Forms.Button();
            this.p1_3 = new System.Windows.Forms.Button();
            this.p10_3 = new System.Windows.Forms.Button();
            this.j3slider = new System.Windows.Forms.TrackBar();
            this.m1_2 = new System.Windows.Forms.Button();
            this.m10_2 = new System.Windows.Forms.Button();
            this.p1_2 = new System.Windows.Forms.Button();
            this.p10_2 = new System.Windows.Forms.Button();
            this.j2slider = new System.Windows.Forms.TrackBar();
            this.m1_1 = new System.Windows.Forms.Button();
            this.m10_1 = new System.Windows.Forms.Button();
            this.p1_1 = new System.Windows.Forms.Button();
            this.p10_1 = new System.Windows.Forms.Button();
            this.j1slider = new System.Windows.Forms.TrackBar();
            this.sad = new System.Windows.Forms.Label();
            this.the3 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.the2 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.the1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.REC_data2 = new System.Windows.Forms.Label();
            this.REC_data1 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.runprogress_btn = new System.Windows.Forms.Button();
            this.rec_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.vcount = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.gcount = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.totalcount = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gripper_slider)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_Slider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tab3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.j3slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.j2slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.j1slider)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM14";
            this.serialPort1.ReadBufferSize = 2096;
            this.serialPort1.WriteBufferSize = 1096;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.Grap_btn);
            this.groupBox5.Controls.Add(this.Grip_value);
            this.groupBox5.Controls.Add(this.resetGrip);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.m1G);
            this.groupBox5.Controls.Add(this.p1G);
            this.groupBox5.Controls.Add(this.m10G);
            this.groupBox5.Controls.Add(this.p10G);
            this.groupBox5.Controls.Add(this.gripper_slider);
            this.groupBox5.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(820, 349);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(262, 127);
            this.groupBox5.TabIndex = 74;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.AliceBlue;
            this.label27.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.DeepPink;
            this.label27.Location = new System.Drawing.Point(99, 77);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(19, 12);
            this.label27.TabIndex = 125;
            this.label27.Text = "95°";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.AliceBlue;
            this.label21.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.DeepPink;
            this.label21.Location = new System.Drawing.Point(15, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 12);
            this.label21.TabIndex = 125;
            this.label21.Text = "30°";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.AliceBlue;
            this.label20.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.DeepPink;
            this.label20.Location = new System.Drawing.Point(178, 77);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(24, 12);
            this.label20.TabIndex = 116;
            this.label20.Text = "200°";
            // 
            // Grap_btn
            // 
            this.Grap_btn.BackColor = System.Drawing.Color.DeepPink;
            this.Grap_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Grap_btn.FlatAppearance.BorderSize = 0;
            this.Grap_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grap_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grap_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Grap_btn.Location = new System.Drawing.Point(207, 93);
            this.Grap_btn.Name = "Grap_btn";
            this.Grap_btn.Size = new System.Drawing.Size(43, 23);
            this.Grap_btn.TabIndex = 118;
            this.Grap_btn.Text = "Grip";
            this.Grap_btn.UseVisualStyleBackColor = false;
            this.Grap_btn.Click += new System.EventHandler(this.Grap_btn_Click);
            // 
            // Grip_value
            // 
            this.Grip_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Grip_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grip_value.Location = new System.Drawing.Point(153, 20);
            this.Grip_value.Name = "Grip_value";
            this.Grip_value.Size = new System.Drawing.Size(47, 20);
            this.Grip_value.TabIndex = 117;
            this.Grip_value.Text = "0";
            this.Grip_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resetGrip
            // 
            this.resetGrip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resetGrip.BackColor = System.Drawing.SystemColors.Window;
            this.resetGrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("resetGrip.BackgroundImage")));
            this.resetGrip.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetGrip.Location = new System.Drawing.Point(205, 44);
            this.resetGrip.Margin = new System.Windows.Forms.Padding(2);
            this.resetGrip.Name = "resetGrip";
            this.resetGrip.Size = new System.Drawing.Size(45, 45);
            this.resetGrip.TabIndex = 115;
            this.resetGrip.UseVisualStyleBackColor = false;
            this.resetGrip.Click += new System.EventHandler(this.resetGrip_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(11, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 16);
            this.label18.TabIndex = 114;
            this.label18.Text = "Gripper(°):";
            // 
            // m1G
            // 
            this.m1G.AccessibleName = "";
            this.m1G.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1G.Location = new System.Drawing.Point(62, 93);
            this.m1G.Name = "m1G";
            this.m1G.Size = new System.Drawing.Size(43, 23);
            this.m1G.TabIndex = 68;
            this.m1G.Text = "-1°";
            this.m1G.UseVisualStyleBackColor = true;
            this.m1G.Click += new System.EventHandler(this.m1G_Click);
            // 
            // p1G
            // 
            this.p1G.AccessibleName = "";
            this.p1G.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1G.Location = new System.Drawing.Point(110, 93);
            this.p1G.Name = "p1G";
            this.p1G.Size = new System.Drawing.Size(43, 23);
            this.p1G.TabIndex = 66;
            this.p1G.Text = "+1°";
            this.p1G.UseVisualStyleBackColor = true;
            this.p1G.Click += new System.EventHandler(this.p1G_Click);
            // 
            // m10G
            // 
            this.m10G.AccessibleName = "";
            this.m10G.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m10G.Location = new System.Drawing.Point(14, 93);
            this.m10G.Name = "m10G";
            this.m10G.Size = new System.Drawing.Size(43, 23);
            this.m10G.TabIndex = 67;
            this.m10G.Text = "-10°";
            this.m10G.UseVisualStyleBackColor = true;
            this.m10G.Click += new System.EventHandler(this.m10G_Click);
            // 
            // p10G
            // 
            this.p10G.AccessibleName = "p10G";
            this.p10G.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p10G.Location = new System.Drawing.Point(158, 93);
            this.p10G.Name = "p10G";
            this.p10G.Size = new System.Drawing.Size(43, 23);
            this.p10G.TabIndex = 65;
            this.p10G.Text = "+10°";
            this.p10G.UseVisualStyleBackColor = true;
            this.p10G.Click += new System.EventHandler(this.p10G_Click);
            // 
            // gripper_slider
            // 
            this.gripper_slider.BackColor = System.Drawing.Color.AliceBlue;
            this.gripper_slider.Location = new System.Drawing.Point(11, 44);
            this.gripper_slider.Maximum = 200;
            this.gripper_slider.Minimum = 30;
            this.gripper_slider.Name = "gripper_slider";
            this.gripper_slider.Size = new System.Drawing.Size(189, 45);
            this.gripper_slider.TabIndex = 62;
            this.gripper_slider.TickFrequency = 4;
            this.gripper_slider.Value = 30;
            this.gripper_slider.Scroll += new System.EventHandler(this.gripper_slider_Scroll);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox6.Controls.Add(this.rst4);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label26);
            this.groupBox6.Controls.Add(this.label25);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.Speed_Slider);
            this.groupBox6.Controls.Add(this.speed_value);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(823, 211);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(262, 105);
            this.groupBox6.TabIndex = 116;
            this.groupBox6.TabStop = false;
            // 
            // rst4
            // 
            this.rst4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rst4.BackColor = System.Drawing.SystemColors.Window;
            this.rst4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rst4.BackgroundImage")));
            this.rst4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rst4.Location = new System.Drawing.Point(206, 42);
            this.rst4.Margin = new System.Windows.Forms.Padding(2);
            this.rst4.Name = "rst4";
            this.rst4.Size = new System.Drawing.Size(45, 45);
            this.rst4.TabIndex = 112;
            this.rst4.UseVisualStyleBackColor = false;
            this.rst4.Click += new System.EventHandler(this.rst4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 69;
            this.label7.Text = "Speed(rpm):";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.AliceBlue;
            this.label26.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.DeepPink;
            this.label26.Location = new System.Drawing.Point(99, 75);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(20, 12);
            this.label26.TabIndex = 125;
            this.label26.Text = "550";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.AliceBlue;
            this.label25.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.DeepPink;
            this.label25.Location = new System.Drawing.Point(178, 75);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(25, 12);
            this.label25.TabIndex = 125;
            this.label25.Text = "1000";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.AliceBlue;
            this.label22.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.DeepPink;
            this.label22.Location = new System.Drawing.Point(19, 75);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 12);
            this.label22.TabIndex = 125;
            this.label22.Text = "100";
            // 
            // Speed_Slider
            // 
            this.Speed_Slider.BackColor = System.Drawing.Color.AliceBlue;
            this.Speed_Slider.Location = new System.Drawing.Point(13, 42);
            this.Speed_Slider.Maximum = 1000;
            this.Speed_Slider.Minimum = 100;
            this.Speed_Slider.Name = "Speed_Slider";
            this.Speed_Slider.Size = new System.Drawing.Size(188, 45);
            this.Speed_Slider.TabIndex = 71;
            this.Speed_Slider.TickFrequency = 30;
            this.Speed_Slider.Value = 100;
            this.Speed_Slider.Scroll += new System.EventHandler(this.Speed_Slider_Scroll);
            this.Speed_Slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Speed_Slider_MouseUp);
            // 
            // speed_value
            // 
            this.speed_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.speed_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_value.Location = new System.Drawing.Point(154, 17);
            this.speed_value.Name = "speed_value";
            this.speed_value.Size = new System.Drawing.Size(47, 20);
            this.speed_value.TabIndex = 12;
            this.speed_value.Text = "0";
            this.speed_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnCon);
            this.groupBox1.Controls.Add(this.cmbBaurate);
            this.groupBox1.Controls.Add(this.cmbCOMPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection:";
            // 
            // button2
            // 
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(311, 36);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 50);
            this.button2.TabIndex = 109;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // btnCon
            // 
            this.btnCon.BackColor = System.Drawing.Color.Red;
            this.btnCon.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCon.ForeColor = System.Drawing.Color.White;
            this.btnCon.Location = new System.Drawing.Point(186, 37);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(116, 49);
            this.btnCon.TabIndex = 1;
            this.btnCon.Text = "DISCONNECTED";
            this.btnCon.UseVisualStyleBackColor = false;
            this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
            // 
            // cmbBaurate
            // 
            this.cmbBaurate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbBaurate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBaurate.FormattingEnabled = true;
            this.cmbBaurate.Items.AddRange(new object[] {
            "115200",
            "1000000",
            "500000",
            "9600",
            "5700"});
            this.cmbBaurate.Location = new System.Drawing.Point(96, 65);
            this.cmbBaurate.Name = "cmbBaurate";
            this.cmbBaurate.Size = new System.Drawing.Size(68, 21);
            this.cmbBaurate.TabIndex = 1;
            this.cmbBaurate.Text = "115200";
            // 
            // cmbCOMPort
            // 
            this.cmbCOMPort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbCOMPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCOMPort.FormattingEnabled = true;
            this.cmbCOMPort.Location = new System.Drawing.Point(96, 35);
            this.cmbCOMPort.Name = "cmbCOMPort";
            this.cmbCOMPort.Size = new System.Drawing.Size(69, 21);
            this.cmbCOMPort.TabIndex = 1;
            this.cmbCOMPort.Text = "COM1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baurate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Com Port:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(820, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 22);
            this.dateTimePicker1.TabIndex = 132;
            // 
            // reData
            // 
            this.reData.BackColor = System.Drawing.SystemColors.MenuText;
            this.reData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reData.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reData.Location = new System.Drawing.Point(404, 58);
            this.reData.Multiline = true;
            this.reData.Name = "reData";
            this.reData.Size = new System.Drawing.Size(678, 33);
            this.reData.TabIndex = 134;
            this.reData.Text = "No data!!! Please check the connetion!\r\nMay be you\'re staying at Auto mode";
            this.reData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(760, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(322, 33);
            this.textBox1.TabIndex = 135;
            this.textBox1.Text = "Robot graphical user interface";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox5.Location = new System.Drawing.Point(404, 42);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(678, 33);
            this.textBox5.TabIndex = 135;
            // 
            // sendDataStr
            // 
            this.sendDataStr.AccessibleName = "sendDataStr";
            this.sendDataStr.BackColor = System.Drawing.SystemColors.MenuText;
            this.sendDataStr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sendDataStr.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendDataStr.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sendDataStr.Location = new System.Drawing.Point(404, 86);
            this.sendDataStr.Multiline = true;
            this.sendDataStr.Name = "sendDataStr";
            this.sendDataStr.Size = new System.Drawing.Size(678, 29);
            this.sendDataStr.TabIndex = 136;
            this.sendDataStr.Text = "No data!!! Please check the connetion!";
            this.sendDataStr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.panel1);
            this.tab3.Location = new System.Drawing.Point(4, 24);
            this.tab3.Name = "tab3";
            this.tab3.Padding = new System.Windows.Forms.Padding(3);
            this.tab3.Size = new System.Drawing.Size(787, 420);
            this.tab3.TabIndex = 3;
            this.tab3.Text = "About";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(-2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 409);
            this.panel1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(112, 34);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(605, 336);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // tab1
            // 
            this.tab1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tab1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tab1.Controls.Add(this.groupBox3);
            this.tab1.Controls.Add(this.groupBox7);
            this.tab1.Controls.Add(this.groupBox4);
            this.tab1.Controls.Add(this.groupBox2);
            this.tab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.tab1.Location = new System.Drawing.Point(4, 24);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(787, 420);
            this.tab1.TabIndex = 1;
            this.tab1.Text = "Manual mode";
            this.tab1.Click += new System.EventHandler(this.tab1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.p);
            this.groupBox3.Controls.Add(this.pz);
            this.groupBox3.Controls.Add(this.value_z);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.mz);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.RUNN_btn);
            this.groupBox3.Controls.Add(this.px);
            this.groupBox3.Controls.Add(this.value_y);
            this.groupBox3.Controls.Add(this.value_x);
            this.groupBox3.Controls.Add(this.py);
            this.groupBox3.Controls.Add(this.my);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.mx);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(402, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(370, 235);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inverse kinematics:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 107;
            this.label4.Text = "Pre:";
            // 
            // p
            // 
            this.p.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p.Location = new System.Drawing.Point(298, 137);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(49, 20);
            this.p.TabIndex = 106;
            this.p.Text = "0";
            this.p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.p.TextChanged += new System.EventHandler(this.p_TextChanged);
            // 
            // pz
            // 
            this.pz.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pz.ForeColor = System.Drawing.SystemColors.Highlight;
            this.pz.Location = new System.Drawing.Point(88, 98);
            this.pz.Margin = new System.Windows.Forms.Padding(2);
            this.pz.Name = "pz";
            this.pz.Size = new System.Drawing.Size(63, 24);
            this.pz.TabIndex = 19;
            this.pz.Text = "Z+";
            this.pz.UseVisualStyleBackColor = false;
            this.pz.Click += new System.EventHandler(this.pz_Click);
            this.pz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pz_MouseDown);
            this.pz.MouseLeave += new System.EventHandler(this.pz_MouseLeave);
            this.pz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pz_MouseMove);
            this.pz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pz_MouseUp);
            // 
            // value_z
            // 
            this.value_z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_z.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_z.Location = new System.Drawing.Point(298, 107);
            this.value_z.Name = "value_z";
            this.value_z.Size = new System.Drawing.Size(49, 20);
            this.value_z.TabIndex = 5;
            this.value_z.Text = "0";
            this.value_z.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(243, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Z(mm):";
            // 
            // mz
            // 
            this.mz.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mz.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mz.Location = new System.Drawing.Point(88, 126);
            this.mz.Margin = new System.Windows.Forms.Padding(2);
            this.mz.Name = "mz";
            this.mz.Size = new System.Drawing.Size(63, 24);
            this.mz.TabIndex = 18;
            this.mz.Text = "Z-";
            this.mz.UseVisualStyleBackColor = false;
            this.mz.Click += new System.EventHandler(this.mz_Click);
            this.mz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mz_MouseDown);
            this.mz.MouseLeave += new System.EventHandler(this.mz_MouseLeave);
            this.mz.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mz_MouseMove);
            this.mz.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mz_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(243, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "X(mm):";
            // 
            // RUNN_btn
            // 
            this.RUNN_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.RUNN_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RUNN_btn.ForeColor = System.Drawing.Color.LavenderBlush;
            this.RUNN_btn.Location = new System.Drawing.Point(246, 170);
            this.RUNN_btn.Margin = new System.Windows.Forms.Padding(2);
            this.RUNN_btn.Name = "RUNN_btn";
            this.RUNN_btn.Size = new System.Drawing.Size(102, 39);
            this.RUNN_btn.TabIndex = 7;
            this.RUNN_btn.Text = "RUN";
            this.RUNN_btn.UseVisualStyleBackColor = false;
            this.RUNN_btn.Click += new System.EventHandler(this.Compute_btn_Click);
            this.RUNN_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RUNN_btn_MouseDown);
            this.RUNN_btn.MouseLeave += new System.EventHandler(this.RUNN_btn_MouseLeave);
            this.RUNN_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RUNN_btn_MouseMove);
            this.RUNN_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RUNN_btn_MouseUp);
            // 
            // px
            // 
            this.px.BackColor = System.Drawing.Color.WhiteSmoke;
            this.px.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.px.ForeColor = System.Drawing.SystemColors.Highlight;
            this.px.Location = new System.Drawing.Point(158, 98);
            this.px.Margin = new System.Windows.Forms.Padding(2);
            this.px.Name = "px";
            this.px.Size = new System.Drawing.Size(63, 53);
            this.px.TabIndex = 17;
            this.px.Text = "X+";
            this.px.UseVisualStyleBackColor = false;
            this.px.Click += new System.EventHandler(this.px_Click);
            this.px.MouseDown += new System.Windows.Forms.MouseEventHandler(this.px_MouseDown);
            this.px.MouseLeave += new System.EventHandler(this.px_MouseLeave);
            this.px.MouseMove += new System.Windows.Forms.MouseEventHandler(this.px_MouseMove);
            this.px.MouseUp += new System.Windows.Forms.MouseEventHandler(this.px_MouseUp);
            // 
            // value_y
            // 
            this.value_y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_y.Location = new System.Drawing.Point(298, 72);
            this.value_y.Name = "value_y";
            this.value_y.Size = new System.Drawing.Size(49, 20);
            this.value_y.TabIndex = 4;
            this.value_y.Text = "0";
            this.value_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // value_x
            // 
            this.value_x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.value_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_x.Location = new System.Drawing.Point(298, 38);
            this.value_x.Name = "value_x";
            this.value_x.Size = new System.Drawing.Size(49, 20);
            this.value_x.TabIndex = 3;
            this.value_x.Text = "0";
            this.value_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // py
            // 
            this.py.BackColor = System.Drawing.Color.WhiteSmoke;
            this.py.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.py.ForeColor = System.Drawing.SystemColors.Highlight;
            this.py.Location = new System.Drawing.Point(88, 38);
            this.py.Margin = new System.Windows.Forms.Padding(2);
            this.py.Name = "py";
            this.py.Size = new System.Drawing.Size(63, 52);
            this.py.TabIndex = 16;
            this.py.Text = "Y+";
            this.py.UseVisualStyleBackColor = false;
            this.py.Click += new System.EventHandler(this.py_Click);
            this.py.MouseDown += new System.Windows.Forms.MouseEventHandler(this.py_MouseDown);
            this.py.MouseLeave += new System.EventHandler(this.py_MouseLeave);
            this.py.MouseMove += new System.Windows.Forms.MouseEventHandler(this.py_MouseMove);
            this.py.MouseUp += new System.Windows.Forms.MouseEventHandler(this.py_MouseUp);
            // 
            // my
            // 
            this.my.BackColor = System.Drawing.Color.WhiteSmoke;
            this.my.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.my.ForeColor = System.Drawing.SystemColors.Highlight;
            this.my.Location = new System.Drawing.Point(88, 157);
            this.my.Margin = new System.Windows.Forms.Padding(2);
            this.my.Name = "my";
            this.my.Size = new System.Drawing.Size(63, 53);
            this.my.TabIndex = 15;
            this.my.Text = "Y-";
            this.my.UseVisualStyleBackColor = false;
            this.my.Click += new System.EventHandler(this.my_Click);
            this.my.MouseDown += new System.Windows.Forms.MouseEventHandler(this.my_MouseDown);
            this.my.MouseLeave += new System.EventHandler(this.my_MouseLeave);
            this.my.MouseMove += new System.Windows.Forms.MouseEventHandler(this.my_MouseMove);
            this.my.MouseUp += new System.Windows.Forms.MouseEventHandler(this.my_MouseUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DeepPink;
            this.label9.Location = new System.Drawing.Point(242, 72);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Y(mm):";
            // 
            // mx
            // 
            this.mx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mx.ForeColor = System.Drawing.SystemColors.Highlight;
            this.mx.Location = new System.Drawing.Point(18, 98);
            this.mx.Margin = new System.Windows.Forms.Padding(2);
            this.mx.Name = "mx";
            this.mx.Size = new System.Drawing.Size(63, 53);
            this.mx.TabIndex = 14;
            this.mx.Text = "X-";
            this.mx.UseVisualStyleBackColor = false;
            this.mx.Click += new System.EventHandler(this.mx_Click);
            this.mx.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mx_MouseDown);
            this.mx.MouseLeave += new System.EventHandler(this.mx_MouseLeave);
            this.mx.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mx_MouseMove);
            this.mx.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mx_MouseUp);
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox7.Controls.Add(this.home_btn);
            this.groupBox7.Controls.Add(this.z_pos);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(682, 254);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox7.Size = new System.Drawing.Size(90, 148);
            this.groupBox7.TabIndex = 114;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Fn:";
            // 
            // home_btn
            // 
            this.home_btn.BackColor = System.Drawing.Color.DeepPink;
            this.home_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.home_btn.Location = new System.Drawing.Point(18, 35);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(54, 41);
            this.home_btn.TabIndex = 68;
            this.home_btn.Text = "Auto \r\nhome";
            this.home_btn.UseVisualStyleBackColor = false;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // z_pos
            // 
            this.z_pos.BackColor = System.Drawing.Color.DeepPink;
            this.z_pos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.z_pos.ForeColor = System.Drawing.SystemColors.Window;
            this.z_pos.Location = new System.Drawing.Point(18, 86);
            this.z_pos.Name = "z_pos";
            this.z_pos.Size = new System.Drawing.Size(54, 41);
            this.z_pos.TabIndex = 73;
            this.z_pos.Text = "Set \r\nhome";
            this.z_pos.UseVisualStyleBackColor = false;
            this.z_pos.Click += new System.EventHandler(this.z_pos_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Controls.Add(this.rst2);
            this.groupBox4.Controls.Add(this.rst3);
            this.groupBox4.Controls.Add(this.rst1);
            this.groupBox4.Controls.Add(this.resetF);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.send_btn);
            this.groupBox4.Controls.Add(this.m1_3);
            this.groupBox4.Controls.Add(this.m10_3);
            this.groupBox4.Controls.Add(this.p1_3);
            this.groupBox4.Controls.Add(this.p10_3);
            this.groupBox4.Controls.Add(this.j3slider);
            this.groupBox4.Controls.Add(this.m1_2);
            this.groupBox4.Controls.Add(this.m10_2);
            this.groupBox4.Controls.Add(this.p1_2);
            this.groupBox4.Controls.Add(this.p10_2);
            this.groupBox4.Controls.Add(this.j2slider);
            this.groupBox4.Controls.Add(this.m1_1);
            this.groupBox4.Controls.Add(this.m10_1);
            this.groupBox4.Controls.Add(this.p1_1);
            this.groupBox4.Controls.Add(this.p10_1);
            this.groupBox4.Controls.Add(this.j1slider);
            this.groupBox4.Controls.Add(this.sad);
            this.groupBox4.Controls.Add(this.the3);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.the2);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.the1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(16, 19);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(371, 383);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Forward kinematics:";
            // 
            // rst2
            // 
            this.rst2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rst2.BackColor = System.Drawing.SystemColors.Window;
            this.rst2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rst2.BackgroundImage")));
            this.rst2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rst2.Location = new System.Drawing.Point(309, 129);
            this.rst2.Margin = new System.Windows.Forms.Padding(2);
            this.rst2.Name = "rst2";
            this.rst2.Size = new System.Drawing.Size(45, 45);
            this.rst2.TabIndex = 114;
            this.rst2.UseVisualStyleBackColor = false;
            this.rst2.Click += new System.EventHandler(this.rst2_Click);
            // 
            // rst3
            // 
            this.rst3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rst3.BackColor = System.Drawing.SystemColors.Window;
            this.rst3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rst3.BackgroundImage")));
            this.rst3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rst3.Location = new System.Drawing.Point(309, 218);
            this.rst3.Margin = new System.Windows.Forms.Padding(2);
            this.rst3.Name = "rst3";
            this.rst3.Size = new System.Drawing.Size(45, 45);
            this.rst3.TabIndex = 113;
            this.rst3.UseVisualStyleBackColor = false;
            this.rst3.Click += new System.EventHandler(this.rst3_Click);
            // 
            // rst1
            // 
            this.rst1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rst1.BackColor = System.Drawing.SystemColors.Window;
            this.rst1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rst1.BackgroundImage")));
            this.rst1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rst1.Location = new System.Drawing.Point(309, 43);
            this.rst1.Margin = new System.Windows.Forms.Padding(2);
            this.rst1.Name = "rst1";
            this.rst1.Size = new System.Drawing.Size(45, 45);
            this.rst1.TabIndex = 111;
            this.rst1.UseVisualStyleBackColor = false;
            this.rst1.Click += new System.EventHandler(this.rst1_Click);
            // 
            // resetF
            // 
            this.resetF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetF.Location = new System.Drawing.Point(88, 313);
            this.resetF.Name = "resetF";
            this.resetF.Size = new System.Drawing.Size(99, 39);
            this.resetF.TabIndex = 110;
            this.resetF.Text = "RESET";
            this.resetF.UseVisualStyleBackColor = true;
            this.resetF.Click += new System.EventHandler(this.resetF_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.AliceBlue;
            this.label17.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DeepPink;
            this.label17.Location = new System.Drawing.Point(188, 247);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 12);
            this.label17.TabIndex = 109;
            this.label17.Text = "0°";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.AliceBlue;
            this.label16.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DeepPink;
            this.label16.Location = new System.Drawing.Point(188, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 12);
            this.label16.TabIndex = 108;
            this.label16.Text = "0°";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.AliceBlue;
            this.label15.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DeepPink;
            this.label15.Location = new System.Drawing.Point(188, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 12);
            this.label15.TabIndex = 107;
            this.label15.Text = "0°";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.AliceBlue;
            this.label14.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DeepPink;
            this.label14.Location = new System.Drawing.Point(277, 247);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(19, 12);
            this.label14.TabIndex = 106;
            this.label14.Text = "90°";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.AliceBlue;
            this.label13.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DeepPink;
            this.label13.Location = new System.Drawing.Point(273, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 12);
            this.label13.TabIndex = 105;
            this.label13.Text = "90°";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.AliceBlue;
            this.label12.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DeepPink;
            this.label12.Location = new System.Drawing.Point(274, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 12);
            this.label12.TabIndex = 104;
            this.label12.Text = "180°";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.AliceBlue;
            this.label10.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DeepPink;
            this.label10.Location = new System.Drawing.Point(86, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 12);
            this.label10.TabIndex = 103;
            this.label10.Text = "-90°";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.AliceBlue;
            this.label11.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DeepPink;
            this.label11.Location = new System.Drawing.Point(87, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 12);
            this.label11.TabIndex = 102;
            this.label11.Text = "-90°";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.AliceBlue;
            this.label8.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepPink;
            this.label8.Location = new System.Drawing.Point(90, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 12);
            this.label8.TabIndex = 100;
            this.label8.Text = "-180°";
            // 
            // send_btn
            // 
            this.send_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.send_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_btn.ForeColor = System.Drawing.Color.Transparent;
            this.send_btn.Location = new System.Drawing.Point(199, 313);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(99, 39);
            this.send_btn.TabIndex = 4;
            this.send_btn.Text = "GO!";
            this.send_btn.UseVisualStyleBackColor = false;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            this.send_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.send_btn_MouseDown);
            this.send_btn.MouseLeave += new System.EventHandler(this.send_btn_MouseLeave);
            this.send_btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.send_btn_MouseMove);
            this.send_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.send_btn_MouseUp);
            // 
            // m1_3
            // 
            this.m1_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_3.Location = new System.Drawing.Point(141, 267);
            this.m1_3.Name = "m1_3";
            this.m1_3.Size = new System.Drawing.Size(48, 23);
            this.m1_3.TabIndex = 99;
            this.m1_3.Text = "-1°";
            this.m1_3.UseVisualStyleBackColor = true;
            this.m1_3.Click += new System.EventHandler(this.m1_3_Click);
            this.m1_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m1_3_MouseDown);
            this.m1_3.MouseLeave += new System.EventHandler(this.m1_3_MouseLeave);
            this.m1_3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.m1_3_MouseMove);
            this.m1_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m1_3_MouseUp);
            // 
            // m10_3
            // 
            this.m10_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m10_3.Location = new System.Drawing.Point(87, 267);
            this.m10_3.Name = "m10_3";
            this.m10_3.Size = new System.Drawing.Size(48, 23);
            this.m10_3.TabIndex = 98;
            this.m10_3.Text = "-5°";
            this.m10_3.UseVisualStyleBackColor = true;
            this.m10_3.Click += new System.EventHandler(this.m10_3_Click);
            this.m10_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m10_3_MouseDown);
            this.m10_3.MouseLeave += new System.EventHandler(this.m10_3_MouseLeave);
            this.m10_3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.m10_3_MouseMove);
            this.m10_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m10_3_MouseUp);
            // 
            // p1_3
            // 
            this.p1_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_3.Location = new System.Drawing.Point(195, 267);
            this.p1_3.Name = "p1_3";
            this.p1_3.Size = new System.Drawing.Size(48, 23);
            this.p1_3.TabIndex = 97;
            this.p1_3.Text = "+1°";
            this.p1_3.UseVisualStyleBackColor = true;
            this.p1_3.Click += new System.EventHandler(this.p1_3_Click);
            this.p1_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p1_3_MouseDown);
            this.p1_3.MouseLeave += new System.EventHandler(this.p1_3_MouseLeave);
            this.p1_3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p1_3_MouseMove);
            this.p1_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p1_3_MouseUp);
            // 
            // p10_3
            // 
            this.p10_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p10_3.Location = new System.Drawing.Point(249, 267);
            this.p10_3.Name = "p10_3";
            this.p10_3.Size = new System.Drawing.Size(48, 23);
            this.p10_3.TabIndex = 96;
            this.p10_3.Text = "+5°";
            this.p10_3.UseVisualStyleBackColor = true;
            this.p10_3.Click += new System.EventHandler(this.p10_3_Click);
            this.p10_3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p10_3_MouseDown);
            this.p10_3.MouseLeave += new System.EventHandler(this.p10_3_MouseLeave);
            this.p10_3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p10_3_MouseMove);
            this.p10_3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p10_3_MouseUp);
            // 
            // j3slider
            // 
            this.j3slider.BackColor = System.Drawing.Color.AliceBlue;
            this.j3slider.Location = new System.Drawing.Point(87, 218);
            this.j3slider.Maximum = 90;
            this.j3slider.Minimum = -90;
            this.j3slider.Name = "j3slider";
            this.j3slider.Size = new System.Drawing.Size(210, 45);
            this.j3slider.TabIndex = 90;
            this.j3slider.TickFrequency = 5;
            this.j3slider.Scroll += new System.EventHandler(this.j3slider_Scroll);
            this.j3slider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.j3slider_MouseDown);
            this.j3slider.MouseLeave += new System.EventHandler(this.j3slider_MouseLeave);
            this.j3slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.j3slider_MouseMove);
            this.j3slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.j3slider_MouseUp);
            // 
            // m1_2
            // 
            this.m1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_2.Location = new System.Drawing.Point(141, 178);
            this.m1_2.Name = "m1_2";
            this.m1_2.Size = new System.Drawing.Size(48, 23);
            this.m1_2.TabIndex = 92;
            this.m1_2.Text = "-1°";
            this.m1_2.UseVisualStyleBackColor = true;
            this.m1_2.Click += new System.EventHandler(this.m1_2_Click);
            this.m1_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m1_2_MouseDown);
            this.m1_2.MouseLeave += new System.EventHandler(this.m1_2_MouseLeave);
            this.m1_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.m1_2_MouseMove);
            this.m1_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m1_2_MouseUp);
            // 
            // m10_2
            // 
            this.m10_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m10_2.Location = new System.Drawing.Point(87, 178);
            this.m10_2.Name = "m10_2";
            this.m10_2.Size = new System.Drawing.Size(48, 23);
            this.m10_2.TabIndex = 91;
            this.m10_2.Text = "-5°";
            this.m10_2.UseVisualStyleBackColor = true;
            this.m10_2.Click += new System.EventHandler(this.m10_2_Click);
            this.m10_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m10_2_MouseDown);
            this.m10_2.MouseLeave += new System.EventHandler(this.m10_2_MouseLeave);
            this.m10_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.m10_2_MouseMove);
            this.m10_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m10_2_MouseUp);
            // 
            // p1_2
            // 
            this.p1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_2.Location = new System.Drawing.Point(195, 178);
            this.p1_2.Name = "p1_2";
            this.p1_2.Size = new System.Drawing.Size(48, 23);
            this.p1_2.TabIndex = 90;
            this.p1_2.Text = "+1°";
            this.p1_2.UseVisualStyleBackColor = true;
            this.p1_2.Click += new System.EventHandler(this.p1_2_Click);
            this.p1_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p1_2_MouseDown);
            this.p1_2.MouseLeave += new System.EventHandler(this.p1_2_MouseLeave);
            this.p1_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p1_2_MouseMove);
            this.p1_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p1_2_MouseUp);
            // 
            // p10_2
            // 
            this.p10_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p10_2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.p10_2.Location = new System.Drawing.Point(249, 178);
            this.p10_2.Name = "p10_2";
            this.p10_2.Size = new System.Drawing.Size(48, 23);
            this.p10_2.TabIndex = 89;
            this.p10_2.Text = "+5°";
            this.p10_2.UseVisualStyleBackColor = true;
            this.p10_2.Click += new System.EventHandler(this.p10_2_Click);
            this.p10_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p10_2_MouseDown);
            this.p10_2.MouseLeave += new System.EventHandler(this.p10_2_MouseLeave);
            this.p10_2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p10_2_MouseMove);
            this.p10_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p10_2_MouseUp);
            // 
            // j2slider
            // 
            this.j2slider.BackColor = System.Drawing.Color.AliceBlue;
            this.j2slider.Location = new System.Drawing.Point(87, 129);
            this.j2slider.Maximum = 90;
            this.j2slider.Minimum = -90;
            this.j2slider.Name = "j2slider";
            this.j2slider.Size = new System.Drawing.Size(210, 45);
            this.j2slider.TabIndex = 88;
            this.j2slider.TickFrequency = 4;
            this.j2slider.Scroll += new System.EventHandler(this.j2slider_Scroll);
            this.j2slider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.j2slider_MouseDown);
            this.j2slider.MouseLeave += new System.EventHandler(this.j2slider_MouseLeave);
            this.j2slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.j2slider_MouseMove);
            this.j2slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.j2slider_MouseUp);
            // 
            // m1_1
            // 
            this.m1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m1_1.Location = new System.Drawing.Point(141, 92);
            this.m1_1.Name = "m1_1";
            this.m1_1.Size = new System.Drawing.Size(48, 23);
            this.m1_1.TabIndex = 68;
            this.m1_1.Text = "-1°";
            this.m1_1.UseVisualStyleBackColor = true;
            this.m1_1.Click += new System.EventHandler(this.m1_1_Click);
            this.m1_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m1_1_MouseDown);
            this.m1_1.MouseLeave += new System.EventHandler(this.m1_1_MouseLeave);
            this.m1_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.m1_1_MouseMove);
            this.m1_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m1_1_MouseUp);
            // 
            // m10_1
            // 
            this.m10_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m10_1.Location = new System.Drawing.Point(87, 92);
            this.m10_1.Name = "m10_1";
            this.m10_1.Size = new System.Drawing.Size(48, 23);
            this.m10_1.TabIndex = 67;
            this.m10_1.Text = "-5°";
            this.m10_1.UseVisualStyleBackColor = true;
            this.m10_1.Click += new System.EventHandler(this.m10_1_click);
            this.m10_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.m10_1_MouseDown);
            this.m10_1.MouseLeave += new System.EventHandler(this.m10_1_MouseLeave);
            this.m10_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.m10_1_MouseMove);
            this.m10_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.m10_1_MouseUp);
            // 
            // p1_1
            // 
            this.p1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_1.Location = new System.Drawing.Point(195, 92);
            this.p1_1.Name = "p1_1";
            this.p1_1.Size = new System.Drawing.Size(48, 23);
            this.p1_1.TabIndex = 66;
            this.p1_1.Text = "+1°";
            this.p1_1.UseVisualStyleBackColor = true;
            this.p1_1.Click += new System.EventHandler(this.p1_1_Click);
            this.p1_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p1_1_MouseDown);
            this.p1_1.MouseLeave += new System.EventHandler(this.p1_1_MouseLeave);
            this.p1_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p1_1_MouseMove);
            this.p1_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p1_1_MouseUp);
            // 
            // p10_1
            // 
            this.p10_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p10_1.Location = new System.Drawing.Point(249, 92);
            this.p10_1.Name = "p10_1";
            this.p10_1.Size = new System.Drawing.Size(48, 23);
            this.p10_1.TabIndex = 65;
            this.p10_1.Text = "+5°";
            this.p10_1.UseVisualStyleBackColor = true;
            this.p10_1.Click += new System.EventHandler(this.p10_1_Click);
            this.p10_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p10_1_MouseDown);
            this.p10_1.MouseLeave += new System.EventHandler(this.p10_1_MouseLeave);
            this.p10_1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.p10_1_MouseMove);
            this.p10_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.p10_1_MouseUp);
            // 
            // j1slider
            // 
            this.j1slider.BackColor = System.Drawing.Color.AliceBlue;
            this.j1slider.Location = new System.Drawing.Point(87, 43);
            this.j1slider.Maximum = 180;
            this.j1slider.Minimum = -180;
            this.j1slider.Name = "j1slider";
            this.j1slider.Size = new System.Drawing.Size(210, 45);
            this.j1slider.TabIndex = 62;
            this.j1slider.TickFrequency = 5;
            this.j1slider.Scroll += new System.EventHandler(this.j1slider_Scroll);
            this.j1slider.MouseDown += new System.Windows.Forms.MouseEventHandler(this.j1slider_MouseDown);
            this.j1slider.MouseLeave += new System.EventHandler(this.j1slider_MouseLeave);
            this.j1slider.MouseMove += new System.Windows.Forms.MouseEventHandler(this.j1slider_MouseMove);
            this.j1slider.MouseUp += new System.Windows.Forms.MouseEventHandler(this.j1slider_MouseUp);
            // 
            // sad
            // 
            this.sad.AutoSize = true;
            this.sad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sad.ForeColor = System.Drawing.Color.DeepPink;
            this.sad.Location = new System.Drawing.Point(15, 218);
            this.sad.Name = "sad";
            this.sad.Size = new System.Drawing.Size(67, 16);
            this.sad.TabIndex = 31;
            this.sad.Text = "Joint3(°):";
            // 
            // the3
            // 
            this.the3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.the3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.the3.Location = new System.Drawing.Point(16, 242);
            this.the3.Name = "the3";
            this.the3.Size = new System.Drawing.Size(53, 20);
            this.the3.TabIndex = 3;
            this.the3.Text = "0";
            this.the3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.DeepPink;
            this.label23.Location = new System.Drawing.Point(15, 129);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(67, 16);
            this.label23.TabIndex = 16;
            this.label23.Text = "Joint2(°):";
            // 
            // the2
            // 
            this.the2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.the2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.the2.Location = new System.Drawing.Point(16, 152);
            this.the2.Name = "the2";
            this.the2.Size = new System.Drawing.Size(53, 20);
            this.the2.TabIndex = 2;
            this.the2.Text = "0";
            this.the2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.DeepPink;
            this.label24.Location = new System.Drawing.Point(15, 43);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 16);
            this.label24.TabIndex = 14;
            this.label24.Text = "Joint1(°):";
            // 
            // the1
            // 
            this.the1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.the1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.the1.ForeColor = System.Drawing.Color.Black;
            this.the1.Location = new System.Drawing.Point(16, 66);
            this.the1.Name = "the1";
            this.the1.Size = new System.Drawing.Size(53, 20);
            this.the1.TabIndex = 1;
            this.the1.Text = "0";
            this.the1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.REC_data2);
            this.groupBox2.Controls.Add(this.REC_data1);
            this.groupBox2.Controls.Add(this.clear_btn);
            this.groupBox2.Controls.Add(this.runprogress_btn);
            this.groupBox2.Controls.Add(this.rec_btn);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(402, 254);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(267, 148);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REC and play:";
            // 
            // REC_data2
            // 
            this.REC_data2.AutoSize = true;
            this.REC_data2.BackColor = System.Drawing.Color.AliceBlue;
            this.REC_data2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REC_data2.ForeColor = System.Drawing.Color.DeepPink;
            this.REC_data2.Location = new System.Drawing.Point(16, 106);
            this.REC_data2.Name = "REC_data2";
            this.REC_data2.Size = new System.Drawing.Size(35, 14);
            this.REC_data2.TabIndex = 130;
            this.REC_data2.Text = "None";
            // 
            // REC_data1
            // 
            this.REC_data1.AutoSize = true;
            this.REC_data1.BackColor = System.Drawing.Color.AliceBlue;
            this.REC_data1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.REC_data1.ForeColor = System.Drawing.Color.DeepPink;
            this.REC_data1.Location = new System.Drawing.Point(17, 86);
            this.REC_data1.Name = "REC_data1";
            this.REC_data1.Size = new System.Drawing.Size(154, 14);
            this.REC_data1.TabIndex = 151;
            this.REC_data1.Text = "Last saved position: ";
            // 
            // clear_btn
            // 
            this.clear_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clear_btn.BackgroundImage")));
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(211, 26);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(45, 45);
            this.clear_btn.TabIndex = 114;
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // runprogress_btn
            // 
            this.runprogress_btn.BackColor = System.Drawing.SystemColors.Highlight;
            this.runprogress_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runprogress_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.runprogress_btn.Location = new System.Drawing.Point(110, 29);
            this.runprogress_btn.Name = "runprogress_btn";
            this.runprogress_btn.Size = new System.Drawing.Size(89, 42);
            this.runprogress_btn.TabIndex = 114;
            this.runprogress_btn.Text = "Run program";
            this.runprogress_btn.UseVisualStyleBackColor = false;
            this.runprogress_btn.Click += new System.EventHandler(this.runprogress_btn_Click);
            // 
            // rec_btn
            // 
            this.rec_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rec_btn.Location = new System.Drawing.Point(10, 31);
            this.rec_btn.Name = "rec_btn";
            this.rec_btn.Size = new System.Drawing.Size(88, 40);
            this.rec_btn.TabIndex = 72;
            this.rec_btn.Text = "REC position";
            this.rec_btn.UseVisualStyleBackColor = true;
            this.rec_btn.Click += new System.EventHandler(this.rec_btn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(9, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 53);
            this.button1.TabIndex = 145;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Controls.Add(this.tab3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(14, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 448);
            this.tabControl1.TabIndex = 130;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.button6);
            this.tab2.Controls.Add(this.button5);
            this.tab2.Controls.Add(this.button7);
            this.tab2.Controls.Add(this.button4);
            this.tab2.Controls.Add(this.button3);
            this.tab2.Controls.Add(this.dataGridView1);
            this.tab2.Controls.Add(this.groupBox9);
            this.tab2.Location = new System.Drawing.Point(4, 24);
            this.tab2.Name = "tab2";
            this.tab2.Padding = new System.Windows.Forms.Padding(3);
            this.tab2.Size = new System.Drawing.Size(787, 420);
            this.tab2.TabIndex = 4;
            this.tab2.Text = "Auto mode";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(293, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 49);
            this.button5.TabIndex = 136;
            this.button5.Text = "CONNECT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(293, 365);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 49);
            this.button7.TabIndex = 135;
            this.button7.Text = "STOP";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Yellow;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(519, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 39);
            this.button4.TabIndex = 132;
            this.button4.Text = "HOME 2";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Yellow;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(519, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 39);
            this.button3.TabIndex = 131;
            this.button3.Text = "HOME 1";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stt,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dataGridView1.GridColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.Location = new System.Drawing.Point(309, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(450, 210);
            this.dataGridView1.TabIndex = 130;
            // 
            // Stt
            // 
            this.Stt.HeaderText = "Stt";
            this.Stt.Name = "Stt";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Y";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Z";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Angle";
            this.Column5.Name = "Column5";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Locate";
            this.Column4.Name = "Column4";
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox9.Controls.Add(this.label36);
            this.groupBox9.Controls.Add(this.vcount);
            this.groupBox9.Controls.Add(this.label35);
            this.groupBox9.Controls.Add(this.label34);
            this.groupBox9.Controls.Add(this.gcount);
            this.groupBox9.Controls.Add(this.label33);
            this.groupBox9.Controls.Add(this.totalcount);
            this.groupBox9.Controls.Add(this.label31);
            this.groupBox9.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(35, 51);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox9.Size = new System.Drawing.Size(265, 224);
            this.groupBox9.TabIndex = 129;
            this.groupBox9.TabStop = false;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(70, 28);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(137, 22);
            this.label36.TabIndex = 122;
            this.label36.Text = "Object counter:";
            // 
            // vcount
            // 
            this.vcount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.vcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vcount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.vcount.Location = new System.Drawing.Point(153, 107);
            this.vcount.Name = "vcount";
            this.vcount.Size = new System.Drawing.Size(82, 31);
            this.vcount.TabIndex = 0;
            this.vcount.Text = "0";
            this.vcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(54, 150);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(60, 21);
            this.label35.TabIndex = 121;
            this.label35.Text = "Kho 2:";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(54, 112);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(60, 21);
            this.label34.TabIndex = 120;
            this.label34.Text = "Kho 1:";
            // 
            // gcount
            // 
            this.gcount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.gcount.Location = new System.Drawing.Point(153, 145);
            this.gcount.Name = "gcount";
            this.gcount.Size = new System.Drawing.Size(82, 31);
            this.gcount.TabIndex = 2;
            this.gcount.Text = "0";
            this.gcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(63, 145);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(0, 16);
            this.label33.TabIndex = 119;
            // 
            // totalcount
            // 
            this.totalcount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcount.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.totalcount.Location = new System.Drawing.Point(153, 63);
            this.totalcount.Name = "totalcount";
            this.totalcount.Size = new System.Drawing.Size(82, 31);
            this.totalcount.TabIndex = 116;
            this.totalcount.Text = "0";
            this.totalcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.totalcount.TextChanged += new System.EventHandler(this.totalcount_TextChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(27, 68);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(111, 21);
            this.label31.TabIndex = 117;
            this.label31.Text = "Total objects:";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Yellow;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(519, 332);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 39);
            this.button6.TabIndex = 137;
            this.button6.Text = "HOME";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.send_btn;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1103, 595);
            this.Controls.Add(this.sendDataStr);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.reData);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gripper_slider)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_Slider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.j3slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.j2slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.j1slider)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.ComboBox cmbBaurate;
        private System.Windows.Forms.ComboBox cmbCOMPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button Grap_btn;
        private System.Windows.Forms.TextBox Grip_value;
        private System.Windows.Forms.Button resetGrip;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button m1G;
        private System.Windows.Forms.Button p1G;
        private System.Windows.Forms.Button m10G;
        private System.Windows.Forms.Button p10G;
        private System.Windows.Forms.TrackBar gripper_slider;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button rst4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TrackBar Speed_Slider;
        private System.Windows.Forms.TextBox speed_value;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox reData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox sendDataStr;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.Button pz;
        private System.Windows.Forms.TextBox value_z;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button mz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RUNN_btn;
        private System.Windows.Forms.Button px;
        private System.Windows.Forms.TextBox value_y;
        private System.Windows.Forms.TextBox value_x;
        private System.Windows.Forms.Button py;
        private System.Windows.Forms.Button my;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button mx;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Button z_pos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button rst2;
        private System.Windows.Forms.Button rst3;
        private System.Windows.Forms.Button rst1;
        private System.Windows.Forms.Button resetF;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Button m1_3;
        private System.Windows.Forms.Button m10_3;
        private System.Windows.Forms.Button p1_3;
        private System.Windows.Forms.Button p10_3;
        private System.Windows.Forms.TrackBar j3slider;
        private System.Windows.Forms.Button m1_2;
        private System.Windows.Forms.Button m10_2;
        private System.Windows.Forms.Button p1_2;
        private System.Windows.Forms.Button p10_2;
        private System.Windows.Forms.TrackBar j2slider;
        private System.Windows.Forms.Button m1_1;
        private System.Windows.Forms.Button m10_1;
        private System.Windows.Forms.Button p1_1;
        private System.Windows.Forms.Button p10_1;
        private System.Windows.Forms.TrackBar j1slider;
        private System.Windows.Forms.Label sad;
        private System.Windows.Forms.TextBox the3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox the2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox the1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label REC_data2;
        private System.Windows.Forms.Label REC_data1;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button runprogress_btn;
        private System.Windows.Forms.Button rec_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox vcount;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox gcount;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox totalcount;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

