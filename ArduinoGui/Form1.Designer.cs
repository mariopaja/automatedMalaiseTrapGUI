
namespace ArduinoGui
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ConnectionPanel = new System.Windows.Forms.Panel();
            this.ConnectionStatus = new System.Windows.Forms.Label();
            this.ConnectionIndicator = new System.Windows.Forms.PictureBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.connectionCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.configDataButton = new System.Windows.Forms.Button();
            this.selectProgramButton = new System.Windows.Forms.Button();
            this.startProgramButton = new System.Windows.Forms.Button();
            this.infoButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.intervalDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConnectionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionIndicator)).BeginInit();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectionPanel
            // 
            this.ConnectionPanel.Controls.Add(this.ConnectionStatus);
            this.ConnectionPanel.Controls.Add(this.ConnectionIndicator);
            this.ConnectionPanel.Location = new System.Drawing.Point(9, 406);
            this.ConnectionPanel.Name = "ConnectionPanel";
            this.ConnectionPanel.Size = new System.Drawing.Size(120, 23);
            this.ConnectionPanel.TabIndex = 5;
            // 
            // ConnectionStatus
            // 
            this.ConnectionStatus.AutoSize = true;
            this.ConnectionStatus.Font = new System.Drawing.Font("Arial", 9F);
            this.ConnectionStatus.Location = new System.Drawing.Point(14, 5);
            this.ConnectionStatus.Name = "ConnectionStatus";
            this.ConnectionStatus.Size = new System.Drawing.Size(83, 15);
            this.ConnectionStatus.TabIndex = 1;
            this.ConnectionStatus.Text = "Disconnected";
            // 
            // ConnectionIndicator
            // 
            this.ConnectionIndicator.BackColor = System.Drawing.Color.Red;
            this.ConnectionIndicator.Location = new System.Drawing.Point(3, 7);
            this.ConnectionIndicator.Name = "ConnectionIndicator";
            this.ConnectionIndicator.Size = new System.Drawing.Size(10, 10);
            this.ConnectionIndicator.TabIndex = 2;
            this.ConnectionIndicator.TabStop = false;
            // 
            // connectionCheckTimer
            // 
            this.connectionCheckTimer.Tick += new System.EventHandler(this.connectionCheckTimer_Tick);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.configDataButton);
            this.buttonPanel.Controls.Add(this.selectProgramButton);
            this.buttonPanel.Controls.Add(this.ConnectionPanel);
            this.buttonPanel.Controls.Add(this.startProgramButton);
            this.buttonPanel.Controls.Add(this.infoButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPanel.Location = new System.Drawing.Point(0, 0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(138, 441);
            this.buttonPanel.TabIndex = 29;
            // 
            // configDataButton
            // 
            this.configDataButton.Font = new System.Drawing.Font("Arial", 9F);
            this.configDataButton.Location = new System.Drawing.Point(9, 105);
            this.configDataButton.Name = "configDataButton";
            this.configDataButton.Size = new System.Drawing.Size(120, 25);
            this.configDataButton.TabIndex = 11;
            this.configDataButton.Text = "Config Data";
            this.configDataButton.UseVisualStyleBackColor = true;
            this.configDataButton.Click += new System.EventHandler(this.configDataButton_Click);
            // 
            // selectProgramButton
            // 
            this.selectProgramButton.Font = new System.Drawing.Font("Arial", 9F);
            this.selectProgramButton.Location = new System.Drawing.Point(9, 42);
            this.selectProgramButton.Name = "selectProgramButton";
            this.selectProgramButton.Size = new System.Drawing.Size(120, 25);
            this.selectProgramButton.TabIndex = 14;
            this.selectProgramButton.Text = "Start Program";
            this.selectProgramButton.UseVisualStyleBackColor = true;
            this.selectProgramButton.Click += new System.EventHandler(this.selectProgramButton_Click);
            // 
            // startProgramButton
            // 
            this.startProgramButton.Font = new System.Drawing.Font("Arial", 9F);
            this.startProgramButton.Location = new System.Drawing.Point(9, 73);
            this.startProgramButton.Name = "startProgramButton";
            this.startProgramButton.Size = new System.Drawing.Size(120, 25);
            this.startProgramButton.TabIndex = 13;
            this.startProgramButton.Text = "Create Program (M)";
            this.startProgramButton.UseVisualStyleBackColor = true;
            this.startProgramButton.Click += new System.EventHandler(this.startProgramButton_Click);
            // 
            // infoButton
            // 
            this.infoButton.Font = new System.Drawing.Font("Arial", 9F);
            this.infoButton.Location = new System.Drawing.Point(9, 11);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(120, 25);
            this.infoButton.TabIndex = 12;
            this.infoButton.Text = "Info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(138, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(552, 441);
            this.panel.TabIndex = 14;
            // 
            // intervalDataBindingSource
            // 
            this.intervalDataBindingSource.DataSource = typeof(ArduinoGui.intervalData);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(690, 441);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.buttonPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AMMOD Malaise Trap";
            this.ConnectionPanel.ResumeLayout(false);
            this.ConnectionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectionIndicator)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intervalDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ConnectionPanel;
        private System.Windows.Forms.PictureBox ConnectionIndicator;
        private System.Windows.Forms.Label ConnectionStatus;
        private System.Windows.Forms.BindingSource intervalDataBindingSource;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer connectionCheckTimer;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button configDataButton;
        private System.Windows.Forms.Button startProgramButton;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button selectProgramButton;
    }
}

