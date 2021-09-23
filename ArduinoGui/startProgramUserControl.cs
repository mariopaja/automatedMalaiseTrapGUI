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


namespace ArduinoGui
{

    public partial class startProgramUserControl : UserControl
    {
        
        private static startProgramUserControl _instance;

        public static startProgramUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new startProgramUserControl();
                return _instance;
            }
        }

        public startProgramUserControl()
        {
            InitializeComponent();
            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.CustomFormat = " HH:mm dd/MM/yyyy";

            startTimePicker.ShowUpDown = true;
            string comPort = DetectArduino();
            serialPort.PortName = comPort;
            
        }

        private void automatedProgramUserControl_Load(object sender, EventArgs e)
        {

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

        private void transferDataButton_Click(object sender, EventArgs e)
        {
            string comPort = DetectArduino();
            if (comPort != "NOPORT") {
                if (automatedProgramRadioButton.Checked)
                {
                    if (startTimePicker.Value >= DateTime.Now)
                    {

                        if (!lightProgramButton.Checked && !soilTemperatureProgramButton.Checked && !soilMoistureProgramButton.Checked && !airHumidityProgramButton.Checked) 
                            MessageBox.Show("Program Missing", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (lightProgramButton.Checked)
                        {
                            try
                            {
                                serialPort.Open();
                                string sLine = "";
                                sLine = sLine + "A" + startTimePicker.Value.ToString("HH:mm,dd/MM/yyyy") + ";" + "0";


                                serialPort.Write(sLine);
                                serialPort.Close();

                                MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (System.Exception err)
                            {
                                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        if (soilTemperatureProgramButton.Checked)
                        {
                            try
                            {
                                serialPort.Open();
                                string sLine = "";
                                sLine = sLine + "A" + startTimePicker.Value.ToString("HH:mm,dd/MM/yyyy") + ";" + "1";


                                serialPort.Write(sLine);
                                serialPort.Close();

                                MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (System.Exception err)
                            {
                                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        if (soilMoistureProgramButton.Checked)
                        {
                            try
                            {
                                serialPort.Open();
                                string sLine = "";
                                sLine = sLine + "A" + startTimePicker.Value.ToString("HH:mm,dd/MM/yyyy") + ";" + "2";


                                serialPort.Write(sLine);
                                serialPort.Close();

                                MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (System.Exception err)
                            {
                                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        if (airHumidityProgramButton.Checked)
                        {
                            try
                            {
                                serialPort.Open();
                                string sLine = "";
                                sLine = sLine + "A" + startTimePicker.Value.ToString("HH:mm,dd/MM/yyyy") + ";" + "3";


                                serialPort.Write(sLine);
                                serialPort.Close();

                                MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (System.Exception err)
                            {
                                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }



                    }
                }
                if (manualProgramRadioButton.Checked)
                {
                    if (txtFileAddressSelector.Text != "")
                    {
                        string program;
                        var fileStream = new FileStream(@txtFileAddressSelector.Text, FileMode.Open, FileAccess.Read);
                        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
                        {
                            program = streamReader.ReadToEnd();
                        }

                        

                   try
                   {
                       serialPort.Open();  
                       serialPort.Write(program);
                       serialPort.Close();

                   MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
                   catch (System.Exception err)
                   {
                       MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
                   

                    }
                    else MessageBox.Show("No File Selected", "Transfer Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                if(!automatedProgramRadioButton.Checked && !manualProgramRadioButton.Checked) MessageBox.Show("No Program Selected", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else MessageBox.Show("No Arduino Connected", "Transfer Error", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void automatedProgramRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (automatedProgramRadioButton.Checked)
            {
                automatedProgramGroupBox.Visible = true;
                
            }
            if (!automatedProgramRadioButton.Checked)
            {
                automatedProgramGroupBox.Visible = false;

            }



        }

        private void manualProgramRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (manualProgramRadioButton.Checked)
            {
                manualProgramGroupBox.Visible = true;
             
            }
            if (!manualProgramRadioButton.Checked)
            {
                manualProgramGroupBox.Visible = false;
                
            }


        }

        private void txtFileAddressSelector_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                

                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                openFileDialog.Filter = "txt files (*.txt)|*.txt";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;
                   /* 

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                   */
                }
                

            }
            txtFileAddressSelector.Text = filePath.ToString();
        }

        
    }
}
