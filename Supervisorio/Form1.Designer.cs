
namespace Supervisorio
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_msg = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_desconect = new System.Windows.Forms.Button();
            this.bt_conect = new System.Windows.Forms.Button();
            this.cb_parity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_bits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_data = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_bould = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_port1 = new System.Windows.Forms.ComboBox();
            this.lb_port = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_reception = new System.Windows.Forms.TextBox();
            this.bt_clean = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_cr = new System.Windows.Forms.CheckBox();
            this.bt_submit = new System.Windows.Forms.Button();
            this.tb_enviar = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.tcb_pwm = new System.Windows.Forms.TrackBar();
            this.button3 = new System.Windows.Forms.Button();
            this.pn_led3 = new System.Windows.Forms.Panel();
            this.lb_led3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pn_led2 = new System.Windows.Forms.Panel();
            this.lb_ld2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pn_led1 = new System.Windows.Forms.Panel();
            this.lb_led1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_sensor2 = new System.Windows.Forms.Label();
            this.lb_sensor1 = new System.Windows.Forms.Label();
            this.lb_s2 = new System.Windows.Forms.Label();
            this.lb_s1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.g_sensor2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.g_sensor1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.pn_msg.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcb_pwm)).BeginInit();
            this.pn_led3.SuspendLayout();
            this.pn_led2.SuspendLayout();
            this.pn_led1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.g_sensor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_sensor1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pn_msg);
            this.panel1.Controls.Add(this.bt_exit);
            this.panel1.Controls.Add(this.bt_desconect);
            this.panel1.Controls.Add(this.bt_conect);
            this.panel1.Controls.Add(this.cb_parity);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cb_bits);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_data);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cb_bould);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_port1);
            this.panel1.Controls.Add(this.lb_port);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 499);
            this.panel1.TabIndex = 0;
            // 
            // pn_msg
            // 
            this.pn_msg.BackColor = System.Drawing.Color.Brown;
            this.pn_msg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_msg.Controls.Add(this.label5);
            this.pn_msg.Location = new System.Drawing.Point(0, 323);
            this.pn_msg.Name = "pn_msg";
            this.pn_msg.Size = new System.Drawing.Size(266, 176);
            this.pn_msg.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(45, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Open port";
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.Color.Gold;
            this.bt_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.Location = new System.Drawing.Point(3, 273);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(257, 31);
            this.bt_exit.TabIndex = 11;
            this.bt_exit.Text = "exit";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_desconect
            // 
            this.bt_desconect.BackColor = System.Drawing.Color.Red;
            this.bt_desconect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_desconect.Enabled = false;
            this.bt_desconect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_desconect.Location = new System.Drawing.Point(131, 236);
            this.bt_desconect.Name = "bt_desconect";
            this.bt_desconect.Size = new System.Drawing.Size(129, 31);
            this.bt_desconect.TabIndex = 10;
            this.bt_desconect.Text = "Close ";
            this.bt_desconect.UseVisualStyleBackColor = false;
            this.bt_desconect.Click += new System.EventHandler(this.bt_desconect_Click);
            // 
            // bt_conect
            // 
            this.bt_conect.BackColor = System.Drawing.Color.GreenYellow;
            this.bt_conect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_conect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_conect.Location = new System.Drawing.Point(6, 236);
            this.bt_conect.Name = "bt_conect";
            this.bt_conect.Size = new System.Drawing.Size(119, 31);
            this.bt_conect.TabIndex = 1;
            this.bt_conect.Text = "Open";
            this.bt_conect.UseVisualStyleBackColor = false;
            this.bt_conect.Click += new System.EventHandler(this.bt_conect_Click);
            // 
            // cb_parity
            // 
            this.cb_parity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_parity.FormattingEnabled = true;
            this.cb_parity.Location = new System.Drawing.Point(122, 184);
            this.cb_parity.Name = "cb_parity";
            this.cb_parity.Size = new System.Drawing.Size(121, 24);
            this.cb_parity.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(21, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Parity:";
            // 
            // cb_bits
            // 
            this.cb_bits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bits.FormattingEnabled = true;
            this.cb_bits.Location = new System.Drawing.Point(122, 139);
            this.cb_bits.Name = "cb_bits";
            this.cb_bits.Size = new System.Drawing.Size(121, 24);
            this.cb_bits.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(4, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stop Bits:";
            // 
            // cb_data
            // 
            this.cb_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_data.FormattingEnabled = true;
            this.cb_data.Location = new System.Drawing.Point(122, 97);
            this.cb_data.Name = "cb_data";
            this.cb_data.Size = new System.Drawing.Size(121, 24);
            this.cb_data.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(4, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Bits:";
            // 
            // cb_bould
            // 
            this.cb_bould.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bould.FormattingEnabled = true;
            this.cb_bould.Location = new System.Drawing.Point(122, 52);
            this.cb_bould.Name = "cb_bould";
            this.cb_bould.Size = new System.Drawing.Size(121, 24);
            this.cb_bould.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(4, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Baud Rate:";
            // 
            // cb_port1
            // 
            this.cb_port1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_port1.FormattingEnabled = true;
            this.cb_port1.Location = new System.Drawing.Point(122, 10);
            this.cb_port1.Name = "cb_port1";
            this.cb_port1.Size = new System.Drawing.Size(121, 24);
            this.cb_port1.TabIndex = 1;
            this.cb_port1.Click += new System.EventHandler(this.cb_port1_Click);
            // 
            // lb_port
            // 
            this.lb_port.AutoSize = true;
            this.lb_port.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_port.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_port.Location = new System.Drawing.Point(4, 15);
            this.lb_port.Name = "lb_port";
            this.lb_port.Size = new System.Drawing.Size(72, 16);
            this.lb_port.TabIndex = 1;
            this.lb_port.Text = "COM Port:";
            this.lb_port.Click += new System.EventHandler(this.lb_port_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(284, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(557, 499);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(549, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor Serial";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.tb_reception);
            this.groupBox2.Controls.Add(this.bt_clean);
            this.groupBox2.Location = new System.Drawing.Point(9, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 350);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reception";
            // 
            // tb_reception
            // 
            this.tb_reception.BackColor = System.Drawing.Color.Gainsboro;
            this.tb_reception.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_reception.Location = new System.Drawing.Point(0, 45);
            this.tb_reception.Multiline = true;
            this.tb_reception.Name = "tb_reception";
            this.tb_reception.Size = new System.Drawing.Size(537, 305);
            this.tb_reception.TabIndex = 4;
            // 
            // bt_clean
            // 
            this.bt_clean.BackColor = System.Drawing.Color.Firebrick;
            this.bt_clean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_clean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_clean.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bt_clean.Location = new System.Drawing.Point(436, 13);
            this.bt_clean.Name = "bt_clean";
            this.bt_clean.Size = new System.Drawing.Size(92, 26);
            this.bt_clean.TabIndex = 3;
            this.bt_clean.Text = " Clean";
            this.bt_clean.UseVisualStyleBackColor = false;
            this.bt_clean.Click += new System.EventHandler(this.bt_clean_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.cb_cr);
            this.groupBox1.Controls.Add(this.bt_submit);
            this.groupBox1.Controls.Add(this.tb_enviar);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transmissão";
            // 
            // cb_cr
            // 
            this.cb_cr.AutoSize = true;
            this.cb_cr.Location = new System.Drawing.Point(6, 66);
            this.cb_cr.Name = "cb_cr";
            this.cb_cr.Size = new System.Drawing.Size(51, 24);
            this.cb_cr.TabIndex = 2;
            this.cb_cr.Text = "CR";
            this.cb_cr.UseVisualStyleBackColor = true;
            // 
            // bt_submit
            // 
            this.bt_submit.BackColor = System.Drawing.Color.SpringGreen;
            this.bt_submit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_submit.Location = new System.Drawing.Point(288, 23);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(92, 26);
            this.bt_submit.TabIndex = 1;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = false;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // tb_enviar
            // 
            this.tb_enviar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tb_enviar.Location = new System.Drawing.Point(6, 23);
            this.tb_enviar.Name = "tb_enviar";
            this.tb_enviar.Size = new System.Drawing.Size(276, 26);
            this.tb_enviar.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tcb_pwm);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.pn_led3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.pn_led2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.pn_led1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(549, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "botões/leds";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(197, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "PWM Control";
            // 
            // tcb_pwm
            // 
            this.tcb_pwm.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tcb_pwm.Location = new System.Drawing.Point(83, 347);
            this.tcb_pwm.Maximum = 5;
            this.tcb_pwm.Name = "tcb_pwm";
            this.tcb_pwm.Size = new System.Drawing.Size(349, 45);
            this.tcb_pwm.TabIndex = 12;
            this.tcb_pwm.Scroll += new System.EventHandler(this.tcb_pwm_Scroll);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LawnGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(373, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 44);
            this.button3.TabIndex = 5;
            this.button3.Text = "ON/OFF";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button4_Click);
            // 
            // pn_led3
            // 
            this.pn_led3.BackColor = System.Drawing.Color.Brown;
            this.pn_led3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_led3.Controls.Add(this.lb_led3);
            this.pn_led3.Location = new System.Drawing.Point(373, 113);
            this.pn_led3.Name = "pn_led3";
            this.pn_led3.Size = new System.Drawing.Size(92, 58);
            this.pn_led3.TabIndex = 4;
            // 
            // lb_led3
            // 
            this.lb_led3.AutoSize = true;
            this.lb_led3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_led3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_led3.Location = new System.Drawing.Point(20, 19);
            this.lb_led3.Name = "lb_led3";
            this.lb_led3.Size = new System.Drawing.Size(51, 16);
            this.lb_led3.TabIndex = 0;
            this.lb_led3.Text = "Load 3";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LawnGreen;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(201, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "ON/OFF";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pn_led2
            // 
            this.pn_led2.BackColor = System.Drawing.Color.Brown;
            this.pn_led2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_led2.Controls.Add(this.lb_ld2);
            this.pn_led2.Location = new System.Drawing.Point(201, 115);
            this.pn_led2.Name = "pn_led2";
            this.pn_led2.Size = new System.Drawing.Size(92, 58);
            this.pn_led2.TabIndex = 2;
            // 
            // lb_ld2
            // 
            this.lb_ld2.AutoSize = true;
            this.lb_ld2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ld2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_ld2.Location = new System.Drawing.Point(16, 18);
            this.lb_ld2.Name = "lb_ld2";
            this.lb_ld2.Size = new System.Drawing.Size(51, 16);
            this.lb_ld2.TabIndex = 4;
            this.lb_ld2.Text = "Load 2";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LawnGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(37, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "ON/OFF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pn_led1
            // 
            this.pn_led1.BackColor = System.Drawing.Color.Brown;
            this.pn_led1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_led1.Controls.Add(this.lb_led1);
            this.pn_led1.Location = new System.Drawing.Point(37, 111);
            this.pn_led1.Name = "pn_led1";
            this.pn_led1.Size = new System.Drawing.Size(92, 58);
            this.pn_led1.TabIndex = 0;
            // 
            // lb_led1
            // 
            this.lb_led1.AutoSize = true;
            this.lb_led1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_led1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_led1.Location = new System.Drawing.Point(20, 19);
            this.lb_led1.Name = "lb_led1";
            this.lb_led1.Size = new System.Drawing.Size(51, 16);
            this.lb_led1.TabIndex = 0;
            this.lb_led1.Text = "Load 1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(549, 473);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sensores";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InfoText;
            this.groupBox3.Controls.Add(this.lb_sensor2);
            this.groupBox3.Controls.Add(this.lb_sensor1);
            this.groupBox3.Controls.Add(this.lb_s2);
            this.groupBox3.Controls.Add(this.lb_s1);
            this.groupBox3.Location = new System.Drawing.Point(6, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 397);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // lb_sensor2
            // 
            this.lb_sensor2.AutoSize = true;
            this.lb_sensor2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sensor2.ForeColor = System.Drawing.Color.Lime;
            this.lb_sensor2.Location = new System.Drawing.Point(182, 308);
            this.lb_sensor2.Name = "lb_sensor2";
            this.lb_sensor2.Size = new System.Drawing.Size(75, 32);
            this.lb_sensor2.TabIndex = 3;
            this.lb_sensor2.Text = "0000";
            // 
            // lb_sensor1
            // 
            this.lb_sensor1.AutoSize = true;
            this.lb_sensor1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sensor1.ForeColor = System.Drawing.Color.Lime;
            this.lb_sensor1.Location = new System.Drawing.Point(182, 107);
            this.lb_sensor1.Name = "lb_sensor1";
            this.lb_sensor1.Size = new System.Drawing.Size(75, 32);
            this.lb_sensor1.TabIndex = 2;
            this.lb_sensor1.Text = "0000";
            // 
            // lb_s2
            // 
            this.lb_s2.AutoSize = true;
            this.lb_s2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_s2.ForeColor = System.Drawing.Color.Lime;
            this.lb_s2.Location = new System.Drawing.Point(175, 211);
            this.lb_s2.Name = "lb_s2";
            this.lb_s2.Size = new System.Drawing.Size(121, 29);
            this.lb_s2.TabIndex = 1;
            this.lb_s2.Text = "Sensor 2:";
            // 
            // lb_s1
            // 
            this.lb_s1.AutoSize = true;
            this.lb_s1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_s1.ForeColor = System.Drawing.Color.Lime;
            this.lb_s1.Location = new System.Drawing.Point(175, 29);
            this.lb_s1.Name = "lb_s1";
            this.lb_s1.Size = new System.Drawing.Size(121, 29);
            this.lb_s1.TabIndex = 0;
            this.lb_s1.Text = "Sensor 1:";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DimGray;
            this.tabPage4.Controls.Add(this.g_sensor2);
            this.tabPage4.Controls.Add(this.g_sensor1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(549, 473);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Gráficos";
            // 
            // g_sensor2
            // 
            this.g_sensor2.BackColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Lime;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Yellow;
            chartArea1.AxisY.MajorTickMark.LineWidth = 2;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.MinorGrid.LineWidth = 2;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisY.ScrollBar.BackColor = System.Drawing.Color.Lime;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.Lime;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea1.AxisY2.ScaleBreakStyle.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.g_sensor2.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.DimGray;
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Sensor 2";
            legend1.TitleForeColor = System.Drawing.Color.White;
            this.g_sensor2.Legends.Add(legend1);
            this.g_sensor2.Location = new System.Drawing.Point(3, 251);
            this.g_sensor2.Name = "g_sensor2";
            this.g_sensor2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Sensor 2";
            series1.MarkerColor = System.Drawing.Color.Yellow;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Sensor 2";
            series1.YValuesPerPoint = 6;
            this.g_sensor2.Series.Add(series1);
            this.g_sensor2.Size = new System.Drawing.Size(540, 216);
            this.g_sensor2.TabIndex = 1;
            this.g_sensor2.Text = "chart2";
            title1.BackColor = System.Drawing.Color.DimGray;
            title1.ForeColor = System.Drawing.Color.Lime;
            title1.Name = "sensor2";
            title1.Text = "Monitoramento ";
            this.g_sensor2.Titles.Add(title1);
            // 
            // g_sensor1
            // 
            this.g_sensor1.BackColor = System.Drawing.Color.DimGray;
            this.g_sensor1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.g_sensor1.BorderlineColor = System.Drawing.Color.Lime;
            chartArea2.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.None;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Lime;
            chartArea2.AxisX.LineColor = System.Drawing.Color.Lime;
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gold;
            chartArea2.AxisX.MajorTickMark.LineWidth = 2;
            chartArea2.AxisX.MajorTickMark.Size = 2F;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Lime;
            chartArea2.AxisX.Title = "s";
            chartArea2.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Lime;
            chartArea2.AxisY.LineColor = System.Drawing.Color.Lime;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Yellow;
            chartArea2.AxisY.MajorTickMark.LineWidth = 2;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Lime;
            chartArea2.AxisY.MinorGrid.LineWidth = 2;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Lime;
            chartArea2.AxisY.ScrollBar.BackColor = System.Drawing.Color.Lime;
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.BackImageTransparentColor = System.Drawing.Color.Lime;
            chartArea2.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipX;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Lime;
            chartArea2.BorderColor = System.Drawing.Color.Lime;
            chartArea2.BorderWidth = 2;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Silver;
            this.g_sensor1.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.DimGray;
            legend2.ForeColor = System.Drawing.Color.White;
            legend2.Name = "Temperatura";
            legend2.TitleForeColor = System.Drawing.Color.WhiteSmoke;
            legend2.TitleSeparatorColor = System.Drawing.Color.DimGray;
            this.g_sensor1.Legends.Add(legend2);
            this.g_sensor1.Location = new System.Drawing.Point(3, 17);
            this.g_sensor1.Name = "g_sensor1";
            this.g_sensor1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Lime};
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.LabelBorderColor = System.Drawing.Color.White;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Temperatura";
            series2.MarkerBorderColor = System.Drawing.Color.Black;
            series2.MarkerColor = System.Drawing.Color.White;
            series2.MarkerImageTransparentColor = System.Drawing.Color.Transparent;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Sensor1";
            series2.SmartLabelStyle.CalloutBackColor = System.Drawing.Color.Lime;
            series2.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Round;
            series2.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.Lime;
            series2.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.None;
            this.g_sensor1.Series.Add(series2);
            this.g_sensor1.Size = new System.Drawing.Size(540, 228);
            this.g_sensor1.TabIndex = 0;
            this.g_sensor1.Text = "chart1";
            title2.BackColor = System.Drawing.Color.DimGray;
            title2.ForeColor = System.Drawing.Color.Lime;
            title2.Name = "Title1";
            title2.Text = "Monitoramento ";
            this.g_sensor1.Titles.Add(title2);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(853, 523);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Serial Supervisory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_msg.ResumeLayout(false);
            this.pn_msg.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tcb_pwm)).EndInit();
            this.pn_led3.ResumeLayout(false);
            this.pn_led3.PerformLayout();
            this.pn_led2.ResumeLayout(false);
            this.pn_led2.PerformLayout();
            this.pn_led1.ResumeLayout(false);
            this.pn_led1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.g_sensor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g_sensor1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_desconect;
        private System.Windows.Forms.Button bt_conect;
        private System.Windows.Forms.ComboBox cb_parity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_bits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_bould;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_port1;
        private System.Windows.Forms.Label lb_port;
        private System.Windows.Forms.Panel pn_msg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.TextBox tb_enviar;
        private System.Windows.Forms.CheckBox cb_cr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_clean;
        private System.Windows.Forms.TextBox tb_reception;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pn_led2;
        private System.Windows.Forms.Label lb_ld2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pn_led1;
        private System.Windows.Forms.Label lb_led1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pn_led3;
        private System.Windows.Forms.Label lb_led3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_s2;
        private System.Windows.Forms.Label lb_s1;
        private System.Windows.Forms.Label lb_sensor2;
        private System.Windows.Forms.Label lb_sensor1;
        private System.Windows.Forms.TrackBar tcb_pwm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart g_sensor2;
        private System.Windows.Forms.DataVisualization.Charting.Chart g_sensor1;
        private System.Windows.Forms.Timer timer1;
    }
}

