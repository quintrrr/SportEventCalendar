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
            panel1 = new Panel();
            checkedListBox1 = new CheckedListBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            timePicker = new DateTimePicker();
            imageButton = new Button();
            cansel = new Button();
            create_button = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            sportSelector = new ComboBox();
            startDate = new DateTimePicker();
            finishDate = new DateTimePicker();
            label5 = new Label();
            NewEventDescription = new TextBox();
            label4 = new Label();
            label2 = new Label();
            newEventName = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(checkedListBox1);
            panel1.Location = new Point(454, 770);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 200);
            panel1.TabIndex = 43;
            panel1.Visible = false;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "1", "2", "3", "4" });
            checkedListBox1.Location = new Point(3, -1);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(294, 184);
            checkedListBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(454, 724);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(265, 40);
            comboBox1.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(160, 713);
            label6.Name = "label6";
            label6.Size = new Size(300, 54);
            label6.TabIndex = 41;
            label6.Text = "Выбор команд:";
            // 
            // timePicker
            // 
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.Location = new Point(734, 595);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(180, 39);
            timePicker.TabIndex = 40;
            // 
            // imageButton
            // 
            imageButton.Location = new Point(1307, 459);
            imageButton.Name = "imageButton";
            imageButton.Size = new Size(413, 46);
            imageButton.TabIndex = 39;
            imageButton.Text = "Добавить изображения";
            imageButton.UseVisualStyleBackColor = true;
            // 
            // cansel
            // 
            cansel.Location = new Point(1322, 746);
            cansel.Name = "cansel";
            cansel.Size = new Size(150, 46);
            cansel.TabIndex = 38;
            cansel.Text = "Отмена";
            cansel.UseVisualStyleBackColor = true;
            // 
            // create_button
            // 
            create_button.Location = new Point(1526, 746);
            create_button.Name = "create_button";
            create_button.Size = new Size(183, 46);
            create_button.TabIndex = 37;
            create_button.Text = "Создать";
            create_button.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(1258, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(497, 412);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(160, 649);
            label8.Name = "label8";
            label8.Size = new Size(288, 54);
            label8.TabIndex = 35;
            label8.Text = "Выбор спорта:";
            // 
            // sportSelector
            // 
            sportSelector.FormattingEnabled = true;
            sportSelector.Location = new Point(454, 663);
            sportSelector.Name = "sportSelector";
            sportSelector.Size = new Size(265, 40);
            sportSelector.TabIndex = 34;
            // 
            // startDate
            // 
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(173, 598);
            startDate.Name = "startDate";
            startDate.Size = new Size(200, 39);
            startDate.TabIndex = 32;
            // 
            // finishDate
            // 
            finishDate.Format = DateTimePickerFormat.Short;
            finishDate.Location = new Point(436, 598);
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
            label5.Location = new Point(173, 177);
            label5.Name = "label5";
            label5.Size = new Size(449, 37);
            label5.TabIndex = 31;
            label5.Text = "Описание                                            ";
            // 
            // NewEventDescription
            // 
            NewEventDescription.BackColor = Color.White;
            NewEventDescription.BorderStyle = BorderStyle.None;
            NewEventDescription.Font = new Font("Segoe UI", 15F);
            NewEventDescription.Location = new Point(173, 217);
            NewEventDescription.MaxLength = 1000;
            NewEventDescription.Multiline = true;
            NewEventDescription.Name = "NewEventDescription";
            NewEventDescription.PlaceholderText = " Введите описание";
            NewEventDescription.Size = new Size(1034, 340);
            NewEventDescription.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 110F);
            label4.Location = new Point(172, 176);
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
            label2.Location = new Point(172, 27);
            label2.Name = "label2";
            label2.Size = new Size(698, 37);
            label2.TabIndex = 28;
            label2.Text = "Название (обязательное поле)                                           ";
            // 
            // newEventName
            // 
            newEventName.BorderStyle = BorderStyle.None;
            newEventName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newEventName.Location = new Point(183, 73);
            newEventName.MaxLength = 100;
            newEventName.Name = "newEventName";
            newEventName.PlaceholderText = "Введите название";
            newEventName.Size = new Size(1034, 54);
            newEventName.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 32F);
            label3.Location = new Point(171, 25);
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
            // EventViewerWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1910, 1168);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(timePicker);
            Controls.Add(imageButton);
            Controls.Add(cansel);
            Controls.Add(create_button);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(sportSelector);
            Controls.Add(startDate);
            Controls.Add(finishDate);
            Controls.Add(label5);
            Controls.Add(NewEventDescription);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(newEventName);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "EventViewerWindow";
            Text = "EventViewerWindow";
            Load += EventViewerWindow_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private CheckedListBox checkedListBox1;
        private ComboBox comboBox1;
        private Label label6;
        private DateTimePicker timePicker;
        private Button imageButton;
        private Button cansel;
        private Button create_button;
        private PictureBox pictureBox1;
        private Label label8;
        private ComboBox sportSelector;
        private DateTimePicker startDate;
        private DateTimePicker finishDate;
        private Label label5;
        private TextBox NewEventDescription;
        private Label label4;
        private Label label2;
        private TextBox newEventName;
        private Label label3;
        private Label label1;
    }
}