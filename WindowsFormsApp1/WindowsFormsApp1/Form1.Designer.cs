
namespace WindowsFormsApp1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_comPort = new System.Windows.Forms.ComboBox();
            this.comboBox_baudRate = new System.Windows.Forms.ComboBox();
            this.label_status = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar_statusBar = new System.Windows.Forms.ProgressBar();
            this.button_open = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.textBox_textSend = new System.Windows.Forms.MaskedTextBox();
            this.richTextBox_textReceiver = new System.Windows.Forms.RichTextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_state = new System.Windows.Forms.TextBox();
            this.textBox_vt = new System.Windows.Forms.TextBox();
            this.textBox_v15 = new System.Windows.Forms.TextBox();
            this.textBox_weight = new System.Windows.Forms.TextBox();
            this.textBox_sumVt = new System.Windows.Forms.TextBox();
            this.textBox_sumV15 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_productNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_flowRate = new System.Windows.Forms.TextBox();
            this.textBox_avgTemp1 = new System.Windows.Forms.TextBox();
            this.textBox_avgDensityX = new System.Windows.Forms.TextBox();
            this.textBox_batchQuantity = new System.Windows.Forms.TextBox();
            this.textBox_sumWght = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_additivType = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_addVt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_sumAddVt = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_targetAddRate = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label_dateTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(624, 450);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_close);
            this.groupBox1.Controls.Add(this.button_open);
            this.groupBox1.Controls.Add(this.progressBar_statusBar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_status);
            this.groupBox1.Controls.Add(this.comboBox_baudRate);
            this.groupBox1.Controls.Add(this.comboBox_comPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 171);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM PORT SETTINGS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM PORT:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "BAUD RATE:";
            // 
            // comboBox_comPort
            // 
            this.comboBox_comPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_comPort.FormattingEnabled = true;
            this.comboBox_comPort.Location = new System.Drawing.Point(98, 26);
            this.comboBox_comPort.Name = "comboBox_comPort";
            this.comboBox_comPort.Size = new System.Drawing.Size(103, 21);
            this.comboBox_comPort.TabIndex = 2;
            // 
            // comboBox_baudRate
            // 
            this.comboBox_baudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_baudRate.FormattingEnabled = true;
            this.comboBox_baudRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox_baudRate.Location = new System.Drawing.Point(98, 54);
            this.comboBox_baudRate.Name = "comboBox_baudRate";
            this.comboBox_baudRate.Size = new System.Drawing.Size(103, 21);
            this.comboBox_baudRate.TabIndex = 3;
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(109, 115);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(92, 13);
            this.label_status.TabIndex = 4;
            this.label_status.Text = "DISCONNECTED";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "STATUS:";
            // 
            // progressBar_statusBar
            // 
            this.progressBar_statusBar.Location = new System.Drawing.Point(98, 82);
            this.progressBar_statusBar.Name = "progressBar_statusBar";
            this.progressBar_statusBar.Size = new System.Drawing.Size(103, 23);
            this.progressBar_statusBar.TabIndex = 6;
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(23, 140);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 25);
            this.button_open.TabIndex = 2;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(104, 140);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 25);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // textBox_textSend
            // 
            this.textBox_textSend.Location = new System.Drawing.Point(233, 12);
            this.textBox_textSend.Name = "textBox_textSend";
            this.textBox_textSend.Size = new System.Drawing.Size(293, 20);
            this.textBox_textSend.TabIndex = 2;
            this.textBox_textSend.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // richTextBox_textReceiver
            // 
            this.richTextBox_textReceiver.Location = new System.Drawing.Point(233, 41);
            this.richTextBox_textReceiver.Name = "richTextBox_textReceiver";
            this.richTextBox_textReceiver.Size = new System.Drawing.Size(383, 132);
            this.richTextBox_textReceiver.TabIndex = 3;
            this.richTextBox_textReceiver.Text = "";
            this.richTextBox_textReceiver.TextChanged += new System.EventHandler(this.richTextBox_textReceiver_TextChanged);
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(541, 12);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(75, 23);
            this.button_send.TabIndex = 4;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "State";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_dateTime);
            this.groupBox2.Controls.Add(this.textBox_targetAddRate);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.textBox_sumAddVt);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.textBox_addVt);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.textBox_additivType);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.textBox_productNo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_flowRate);
            this.groupBox2.Controls.Add(this.textBox_avgTemp1);
            this.groupBox2.Controls.Add(this.textBox_avgDensityX);
            this.groupBox2.Controls.Add(this.textBox_batchQuantity);
            this.groupBox2.Controls.Add(this.textBox_sumWght);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBox_sumV15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBox_sumVt);
            this.groupBox2.Controls.Add(this.textBox_weight);
            this.groupBox2.Controls.Add(this.textBox_v15);
            this.groupBox2.Controls.Add(this.textBox_vt);
            this.groupBox2.Controls.Add(this.textBox_state);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(0, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 271);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(80, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "SumVT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(81, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = "Weight";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(103, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "V15";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(111, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "VT";
            // 
            // textBox_state
            // 
            this.textBox_state.Location = new System.Drawing.Point(145, 14);
            this.textBox_state.Name = "textBox_state";
            this.textBox_state.Size = new System.Drawing.Size(120, 20);
            this.textBox_state.TabIndex = 15;
            // 
            // textBox_vt
            // 
            this.textBox_vt.Location = new System.Drawing.Point(145, 42);
            this.textBox_vt.Name = "textBox_vt";
            this.textBox_vt.Size = new System.Drawing.Size(120, 20);
            this.textBox_vt.TabIndex = 16;
            // 
            // textBox_v15
            // 
            this.textBox_v15.Location = new System.Drawing.Point(145, 70);
            this.textBox_v15.Name = "textBox_v15";
            this.textBox_v15.Size = new System.Drawing.Size(120, 20);
            this.textBox_v15.TabIndex = 17;
            // 
            // textBox_weight
            // 
            this.textBox_weight.Location = new System.Drawing.Point(145, 98);
            this.textBox_weight.Name = "textBox_weight";
            this.textBox_weight.Size = new System.Drawing.Size(120, 20);
            this.textBox_weight.TabIndex = 18;
            // 
            // textBox_sumVt
            // 
            this.textBox_sumVt.Location = new System.Drawing.Point(145, 126);
            this.textBox_sumVt.Name = "textBox_sumVt";
            this.textBox_sumVt.Size = new System.Drawing.Size(120, 20);
            this.textBox_sumVt.TabIndex = 19;
            // 
            // textBox_sumV15
            // 
            this.textBox_sumV15.Location = new System.Drawing.Point(145, 155);
            this.textBox_sumV15.Name = "textBox_sumV15";
            this.textBox_sumV15.Size = new System.Drawing.Size(120, 20);
            this.textBox_sumV15.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(72, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "SumV15";
            // 
            // textBox_productNo
            // 
            this.textBox_productNo.Location = new System.Drawing.Point(441, 98);
            this.textBox_productNo.Name = "textBox_productNo";
            this.textBox_productNo.Size = new System.Drawing.Size(120, 20);
            this.textBox_productNo.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "ProductNo";
            // 
            // textBox_flowRate
            // 
            this.textBox_flowRate.Location = new System.Drawing.Point(441, 70);
            this.textBox_flowRate.Name = "textBox_flowRate";
            this.textBox_flowRate.Size = new System.Drawing.Size(120, 20);
            this.textBox_flowRate.TabIndex = 31;
            // 
            // textBox_avgTemp1
            // 
            this.textBox_avgTemp1.Location = new System.Drawing.Point(441, 42);
            this.textBox_avgTemp1.Name = "textBox_avgTemp1";
            this.textBox_avgTemp1.Size = new System.Drawing.Size(120, 20);
            this.textBox_avgTemp1.TabIndex = 30;
            // 
            // textBox_avgDensityX
            // 
            this.textBox_avgDensityX.Location = new System.Drawing.Point(441, 14);
            this.textBox_avgDensityX.Name = "textBox_avgDensityX";
            this.textBox_avgDensityX.Size = new System.Drawing.Size(120, 20);
            this.textBox_avgDensityX.TabIndex = 29;
            // 
            // textBox_batchQuantity
            // 
            this.textBox_batchQuantity.Location = new System.Drawing.Point(145, 211);
            this.textBox_batchQuantity.Name = "textBox_batchQuantity";
            this.textBox_batchQuantity.Size = new System.Drawing.Size(120, 20);
            this.textBox_batchQuantity.TabIndex = 28;
            // 
            // textBox_sumWght
            // 
            this.textBox_sumWght.Location = new System.Drawing.Point(145, 184);
            this.textBox_sumWght.Name = "textBox_sumWght";
            this.textBox_sumWght.Size = new System.Drawing.Size(120, 20);
            this.textBox_sumWght.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "BatchQuantitiy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(338, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "AvgDensityX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(353, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "AvgTemp1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(363, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "FlowRate";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(63, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 17);
            this.label15.TabIndex = 22;
            this.label15.Text = "SumWght";
            // 
            // textBox_additivType
            // 
            this.textBox_additivType.Location = new System.Drawing.Point(441, 126);
            this.textBox_additivType.Name = "textBox_additivType";
            this.textBox_additivType.Size = new System.Drawing.Size(120, 20);
            this.textBox_additivType.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(344, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 17);
            this.label16.TabIndex = 34;
            this.label16.Text = "AdditivType";
            // 
            // textBox_addVt
            // 
            this.textBox_addVt.Location = new System.Drawing.Point(441, 155);
            this.textBox_addVt.Name = "textBox_addVt";
            this.textBox_addVt.Size = new System.Drawing.Size(120, 20);
            this.textBox_addVt.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(381, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 17);
            this.label17.TabIndex = 36;
            this.label17.Text = "AddVT";
            // 
            // textBox_sumAddVt
            // 
            this.textBox_sumAddVt.Location = new System.Drawing.Point(441, 184);
            this.textBox_sumAddVt.Name = "textBox_sumAddVt";
            this.textBox_sumAddVt.Size = new System.Drawing.Size(120, 20);
            this.textBox_sumAddVt.TabIndex = 39;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(350, 186);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 17);
            this.label18.TabIndex = 38;
            this.label18.Text = "SumAddVT";
            // 
            // textBox_targetAddRate
            // 
            this.textBox_targetAddRate.Location = new System.Drawing.Point(441, 211);
            this.textBox_targetAddRate.Name = "textBox_targetAddRate";
            this.textBox_targetAddRate.Size = new System.Drawing.Size(120, 20);
            this.textBox_targetAddRate.TabIndex = 41;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(319, 213);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(118, 17);
            this.label19.TabIndex = 40;
            this.label19.Text = "TargetAddRate";
            // 
            // label_dateTime
            // 
            this.label_dateTime.AutoSize = true;
            this.label_dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dateTime.Location = new System.Drawing.Point(242, 245);
            this.label_dateTime.Name = "label_dateTime";
            this.label_dateTime.Size = new System.Drawing.Size(172, 22);
            this.label_dateTime.TabIndex = 42;
            this.label_dateTime.Text = "14.10.2021  12:04";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.richTextBox_textReceiver);
            this.Controls.Add(this.textBox_textSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "I-GRAPHX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.ComboBox comboBox_baudRate;
        private System.Windows.Forms.ComboBox comboBox_comPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar_statusBar;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.MaskedTextBox textBox_textSend;
        private System.Windows.Forms.RichTextBox richTextBox_textReceiver;
        private System.Windows.Forms.Button button_send;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_sumVt;
        private System.Windows.Forms.TextBox textBox_weight;
        private System.Windows.Forms.TextBox textBox_v15;
        private System.Windows.Forms.TextBox textBox_vt;
        private System.Windows.Forms.TextBox textBox_state;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_sumV15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_targetAddRate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_sumAddVt;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_addVt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_additivType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_productNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_flowRate;
        private System.Windows.Forms.TextBox textBox_avgTemp1;
        private System.Windows.Forms.TextBox textBox_avgDensityX;
        private System.Windows.Forms.TextBox textBox_batchQuantity;
        private System.Windows.Forms.TextBox textBox_sumWght;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_dateTime;
    }
}

