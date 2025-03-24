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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            notifyIcon1 = new NotifyIcon(components);
            toolTip1 = new ToolTip(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 25F, FontStyle.Bold);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(629, 82);
            label1.TabIndex = 0;
            label1.Text = "Сведения о событии";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(35, 172);
            textBox1.MaxLength = 100;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Введите название";
            textBox1.Size = new Size(1034, 54);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(25, 316);
            textBox2.MaxLength = 1000;
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = " Введите описание";
            textBox2.Size = new Size(1034, 340);
            textBox2.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(24, 126);
            label2.Name = "label2";
            label2.Size = new Size(698, 37);
            label2.TabIndex = 3;
            label2.Text = "Название (обязательное поле)                                           ";
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
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(394, 708);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 39);
            dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(394, 762);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(200, 39);
            dateTimePicker3.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(35, 696);
            label6.Name = "label6";
            label6.Size = new Size(254, 54);
            label6.TabIndex = 10;
            label6.Text = "Дата начала:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(35, 750);
            label7.Name = "label7";
            label7.Size = new Size(325, 54);
            label7.TabIndex = 11;
            label7.Text = "Дата окончания:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(329, 818);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(265, 40);
            comboBox1.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(35, 804);
            label8.Name = "label8";
            label8.Size = new Size(288, 54);
            label8.TabIndex = 13;
            label8.Text = "Выбор спорта:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(1105, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(497, 412);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F);
            label9.Location = new Point(667, 693);
            label9.Name = "label9";
            label9.Size = new Size(414, 54);
            label9.TabIndex = 15;
            label9.Text = "Добавить участников";
            // 
            // button1
            // 
            button1.Location = new Point(1148, 818);
            button1.Name = "button1";
            button1.Size = new Size(183, 46);
            button1.TabIndex = 16;
            button1.Text = "Создать";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1386, 814);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 17;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1148, 447);
            button3.Name = "button3";
            button3.Size = new Size(413, 46);
            button3.TabIndex = 19;
            button3.Text = "Добавить изображения";
            button3.UseVisualStyleBackColor = true;
            // 
            // NewEventCreationWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1614, 875);
            ControlBox = false;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimePicker3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "NewEventCreationWindow";
            Text = "New Event Creation Window";
            Load += NewEventCreationWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private NotifyIcon notifyIcon1;
        private ToolTip toolTip1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker3;
        private Label label6;
        private Label label7;
        private ComboBox comboBox1;
        private Label label8;
        private PictureBox pictureBox1;
        private Label label9;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
