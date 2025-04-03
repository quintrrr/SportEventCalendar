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
            checkedListBox1 = new CheckedListBox();
            label6 = new Label();
            timePicker = new DateTimePicker();
            imageButton = new Button();
            cancel1Button = new Button();
            deleteButton = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
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
            panel2 = new Panel();
            teamsView = new ListView();
            sportName = new Label();
            editButton = new Button();
            cancel2Button = new Button();
            label7 = new Label();
            label9 = new Label();
            saveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "1", "2", "3", "4" });
            checkedListBox1.Location = new Point(297, 92);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(294, 184);
            checkedListBox1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(3, 77);
            label6.Name = "label6";
            label6.Size = new Size(300, 54);
            label6.TabIndex = 41;
            label6.Text = "Выбор команд:";
            // 
            // timePicker
            // 
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(567, 665);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(180, 39);
            timePicker.TabIndex = 40;
            // 
            // imageButton
            // 
            imageButton.Location = new Point(1146, 540);
            imageButton.Name = "imageButton";
            imageButton.Size = new Size(413, 46);
            imageButton.TabIndex = 39;
            imageButton.Text = "Изменить изображения";
            imageButton.UseVisualStyleBackColor = true;
            imageButton.Visible = false;
            // 
            // cancel1Button
            // 
            cancel1Button.Location = new Point(1426, 1111);
            cancel1Button.Name = "cancel1Button";
            cancel1Button.Size = new Size(150, 46);
            cancel1Button.TabIndex = 38;
            cancel1Button.Text = "Отмена";
            cancel1Button.UseVisualStyleBackColor = true;
            cancel1Button.Click += cancel1Button_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(1201, 1111);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(183, 46);
            deleteButton.TabIndex = 37;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(1097, 93);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(497, 412);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(3, 13);
            label8.Name = "label8";
            label8.Size = new Size(288, 54);
            label8.TabIndex = 35;
            label8.Text = "Выбор спорта:";
            // 
            // startDate
            // 
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(14, 664);
            startDate.Name = "startDate";
            startDate.Size = new Size(200, 39);
            startDate.TabIndex = 32;
            // 
            // finishDate
            // 
            finishDate.Format = DateTimePickerFormat.Short;
            finishDate.Location = new Point(232, 664);
            finishDate.Name = "finishDate";
            finishDate.Size = new Size(200, 39);
            finishDate.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(14, 243);
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
            EventDescription.Location = new Point(14, 283);
            EventDescription.MaxLength = 1000;
            EventDescription.Multiline = true;
            EventDescription.Name = "EventDescription";
            EventDescription.PlaceholderText = " Введите описание";
            EventDescription.ReadOnly = true;
            EventDescription.Size = new Size(1034, 340);
            EventDescription.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 110F);
            label4.Location = new Point(13, 242);
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
            label2.Location = new Point(13, 93);
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
            EventName.MaxLength = 100;
            EventName.Name = "EventName";
            EventName.PlaceholderText = "Введите название";
            EventName.ReadOnly = true;
            EventName.Size = new Size(1034, 54);
            EventName.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 32F);
            label3.Location = new Point(12, 91);
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
            label1.Name = "label1";
            label1.Size = new Size(476, 82);
            label1.TabIndex = 25;
            label1.Text = "Новое событие";
            // 
            // sportSelector
            // 
            sportSelector.FormattingEnabled = true;
            sportSelector.Location = new Point(297, 27);
            sportSelector.Name = "sportSelector";
            sportSelector.Size = new Size(265, 40);
            sportSelector.TabIndex = 34;
            // 
            // panel2
            // 
            panel2.Controls.Add(teamsView);
            panel2.Controls.Add(checkedListBox1);
            panel2.Controls.Add(sportName);
            panel2.Controls.Add(sportSelector);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(12, 727);
            panel2.Name = "panel2";
            panel2.Size = new Size(653, 344);
            panel2.TabIndex = 44;
            panel2.Visible = false;
            // 
            // teamsView
            // 
            teamsView.Location = new Point(12, 53);
            teamsView.Name = "teamsView";
            teamsView.Size = new Size(358, 194);
            teamsView.TabIndex = 47;
            teamsView.UseCompatibleStateImageBehavior = false;
            // 
            // sportName
            // 
            sportName.AutoSize = true;
            sportName.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sportName.Location = new Point(2, -21);
            sportName.Name = "sportName";
            sportName.Size = new Size(171, 71);
            sportName.TabIndex = 46;
            sportName.Text = "label7";
            // 
            // editButton
            // 
            editButton.Location = new Point(14, 1111);
            editButton.Name = "editButton";
            editButton.Size = new Size(219, 46);
            editButton.TabIndex = 45;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // cancel2Button
            // 
            cancel2Button.Location = new Point(1201, 1040);
            cancel2Button.Name = "cancel2Button";
            cancel2Button.Size = new Size(183, 46);
            cancel2Button.TabIndex = 46;
            cancel2Button.Text = "Отмена";
            cancel2Button.UseVisualStyleBackColor = true;
            cancel2Button.Visible = false;
            cancel2Button.Click += cancel2Button_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(212, 665);
            label7.Name = "label7";
            label7.Size = new Size(24, 32);
            label7.TabIndex = 47;
            label7.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 25F, FontStyle.Bold);
            label9.Location = new Point(10, 9);
            label9.Name = "label9";
            label9.Size = new Size(476, 82);
            label9.TabIndex = 48;
            label9.Text = "Новое событие";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(1411, 1040);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(183, 46);
            saveButton.TabIndex = 49;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Visible = false;
            // 
            // EventViewerWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1609, 1169);
            Controls.Add(saveButton);
            Controls.Add(label9);
            Controls.Add(cancel2Button);
            Controls.Add(editButton);
            Controls.Add(panel2);
            Controls.Add(timePicker);
            Controls.Add(imageButton);
            Controls.Add(cancel1Button);
            Controls.Add(deleteButton);
            Controls.Add(pictureBox1);
            Controls.Add(startDate);
            Controls.Add(finishDate);
            Controls.Add(label5);
            Controls.Add(EventDescription);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(EventName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label7);
            Name = "EventViewerWindow";
            Text = "EventViewerWindow";
            Load += EventViewerWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox checkedListBox1;
        private Label label6;
        private DateTimePicker timePicker;
        private Button imageButton;
        private Button cancel1Button;
        private Button deleteButton;
        private PictureBox pictureBox1;
        private Label label8;
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
        private Panel panel2;
        private Button editButton;
        private ListView teamsView;
        private Label sportName;
        private Button cancel2Button;
        private Label label7;
        private Label label9;
        private Button saveButton;
    }
}