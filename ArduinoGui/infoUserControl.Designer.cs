
namespace ArduinoGui
{
    partial class infoUserControl
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
            this.machineIDlabel = new System.Windows.Forms.Label();
            this.IDtextbox = new System.Windows.Forms.TextBox();
            this.airTemperatureTextbox = new System.Windows.Forms.TextBox();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.airHumidityTextbox = new System.Windows.Forms.TextBox();
            this.airHumidityLabel = new System.Windows.Forms.Label();
            this.soilTemperatureTextbox = new System.Windows.Forms.TextBox();
            this.soilTemperatureLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.getInfoButton = new System.Windows.Forms.Button();
            this.soilMoistureTextBox = new System.Windows.Forms.TextBox();
            this.soilMoistureLabel = new System.Windows.Forms.Label();
            this.lightIntensityTextBox = new System.Windows.Forms.TextBox();
            this.lightIntensityLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // machineIDlabel
            // 
            this.machineIDlabel.AutoSize = true;
            this.machineIDlabel.Font = new System.Drawing.Font("Arial", 9F);
            this.machineIDlabel.Location = new System.Drawing.Point(22, 22);
            this.machineIDlabel.Name = "machineIDlabel";
            this.machineIDlabel.Size = new System.Drawing.Size(71, 15);
            this.machineIDlabel.TabIndex = 29;
            this.machineIDlabel.Text = "Machine ID:";
            // 
            // IDtextbox
            // 
            this.IDtextbox.BackColor = System.Drawing.SystemColors.Control;
            this.IDtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDtextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDtextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.IDtextbox.Location = new System.Drawing.Point(130, 19);
            this.IDtextbox.Name = "IDtextbox";
            this.IDtextbox.ReadOnly = true;
            this.IDtextbox.Size = new System.Drawing.Size(120, 21);
            this.IDtextbox.TabIndex = 30;
            // 
            // airTemperatureTextbox
            // 
            this.airTemperatureTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.airTemperatureTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.airTemperatureTextbox.Location = new System.Drawing.Point(130, 45);
            this.airTemperatureTextbox.Name = "airTemperatureTextbox";
            this.airTemperatureTextbox.ReadOnly = true;
            this.airTemperatureTextbox.Size = new System.Drawing.Size(120, 21);
            this.airTemperatureTextbox.TabIndex = 32;
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Font = new System.Drawing.Font("Arial", 9F);
            this.temperatureLabel.Location = new System.Drawing.Point(22, 48);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(97, 15);
            this.temperatureLabel.TabIndex = 31;
            this.temperatureLabel.Text = "Air Temperature:";
            // 
            // airHumidityTextbox
            // 
            this.airHumidityTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.airHumidityTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.airHumidityTextbox.Location = new System.Drawing.Point(130, 71);
            this.airHumidityTextbox.Name = "airHumidityTextbox";
            this.airHumidityTextbox.ReadOnly = true;
            this.airHumidityTextbox.Size = new System.Drawing.Size(120, 21);
            this.airHumidityTextbox.TabIndex = 34;
            // 
            // airHumidityLabel
            // 
            this.airHumidityLabel.AutoSize = true;
            this.airHumidityLabel.Font = new System.Drawing.Font("Arial", 9F);
            this.airHumidityLabel.Location = new System.Drawing.Point(22, 74);
            this.airHumidityLabel.Name = "airHumidityLabel";
            this.airHumidityLabel.Size = new System.Drawing.Size(75, 15);
            this.airHumidityLabel.TabIndex = 33;
            this.airHumidityLabel.Text = "Air Humidity:";
            // 
            // soilTemperatureTextbox
            // 
            this.soilTemperatureTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soilTemperatureTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.soilTemperatureTextbox.Location = new System.Drawing.Point(130, 97);
            this.soilTemperatureTextbox.Name = "soilTemperatureTextbox";
            this.soilTemperatureTextbox.ReadOnly = true;
            this.soilTemperatureTextbox.Size = new System.Drawing.Size(120, 21);
            this.soilTemperatureTextbox.TabIndex = 36;
            // 
            // soilTemperatureLabel
            // 
            this.soilTemperatureLabel.AutoSize = true;
            this.soilTemperatureLabel.Font = new System.Drawing.Font("Arial", 9F);
            this.soilTemperatureLabel.Location = new System.Drawing.Point(22, 100);
            this.soilTemperatureLabel.Name = "soilTemperatureLabel";
            this.soilTemperatureLabel.Size = new System.Drawing.Size(104, 15);
            this.soilTemperatureLabel.TabIndex = 35;
            this.soilTemperatureLabel.Text = "Soil Temperature:";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // getInfoButton
            // 
            this.getInfoButton.Font = new System.Drawing.Font("Arial", 9F);
            this.getInfoButton.Location = new System.Drawing.Point(419, 384);
            this.getInfoButton.Name = "getInfoButton";
            this.getInfoButton.Size = new System.Drawing.Size(75, 23);
            this.getInfoButton.TabIndex = 43;
            this.getInfoButton.Text = "Read Data";
            this.getInfoButton.UseVisualStyleBackColor = true;
            this.getInfoButton.Click += new System.EventHandler(this.getInfoButton_Click);
            // 
            // soilMoistureTextBox
            // 
            this.soilMoistureTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.soilMoistureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.soilMoistureTextBox.Location = new System.Drawing.Point(130, 123);
            this.soilMoistureTextBox.Name = "soilMoistureTextBox";
            this.soilMoistureTextBox.ReadOnly = true;
            this.soilMoistureTextBox.Size = new System.Drawing.Size(120, 21);
            this.soilMoistureTextBox.TabIndex = 45;
            // 
            // soilMoistureLabel
            // 
            this.soilMoistureLabel.AutoSize = true;
            this.soilMoistureLabel.Font = new System.Drawing.Font("Arial", 9F);
            this.soilMoistureLabel.Location = new System.Drawing.Point(22, 126);
            this.soilMoistureLabel.Name = "soilMoistureLabel";
            this.soilMoistureLabel.Size = new System.Drawing.Size(81, 15);
            this.soilMoistureLabel.TabIndex = 44;
            this.soilMoistureLabel.Text = "Soil Moisture:";
            // 
            // lightIntensityTextBox
            // 
            this.lightIntensityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lightIntensityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lightIntensityTextBox.Location = new System.Drawing.Point(130, 149);
            this.lightIntensityTextBox.Name = "lightIntensityTextBox";
            this.lightIntensityTextBox.ReadOnly = true;
            this.lightIntensityTextBox.Size = new System.Drawing.Size(120, 21);
            this.lightIntensityTextBox.TabIndex = 47;
            // 
            // lightIntensityLabel
            // 
            this.lightIntensityLabel.AutoSize = true;
            this.lightIntensityLabel.Font = new System.Drawing.Font("Arial", 9F);
            this.lightIntensityLabel.Location = new System.Drawing.Point(22, 152);
            this.lightIntensityLabel.Name = "lightIntensityLabel";
            this.lightIntensityLabel.Size = new System.Drawing.Size(104, 15);
            this.lightIntensityLabel.TabIndex = 46;
            this.lightIntensityLabel.Text = "Light Illuminance:";
            // 
            // infoUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lightIntensityTextBox);
            this.Controls.Add(this.lightIntensityLabel);
            this.Controls.Add(this.soilMoistureTextBox);
            this.Controls.Add(this.soilMoistureLabel);
            this.Controls.Add(this.getInfoButton);
            this.Controls.Add(this.soilTemperatureTextbox);
            this.Controls.Add(this.soilTemperatureLabel);
            this.Controls.Add(this.airHumidityTextbox);
            this.Controls.Add(this.airHumidityLabel);
            this.Controls.Add(this.airTemperatureTextbox);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.IDtextbox);
            this.Controls.Add(this.machineIDlabel);
            this.Name = "infoUserControl";
            this.Size = new System.Drawing.Size(526, 410);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label machineIDlabel;
        private System.Windows.Forms.TextBox IDtextbox;
        private System.Windows.Forms.TextBox airTemperatureTextbox;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.TextBox airHumidityTextbox;
        private System.Windows.Forms.Label airHumidityLabel;
        private System.Windows.Forms.TextBox soilTemperatureTextbox;
        private System.Windows.Forms.Label soilTemperatureLabel;
        private System.Windows.Forms.Timer timer;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Button getInfoButton;
        private System.Windows.Forms.TextBox soilMoistureTextBox;
        private System.Windows.Forms.Label soilMoistureLabel;
        private System.Windows.Forms.TextBox lightIntensityTextBox;
        private System.Windows.Forms.Label lightIntensityLabel;
    }
}
