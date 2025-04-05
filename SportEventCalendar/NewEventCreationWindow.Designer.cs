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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // windowName
            // 
            windowName.AutoSize = true;
            windowName.Font = new Font("Calibri", 25F, FontStyle.Bold);
            windowName.Location = new Point(12, 18);
            windowName.Name = "windowName";
            windowName.Size = new Size(476, 82);
            windowName.TabIndex = 0;
            windowName.Text = "Новое событие";
            // 
            // newEventName
            // 
            newEventName.BorderStyle = BorderStyle.None;
            newEventName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newEventName.Location = new Point(35, 172);
            newEventName.MaxLength = 100;
            newEventName.Name = "newEventName";
            newEventName.PlaceholderText = "Введите название";
            newEventName.Size = new Size(1034, 54);
            newEventName.TabIndex = 1;
            newEventName.TabStop = false;
            // 
            // NewEventDescription
            // 
            NewEventDescription.BackColor = Color.White;
            NewEventDescription.BorderStyle = BorderStyle.None;
            NewEventDescription.Font = new Font("Segoe UI", 15F);
            NewEventDescription.Location = new Point(25, 316);
            NewEventDescription.MaxLength = 1000;
            NewEventDescription.Multiline = true;
            NewEventDescription.Name = "NewEventDescription";
            NewEventDescription.PlaceholderText = " Введите описание";
            NewEventDescription.Size = new Size(1034, 340);
            NewEventDescription.TabIndex = 2;
            NewEventDescription.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(24, 126);
            label2.Name = "label2";
            label2.Size = new Size(136, 37);
            label2.TabIndex = 3;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 32F);
            label3.Location = new Point(23, 124);
            label3.Name = "label3";
            label3.Size = new Size(1058, 116);
            label3.TabIndex = 4;
            label3.Text = "                                          ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 110F);
            label4.Location = new Point(24, 275);
            label4.Name = "label4";
            label4.Size = new Size(1057, 393);
            label4.TabIndex = 5;
            label4.Text = "           ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(25, 276);
            label5.Name = "label5";
            label5.Size = new Size(449, 37);
            label5.TabIndex = 6;
            label5.Text = "Описание                                            ";
            // 
            // startDate
            // 
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(25, 697);
            startDate.Name = "startDate";
            startDate.Size = new Size(200, 39);
            startDate.TabIndex = 7;
            startDate.TabStop = false;
            // 
            // finishDate
            // 
            finishDate.Format = DateTimePickerFormat.Short;
            finishDate.Location = new Point(275, 697);
            finishDate.Name = "finishDate";
            finishDate.Size = new Size(200, 39);
            finishDate.TabIndex = 9;
            finishDate.TabStop = false;
            // 
            // sportSelector
            // 
            sportSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            sportSelector.Location = new Point(25, 761);
            sportSelector.Name = "sportSelector";
            sportSelector.Size = new Size(364, 40);
            sportSelector.TabIndex = 12;
            sportSelector.SelectedIndexChanged += sportSelector_SelectedIndexChanged;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(1105, 124);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(497, 412);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 14;
            pictureBox.TabStop = false;
            // 
            // create_button
            // 
            create_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            create_button.Location = new Point(1419, 966);
            create_button.Name = "create_button";
            create_button.Size = new Size(183, 46);
            create_button.TabIndex = 16;
            create_button.Text = "Создать";
            create_button.UseVisualStyleBackColor = true;
            create_button.Click += create_button_Click;
            // 
            // canсel
            // 
            canсel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            canсel.Location = new Point(1244, 966);
            canсel.Name = "canсel";
            canсel.Size = new Size(150, 46);
            canсel.TabIndex = 17;
            canсel.Text = "Отмена";
            canсel.UseVisualStyleBackColor = true;
            canсel.Click += cancel_Click;
            // 
            // imageButton
            // 
            imageButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imageButton.Location = new Point(1148, 554);
            imageButton.Name = "imageButton";
            imageButton.Size = new Size(413, 46);
            imageButton.TabIndex = 19;
            imageButton.Text = "Добавить изображения";
            imageButton.UseVisualStyleBackColor = true;
            imageButton.Click += imageButton_Click;
            // 
            // timePicker
            // 
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(901, 697);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(180, 39);
            timePicker.TabIndex = 20;
            timePicker.TabStop = false;
            // 
            // teamSelectorCheckBox
            // 
            teamSelectorCheckBox.CheckOnClick = true;
            teamSelectorCheckBox.FormattingEnabled = true;
            teamSelectorCheckBox.Location = new Point(24, 818);
            teamSelectorCheckBox.Name = "teamSelectorCheckBox";
            teamSelectorCheckBox.Size = new Size(364, 184);
            teamSelectorCheckBox.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(231, 702);
            label7.Name = "label7";
            label7.Size = new Size(38, 32);
            label7.TabIndex = 48;
            label7.Text = "—";
            // 
            // NewEventCreationWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1614, 1031);
            Controls.Add(label7);
            Controls.Add(teamSelectorCheckBox);
            Controls.Add(timePicker);
            Controls.Add(imageButton);
            Controls.Add(canсel);
            Controls.Add(create_button);
            Controls.Add(pictureBox);
            Controls.Add(sportSelector);
            Controls.Add(startDate);
            Controls.Add(finishDate);
            Controls.Add(label5);
            Controls.Add(NewEventDescription);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(newEventName);
            Controls.Add(label3);
            Controls.Add(windowName);
            Name = "NewEventCreationWindow";
            Text = "New Event Creation Window";
            Load += NewEventCreationWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label windowName;
        private TextBox newEventName;
        private TextBox NewEventDescription;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
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
    }
}
