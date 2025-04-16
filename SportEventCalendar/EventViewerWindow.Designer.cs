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
            label5 = new Label();
            EventDescription = new TextBox();
            label4 = new Label();
            label2 = new Label();
            EventName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            sportSelector = new ComboBox();
            editButton = new Button();
            cancel2Button = new Button();
            label7 = new Label();
            label9 = new Label();
            saveButton = new Button();
            teamsView = new TreeView();
            openFileDialog = new OpenFileDialog();
            dateSelectorGroupBox = new GroupBox();
            sportSelectorGroupBox = new GroupBox();
            teamViewerGroupBox = new GroupBox();
            teamSelectorGroupBox = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            dateSelectorGroupBox.SuspendLayout();
            sportSelectorGroupBox.SuspendLayout();
            teamViewerGroupBox.SuspendLayout();
            teamSelectorGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamSelectorCheckBox
            // 
            teamSelectorCheckBox.CheckOnClick = true;
            teamSelectorCheckBox.FormattingEnabled = true;
            teamSelectorCheckBox.Items.AddRange(new object[] { "1", "2", "3", "4" });
            teamSelectorCheckBox.Location = new Point(7, 37);
            teamSelectorCheckBox.Margin = new Padding(4, 2, 4, 2);
            teamSelectorCheckBox.Name = "teamSelectorCheckBox";
            teamSelectorCheckBox.Size = new Size(1024, 292);
            teamSelectorCheckBox.TabIndex = 0;
            // 
            // timePicker
            // 
            timePicker.CustomFormat = "hh:mm";
            timePicker.Enabled = false;
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.Location = new Point(844, 65);
            timePicker.Margin = new Padding(4, 2, 4, 2);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(143, 39);
            timePicker.TabIndex = 40;
            timePicker.TabStop = false;
            // 
            // imageButton
            // 
            imageButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imageButton.Location = new Point(1098, 540);
            imageButton.Margin = new Padding(4, 2, 4, 2);
            imageButton.Name = "imageButton";
            imageButton.Size = new Size(497, 47);
            imageButton.TabIndex = 39;
            imageButton.TabStop = false;
            imageButton.Text = "Изменить изображениe";
            imageButton.UseVisualStyleBackColor = true;
            imageButton.Visible = false;
            imageButton.Click += imageButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.Location = new Point(1202, 1102);
            deleteButton.Margin = new Padding(4, 2, 4, 2);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(184, 47);
            deleteButton.TabIndex = 37;
            deleteButton.TabStop = false;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox.ImageLocation = "";
            pictureBox.Location = new Point(1098, 94);
            pictureBox.Margin = new Padding(4, 2, 4, 2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(498, 412);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 36;
            pictureBox.TabStop = false;
            // 
            // startDate
            // 
            startDate.Enabled = false;
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(19, 65);
            startDate.Margin = new Padding(4, 2, 4, 2);
            startDate.Name = "startDate";
            startDate.Size = new Size(179, 39);
            startDate.TabIndex = 32;
            startDate.TabStop = false;
            // 
            // finishDate
            // 
            finishDate.Enabled = false;
            finishDate.Format = DateTimePickerFormat.Short;
            finishDate.Location = new Point(248, 65);
            finishDate.Margin = new Padding(4, 2, 4, 2);
            finishDate.Name = "finishDate";
            finishDate.Size = new Size(181, 39);
            finishDate.TabIndex = 33;
            finishDate.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(15, 243);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(449, 37);
            label5.TabIndex = 31;
            label5.Text = "Описание                                            ";
            // 
            // EventDescription
            // 
            EventDescription.BackColor = Color.White;
            EventDescription.BorderStyle = BorderStyle.None;
            EventDescription.Font = new Font("Segoe UI", 15F);
            EventDescription.Location = new Point(15, 284);
            EventDescription.Margin = new Padding(4, 2, 4, 2);
            EventDescription.MaxLength = 1000;
            EventDescription.Multiline = true;
            EventDescription.Name = "EventDescription";
            EventDescription.PlaceholderText = " Введите описание";
            EventDescription.ReadOnly = true;
            EventDescription.Size = new Size(1034, 339);
            EventDescription.TabIndex = 27;
            EventDescription.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 110F);
            label4.Location = new Point(13, 241);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(1057, 393);
            label4.TabIndex = 30;
            label4.Text = "           ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(13, 94);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(437, 37);
            label2.TabIndex = 28;
            label2.Text = "Название                                           ";
            // 
            // EventName
            // 
            EventName.BackColor = Color.White;
            EventName.BorderStyle = BorderStyle.None;
            EventName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EventName.Location = new Point(24, 139);
            EventName.Margin = new Padding(4, 2, 4, 2);
            EventName.MaxLength = 100;
            EventName.Name = "EventName";
            EventName.PlaceholderText = "Введите название";
            EventName.ReadOnly = true;
            EventName.Size = new Size(1034, 54);
            EventName.TabIndex = 26;
            EventName.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 32F);
            label3.Location = new Point(11, 92);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(1058, 116);
            label3.TabIndex = 29;
            label3.Text = "                                          ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 25F, FontStyle.Bold);
            label1.Location = new Point(160, -81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(476, 82);
            label1.TabIndex = 25;
            label1.Text = "Новое событие";
            // 
            // sportSelector
            // 
            sportSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            sportSelector.FormattingEnabled = true;
            sportSelector.Location = new Point(20, 86);
            sportSelector.Margin = new Padding(4, 2, 4, 2);
            sportSelector.Name = "sportSelector";
            sportSelector.Size = new Size(458, 40);
            sportSelector.TabIndex = 34;
            sportSelector.SelectedIndexChanged += sportSelector_SelectedIndexChanged;
            // 
            // editButton
            // 
            editButton.Location = new Point(1412, 1102);
            editButton.Margin = new Padding(4, 2, 4, 2);
            editButton.Name = "editButton";
            editButton.Size = new Size(184, 47);
            editButton.TabIndex = 45;
            editButton.TabStop = false;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // cancel2Button
            // 
            cancel2Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancel2Button.Location = new Point(1202, 1102);
            cancel2Button.Margin = new Padding(4, 2, 4, 2);
            cancel2Button.Name = "cancel2Button";
            cancel2Button.Size = new Size(184, 47);
            cancel2Button.TabIndex = 46;
            cancel2Button.TabStop = false;
            cancel2Button.Text = "Отмена";
            cancel2Button.UseVisualStyleBackColor = true;
            cancel2Button.Visible = false;
            cancel2Button.Click += cancel2Button_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(204, 69);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(38, 32);
            label7.TabIndex = 47;
            label7.Text = "—";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 25F, FontStyle.Bold);
            label9.Location = new Point(9, 9);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(736, 82);
            label9.TabIndex = 48;
            label9.Text = "Подробности о событии";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(1411, 1102);
            saveButton.Margin = new Padding(4, 2, 4, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(184, 47);
            saveButton.TabIndex = 49;
            saveButton.TabStop = false;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Visible = false;
            saveButton.Click += saveButton_Click;
            // 
            // teamsView
            // 
            teamsView.Indent = 5;
            teamsView.Location = new Point(10, 37);
            teamsView.Margin = new Padding(4, 2, 4, 2);
            teamsView.Name = "teamsView";
            teamsView.PathSeparator = "";
            teamsView.ShowLines = false;
            teamsView.Size = new Size(1024, 292);
            teamsView.TabIndex = 51;
            teamsView.TabStop = false;
            // 
            // dateSelectorGroupBox
            // 
            dateSelectorGroupBox.Controls.Add(timePicker);
            dateSelectorGroupBox.Controls.Add(label7);
            dateSelectorGroupBox.Controls.Add(finishDate);
            dateSelectorGroupBox.Controls.Add(startDate);
            dateSelectorGroupBox.Location = new Point(15, 662);
            dateSelectorGroupBox.Name = "dateSelectorGroupBox";
            dateSelectorGroupBox.Size = new Size(1056, 152);
            dateSelectorGroupBox.TabIndex = 51;
            dateSelectorGroupBox.TabStop = false;
            dateSelectorGroupBox.Text = "Дата и время";
            // 
            // sportSelectorGroupBox
            // 
            sportSelectorGroupBox.Controls.Add(sportSelector);
            sportSelectorGroupBox.Location = new Point(1098, 662);
            sportSelectorGroupBox.Name = "sportSelectorGroupBox";
            sportSelectorGroupBox.Size = new Size(498, 200);
            sportSelectorGroupBox.TabIndex = 52;
            sportSelectorGroupBox.TabStop = false;
            sportSelectorGroupBox.Text = "Вид спорта";
            // 
            // teamViewerGroupBox
            // 
            teamViewerGroupBox.Controls.Add(teamsView);
            teamViewerGroupBox.Location = new Point(24, 832);
            teamViewerGroupBox.Name = "teamViewerGroupBox";
            teamViewerGroupBox.Size = new Size(1047, 351);
            teamViewerGroupBox.TabIndex = 53;
            teamViewerGroupBox.TabStop = false;
            teamViewerGroupBox.Text = "Команды";
            // 
            // teamSelectorGroupBox
            // 
            teamSelectorGroupBox.Controls.Add(teamSelectorCheckBox);
            teamSelectorGroupBox.Location = new Point(15, 826);
            teamSelectorGroupBox.Name = "teamSelectorGroupBox";
            teamSelectorGroupBox.Size = new Size(1050, 351);
            teamSelectorGroupBox.TabIndex = 54;
            teamSelectorGroupBox.TabStop = false;
            teamSelectorGroupBox.Text = "Выбор команд";
            teamSelectorGroupBox.Visible = false;
            // 
            // EventViewerWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1608, 1186);
            Controls.Add(teamSelectorGroupBox);
            Controls.Add(teamViewerGroupBox);
            Controls.Add(editButton);
            Controls.Add(sportSelectorGroupBox);
            Controls.Add(dateSelectorGroupBox);
            Controls.Add(saveButton);
            Controls.Add(label9);
            Controls.Add(cancel2Button);
            Controls.Add(imageButton);
            Controls.Add(deleteButton);
            Controls.Add(pictureBox);
            Controls.Add(label5);
            Controls.Add(EventDescription);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(EventName);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "EventViewerWindow";
            Text = "EventViewerWindow";
            Load += EventViewerWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            dateSelectorGroupBox.ResumeLayout(false);
            dateSelectorGroupBox.PerformLayout();
            sportSelectorGroupBox.ResumeLayout(false);
            teamViewerGroupBox.ResumeLayout(false);
            teamSelectorGroupBox.ResumeLayout(false);
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
        private Label label5;
        private TextBox EventDescription;
        private Label label4;
        private Label label2;
        private TextBox EventName;
        private Label label3;
        private Label label1;
        private ComboBox sportSelector;
        private Button editButton;
        private Label sportName;
        private Button cancel2Button;
        private Label label7;
        private Label label9;
        private Button saveButton;
        private OpenFileDialog openFileDialog;
        private TreeView teamsView;
        private GroupBox dateSelectorGroupBox;
        private GroupBox sportSelectorGroupBox;
        private GroupBox teamViewerGroupBox;
        private GroupBox teamSelectorGroupBox;
    }
}