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
            teamSelectorCheckBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            teamSelectorCheckBox.Location = new Point(4, 17);
            teamSelectorCheckBox.Margin = new Padding(2, 1, 2, 1);
            teamSelectorCheckBox.Name = "teamSelectorCheckBox";
            teamSelectorCheckBox.Size = new Size(559, 108);
            teamSelectorCheckBox.TabIndex = 0;
            // 
            // timePicker
            // 
            timePicker.CustomFormat = "hh:mm";
            timePicker.Enabled = false;
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.Location = new Point(484, 30);
            timePicker.Margin = new Padding(2, 1, 2, 1);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(79, 23);
            timePicker.TabIndex = 40;
            timePicker.TabStop = false;
            // 
            // imageButton
            // 
            imageButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imageButton.BackColor = Color.White;
            imageButton.FlatStyle = FlatStyle.Popup;
            imageButton.Location = new Point(608, 293);
            imageButton.Margin = new Padding(2, 1, 2, 1);
            imageButton.Name = "imageButton";
            imageButton.Size = new Size(303, 22);
            imageButton.TabIndex = 39;
            imageButton.TabStop = false;
            imageButton.Text = "Изменить изображениe";
            imageButton.UseVisualStyleBackColor = false;
            imageButton.Visible = false;
            imageButton.Click += imageButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.FlatAppearance.BorderColor = Color.Silver;
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Location = new Point(709, 542);
            deleteButton.Margin = new Padding(2, 1, 2, 1);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(99, 22);
            deleteButton.TabIndex = 37;
            deleteButton.TabStop = false;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.ImageLocation = "";
            pictureBox.Location = new Point(607, 58);
            pictureBox.Margin = new Padding(2, 1, 2, 1);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(304, 221);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 36;
            pictureBox.TabStop = false;
            // 
            // startDate
            // 
            startDate.Enabled = false;
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(5, 30);
            startDate.Margin = new Padding(2, 1, 2, 1);
            startDate.Name = "startDate";
            startDate.Size = new Size(98, 23);
            startDate.TabIndex = 32;
            startDate.TabStop = false;
            // 
            // finishDate
            // 
            finishDate.Enabled = false;
            finishDate.Format = DateTimePickerFormat.Short;
            finishDate.Location = new Point(125, 30);
            finishDate.Margin = new Padding(2, 1, 2, 1);
            finishDate.Name = "finishDate";
            finishDate.Size = new Size(98, 23);
            finishDate.TabIndex = 33;
            finishDate.TabStop = false;
            // 
            // EventDescription
            // 
            EventDescription.BackColor = Color.White;
            EventDescription.BorderStyle = BorderStyle.None;
            EventDescription.Font = new Font("Segoe UI", 15F);
            EventDescription.Location = new Point(11, 155);
            EventDescription.Margin = new Padding(2, 1, 2, 1);
            EventDescription.MaxLength = 1000;
            EventDescription.Multiline = true;
            EventDescription.Name = "EventDescription";
            EventDescription.PlaceholderText = " Введите описание";
            EventDescription.ReadOnly = true;
            EventDescription.ScrollBars = ScrollBars.Vertical;
            EventDescription.Size = new Size(560, 143);
            EventDescription.TabIndex = 27;
            EventDescription.TabStop = false;
            // 
            // EventName
            // 
            EventName.BackColor = Color.White;
            EventName.BorderStyle = BorderStyle.None;
            EventName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EventName.Location = new Point(8, 26);
            EventName.Margin = new Padding(2, 1, 2, 1);
            EventName.MaxLength = 100;
            EventName.Name = "EventName";
            EventName.PlaceholderText = "Введите название";
            EventName.ReadOnly = true;
            EventName.Size = new Size(546, 27);
            EventName.TabIndex = 26;
            EventName.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 25F, FontStyle.Bold);
            label1.Location = new Point(86, -38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 41);
            label1.TabIndex = 25;
            label1.Text = "Новое событие";
            // 
            // sportSelector
            // 
            sportSelector.BackColor = Color.White;
            sportSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            sportSelector.FlatStyle = FlatStyle.Flat;
            sportSelector.FormattingEnabled = true;
            sportSelector.Location = new Point(4, 18);
            sportSelector.Margin = new Padding(2, 1, 2, 1);
            sportSelector.Name = "sportSelector";
            sportSelector.Size = new Size(295, 23);
            sportSelector.TabIndex = 34;
            sportSelector.SelectedIndexChanged += sportSelector_SelectedIndexChanged;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editButton.FlatAppearance.BorderColor = Color.Silver;
            editButton.FlatStyle = FlatStyle.Popup;
            editButton.Location = new Point(812, 542);
            editButton.Margin = new Padding(2, 1, 2, 1);
            editButton.Name = "editButton";
            editButton.Size = new Size(99, 22);
            editButton.TabIndex = 45;
            editButton.TabStop = false;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.BackColor = Color.White;
            cancelButton.FlatAppearance.BorderColor = Color.Silver;
            cancelButton.FlatStyle = FlatStyle.Popup;
            cancelButton.ForeColor = SystemColors.ControlText;
            cancelButton.Location = new Point(709, 542);
            cancelButton.Margin = new Padding(2, 1, 2, 1);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(99, 22);
            cancelButton.TabIndex = 46;
            cancelButton.TabStop = false;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Visible = false;
            cancelButton.Click += cancel2Button_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(105, 34);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 47;
            label7.Text = "—";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 25F, FontStyle.Bold);
            label9.Location = new Point(8, 9);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(372, 41);
            label9.TabIndex = 48;
            label9.Text = "Подробности о событии";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.FlatAppearance.BorderColor = Color.Silver;
            saveButton.FlatStyle = FlatStyle.Popup;
            saveButton.Location = new Point(812, 542);
            saveButton.Margin = new Padding(2, 1, 2, 1);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(99, 22);
            saveButton.TabIndex = 49;
            saveButton.TabStop = false;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Visible = false;
            saveButton.Click += saveButton_Click;
            // 
            // teamsView
            // 
            teamsView.BackColor = Color.White;
            teamsView.BorderStyle = BorderStyle.None;
            teamsView.Indent = 5;
            teamsView.LineColor = Color.White;
            teamsView.Location = new Point(4, 18);
            teamsView.Margin = new Padding(2, 1, 2, 1);
            teamsView.Name = "teamsView";
            teamsView.PathSeparator = "";
            teamsView.ShowLines = false;
            teamsView.Size = new Size(559, 108);
            teamsView.TabIndex = 51;
            teamsView.TabStop = false;
            // 
            // dateSelectorGroupBox
            // 
            dateSelectorGroupBox.Controls.Add(timePicker);
            dateSelectorGroupBox.Controls.Add(label7);
            dateSelectorGroupBox.Controls.Add(finishDate);
            dateSelectorGroupBox.Controls.Add(startDate);
            dateSelectorGroupBox.Location = new Point(8, 310);
            dateSelectorGroupBox.Margin = new Padding(2, 1, 2, 1);
            dateSelectorGroupBox.Name = "dateSelectorGroupBox";
            dateSelectorGroupBox.Padding = new Padding(2, 1, 2, 1);
            dateSelectorGroupBox.Size = new Size(569, 71);
            dateSelectorGroupBox.TabIndex = 51;
            dateSelectorGroupBox.TabStop = false;
            dateSelectorGroupBox.Text = "Дата и время";
            // 
            // sportSelectorGroupBox
            // 
            sportSelectorGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sportSelectorGroupBox.Controls.Add(sportSelector);
            sportSelectorGroupBox.Location = new Point(607, 326);
            sportSelectorGroupBox.Margin = new Padding(2, 1, 2, 1);
            sportSelectorGroupBox.Name = "sportSelectorGroupBox";
            sportSelectorGroupBox.Padding = new Padding(2, 1, 2, 1);
            sportSelectorGroupBox.Size = new Size(303, 55);
            sportSelectorGroupBox.TabIndex = 52;
            sportSelectorGroupBox.TabStop = false;
            sportSelectorGroupBox.Text = "Вид спорта";
            // 
            // teamViewerGroupBox
            // 
            teamViewerGroupBox.Controls.Add(teamsView);
            teamViewerGroupBox.Location = new Point(8, 390);
            teamViewerGroupBox.Margin = new Padding(2, 1, 2, 1);
            teamViewerGroupBox.Name = "teamViewerGroupBox";
            teamViewerGroupBox.Padding = new Padding(2, 1, 2, 1);
            teamViewerGroupBox.Size = new Size(569, 133);
            teamViewerGroupBox.TabIndex = 53;
            teamViewerGroupBox.TabStop = false;
            teamViewerGroupBox.Text = "Команды";
            // 
            // teamSelectorGroupBox
            // 
            teamSelectorGroupBox.Controls.Add(teamSelectorCheckBox);
            teamSelectorGroupBox.Location = new Point(8, 390);
            teamSelectorGroupBox.Margin = new Padding(2, 1, 2, 1);
            teamSelectorGroupBox.Name = "teamSelectorGroupBox";
            teamSelectorGroupBox.Padding = new Padding(2, 1, 2, 1);
            teamSelectorGroupBox.Size = new Size(569, 133);
            teamSelectorGroupBox.TabIndex = 54;
            teamSelectorGroupBox.TabStop = false;
            teamSelectorGroupBox.Text = "Выбор команд";
            teamSelectorGroupBox.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(EventName);
            groupBox1.Font = new Font("Segoe UI", 12F);
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Location = new Point(8, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(569, 75);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Название";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.ForeColor = SystemColors.ControlDarkDark;
            groupBox2.Location = new Point(8, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(569, 177);
            groupBox2.TabIndex = 56;
            groupBox2.TabStop = false;
            groupBox2.Text = "Описание";
            // 
            // EventViewerWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(922, 576);
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
            Margin = new Padding(2, 1, 2, 1);
            MinimumSize = new Size(938, 615);
            Name = "EventViewerWindow";
            Text = "EventViewerWindow";
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