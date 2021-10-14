
namespace ArduinoGui
{
    partial class startProgramUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.transferDataButton = new System.Windows.Forms.Button();
            this.lightProgramButton = new System.Windows.Forms.RadioButton();
            this.soilTemperatureProgramButton = new System.Windows.Forms.RadioButton();
            this.selectAutomatedProgramLabel = new System.Windows.Forms.Label();
            this.soilMoistureProgramButton = new System.Windows.Forms.RadioButton();
            this.airHumidityProgramButton = new System.Windows.Forms.RadioButton();
            this.automatedProgramGroupBox = new System.Windows.Forms.GroupBox();
            this.automatedProgramRadioButton = new System.Windows.Forms.RadioButton();
            this.manualProgramRadioButton = new System.Windows.Forms.RadioButton();
            this.manualProgramGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileAddressSelector = new System.Windows.Forms.TextBox();
            this.automatedProgramGroupBox.SuspendLayout();
            this.manualProgramGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startTimePicker
            // 
            this.startTimePicker.Font = new System.Drawing.Font("Arial", 9F);
            this.startTimePicker.Location = new System.Drawing.Point(128, 36);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(200, 21);
            this.startTimePicker.TabIndex = 0;
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Font = new System.Drawing.Font("Arial", 9F);
            this.startTimeLabel.Location = new System.Drawing.Point(26, 39);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(83, 15);
            this.startTimeLabel.TabIndex = 38;
            this.startTimeLabel.Text = "Starting Time:";
            // 
            // transferDataButton
            // 
            this.transferDataButton.Font = new System.Drawing.Font("Arial", 9F);
            this.transferDataButton.Location = new System.Drawing.Point(419, 384);
            this.transferDataButton.Name = "transferDataButton";
            this.transferDataButton.Size = new System.Drawing.Size(106, 23);
            this.transferDataButton.TabIndex = 39;
            this.transferDataButton.Text = "Transfer Data";
            this.transferDataButton.UseVisualStyleBackColor = true;
            this.transferDataButton.Click += new System.EventHandler(this.transferDataButton_Click);
            // 
            // lightProgramButton
            // 
            this.lightProgramButton.AutoSize = true;
            this.lightProgramButton.Font = new System.Drawing.Font("Arial", 9F);
            this.lightProgramButton.Location = new System.Drawing.Point(128, 74);
            this.lightProgramButton.Name = "lightProgramButton";
            this.lightProgramButton.Size = new System.Drawing.Size(140, 19);
            this.lightProgramButton.TabIndex = 40;
            this.lightProgramButton.TabStop = true;
            this.lightProgramButton.Text = "Illuminance Program";
            this.lightProgramButton.UseVisualStyleBackColor = true;
            // 
            // soilTemperatureProgramButton
            // 
            this.soilTemperatureProgramButton.AutoSize = true;
            this.soilTemperatureProgramButton.Font = new System.Drawing.Font("Arial", 9F);
            this.soilTemperatureProgramButton.Location = new System.Drawing.Point(128, 101);
            this.soilTemperatureProgramButton.Name = "soilTemperatureProgramButton";
            this.soilTemperatureProgramButton.Size = new System.Drawing.Size(170, 19);
            this.soilTemperatureProgramButton.TabIndex = 41;
            this.soilTemperatureProgramButton.TabStop = true;
            this.soilTemperatureProgramButton.Text = "Soil Temperature Program";
            this.soilTemperatureProgramButton.UseVisualStyleBackColor = true;
            // 
            // selectAutomatedProgramLabel
            // 
            this.selectAutomatedProgramLabel.AutoSize = true;
            this.selectAutomatedProgramLabel.Font = new System.Drawing.Font("Arial", 9F);
            this.selectAutomatedProgramLabel.Location = new System.Drawing.Point(26, 75);
            this.selectAutomatedProgramLabel.Name = "selectAutomatedProgramLabel";
            this.selectAutomatedProgramLabel.Size = new System.Drawing.Size(95, 15);
            this.selectAutomatedProgramLabel.TabIndex = 42;
            this.selectAutomatedProgramLabel.Text = "Select Program:";
            // 
            // soilMoistureProgramButton
            // 
            this.soilMoistureProgramButton.AutoSize = true;
            this.soilMoistureProgramButton.Font = new System.Drawing.Font("Arial", 9F);
            this.soilMoistureProgramButton.Location = new System.Drawing.Point(128, 126);
            this.soilMoistureProgramButton.Name = "soilMoistureProgramButton";
            this.soilMoistureProgramButton.Size = new System.Drawing.Size(147, 19);
            this.soilMoistureProgramButton.TabIndex = 43;
            this.soilMoistureProgramButton.TabStop = true;
            this.soilMoistureProgramButton.Text = "Soil Moisture Program";
            this.soilMoistureProgramButton.UseVisualStyleBackColor = true;
            // 
            // airHumidityProgramButton
            // 
            this.airHumidityProgramButton.AutoSize = true;
            this.airHumidityProgramButton.Font = new System.Drawing.Font("Arial", 9F);
            this.airHumidityProgramButton.Location = new System.Drawing.Point(128, 151);
            this.airHumidityProgramButton.Name = "airHumidityProgramButton";
            this.airHumidityProgramButton.Size = new System.Drawing.Size(141, 19);
            this.airHumidityProgramButton.TabIndex = 44;
            this.airHumidityProgramButton.TabStop = true;
            this.airHumidityProgramButton.Text = "Air Humidity Program";
            this.airHumidityProgramButton.UseVisualStyleBackColor = true;
            // 
            // automatedProgramGroupBox
            // 
            this.automatedProgramGroupBox.Controls.Add(this.lightProgramButton);
            this.automatedProgramGroupBox.Controls.Add(this.airHumidityProgramButton);
            this.automatedProgramGroupBox.Controls.Add(this.startTimePicker);
            this.automatedProgramGroupBox.Controls.Add(this.soilMoistureProgramButton);
            this.automatedProgramGroupBox.Controls.Add(this.startTimeLabel);
            this.automatedProgramGroupBox.Controls.Add(this.selectAutomatedProgramLabel);
            this.automatedProgramGroupBox.Controls.Add(this.soilTemperatureProgramButton);
            this.automatedProgramGroupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.automatedProgramGroupBox.Location = new System.Drawing.Point(17, 64);
            this.automatedProgramGroupBox.Name = "automatedProgramGroupBox";
            this.automatedProgramGroupBox.Size = new System.Drawing.Size(460, 210);
            this.automatedProgramGroupBox.TabIndex = 45;
            this.automatedProgramGroupBox.TabStop = false;
            this.automatedProgramGroupBox.Text = "Automated Program";
            this.automatedProgramGroupBox.Visible = false;
            // 
            // automatedProgramRadioButton
            // 
            this.automatedProgramRadioButton.AutoSize = true;
            this.automatedProgramRadioButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.automatedProgramRadioButton.Location = new System.Drawing.Point(93, 24);
            this.automatedProgramRadioButton.Name = "automatedProgramRadioButton";
            this.automatedProgramRadioButton.Size = new System.Drawing.Size(135, 19);
            this.automatedProgramRadioButton.TabIndex = 46;
            this.automatedProgramRadioButton.TabStop = true;
            this.automatedProgramRadioButton.Text = "Automated Program";
            this.automatedProgramRadioButton.UseVisualStyleBackColor = true;
            this.automatedProgramRadioButton.CheckedChanged += new System.EventHandler(this.automatedProgramRadioButton_CheckedChanged);
            // 
            // manualProgramRadioButton
            // 
            this.manualProgramRadioButton.AutoSize = true;
            this.manualProgramRadioButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualProgramRadioButton.Location = new System.Drawing.Point(289, 24);
            this.manualProgramRadioButton.Name = "manualProgramRadioButton";
            this.manualProgramRadioButton.Size = new System.Drawing.Size(116, 19);
            this.manualProgramRadioButton.TabIndex = 47;
            this.manualProgramRadioButton.TabStop = true;
            this.manualProgramRadioButton.Text = "Manual Program";
            this.manualProgramRadioButton.UseVisualStyleBackColor = true;
            this.manualProgramRadioButton.CheckedChanged += new System.EventHandler(this.manualProgramRadioButton_CheckedChanged);
            // 
            // manualProgramGroupBox
            // 
            this.manualProgramGroupBox.Controls.Add(this.label1);
            this.manualProgramGroupBox.Controls.Add(this.txtFileAddressSelector);
            this.manualProgramGroupBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualProgramGroupBox.Location = new System.Drawing.Point(17, 64);
            this.manualProgramGroupBox.Name = "manualProgramGroupBox";
            this.manualProgramGroupBox.Size = new System.Drawing.Size(460, 210);
            this.manualProgramGroupBox.TabIndex = 48;
            this.manualProgramGroupBox.TabStop = false;
            this.manualProgramGroupBox.Text = "Manual Program";
            this.manualProgramGroupBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Program File:";
            // 
            // txtFileAddressSelector
            // 
            this.txtFileAddressSelector.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFileAddressSelector.Location = new System.Drawing.Point(131, 40);
            this.txtFileAddressSelector.Name = "txtFileAddressSelector";
            this.txtFileAddressSelector.ReadOnly = true;
            this.txtFileAddressSelector.Size = new System.Drawing.Size(310, 21);
            this.txtFileAddressSelector.TabIndex = 0;
            this.txtFileAddressSelector.Click += new System.EventHandler(this.txtFileAddressSelector_Click);
            // 
            // startProgramUserControl
            // 
            this.Controls.Add(this.manualProgramRadioButton);
            this.Controls.Add(this.automatedProgramRadioButton);
            this.Controls.Add(this.transferDataButton);
            this.Controls.Add(this.automatedProgramGroupBox);
            this.Controls.Add(this.manualProgramGroupBox);
            this.Name = "startProgramUserControl";
            this.Size = new System.Drawing.Size(679, 455);
            this.automatedProgramGroupBox.ResumeLayout(false);
            this.automatedProgramGroupBox.PerformLayout();
            this.manualProgramGroupBox.ResumeLayout(false);
            this.manualProgramGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Button transferDataButton;
        private System.Windows.Forms.RadioButton lightProgramButton;
        private System.Windows.Forms.RadioButton soilTemperatureProgramButton;
        private System.Windows.Forms.Label selectAutomatedProgramLabel;
        private System.Windows.Forms.RadioButton soilMoistureProgramButton;
        private System.Windows.Forms.RadioButton airHumidityProgramButton;
        private System.Windows.Forms.GroupBox automatedProgramGroupBox;
        private System.Windows.Forms.RadioButton automatedProgramRadioButton;
        private System.Windows.Forms.RadioButton manualProgramRadioButton;
        private System.Windows.Forms.GroupBox manualProgramGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileAddressSelector;
    }
}
