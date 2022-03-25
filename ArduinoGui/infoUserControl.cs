using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Threading;

namespace ArduinoGui
{
    public partial class infoUserControl : UserControl
    {
        

        private static infoUserControl _instance;
        public static infoUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new infoUserControl();
                return _instance;
            }
        }
        public infoUserControl()
        {
            InitializeComponent();
            timer.Enabled = true;
        }
        public static string DetectArduino()
        {
            ManagementScope connectionScope = new ManagementScope();
            SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);
            try
            {
                foreach (ManagementObject item in searcher.Get())
                {
                    string desc = item["Description"].ToString();
                    string deviceId = item["DeviceID"].ToString();
                    if (desc.Contains("Arduino"))
                    {
                        DebugOut("Arduino details: " + desc + " on " + deviceId);

                        return deviceId;
                    }
                }
            }
            catch (ManagementException e)
            {
                /* Do Nothing */
                DebugOut("An error occurred while querying for WMI data: " + e.Message);
            }
            return "NOPORT";
        }
        public static void DebugOut(string message)
        {
            Console.WriteLine(message);
        }


        private void getInfoButton_Click(object sender, EventArgs e)
        {

            string comPort = DetectArduino();
            try
                {
                serialPort.PortName = comPort;
                serialPort.BaudRate = 9600;
                serialPort.Open();
                string sLine = "";
                    sLine = sLine + "N;";
                    serialPort.Write("N");
                    IDtextbox.Text = serialPort.ReadLine();
                    airTemperatureTextbox.Text = serialPort.ReadLine();
                    airTemperatureTextbox.Text += "°C";
                    airHumidityTextbox.Text = serialPort.ReadLine();
                    airHumidityTextbox.Text += "%";
                    soilTemperatureTextbox.Text = serialPort.ReadLine();
                    soilTemperatureTextbox.Text += "°C";
                    soilMoistureTextBox.Text = serialPort.ReadLine();
                    soilMoistureTextBox.Text += "%";
                    lightIntensityTextBox.Text = serialPort.ReadLine();
                    lightIntensityTextBox.Text += "lx";
                    serialPort.Close();
                }
                catch (System.Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string comPort = DetectArduino();
            timer.Interval = 1000;
            if (comPort == "NOPORT")
            {
                
                    IDtextbox.Text = "";
                    airTemperatureTextbox.Text = "";
                    airHumidityTextbox.Text = "";
                    soilTemperatureTextbox.Text = "";
                    soilMoistureTextBox.Text = "";
                    lightIntensityTextBox.Text = "";
                    
                
                getInfoButton.Enabled = false;

            }
            else
            {
                serialPort.PortName = comPort;
                getInfoButton.Enabled = true;
                // IDtextbox.Text = "mut";
            }
        }
    }
}


