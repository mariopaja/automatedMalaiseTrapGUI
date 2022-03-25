using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Management;


namespace ArduinoGui
{
    public partial class createManualProgramUserControl : UserControl
    {

        private static createManualProgramUserControl _instance;
        public static createManualProgramUserControl Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new createManualProgramUserControl();
                return _instance;
            }
        }
        public createManualProgramUserControl()
        {
            InitializeComponent();
            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.CustomFormat = " HH:mm dd/MM/yyyy";

            intervalMins.SelectedIndex = 1;
            intervalHours.SelectedIndex = 0;
            intervalDays.SelectedIndex = 0;
            intervalBottle.SelectedIndex = 0;
            pauseMins.SelectedIndex = 1;
            pauseHours.SelectedIndex = 0;
            pauseDays.SelectedIndex = 0;
            repeat.SelectedIndex = 0;

            startTimePicker.ShowUpDown = true;
            string comPort = DetectArduino();
            serialPort.PortName = comPort;
        }

        private void addInterval_Click(object sender, EventArgs e)
        {
            if (intervalBottle.Text != "Bottle" && intervalDays.Text != "Days" && intervalHours.Text != "Hours" && intervalHours.Text != "Mins")
            {
                if (intervalDays.Text != "0" || intervalHours.Text != "0" || intervalMins.Text != "0")
                {
                    intervalDataBindingSource.Add(new intervalData() { bottle = intervalBottle.SelectedItem.ToString(), days = intervalDays.SelectedItem.ToString(), hours = intervalHours.SelectedItem.ToString(), mins = intervalMins.SelectedItem.ToString() });
                    if (dataGridView.Rows.Count * Convert.ToInt32(repeat.SelectedItem.ToString()) > 198)
                    {
                        addInterval.Enabled = false;
                        addPauseButton.Enabled = false;
                        transferDataButton.Enabled = false;
                    }
                }  
                else
                    MessageBox.Show("Interval Data Missing \nInterval Not Added", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Interval Data Missing \nInterval Not Added", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addPauseButton_Click(object sender, EventArgs e)
        {
            if (pauseDays.Text != "Days" && pauseHours.Text != "Hours" && pauseMins.Text != "Mins")
            {
                if (pauseDays.Text == "0" && pauseHours.Text == "0" && pauseMins.Text == "0")
                    MessageBox.Show("Pause Data Missing \nPause Not Added", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    intervalDataBindingSource.Add(new intervalData() { bottle = "Pause", days = pauseDays.SelectedItem.ToString(), hours = pauseHours.SelectedItem.ToString(), mins = pauseMins.SelectedItem.ToString() });
                    if (dataGridView.Rows.Count * Convert.ToInt32(repeat.SelectedItem.ToString()) > 198)
                    {
                        addInterval.Enabled = false;
                        addPauseButton.Enabled = false;
                        transferDataButton.Enabled = false;
                    }
                }
                    
            }
            else
                MessageBox.Show("Pause Data Missing \nPause Not Added", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this interval?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    intervalDataBindingSource.RemoveCurrent();
                if(dataGridView.Rows.Count * Convert.ToInt32(repeat.SelectedItem.ToString()) <= 198)
                {
                    addInterval.Enabled = true;
                    addPauseButton.Enabled = true;
                    transferDataButton.Enabled = true;
                }
            }
        }

        private void transferDataButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.Rows.Count > 0) { 

                if (startTimePicker.Value >= DateTime.Now)
                {
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string fileName = path+"\\M-R"+startTimePicker.Value.ToString("yyyyMMdd") + ".txt";
                    StreamWriter streamWriter = new StreamWriter(fileName);

                    string sLine = "";
                    sLine = sLine + "S" + startTimePicker.Value.ToString("HH:mm,dd/MM/yyyy") + ";";

                    for (int i = 0; i < Convert.ToInt32(repeat.SelectedItem.ToString()); i++)
                    {
                        for (int r = 0; r <= dataGridView.Rows.Count - 1; r++)
                        {
                            if (dataGridView.Rows[r].Cells[0].Value.ToString() == "Pause") sLine = sLine + "13";
                            else sLine = sLine + dataGridView.Rows[r].Cells[0].Value;

                            int mins = (Convert.ToInt32(dataGridView.Rows[r].Cells[1].Value)) * 24 * 60 + (Convert.ToInt32(dataGridView.Rows[r].Cells[2].Value)) * 60 + Convert.ToInt32(dataGridView.Rows[r].Cells[3].Value);
                            sLine = sLine + "," + mins + ";";
                        }
                    }

                    streamWriter.Write(sLine);
                    streamWriter.Close();
                }
                else MessageBox.Show("Check Start Time \nTransfer Failed", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("No Intervals \nTransfer Failed", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
        private void intervalMins_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


    }

}
