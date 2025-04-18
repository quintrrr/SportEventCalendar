namespace SportEventCalendar
{
    partial class NewEventCreationWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            windowName = new Label();
            newEventName = new TextBox();
            NewEventDescription = new TextBox();
            startDate = new DateTimePicker();
            finishDate = new DateTimePicker();
            sportSelector = new ComboBox();
            pictureBox = new PictureBox();
            create_button = new Button();
            canсel = new Button();
            imageButton = new Button();
            openFileDialog = new OpenFileDialog();
            timePicker = new DateTimePicker();
            teamSelectorCheckBox = new CheckedListBox();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // windowName
            // 
            windowName.AutoSize = true;
            windowName.Font = new Font("Calibri", 25F, FontStyle.Bold);
            windowName.Location = new Point(8, 9);
            windowName.Margin = new Padding(2, 0, 2, 0);
            windowName.Name = "windowName";
            windowName.Size = new Size(240, 41);
            windowName.TabIndex = 0;
            windowName.Text = "Новое событие";
            // 
            // newEventName
            // 
            newEventName.BorderStyle = BorderStyle.None;
            newEventName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newEventName.Location = new Point(8, 26);
            newEventName.Margin = new Padding(2, 1, 2, 1);
            newEventName.MaxLength = 100;
            newEventName.Name = "newEventName";
            newEventName.PlaceholderText = "Введите название";
            newEventName.Size = new Size(503, 27);
            newEventName.TabIndex = 1;
            newEventName.TabStop = false;
            // 
            // NewEventDescription
            // 
            NewEventDescription.BackColor = Color.White;
            NewEventDescription.BorderStyle = BorderStyle.None;
            NewEventDescription.Font = new Font("Segoe UI", 15F);
            NewEventDescription.Location = new Point(11, 155);
            NewEventDescription.Margin = new Padding(2, 1, 2, 1);
            NewEventDescription.MaxLength = 1000;
            NewEventDescription.Multiline = true;
            NewEventDescription.Name = "NewEventDescription";
            NewEventDescription.PlaceholderText = " Введите описание";
            NewEventDescription.ScrollBars = ScrollBars.Vertical;
            NewEventDescription.Size = new Size(560, 143);
            NewEventDescription.TabIndex = 2;
            NewEventDescription.TabStop = false;
            // 
            // startDate
            // 
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(5, 30);
            startDate.Margin = new Padding(2, 1, 2, 1);
            startDate.Name = "startDate";
            startDate.Size = new Size(98, 23);
            startDate.TabIndex = 7;
            startDate.TabStop = false;
            // 
            // finishDate
            // 
            finishDate.Format = DateTimePickerFormat.Short;
            finishDate.Location = new Point(125, 30);
            finishDate.Margin = new Padding(2, 1, 2, 1);
            finishDate.Name = "finishDate";
            finishDate.RightToLeft = RightToLeft.No;
            finishDate.RightToLeftLayout = true;
            finishDate.Size = new Size(98, 23);
            finishDate.TabIndex = 9;
            finishDate.TabStop = false;
            // 
            // sportSelector
            // 
            sportSelector.BackColor = Color.White;
            sportSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            sportSelector.FlatStyle = FlatStyle.Flat;
            sportSelector.Location = new Point(4, 18);
            sportSelector.Margin = new Padding(2, 1, 2, 1);
            sportSelector.Name = "sportSelector";
            sportSelector.Size = new Size(295, 23);
            sportSelector.TabIndex = 12;
            sportSelector.SelectedIndexChanged += sportSelector_SelectedIndexChanged;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(607, 58);
            pictureBox.Margin = new Padding(2, 1, 2, 1);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(304, 221);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 14;
            pictureBox.TabStop = false;
            // 
            // create_button
            // 
            create_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            create_button.FlatAppearance.BorderColor = Color.Silver;
            create_button.FlatStyle = FlatStyle.Popup;
            create_button.Location = new Point(812, 542);
            create_button.Margin = new Padding(2, 1, 2, 1);
            create_button.Name = "create_button";
            create_button.Size = new Size(99, 22);
            create_button.TabIndex = 16;
            create_button.Text = "Создать";
            create_button.UseVisualStyleBackColor = true;
            create_button.Click += create_button_Click;
            // 
            // canсel
            // 
            canсel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            canсel.FlatAppearance.BorderColor = Color.Silver;
            canсel.FlatStyle = FlatStyle.Popup;
            canсel.Location = new Point(709, 542);
            canсel.Margin = new Padding(2, 1, 2, 1);
            canсel.Name = "canсel";
            canсel.Size = new Size(99, 22);
            canсel.TabIndex = 17;
            canсel.Text = "Отмена";
            canсel.UseVisualStyleBackColor = true;
            canсel.Click += cancel_Click;
            // 
            // imageButton
            // 
            imageButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imageButton.FlatAppearance.BorderColor = Color.Silver;
            imageButton.FlatStyle = FlatStyle.Popup;
            imageButton.Location = new Point(608, 293);
            imageButton.Margin = new Padding(2, 1, 2, 1);
            imageButton.Name = "imageButton";
            imageButton.Size = new Size(303, 22);
            imageButton.TabIndex = 19;
            imageButton.Text = "Добавить изображения";
            imageButton.UseVisualStyleBackColor = true;
            imageButton.Click += imageButton_Click;
            // 
            // timePicker
            // 
            timePicker.CustomFormat = "hh:mm";
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.Location = new Point(484, 30);
            timePicker.Margin = new Padding(2, 1, 2, 1);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(79, 23);
            timePicker.TabIndex = 20;
            timePicker.TabStop = false;
            // 
            // teamSelectorCheckBox
            // 
            teamSelectorCheckBox.BorderStyle = BorderStyle.None;
            teamSelectorCheckBox.CheckOnClick = true;
            teamSelectorCheckBox.FormattingEnabled = true;
            teamSelectorCheckBox.Location = new Point(4, 17);
            teamSelectorCheckBox.Margin = new Padding(2, 1, 2, 1);
            teamSelectorCheckBox.Name = "teamSelectorCheckBox";
            teamSelectorCheckBox.Size = new Size(559, 108);
            teamSelectorCheckBox.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(105, 34);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(19, 15);
            label7.TabIndex = 48;
            label7.Text = "—";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(finishDate);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(startDate);
            groupBox1.Controls.Add(timePicker);
            groupBox1.Location = new Point(8, 310);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(569, 71);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выбор даты и времени";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(teamSelectorCheckBox);
            groupBox2.Location = new Point(8, 390);
            groupBox2.Margin = new Padding(2, 1, 2, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 1, 2, 1);
            groupBox2.Size = new Size(569, 133);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            groupBox2.Text = "Выбор команд";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.Controls.Add(sportSelector);
            groupBox3.Location = new Point(607, 326);
            groupBox3.Margin = new Padding(2, 1, 2, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 1, 2, 1);
            groupBox3.Size = new Size(303, 55);
            groupBox3.TabIndex = 51;
            groupBox3.TabStop = false;
            groupBox3.Text = "Выбор спорта";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(newEventName);
            groupBox4.Font = new Font("Segoe UI", 12F);
            groupBox4.ForeColor = SystemColors.ControlDarkDark;
            groupBox4.Location = new Point(8, 48);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(569, 75);
            groupBox4.TabIndex = 52;
            groupBox4.TabStop = false;
            groupBox4.Text = "Название";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.White;
            groupBox5.Font = new Font("Segoe UI", 12F);
            groupBox5.ForeColor = SystemColors.ControlDarkDark;
            groupBox5.Location = new Point(8, 129);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(569, 177);
            groupBox5.TabIndex = 56;
            groupBox5.TabStop = false;
            groupBox5.Text = "Описание";
            // 
            // NewEventCreationWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(922, 576);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(imageButton);
            Controls.Add(canсel);
            Controls.Add(create_button);
            Controls.Add(pictureBox);
            Controls.Add(NewEventDescription);
            Controls.Add(windowName);
            Controls.Add(groupBox5);
            Margin = new Padding(2, 1, 2, 1);
            MinimumSize = new Size(938, 615);
            Name = "NewEventCreationWindow";
            Text = "New Event Creation Window";
            Load += NewEventCreationWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label windowName;
        private TextBox newEventName;
        private TextBox NewEventDescription;
        private DateTimePicker startDate;
        private DateTimePicker finishDate;
        private ComboBox sportSelector;
        private PictureBox pictureBox;
        private Button create_button;
        private Button canсel;
        private Button imageButton;
        private OpenFileDialog openFileDialog;
        private DateTimePicker timePicker;
        private CheckedListBox teamSelectorCheckBox;
        private Label label7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
    }
}
