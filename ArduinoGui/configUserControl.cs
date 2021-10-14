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
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace ArduinoGui
{
    public partial class configUserControl : UserControl
    {
        private static configUserControl _instance;
        public static configUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new configUserControl();
                return _instance;
            }
        }
        public configUserControl()
        {
            InitializeComponent();
            RTCpicker.Format = DateTimePickerFormat.Custom;
            RTCpicker.CustomFormat = " HH:mm:ss dd/MM/yyyy";
            RTCpicker.ShowUpDown = true;
            string comPort = DetectArduino();
            serialPort.PortName = comPort;
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

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = 200;
            RTCpicker.Value = DateTime.Now;
        }

        private void saveTimeButton_Click(object sender, EventArgs e)
        {
            string comPort = DetectArduino();
            if (comPort != "NOPORT")
            {
                try
                {
                    serialPort.Open();
                    string sLine = "";
                    sLine = sLine + "R" + DateTime.Now.ToString("HH:mm:ss,dd/MM/yyyy") + ";";
                    serialPort.Write(sLine);
                    serialPort.Close();
                    Console.WriteLine(sLine);
                    MessageBox.Show("Time Set", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("No Arduino Connected", "Transfer Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


    }
}
