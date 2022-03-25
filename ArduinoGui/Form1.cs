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
            connectionCheckTimer.Enabled = true;    /*  <-  create a timer which allows the gui to check if arduino is connected    */


            /*  declare the panels for each gui interface   */
            panel.Controls.Add(infoUserControl.Instance);
            infoUserControl.Instance.Dock = DockStyle.Fill;
            panel.Controls.Add(createManualProgramUserControl.Instance);
            createManualProgramUserControl.Instance.Dock = DockStyle.Fill;
            panel.Controls.Add(startProgramUserControl.Instance);
            startProgramUserControl.Instance.Dock = DockStyle.Fill;
            panel.Controls.Add(configUserControl.Instance);
            configUserControl.Instance.Dock = DockStyle.Fill;

        }

        /*
            DetectArduino() :   checks if an arduino is connected to the device
                            :   reads teh description of all the connected devices to the PC
                            :   returns the com port where the arduino is connected
         */
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
                    string port=item["Caption"].ToString();
                    if (desc.Contains("Arduino"))
                    {
                        //Console.WriteLine(port);
                        Console.WriteLine(deviceId);
                        //Console.WriteLine(desc);
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

        /*
            DebugOut()  :   debug function for the DetectArduino()
         */
        public static void DebugOut(string message)
        {
            Console.WriteLine(message);
        }

        /*
            connectionCheckTimer_Tick() :   software clock that enables gui to check every second for arduino device
                                        :   1000 interval is in milliseconds
         */
        public void connectionCheckTimer_Tick(object sender, EventArgs e)
        {
            connectionCheckTimer.Interval = 1000;
            string comPort = DetectArduino();

            if (comPort == "NOPORT")
            {
                ConnectionIndicator.BackColor = Color.Red;              /*  <-  indicator turned red    */
                ConnectionStatus.Text = "Disconnected";                 /*  <-  panel displays disconnected */
            }
            else
            {
                ConnectionIndicator.BackColor = Color.Green;            /*  <-  indicator turned green  */
                ConnectionStatus.Text = "Connected";                    /*  <-  panel displays connected    */
            }


        }

        /*
            infoButton_Click()  :   brings to front info gui interface
         */
        private void infoButton_Click(object sender, EventArgs e)
        {
            infoUserControl.Instance.BringToFront();
        }

        /*
            startProgramButton_Click()  :   brings to front start program gui interface
         */
        private void startProgramButton_Click(object sender, EventArgs e)
        {

            createManualProgramUserControl.Instance.BringToFront();

        }

        /*
            configDataButton_Click()    :   brings to front config data gui interface
         */
        private void configDataButton_Click(object sender, EventArgs e)
        {
            configUserControl.Instance.BringToFront();
        }

        /*
            selectProgramButton_Click    :   brings to front start program gui interface
         */
        private void selectProgramButton_Click(object sender, EventArgs e)
        {
            startProgramUserControl.Instance.BringToFront();
        }
    }

}
