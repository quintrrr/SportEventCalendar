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
            imageButton = new Button();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            dateSelectorGroupBox.SuspendLayout();
            sportSelectorGroupBox.SuspendLayout();
            teamViewerGroupBox.SuspendLayout();
            teamSelectorGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // teamSelectorCheckBox
            // 
            teamSelectorCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            teamSelectorCheckBox.BorderStyle = BorderStyle.None;
            teamSelectorCheckBox.CheckOnClick = true;
            teamSelectorCheckBox.FormattingEnabled = true;
            teamSelectorCheckBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8" });
            teamSelectorCheckBox.Location = new Point(5, 16);
            teamSelectorCheckBox.Margin = new Padding(2, 1, 2, 1);
            teamSelectorCheckBox.Name = "teamSelectorCheckBox";
            teamSelectorCheckBox.Size = new Size(508, 102);
            teamSelectorCheckBox.TabIndex = 0;
            // 
            // timePicker
            // 
            timePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timePicker.CustomFormat = "hh:mm";
            timePicker.Enabled = false;
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.Location = new Point(410, 28);
            timePicker.Margin = new Padding(2, 1, 2, 1);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(90, 22);
            timePicker.TabIndex = 40;
            timePicker.TabStop = false;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.FlatAppearance.BorderColor = Color.Silver;
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Location = new Point(571, 501);
            deleteButton.Margin = new Padding(2, 1, 2, 1);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(113, 27);
            deleteButton.TabIndex = 37;
            deleteButton.TabStop = false;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.ImageLocation = "";
            pictureBox.Location = new Point(2, 13);
            pictureBox.Margin = new Padding(2, 1, 2, 1);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(293, 172);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 36;
            pictureBox.TabStop = false;
            // 
            // startDate
            // 
            startDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            startDate.Enabled = false;
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(12, 28);
            startDate.Margin = new Padding(2, 1, 2, 1);
            startDate.Name = "startDate";
            startDate.Size = new Size(111, 22);
            startDate.TabIndex = 32;
            startDate.TabStop = false;
            // 
            // finishDate
            // 
            finishDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            finishDate.Enabled = false;
            finishDate.Format = DateTimePickerFormat.Short;
            finishDate.Location = new Point(151, 28);
            finishDate.Margin = new Padding(2, 1, 2, 1);
            finishDate.Name = "finishDate";
            finishDate.Size = new Size(111, 22);
            finishDate.TabIndex = 33;
            finishDate.TabStop = false;
            // 
            // EventDescription
            // 
            EventDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EventDescription.BackColor = Color.White;
            EventDescription.BorderStyle = BorderStyle.None;
            EventDescription.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EventDescription.Location = new Point(7, 103);
            EventDescription.Margin = new Padding(2, 1, 2, 1);
            EventDescription.MaxLength = 1000;
            EventDescription.Multiline = true;
            EventDescription.Name = "EventDescription";
            EventDescription.PlaceholderText = " Введите описание";
            EventDescription.ReadOnly = true;
            EventDescription.ScrollBars = ScrollBars.Vertical;
            EventDescription.Size = new Size(507, 116);
            EventDescription.TabIndex = 27;
            EventDescription.TabStop = false;
            // 
            // EventName
            // 
            EventName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EventName.BackColor = Color.White;
            EventName.BorderStyle = BorderStyle.None;
            EventName.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EventName.Location = new Point(9, 24);
            EventName.Margin = new Padding(2, 1, 2, 1);
            EventName.MaxLength = 100;
            EventName.Name = "EventName";
            EventName.PlaceholderText = "Введите название";
            EventName.ReadOnly = true;
            EventName.Size = new Size(502, 25);
            EventName.TabIndex = 26;
            EventName.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 25F, FontStyle.Bold);
            label1.Location = new Point(98, -35);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 41);
            label1.TabIndex = 25;
            label1.Text = "Новое событие";
            // 
            // sportSelector
            // 
            sportSelector.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sportSelector.BackColor = Color.White;
            sportSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            sportSelector.FormattingEnabled = true;
            sportSelector.Location = new Point(17, 28);
            sportSelector.Margin = new Padding(2, 1, 2, 1);
            sportSelector.Name = "sportSelector";
            sportSelector.Size = new Size(260, 22);
            sportSelector.TabIndex = 34;
            sportSelector.SelectedIndexChanged += sportSelector_SelectedIndexChanged;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editButton.FlatAppearance.BorderColor = Color.Silver;
            editButton.FlatStyle = FlatStyle.Flat;
            editButton.Location = new Point(700, 501);
            editButton.Margin = new Padding(2, 1, 2, 1);
            editButton.Name = "editButton";
            editButton.Size = new Size(140, 27);
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
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.ForeColor = SystemColors.ControlText;
            cancelButton.Location = new Point(571, 501);
            cancelButton.Margin = new Padding(2, 1, 2, 1);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(113, 27);
            cancelButton.TabIndex = 46;
            cancelButton.TabStop = false;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Visible = false;
            cancelButton.Click += cancel2Button_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(128, 31);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(19, 14);
            label7.TabIndex = 47;
            label7.Text = "—";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 25F, FontStyle.Bold);
            label9.Location = new Point(9, 8);
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
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Location = new Point(700, 501);
            saveButton.Margin = new Padding(2, 1, 2, 1);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(140, 27);
            saveButton.TabIndex = 49;
            saveButton.TabStop = false;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Visible = false;
            saveButton.Click += saveButton_Click;
            // 
            // teamsView
            // 
            teamsView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            teamsView.BackColor = Color.White;
            teamsView.BorderStyle = BorderStyle.None;
            teamsView.Indent = 5;
            teamsView.LineColor = Color.White;
            teamsView.Location = new Point(12, 16);
            teamsView.Margin = new Padding(2, 1, 2, 1);
            teamsView.Name = "teamsView";
            teamsView.PathSeparator = "";
            teamsView.ShowLines = false;
            teamsView.Size = new Size(500, 107);
            teamsView.TabIndex = 51;
            teamsView.TabStop = false;
            // 
            // dateSelectorGroupBox
            // 
            dateSelectorGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateSelectorGroupBox.Controls.Add(timePicker);
            dateSelectorGroupBox.Controls.Add(label7);
            dateSelectorGroupBox.Controls.Add(finishDate);
            dateSelectorGroupBox.Controls.Add(startDate);
            dateSelectorGroupBox.Location = new Point(2, 4);
            dateSelectorGroupBox.Margin = new Padding(2, 1, 2, 1);
            dateSelectorGroupBox.Name = "dateSelectorGroupBox";
            dateSelectorGroupBox.Padding = new Padding(2, 1, 2, 1);
            dateSelectorGroupBox.Size = new Size(517, 66);
            dateSelectorGroupBox.TabIndex = 51;
            dateSelectorGroupBox.TabStop = false;
            dateSelectorGroupBox.Text = "Дата и время";
            // 
            // sportSelectorGroupBox
            // 
            sportSelectorGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sportSelectorGroupBox.Controls.Add(sportSelector);
            sportSelectorGroupBox.Location = new Point(2, 4);
            sportSelectorGroupBox.Margin = new Padding(2, 1, 2, 1);
            sportSelectorGroupBox.Name = "sportSelectorGroupBox";
            sportSelectorGroupBox.Padding = new Padding(2, 1, 2, 1);
            sportSelectorGroupBox.Size = new Size(293, 66);
            sportSelectorGroupBox.TabIndex = 52;
            sportSelectorGroupBox.TabStop = false;
            sportSelectorGroupBox.Text = "Вид спорта";
            // 
            // teamViewerGroupBox
            // 
            teamViewerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            teamViewerGroupBox.Controls.Add(teamsView);
            teamViewerGroupBox.Location = new Point(2, 77);
            teamViewerGroupBox.Margin = new Padding(2, 1, 2, 1);
            teamViewerGroupBox.Name = "teamViewerGroupBox";
            teamViewerGroupBox.Padding = new Padding(2, 1, 2, 1);
            teamViewerGroupBox.Size = new Size(517, 126);
            teamViewerGroupBox.TabIndex = 53;
            teamViewerGroupBox.TabStop = false;
            teamViewerGroupBox.Text = "Команды";
            // 
            // teamSelectorGroupBox
            // 
            teamSelectorGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            teamSelectorGroupBox.Controls.Add(teamSelectorCheckBox);
            teamSelectorGroupBox.Location = new Point(2, 77);
            teamSelectorGroupBox.Margin = new Padding(2, 1, 2, 1);
            teamSelectorGroupBox.Name = "teamSelectorGroupBox";
            teamSelectorGroupBox.Padding = new Padding(2, 1, 2, 1);
            teamSelectorGroupBox.Size = new Size(517, 126);
            teamSelectorGroupBox.TabIndex = 54;
            teamSelectorGroupBox.TabStop = false;
            teamSelectorGroupBox.Text = "Выбор команд";
            teamSelectorGroupBox.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(EventName);
            groupBox1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(516, 66);
            groupBox1.TabIndex = 55;
            groupBox1.TabStop = false;
            groupBox1.Text = "Название";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.White;
            groupBox2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ControlDarkDark;
            groupBox2.Location = new Point(3, 74);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(516, 149);
            groupBox2.TabIndex = 56;
            groupBox2.TabStop = false;
            groupBox2.Text = "Описание";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(EventDescription);
            panel1.Controls.Add(groupBox2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 226);
            panel1.TabIndex = 57;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(teamViewerGroupBox);
            panel2.Controls.Add(dateSelectorGroupBox);
            panel2.Controls.Add(teamSelectorGroupBox);
            panel2.Location = new Point(3, 235);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 207);
            panel2.TabIndex = 58;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(pictureBox);
            panel3.Controls.Add(imageButton);
            panel3.Location = new Point(531, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(299, 226);
            panel3.TabIndex = 59;
            // 
            // imageButton
            // 
            imageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imageButton.BackColor = Color.White;
            imageButton.FlatAppearance.BorderColor = Color.Silver;
            imageButton.FlatStyle = FlatStyle.Flat;
            imageButton.Location = new Point(2, 194);
            imageButton.Margin = new Padding(2, 1, 2, 1);
            imageButton.Name = "imageButton";
            imageButton.Size = new Size(293, 29);
            imageButton.TabIndex = 39;
            imageButton.TabStop = false;
            imageButton.Text = "Изменить изображениe";
            imageButton.UseVisualStyleBackColor = true;
            imageButton.Visible = false;
            imageButton.Click += imageButton_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(sportSelectorGroupBox);
            panel4.Location = new Point(531, 235);
            panel4.Name = "panel4";
            panel4.Size = new Size(299, 207);
            panel4.TabIndex = 60;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.3853531F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.6146469F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Location = new Point(9, 52);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.13483F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.86517F));
            tableLayoutPanel1.Size = new Size(833, 445);
            tableLayoutPanel1.TabIndex = 27;
            // 
            // EventViewerWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(854, 538);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(editButton);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Controls.Add(deleteButton);
            Controls.Add(label1);
            Controls.Add(label9);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 1, 2, 1);
            MinimumSize = new Size(870, 577);
            Name = "EventViewerWindow";
            Text = " ";
            Load += EventViewerWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            dateSelectorGroupBox.ResumeLayout(false);
            dateSelectorGroupBox.PerformLayout();
            sportSelectorGroupBox.ResumeLayout(false);
            teamViewerGroupBox.ResumeLayout(false);
            teamSelectorGroupBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Button imageButton;
    }
}