namespace SportEventCalendar
{
    partial class EventViewerWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventViewerWindow));
            teamSelectorCheckBox = new CheckedListBox();
            timePicker = new DateTimePicker();
            imageButton = new Button();
            deleteButton = new Button();
            pictureBox = new PictureBox();
            startDate = new DateTimePicker();
            finishDate = new DateTimePicker();
            EventDescription = new TextBox();
            EventName = new TextBox();
            label1 = new Label();
            sportSelector = new ComboBox();
            editButton = new Button();
            cancelButton = new Button();
            label7 = new Label();
            label9 = new Label();
            saveButton = new Button();
            teamsView = new TreeView();
            openFileDialog = new OpenFileDialog();
            dateSelectorGroupBox = new GroupBox();
            sportSelectorGroupBox = new GroupBox();
            teamViewerGroupBox = new GroupBox();
            teamSelectorGroupBox = new GroupBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            dateSelectorGroupBox.SuspendLayout();
            sportSelectorGroupBox.SuspendLayout();
            teamViewerGroupBox.SuspendLayout();
            teamSelectorGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // teamSelectorCheckBox
            // 
            resources.ApplyResources(teamSelectorCheckBox, "teamSelectorCheckBox");
            teamSelectorCheckBox.BorderStyle = BorderStyle.None;
            teamSelectorCheckBox.CheckOnClick = true;
            teamSelectorCheckBox.FormattingEnabled = true;
            teamSelectorCheckBox.Items.AddRange(new object[] { resources.GetString("teamSelectorCheckBox.Items"), resources.GetString("teamSelectorCheckBox.Items1"), resources.GetString("teamSelectorCheckBox.Items2"), resources.GetString("teamSelectorCheckBox.Items3"), resources.GetString("teamSelectorCheckBox.Items4"), resources.GetString("teamSelectorCheckBox.Items5"), resources.GetString("teamSelectorCheckBox.Items6"), resources.GetString("teamSelectorCheckBox.Items7") });
            teamSelectorCheckBox.Name = "teamSelectorCheckBox";
            // 
            // timePicker
            // 
            resources.ApplyResources(timePicker, "timePicker");
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.TabStop = false;
            // 
            // imageButton
            // 
            resources.ApplyResources(imageButton, "imageButton");
            imageButton.BackColor = Color.White;
            imageButton.FlatAppearance.BorderColor = Color.Silver;
            imageButton.Name = "imageButton";
            imageButton.TabStop = false;
            imageButton.UseVisualStyleBackColor = false;
            imageButton.Click += imageButton_Click;
            // 
            // deleteButton
            // 
            resources.ApplyResources(deleteButton, "deleteButton");
            deleteButton.FlatAppearance.BorderColor = Color.Silver;
            deleteButton.Name = "deleteButton";
            deleteButton.TabStop = false;
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // pictureBox
            // 
            resources.ApplyResources(pictureBox, "pictureBox");
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Name = "pictureBox";
            pictureBox.TabStop = false;
            // 
            // startDate
            // 
            resources.ApplyResources(startDate, "startDate");
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Name = "startDate";
            startDate.TabStop = false;
            // 
            // finishDate
            // 
            resources.ApplyResources(finishDate, "finishDate");
            finishDate.Format = DateTimePickerFormat.Short;
            finishDate.Name = "finishDate";
            finishDate.TabStop = false;
            // 
            // EventDescription
            // 
            resources.ApplyResources(EventDescription, "EventDescription");
            EventDescription.BackColor = Color.White;
            EventDescription.BorderStyle = BorderStyle.None;
            EventDescription.Name = "EventDescription";
            EventDescription.ReadOnly = true;
            EventDescription.TabStop = false;
            // 
            // EventName
            // 
            resources.ApplyResources(EventName, "EventName");
            EventName.BackColor = Color.White;
            EventName.BorderStyle = BorderStyle.None;
            EventName.Name = "EventName";
            EventName.ReadOnly = true;
            EventName.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // sportSelector
            // 
            resources.ApplyResources(sportSelector, "sportSelector");
            sportSelector.BackColor = Color.White;
            sportSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            sportSelector.FormattingEnabled = true;
            sportSelector.Name = "sportSelector";
            sportSelector.SelectedIndexChanged += sportSelector_SelectedIndexChanged;
            // 
            // editButton
            // 
            resources.ApplyResources(editButton, "editButton");
            editButton.FlatAppearance.BorderColor = Color.Silver;
            editButton.Name = "editButton";
            editButton.TabStop = false;
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // cancelButton
            // 
            resources.ApplyResources(cancelButton, "cancelButton");
            cancelButton.BackColor = Color.White;
            cancelButton.FlatAppearance.BorderColor = Color.Silver;
            cancelButton.ForeColor = SystemColors.ControlText;
            cancelButton.Name = "cancelButton";
            cancelButton.TabStop = false;
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancel2Button_Click;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // saveButton
            // 
            resources.ApplyResources(saveButton, "saveButton");
            saveButton.FlatAppearance.BorderColor = Color.Silver;
            saveButton.Name = "saveButton";
            saveButton.TabStop = false;
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // teamsView
            // 
            resources.ApplyResources(teamsView, "teamsView");
            teamsView.BackColor = Color.White;
            teamsView.BorderStyle = BorderStyle.None;
            teamsView.LineColor = Color.White;
            teamsView.Name = "teamsView";
            teamsView.PathSeparator = "";
            teamsView.ShowLines = false;
            teamsView.TabStop = false;
            // 
            // openFileDialog
            // 
            resources.ApplyResources(openFileDialog, "openFileDialog");
            // 
            // dateSelectorGroupBox
            // 
            resources.ApplyResources(dateSelectorGroupBox, "dateSelectorGroupBox");
            dateSelectorGroupBox.Controls.Add(timePicker);
            dateSelectorGroupBox.Controls.Add(label7);
            dateSelectorGroupBox.Controls.Add(finishDate);
            dateSelectorGroupBox.Controls.Add(startDate);
            dateSelectorGroupBox.Name = "dateSelectorGroupBox";
            dateSelectorGroupBox.TabStop = false;
            // 
            // sportSelectorGroupBox
            // 
            resources.ApplyResources(sportSelectorGroupBox, "sportSelectorGroupBox");
            sportSelectorGroupBox.Controls.Add(sportSelector);
            sportSelectorGroupBox.Name = "sportSelectorGroupBox";
            sportSelectorGroupBox.TabStop = false;
            // 
            // teamViewerGroupBox
            // 
            resources.ApplyResources(teamViewerGroupBox, "teamViewerGroupBox");
            teamViewerGroupBox.Controls.Add(teamsView);
            teamViewerGroupBox.Name = "teamViewerGroupBox";
            teamViewerGroupBox.TabStop = false;
            // 
            // teamSelectorGroupBox
            // 
            resources.ApplyResources(teamSelectorGroupBox, "teamSelectorGroupBox");
            teamSelectorGroupBox.Controls.Add(teamSelectorCheckBox);
            teamSelectorGroupBox.Name = "teamSelectorGroupBox";
            teamSelectorGroupBox.TabStop = false;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(EventName);
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(EventDescription);
            groupBox2.ForeColor = SystemColors.ControlDarkDark;
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Controls.Add(dateSelectorGroupBox);
            panel2.Controls.Add(teamSelectorGroupBox);
            panel2.Controls.Add(teamViewerGroupBox);
            panel2.Name = "panel2";
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.Controls.Add(pictureBox);
            panel3.Controls.Add(imageButton);
            panel3.Name = "panel3";
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.Controls.Add(sportSelectorGroupBox);
            panel4.Name = "panel4";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // EventViewerWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(editButton);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Controls.Add(deleteButton);
            Controls.Add(label1);
            Controls.Add(label9);
            Name = "EventViewerWindow";
            Load += EventViewerWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            dateSelectorGroupBox.ResumeLayout(false);
            dateSelectorGroupBox.PerformLayout();
            sportSelectorGroupBox.ResumeLayout(false);
            teamViewerGroupBox.ResumeLayout(false);
            teamSelectorGroupBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox teamSelectorCheckBox;
        private DateTimePicker timePicker;
        private Button imageButton;
        private Button deleteButton;
        private PictureBox pictureBox;
        private DateTimePicker startDate;
        private DateTimePicker finishDate;
        private TextBox EventDescription;
        private TextBox EventName;
        private Label label1;
        private ComboBox sportSelector;
        private Button editButton;
        private Label sportName;
        private Button cancelButton;
        private Label label7;
        private Label label9;
        private Button saveButton;
        private OpenFileDialog openFileDialog;
        private TreeView teamsView;
        private GroupBox dateSelectorGroupBox;
        private GroupBox sportSelectorGroupBox;
        private GroupBox teamViewerGroupBox;
        private GroupBox teamSelectorGroupBox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
    }
}