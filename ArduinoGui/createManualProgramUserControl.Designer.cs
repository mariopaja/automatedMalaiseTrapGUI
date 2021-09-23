
namespace ArduinoGui
{
    partial class createManualProgramUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.startProgramPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.repeat = new System.Windows.Forms.ComboBox();
            this.pauseBottle = new System.Windows.Forms.TextBox();
            this.pauseMins = new System.Windows.Forms.ComboBox();
            this.labelMins = new System.Windows.Forms.Label();
            this.intervalMins = new System.Windows.Forms.ComboBox();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelDays = new System.Windows.Forms.Label();
            this.labelBottle = new System.Windows.Forms.Label();
            this.pauseLabel = new System.Windows.Forms.Label();
            this.intervalDataLabel = new System.Windows.Forms.Label();
            this.startTimeLabel = new System.Windows.Forms.Label();
            this.addPauseButton = new System.Windows.Forms.Button();
            this.pauseHours = new System.Windows.Forms.ComboBox();
            this.pauseDays = new System.Windows.Forms.ComboBox();
            this.intervalHours = new System.Windows.Forms.ComboBox();
            this.intervalDays = new System.Windows.Forms.ComboBox();
            this.addInterval = new System.Windows.Forms.Button();
            this.intervalBottle = new System.Windows.Forms.ComboBox();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.transferDataButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.minsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.bottleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intervalDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startProgramPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startProgramPanel
            // 
            this.startProgramPanel.Controls.Add(this.label1);
            this.startProgramPanel.Controls.Add(this.repeat);
            this.startProgramPanel.Controls.Add(this.pauseBottle);
            this.startProgramPanel.Controls.Add(this.pauseMins);
            this.startProgramPanel.Controls.Add(this.labelMins);
            this.startProgramPanel.Controls.Add(this.intervalMins);
            this.startProgramPanel.Controls.Add(this.labelHours);
            this.startProgramPanel.Controls.Add(this.labelDays);
            this.startProgramPanel.Controls.Add(this.labelBottle);
            this.startProgramPanel.Controls.Add(this.pauseLabel);
            this.startProgramPanel.Controls.Add(this.intervalDataLabel);
            this.startProgramPanel.Controls.Add(this.startTimeLabel);
            this.startProgramPanel.Controls.Add(this.addPauseButton);
            this.startProgramPanel.Controls.Add(this.pauseHours);
            this.startProgramPanel.Controls.Add(this.pauseDays);
            this.startProgramPanel.Controls.Add(this.intervalHours);
            this.startProgramPanel.Controls.Add(this.intervalDays);
            this.startProgramPanel.Controls.Add(this.addInterval);
            this.startProgramPanel.Controls.Add(this.intervalBottle);
            this.startProgramPanel.Controls.Add(this.startTimePicker);
            this.startProgramPanel.Controls.Add(this.transferDataButton);
            this.startProgramPanel.Controls.Add(this.dataGridView);
            this.startProgramPanel.Location = new System.Drawing.Point(4, 5);
            this.startProgramPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startProgramPanel.Name = "startProgramPanel";
            this.startProgramPanel.Size = new System.Drawing.Size(844, 631);
            this.startProgramPanel.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.Location = new System.Drawing.Point(402, 597);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Repeat :";
            // 
            // repeat
            // 
            this.repeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.repeat.DropDownWidth = 60;
            this.repeat.Font = new System.Drawing.Font("Arial", 9F);
            this.repeat.FormattingEnabled = true;
            this.repeat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.repeat.Location = new System.Drawing.Point(486, 591);
            this.repeat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.repeat.Name = "repeat";
            this.repeat.Size = new System.Drawing.Size(67, 29);
            this.repeat.TabIndex = 47;
            // 
            // pauseBottle
            // 
            this.pauseBottle.Enabled = false;
            this.pauseBottle.Font = new System.Drawing.Font("Arial", 9F);
            this.pauseBottle.Location = new System.Drawing.Point(120, 136);
            this.pauseBottle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pauseBottle.Multiline = true;
            this.pauseBottle.Name = "pauseBottle";
            this.pauseBottle.Size = new System.Drawing.Size(61, 33);
            this.pauseBottle.TabIndex = 46;
            this.pauseBottle.Text = "13";
            // 
            // pauseMins
            // 
            this.pauseMins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pauseMins.Font = new System.Drawing.Font("Arial", 9F);
            this.pauseMins.FormattingEnabled = true;
            this.pauseMins.Items.AddRange(new object[] {
            "0",
            "15",
            "30",
            "45"});
            this.pauseMins.Location = new System.Drawing.Point(490, 136);
            this.pauseMins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pauseMins.Name = "pauseMins";
            this.pauseMins.Size = new System.Drawing.Size(132, 29);
            this.pauseMins.TabIndex = 45;
            // 
            // labelMins
            // 
            this.labelMins.AutoSize = true;
            this.labelMins.Font = new System.Drawing.Font("Arial", 9F);
            this.labelMins.Location = new System.Drawing.Point(490, 70);
            this.labelMins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMins.Name = "labelMins";
            this.labelMins.Size = new System.Drawing.Size(133, 21);
            this.labelMins.TabIndex = 44;
            this.labelMins.Text = "Duration (Mins)";
            // 
            // intervalMins
            // 
            this.intervalMins.AccessibleName = "";
            this.intervalMins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intervalMins.Font = new System.Drawing.Font("Arial", 9F);
            this.intervalMins.FormattingEnabled = true;
            this.intervalMins.Items.AddRange(new object[] {
            "0",
            "15",
            "30",
            "45"});
            this.intervalMins.Location = new System.Drawing.Point(490, 94);
            this.intervalMins.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.intervalMins.Name = "intervalMins";
            this.intervalMins.Size = new System.Drawing.Size(132, 29);
            this.intervalMins.TabIndex = 43;
            this.intervalMins.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intervalMins_KeyPress);
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Arial", 9F);
            this.labelHours.Location = new System.Drawing.Point(336, 70);
            this.labelHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(143, 21);
            this.labelHours.TabIndex = 42;
            this.labelHours.Text = "Duration (Hours)";
            // 
            // labelDays
            // 
            this.labelDays.AutoSize = true;
            this.labelDays.Font = new System.Drawing.Font("Arial", 9F);
            this.labelDays.Location = new System.Drawing.Point(192, 70);
            this.labelDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDays.Name = "labelDays";
            this.labelDays.Size = new System.Drawing.Size(136, 21);
            this.labelDays.TabIndex = 41;
            this.labelDays.Text = "Duration (Days)";
            // 
            // labelBottle
            // 
            this.labelBottle.AutoSize = true;
            this.labelBottle.Font = new System.Drawing.Font("Arial", 9F);
            this.labelBottle.Location = new System.Drawing.Point(123, 70);
            this.labelBottle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBottle.Name = "labelBottle";
            this.labelBottle.Size = new System.Drawing.Size(56, 21);
            this.labelBottle.TabIndex = 40;
            this.labelBottle.Text = "Bottle";
            // 
            // pauseLabel
            // 
            this.pauseLabel.AutoSize = true;
            this.pauseLabel.Font = new System.Drawing.Font("Arial", 9F);
            this.pauseLabel.Location = new System.Drawing.Point(2, 140);
            this.pauseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pauseLabel.Name = "pauseLabel";
            this.pauseLabel.Size = new System.Drawing.Size(109, 21);
            this.pauseLabel.TabIndex = 39;
            this.pauseLabel.Text = "Pause Data:";
            // 
            // intervalDataLabel
            // 
            this.intervalDataLabel.AutoSize = true;
            this.intervalDataLabel.Font = new System.Drawing.Font("Arial", 9F);
            this.intervalDataLabel.Location = new System.Drawing.Point(2, 99);
            this.intervalDataLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.intervalDataLabel.Name = "intervalDataLabel";
            this.intervalDataLabel.Size = new System.Drawing.Size(116, 21);
            this.intervalDataLabel.TabIndex = 38;
            this.intervalDataLabel.Text = "Interval Data:";
            // 
            // startTimeLabel
            // 
            this.startTimeLabel.AutoSize = true;
            this.startTimeLabel.Font = new System.Drawing.Font("Arial", 9F);
            this.startTimeLabel.Location = new System.Drawing.Point(4, 14);
            this.startTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startTimeLabel.Name = "startTimeLabel";
            this.startTimeLabel.Size = new System.Drawing.Size(121, 21);
            this.startTimeLabel.TabIndex = 37;
            this.startTimeLabel.Text = "Starting Time:";
            // 
            // addPauseButton
            // 
            this.addPauseButton.Font = new System.Drawing.Font("Arial", 9F);
            this.addPauseButton.Location = new System.Drawing.Point(633, 134);
            this.addPauseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addPauseButton.Name = "addPauseButton";
            this.addPauseButton.Size = new System.Drawing.Size(159, 37);
            this.addPauseButton.TabIndex = 36;
            this.addPauseButton.Text = "Add Pause";
            this.addPauseButton.UseVisualStyleBackColor = true;
            this.addPauseButton.Click += new System.EventHandler(this.addPauseButton_Click);
            // 
            // pauseHours
            // 
            this.pauseHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pauseHours.Font = new System.Drawing.Font("Arial", 9F);
            this.pauseHours.FormattingEnabled = true;
            this.pauseHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.pauseHours.Location = new System.Drawing.Point(338, 136);
            this.pauseHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pauseHours.Name = "pauseHours";
            this.pauseHours.Size = new System.Drawing.Size(142, 29);
            this.pauseHours.TabIndex = 35;
            // 
            // pauseDays
            // 
            this.pauseDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pauseDays.Font = new System.Drawing.Font("Arial", 9F);
            this.pauseDays.FormattingEnabled = true;
            this.pauseDays.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.pauseDays.Location = new System.Drawing.Point(192, 136);
            this.pauseDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pauseDays.Name = "pauseDays";
            this.pauseDays.Size = new System.Drawing.Size(134, 29);
            this.pauseDays.TabIndex = 34;
            // 
            // intervalHours
            // 
            this.intervalHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intervalHours.Font = new System.Drawing.Font("Arial", 9F);
            this.intervalHours.FormattingEnabled = true;
            this.intervalHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.intervalHours.Location = new System.Drawing.Point(338, 94);
            this.intervalHours.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.intervalHours.Name = "intervalHours";
            this.intervalHours.Size = new System.Drawing.Size(142, 29);
            this.intervalHours.TabIndex = 33;
            // 
            // intervalDays
            // 
            this.intervalDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intervalDays.Font = new System.Drawing.Font("Arial", 9F);
            this.intervalDays.FormattingEnabled = true;
            this.intervalDays.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.intervalDays.Location = new System.Drawing.Point(192, 94);
            this.intervalDays.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.intervalDays.Name = "intervalDays";
            this.intervalDays.Size = new System.Drawing.Size(134, 29);
            this.intervalDays.TabIndex = 32;
            // 
            // addInterval
            // 
            this.addInterval.Font = new System.Drawing.Font("Arial", 9F);
            this.addInterval.Location = new System.Drawing.Point(633, 93);
            this.addInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addInterval.Name = "addInterval";
            this.addInterval.Size = new System.Drawing.Size(159, 37);
            this.addInterval.TabIndex = 31;
            this.addInterval.Text = "Add Interval";
            this.addInterval.UseVisualStyleBackColor = true;
            this.addInterval.Click += new System.EventHandler(this.addInterval_Click);
            // 
            // intervalBottle
            // 
            this.intervalBottle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intervalBottle.Font = new System.Drawing.Font("Arial", 9F);
            this.intervalBottle.FormattingEnabled = true;
            this.intervalBottle.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.intervalBottle.Location = new System.Drawing.Point(120, 94);
            this.intervalBottle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.intervalBottle.Name = "intervalBottle";
            this.intervalBottle.Size = new System.Drawing.Size(61, 29);
            this.intervalBottle.TabIndex = 30;
            // 
            // startTimePicker
            // 
            this.startTimePicker.Font = new System.Drawing.Font("Arial", 9F);
            this.startTimePicker.Location = new System.Drawing.Point(153, 12);
            this.startTimePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(356, 28);
            this.startTimePicker.TabIndex = 29;
            // 
            // transferDataButton
            // 
            this.transferDataButton.Font = new System.Drawing.Font("Arial", 9F);
            this.transferDataButton.Location = new System.Drawing.Point(577, 587);
            this.transferDataButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.transferDataButton.Name = "transferDataButton";
            this.transferDataButton.Size = new System.Drawing.Size(210, 35);
            this.transferDataButton.TabIndex = 28;
            this.transferDataButton.Text = "Create Program File";
            this.transferDataButton.UseVisualStyleBackColor = true;
            this.transferDataButton.Click += new System.EventHandler(this.transferDataButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bottleDataGridViewTextBoxColumn,
            this.daysDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn,
            this.minsDataGridViewTextBoxColumn,
            this.Delete});
            this.dataGridView.DataSource = this.intervalDataBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(6, 189);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.Size = new System.Drawing.Size(782, 388);
            this.dataGridView.TabIndex = 27;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView_RowPostPaint);
            // 
            // minsDataGridViewTextBoxColumn
            // 
            this.minsDataGridViewTextBoxColumn.DataPropertyName = "mins";
            this.minsDataGridViewTextBoxColumn.HeaderText = "Minutes";
            this.minsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.minsDataGridViewTextBoxColumn.Name = "minsDataGridViewTextBoxColumn";
            this.minsDataGridViewTextBoxColumn.ReadOnly = true;
            this.minsDataGridViewTextBoxColumn.Width = 150;
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 8;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 70;
            // 
            // bottleDataGridViewTextBoxColumn
            // 
            this.bottleDataGridViewTextBoxColumn.DataPropertyName = "bottle";
            this.bottleDataGridViewTextBoxColumn.HeaderText = "Bottle";
            this.bottleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bottleDataGridViewTextBoxColumn.Name = "bottleDataGridViewTextBoxColumn";
            this.bottleDataGridViewTextBoxColumn.ReadOnly = true;
            this.bottleDataGridViewTextBoxColumn.Width = 150;
            // 
            // daysDataGridViewTextBoxColumn
            // 
            this.daysDataGridViewTextBoxColumn.DataPropertyName = "days";
            this.daysDataGridViewTextBoxColumn.HeaderText = "Days";
            this.daysDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.daysDataGridViewTextBoxColumn.Name = "daysDataGridViewTextBoxColumn";
            this.daysDataGridViewTextBoxColumn.ReadOnly = true;
            this.daysDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Hours";
            this.hoursDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            this.hoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.hoursDataGridViewTextBoxColumn.Width = 150;
            // 
            // intervalDataBindingSource
            // 
            this.intervalDataBindingSource.DataSource = typeof(ArduinoGui.intervalData);
            // 
            // startProgramUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.startProgramPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "startProgramUserControl";
            this.Size = new System.Drawing.Size(854, 640);
            this.startProgramPanel.ResumeLayout(false);
            this.startProgramPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel startProgramPanel;
        private System.Windows.Forms.Label pauseLabel;
        private System.Windows.Forms.Label intervalDataLabel;
        private System.Windows.Forms.Label startTimeLabel;
        private System.Windows.Forms.Button addPauseButton;
        private System.Windows.Forms.ComboBox pauseHours;
        private System.Windows.Forms.ComboBox pauseDays;
        private System.Windows.Forms.ComboBox intervalHours;
        private System.Windows.Forms.ComboBox intervalDays;
        private System.Windows.Forms.Button addInterval;
        private System.Windows.Forms.ComboBox intervalBottle;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Button transferDataButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label labelBottle;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelDays;
        private System.Windows.Forms.Label labelMins;
        private System.Windows.Forms.ComboBox intervalMins;
        private System.Windows.Forms.TextBox pauseBottle;
        private System.Windows.Forms.ComboBox pauseMins;
        private System.Windows.Forms.BindingSource intervalDataBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bottleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.ComboBox repeat;
        private System.Windows.Forms.Label label1;
    }
}
