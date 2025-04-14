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
            cancel1Button = new Button();
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
            panel2 = new Panel();
            sportName = new Label();
            editButton = new Button();
            cancel2Button = new Button();
            label7 = new Label();
            label9 = new Label();
            saveButton = new Button();
            panel1 = new Panel();
            teamsView = new TreeView();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // teamSelectorCheckBox
            // 
            teamSelectorCheckBox.CheckOnClick = true;
            teamSelectorCheckBox.FormattingEnabled = true;
            teamSelectorCheckBox.Items.AddRange(new object[] { "1", "2", "3", "4" });
            teamSelectorCheckBox.Location = new Point(1, 50);
            teamSelectorCheckBox.Margin = new Padding(2, 1, 2, 1);
            teamSelectorCheckBox.Name = "teamSelectorCheckBox";
            teamSelectorCheckBox.Size = new Size(198, 76);
            teamSelectorCheckBox.TabIndex = 0;
            // 
            // timePicker
            // 
            timePicker.CustomFormat = "hh:mm";
            timePicker.Enabled = false;
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.Location = new Point(460, 314);
            timePicker.Margin = new Padding(2, 1, 2, 1);
            timePicker.Name = "timePicker";
            timePicker.Size = new Size(56, 23);
            timePicker.TabIndex = 40;
            timePicker.TabStop = false;
            // 
            // imageButton
            // 
            imageButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imageButton.Location = new Point(617, 253);
            imageButton.Margin = new Padding(2, 1, 2, 1);
            imageButton.Name = "imageButton";
            imageButton.Size = new Size(222, 22);
            imageButton.TabIndex = 39;
            imageButton.TabStop = false;
            imageButton.Text = "Изменить изображения";
            imageButton.UseVisualStyleBackColor = true;
            imageButton.Visible = false;
            imageButton.Click += imageButton_Click;
            // 
            // cancel1Button
            // 
            cancel1Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancel1Button.Location = new Point(760, 521);
            cancel1Button.Margin = new Padding(2, 1, 2, 1);
            cancel1Button.Name = "cancel1Button";
            cancel1Button.Size = new Size(99, 22);
            cancel1Button.TabIndex = 38;
            cancel1Button.TabStop = false;
            cancel1Button.Text = "Отмена";
            cancel1Button.UseVisualStyleBackColor = true;
            cancel1Button.Click += cancel1Button_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteButton.Location = new Point(647, 521);
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
            pictureBox.Location = new Point(591, 44);
            pictureBox.Margin = new Padding(2, 1, 2, 1);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(269, 194);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 36;
            pictureBox.TabStop = false;
            // 
            // startDate
            // 
            startDate.Enabled = false;
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(8, 312);
            startDate.Margin = new Padding(2, 1, 2, 1);
            startDate.Name = "startDate";
            startDate.Size = new Size(110, 23);
            startDate.TabIndex = 32;
            startDate.TabStop = false;
            // 
            // finishDate
            // 
            finishDate.Enabled = false;
            finishDate.Format = DateTimePickerFormat.Short;
            finishDate.Location = new Point(142, 312);
            finishDate.Margin = new Padding(2, 1, 2, 1);
            finishDate.Name = "finishDate";
            finishDate.Size = new Size(110, 23);
            finishDate.TabIndex = 33;
            finishDate.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = SystemColors.ControlDark;
            label5.Location = new Point(8, 114);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(248, 19);
            label5.TabIndex = 31;
            label5.Text = "Описание                                            ";
            // 
            // EventDescription
            // 
            EventDescription.BackColor = Color.White;
            EventDescription.BorderStyle = BorderStyle.None;
            EventDescription.Font = new Font("Segoe UI", 15F);
            EventDescription.Location = new Point(8, 133);
            EventDescription.Margin = new Padding(2, 1, 2, 1);
            EventDescription.MaxLength = 1000;
            EventDescription.Multiline = true;
            EventDescription.Name = "EventDescription";
            EventDescription.PlaceholderText = " Введите описание";
            EventDescription.ReadOnly = true;
            EventDescription.Size = new Size(557, 159);
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
            label4.Location = new Point(7, 113);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(524, 197);
            label4.TabIndex = 30;
            label4.Text = "           ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(7, 44);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(241, 19);
            label2.TabIndex = 28;
            label2.Text = "Название                                           ";
            // 
            // EventName
            // 
            EventName.BackColor = Color.White;
            EventName.BorderStyle = BorderStyle.None;
            EventName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EventName.Location = new Point(13, 65);
            EventName.Margin = new Padding(2, 1, 2, 1);
            EventName.MaxLength = 100;
            EventName.Name = "EventName";
            EventName.PlaceholderText = "Введите название";
            EventName.ReadOnly = true;
            EventName.Size = new Size(557, 27);
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
            label3.Location = new Point(6, 43);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(531, 61);
            label3.TabIndex = 29;
            label3.Text = "                                          ";
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
            sportSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            sportSelector.FormattingEnabled = true;
            sportSelector.Location = new Point(1, 22);
            sportSelector.Margin = new Padding(2, 1, 2, 1);
            sportSelector.Name = "sportSelector";
            sportSelector.Size = new Size(145, 23);
            sportSelector.TabIndex = 34;
            sportSelector.SelectedIndexChanged += sportSelector_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(teamSelectorCheckBox);
            panel2.Controls.Add(sportSelector);
            panel2.Location = new Point(6, 341);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(292, 161);
            panel2.TabIndex = 44;
            panel2.Visible = false;
            // 
            // sportName
            // 
            sportName.AutoSize = true;
            sportName.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sportName.Location = new Point(0, 15);
            sportName.Margin = new Padding(2, 0, 2, 0);
            sportName.Name = "sportName";
            sportName.Size = new Size(90, 37);
            sportName.TabIndex = 46;
            sportName.Text = "label7";
            // 
            // editButton
            // 
            editButton.Location = new Point(3, 188);
            editButton.Margin = new Padding(2, 1, 2, 1);
            editButton.Name = "editButton";
            editButton.Size = new Size(118, 22);
            editButton.TabIndex = 45;
            editButton.TabStop = false;
            editButton.Text = "Редактировать";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // cancel2Button
            // 
            cancel2Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancel2Button.Location = new Point(647, 521);
            cancel2Button.Margin = new Padding(2, 1, 2, 1);
            cancel2Button.Name = "cancel2Button";
            cancel2Button.Size = new Size(99, 22);
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
            label7.Location = new Point(118, 314);
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
            label9.Location = new Point(5, 4);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(372, 41);
            label9.TabIndex = 48;
            label9.Text = "Подробности о событии";
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(761, 521);
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
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(teamsView);
            panel1.Controls.Add(editButton);
            panel1.Controls.Add(sportName);
            panel1.Location = new Point(5, 332);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 219);
            panel1.TabIndex = 50;
            // 
            // teamsView
            // 
            teamsView.Location = new Point(3, 52);
            teamsView.Margin = new Padding(2, 1, 2, 1);
            teamsView.Name = "teamsView";
            teamsView.ShowLines = false;
            teamsView.Size = new Size(197, 93);
            teamsView.TabIndex = 51;
            teamsView.TabStop = false;
            // 
            // EventViewerWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 492);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(saveButton);
            Controls.Add(label9);
            Controls.Add(cancel2Button);
            Controls.Add(timePicker);
            Controls.Add(imageButton);
            Controls.Add(cancel1Button);
            Controls.Add(deleteButton);
            Controls.Add(pictureBox);
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
            Margin = new Padding(2, 1, 2, 1);
            Name = "EventViewerWindow";
            Text = "EventViewerWindow";
            Load += EventViewerWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckedListBox teamSelectorCheckBox;
        private DateTimePicker timePicker;
        private Button imageButton;
        private Button cancel1Button;
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
        private Panel panel2;
        private Button editButton;
        private Label sportName;
        private Button cancel2Button;
        private Label label7;
        private Label label9;
        private Button saveButton;
        private Panel panel1;
        private OpenFileDialog openFileDialog;
        private TreeView teamsView;
    }
}