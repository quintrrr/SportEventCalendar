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
            NewEventDescription = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // windowName
            // 
            windowName.AutoSize = true;
            windowName.Font = new Font("Calibri", 25F, FontStyle.Bold);
            windowName.Location = new Point(9, 8);
            windowName.Margin = new Padding(2, 0, 2, 0);
            windowName.Name = "windowName";
            windowName.Size = new Size(240, 41);
            windowName.TabIndex = 0;
            windowName.Text = "Новое событие";
            // 
            // newEventName
            // 
            newEventName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            newEventName.BorderStyle = BorderStyle.None;
            newEventName.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newEventName.Location = new Point(9, 24);
            newEventName.Margin = new Padding(2, 1, 2, 1);
            newEventName.MaxLength = 100;
            newEventName.Name = "newEventName";
            newEventName.PlaceholderText = "Введите название";
            newEventName.Size = new Size(502, 25);
            newEventName.TabIndex = 1;
            newEventName.TabStop = false;
            // 
            // startDate
            // 
            startDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(10, 28);
            startDate.Margin = new Padding(2, 1, 2, 1);
            startDate.Name = "startDate";
            startDate.Size = new Size(111, 22);
            startDate.TabIndex = 7;
            startDate.TabStop = false;
            // 
            // finishDate
            // 
            finishDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            finishDate.Format = DateTimePickerFormat.Short;
            finishDate.Location = new Point(149, 28);
            finishDate.Margin = new Padding(2, 1, 2, 1);
            finishDate.Name = "finishDate";
            finishDate.RightToLeft = RightToLeft.No;
            finishDate.RightToLeftLayout = true;
            finishDate.Size = new Size(111, 22);
            finishDate.TabIndex = 9;
            finishDate.TabStop = false;
            // 
            // sportSelector
            // 
            sportSelector.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sportSelector.BackColor = Color.White;
            sportSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            sportSelector.Location = new Point(15, 25);
            sportSelector.Margin = new Padding(2, 1, 2, 1);
            sportSelector.Name = "sportSelector";
            sportSelector.Size = new Size(265, 22);
            sportSelector.TabIndex = 12;
            sportSelector.SelectedIndexChanged += sportSelector_SelectedIndexChanged;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(2, 13);
            pictureBox.Margin = new Padding(2, 1, 2, 1);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(295, 171);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 14;
            pictureBox.TabStop = false;
            // 
            // create_button
            // 
            create_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            create_button.FlatAppearance.BorderColor = Color.Silver;
            create_button.FlatStyle = FlatStyle.Flat;
            create_button.Location = new Point(724, 503);
            create_button.Margin = new Padding(2, 1, 2, 1);
            create_button.Name = "create_button";
            create_button.Size = new Size(113, 25);
            create_button.TabIndex = 16;
            create_button.Text = "Создать";
            create_button.UseVisualStyleBackColor = true;
            create_button.Click += create_button_Click;
            // 
            // canсel
            // 
            canсel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            canсel.FlatAppearance.BorderColor = Color.Silver;
            canсel.FlatStyle = FlatStyle.Flat;
            canсel.Location = new Point(597, 503);
            canсel.Margin = new Padding(2, 1, 2, 1);
            canсel.Name = "canсel";
            canсel.Size = new Size(113, 25);
            canсel.TabIndex = 17;
            canсel.Text = "Отмена";
            canсel.UseVisualStyleBackColor = true;
            canсel.Click += cancel_Click;
            // 
            // imageButton
            // 
            imageButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            imageButton.FlatAppearance.BorderColor = Color.Silver;
            imageButton.FlatStyle = FlatStyle.Flat;
            imageButton.Location = new Point(2, 194);
            imageButton.Margin = new Padding(2, 1, 2, 1);
            imageButton.Name = "imageButton";
            imageButton.Size = new Size(295, 29);
            imageButton.TabIndex = 19;
            imageButton.Text = "Добавить изображения";
            imageButton.UseVisualStyleBackColor = true;
            imageButton.Click += imageButton_Click;
            // 
            // timePicker
            // 
            timePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            timePicker.CustomFormat = "hh:mm";
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.Location = new Point(411, 25);
            timePicker.Margin = new Padding(2, 1, 2, 1);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(90, 22);
            timePicker.TabIndex = 20;
            timePicker.TabStop = false;
            // 
            // teamSelectorCheckBox
            // 
            teamSelectorCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            teamSelectorCheckBox.BorderStyle = BorderStyle.None;
            teamSelectorCheckBox.CheckOnClick = true;
            teamSelectorCheckBox.FormattingEnabled = true;
            teamSelectorCheckBox.Location = new Point(3, 26);
            teamSelectorCheckBox.Margin = new Padding(2, 1, 2, 1);
            teamSelectorCheckBox.Name = "teamSelectorCheckBox";
            teamSelectorCheckBox.Size = new Size(509, 102);
            teamSelectorCheckBox.TabIndex = 0;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(126, 31);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(19, 14);
            label7.TabIndex = 48;
            label7.Text = "—";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(finishDate);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(startDate);
            groupBox1.Controls.Add(timePicker);
            groupBox1.ForeColor = SystemColors.ControlDarkDark;
            groupBox1.Location = new Point(2, 1);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(517, 66);
            groupBox1.TabIndex = 49;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выбор даты и времени";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(teamSelectorCheckBox);
            groupBox2.ForeColor = SystemColors.ControlDarkDark;
            groupBox2.Location = new Point(2, 76);
            groupBox2.Margin = new Padding(2, 1, 2, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 1, 2, 1);
            groupBox2.Size = new Size(517, 131);
            groupBox2.TabIndex = 50;
            groupBox2.TabStop = false;
            groupBox2.Text = "Выбор команд";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(sportSelector);
            groupBox3.ForeColor = SystemColors.ControlDarkDark;
            groupBox3.Location = new Point(2, 1);
            groupBox3.Margin = new Padding(2, 1, 2, 1);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2, 1, 2, 1);
            groupBox3.Size = new Size(295, 66);
            groupBox3.TabIndex = 51;
            groupBox3.TabStop = false;
            groupBox3.Text = "Выбор спорта";
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(newEventName);
            groupBox4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.ControlDarkDark;
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(516, 66);
            groupBox4.TabIndex = 52;
            groupBox4.TabStop = false;
            groupBox4.Text = "Название";
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox5.BackColor = Color.White;
            groupBox5.Controls.Add(NewEventDescription);
            groupBox5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox5.ForeColor = SystemColors.ControlDarkDark;
            groupBox5.Location = new Point(3, 75);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(516, 148);
            groupBox5.TabIndex = 56;
            groupBox5.TabStop = false;
            groupBox5.Text = "Описание";
            // 
            // NewEventDescription
            // 
            NewEventDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NewEventDescription.BackColor = Color.White;
            NewEventDescription.BorderStyle = BorderStyle.None;
            NewEventDescription.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewEventDescription.Location = new Point(2, 24);
            NewEventDescription.Margin = new Padding(2, 1, 2, 1);
            NewEventDescription.MaxLength = 1000;
            NewEventDescription.Multiline = true;
            NewEventDescription.Name = "NewEventDescription";
            NewEventDescription.PlaceholderText = " Введите описание";
            NewEventDescription.ScrollBars = ScrollBars.Vertical;
            NewEventDescription.Size = new Size(509, 115);
            NewEventDescription.TabIndex = 2;
            NewEventDescription.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox5);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 225);
            panel1.TabIndex = 57;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupBox2);
            panel2.Location = new Point(3, 234);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 208);
            panel2.TabIndex = 58;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(groupBox3);
            panel3.Location = new Point(531, 234);
            panel3.Name = "panel3";
            panel3.Size = new Size(299, 208);
            panel3.TabIndex = 59;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(pictureBox);
            panel4.Controls.Add(imageButton);
            panel4.Location = new Point(531, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(299, 225);
            panel4.TabIndex = 60;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.39F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.61F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Location = new Point(9, 52);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.13F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.87F));
            tableLayoutPanel1.Size = new Size(833, 445);
            tableLayoutPanel1.TabIndex = 61;
            // 
            // NewEventCreationWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(854, 538);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(canсel);
            Controls.Add(create_button);
            Controls.Add(windowName);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 1, 2, 1);
            MinimumSize = new Size(870, 577);
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
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label windowName;
        private TextBox newEventName;
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
        private Panel panel1;
        private TextBox NewEventDescription;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
