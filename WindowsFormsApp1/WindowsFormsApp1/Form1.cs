using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        String serialDataIn;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button_open.Enabled = true;
            button_close.Enabled = false;
            button_send.Enabled = false;
            progressBar_statusBar.Value = 0;
            label_status.Text = "DISCONNECTED";
            label_status.ForeColor = Color.Red;

            comboBox_baudRate.Text = "115200";
            string[] portLists = SerialPort.GetPortNames();
            comboBox_comPort.Items.AddRange(portLists);





        }

        private void button_open_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_comPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_baudRate.Text);
                serialPort1.Open();

                button_open.Enabled = false;
                button_close.Enabled = true;
                button_send.Enabled = true;
                progressBar_statusBar.Value = 100;
                label_status.Text = "CONNECTED";
                label_status.ForeColor = Color.Green;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                    button_open.Enabled = true;
                    button_close.Enabled = false;
                    button_send.Enabled = false;
                    progressBar_statusBar.Value = 0;
                    label_status.Text = "DISCONNECTED";
                    label_status.ForeColor = Color.Red;

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }

            }
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write(textBox_textSend.Text);
            }
            catch (Exception error)
            {

            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialDataIn = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            richTextBox_textReceiver.Text += serialDataIn;
        }
        private void richTextBox_textReceiver_TextChanged(object sender, EventArgs e)
        {
            richTextBox_textReceiver.SelectionStart = richTextBox_textReceiver.Text.Length;
            richTextBox_textReceiver.ScrollToCaret();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
    }
