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
using System.IO.Ports;
using System.Timers;
using System.Threading;

namespace ArduinoGui
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            connectionCheckTimer.Enabled = true;



            panel.Controls.Add(infoUserControl.Instance);
            infoUserControl.Instance.Dock = DockStyle.Fill;
            panel.Controls.Add(createManualProgramUserControl.Instance);
            createManualProgramUserControl.Instance.Dock = DockStyle.Fill;
            panel.Controls.Add(startProgramUserControl.Instance);
            startProgramUserControl.Instance.Dock = DockStyle.Fill;
            panel.Controls.Add(configUserControl.Instance);
            configUserControl.Instance.Dock = DockStyle.Fill;

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
                        //DebugOut("Arduino details: " + desc + " on " + deviceId);

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
        public void connectionCheckTimer_Tick(object sender, EventArgs e)
        {
            connectionCheckTimer.Interval = 1000;
            string comPort = DetectArduino();

            if (comPort == "NOPORT")
            {
                
                
                ConnectionIndicator.BackColor = Color.Red;
                ConnectionStatus.Text = "Disconnected";
               
                //infoUserControl.Instance.BringToFront();
                infoButton.Enabled = true;
                startProgramButton.Enabled = true;
                automatedProgramButton.Enabled = true;
                configDataButton.Enabled = true;
            }
            else
            {
                //panel.Visible = true;
                ConnectionIndicator.BackColor = Color.Green;
                ConnectionStatus.Text = "Connected";
                infoButton.Enabled = true;
                startProgramButton.Enabled = true;
                automatedProgramButton.Enabled = true;
                configDataButton.Enabled = true;
                
            }


        }
        private void infoButton_Click(object sender, EventArgs e)
        {
            infoUserControl.Instance.BringToFront();            
        }
        private void startProgramButton_Click(object sender, EventArgs e)
        {

                createManualProgramUserControl.Instance.BringToFront();
            
        }
        private void configDataButton_Click(object sender, EventArgs e)
        {
           // if (!panel.Controls.Contains(configUserControl.Instance))
                configUserControl.Instance.BringToFront();
        }

        private void automatedProgramButton_Click(object sender, EventArgs e)
        {
            startProgramUserControl.Instance.BringToFront();
        }
    }

}
