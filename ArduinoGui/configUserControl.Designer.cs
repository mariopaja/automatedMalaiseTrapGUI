
namespace ArduinoGui
{
    partial class configUserControl
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
            this.setRTClabel = new System.Windows.Forms.Label();
            this.RTCpicker = new System.Windows.Forms.DateTimePicker();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.saveTimeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setRTClabel
            // 
            this.setRTClabel.AutoSize = true;
            this.setRTClabel.Font = new System.Drawing.Font("Arial", 9F);
            this.setRTClabel.Location = new System.Drawing.Point(81, 66);
            this.setRTClabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.setRTClabel.Name = "setRTClabel";
            this.setRTClabel.Size = new System.Drawing.Size(86, 21);
            this.setRTClabel.TabIndex = 1;
            this.setRTClabel.Text = "Set Time:";
            // 
            // RTCpicker
            // 
            this.RTCpicker.Enabled = false;
            this.RTCpicker.Font = new System.Drawing.Font("Arial", 9F);
            this.RTCpicker.Location = new System.Drawing.Point(264, 57);
            this.RTCpicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RTCpicker.Name = "RTCpicker";
            this.RTCpicker.Size = new System.Drawing.Size(298, 28);
            this.RTCpicker.TabIndex = 3;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // saveTimeButton
            // 
            this.saveTimeButton.Font = new System.Drawing.Font("Arial", 9F);
            this.saveTimeButton.Location = new System.Drawing.Point(687, 54);
            this.saveTimeButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveTimeButton.Name = "saveTimeButton";
            this.saveTimeButton.Size = new System.Drawing.Size(112, 35);
            this.saveTimeButton.TabIndex = 7;
            this.saveTimeButton.Text = "Set Time";
            this.saveTimeButton.UseVisualStyleBackColor = true;
            this.saveTimeButton.Click += new System.EventHandler(this.saveTimeButton_Click);
            // 
            // configUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saveTimeButton);
            this.Controls.Add(this.RTCpicker);
            this.Controls.Add(this.setRTClabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "configUserControl";
            this.Size = new System.Drawing.Size(992, 689);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label setRTClabel;
        private System.Windows.Forms.DateTimePicker RTCpicker;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button saveTimeButton;
    }
}
