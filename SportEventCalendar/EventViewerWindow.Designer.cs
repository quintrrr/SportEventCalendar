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
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            dateSelectorGroupBox.SuspendLayout();
            sportSelectorGroupBox.SuspendLayout();
            teamViewerGroupBox.SuspendLayout();
            teamSelectorGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // teamSelectorCheckBox
            // 
            teamSelectorCheckBox.BorderStyle = BorderStyle.None;
            teamSelectorCheckBox.CheckOnClick = true;
            teamSelectorCheckBox.FormattingEnabled = true;
            teamSelectorCheckBox.Items.AddRange(new object[] { resources.GetString("teamSelectorCheckBox.Items"), resources.GetString("teamSelectorCheckBox.Items1"), resources.GetString("teamSelectorCheckBox.Items2"), resources.GetString("teamSelectorCheckBox.Items3"), resources.GetString("teamSelectorCheckBox.Items4"), resources.GetString("teamSelectorCheckBox.Items5"), resources.GetString("teamSelectorCheckBox.Items6"), resources.GetString("teamSelectorCheckBox.Items7") });
            resources.ApplyResources(teamSelectorCheckBox, "teamSelectorCheckBox");
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
            EventDescription.BackColor = Color.White;
            EventDescription.BorderStyle = BorderStyle.None;
            resources.ApplyResources(EventDescription, "EventDescription");
            EventDescription.Name = "EventDescription";
            EventDescription.ReadOnly = true;
            EventDescription.TabStop = false;
            // 
            // EventName
            // 
            EventName.BackColor = Color.White;
            EventName.BorderStyle = BorderStyle.None;
            resources.ApplyResources(EventName, "EventName");
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
            sportSelector.BackColor = Color.White;
            sportSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(sportSelector, "sportSelector");
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
            teamsView.BackColor = Color.White;
            teamsView.BorderStyle = BorderStyle.None;
            resources.ApplyResources(teamsView, "teamsView");
            teamsView.LineColor = Color.White;
            teamsView.Name = "teamsView";
            teamsView.PathSeparator = "";
            teamsView.ShowLines = false;
            teamsView.TabStop = false;
            // 
            // dateSelectorGroupBox
            // 
            dateSelectorGroupBox.Controls.Add(timePicker);
            dateSelectorGroupBox.Controls.Add(label7);
            dateSelectorGroupBox.Controls.Add(finishDate);
            dateSelectorGroupBox.Controls.Add(startDate);
            resources.ApplyResources(dateSelectorGroupBox, "dateSelectorGroupBox");
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
            teamViewerGroupBox.Controls.Add(teamsView);
            resources.ApplyResources(teamViewerGroupBox, "teamViewerGroupBox");
            teamViewerGroupBox.Name = "teamViewerGroupBox";
            teamViewerGroupBox.TabStop = false;
            // 
            // teamSelectorGroupBox
            // 
            teamSelectorGroupBox.Controls.Add(teamSelectorCheckBox);
            resources.ApplyResources(teamSelectorGroupBox, "teamSelectorGroupBox");
            teamSelectorGroupBox.Name = "teamSelectorGroupBox";
            teamSelectorGroupBox.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(EventName);
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.ForeColor = SystemColors.ControlDarkDark;
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // EventViewerWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(EventDescription);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(editButton);
            Controls.Add(sportSelectorGroupBox);
            Controls.Add(dateSelectorGroupBox);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Controls.Add(imageButton);
            Controls.Add(deleteButton);
            Controls.Add(pictureBox);
            Controls.Add(label1);
            Controls.Add(label9);
            Controls.Add(teamSelectorGroupBox);
            Controls.Add(teamViewerGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
    }
}