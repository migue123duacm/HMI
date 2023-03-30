using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace HMI_prototipo1
{
    public partial class Form1 : Form
    {
        //private readonly object[] portlist;
        private object serialPort;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonOpen.Enabled = true;
            buttonClose.Enabled = false;
            buttonLedOn.Enabled = false;
            buttonledOff.Enabled = false;
            comboBoxBautRate.Text = "9600";
            progressBarConnection.Value = 0;
            pictureBoxLed.Image = Properties.Resources.blue_power_button;

            string[] portList = SerialPort.GetPortNames();
            ComboBox.ObjectCollection items = comboBoxPort.Items;
            comboBoxPort.Items.AddRange(portList);
            //comboBoxPort
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBoxPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBoxBautRate.Text);
                serialPort1.Open();
                buttonOpen.Enabled = false;
                buttonClose.Enabled = true;
                buttonLedOn.Enabled = true;
                buttonledOff.Enabled = true;
                progressBarConnection.Value = 100;
                comboBoxBautRate.Enabled = false;
                comboBoxPort.Enabled = false;
            }
            catch (Exception error) 
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("#off");
                pictureBoxLed.Image = Properties.Resources.red_power_button;

                serialPort1.Close();
                buttonOpen.Enabled = true;
                buttonClose.Enabled = false;
                buttonLedOn.Enabled = false;
                buttonledOff.Enabled = false;
                progressBarConnection.Value = 0;
                comboBoxBautRate.Enabled = true;
                comboBoxPort.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void buttonledOff_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                try
                {
                    pictureBoxLed.Image = Properties.Resources.red_power_button;

                    // envia comando al arduino
                    serialPort1.WriteLine("#off");
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void labelPort_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
