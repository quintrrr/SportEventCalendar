namespace SportEventCalendar
{
    partial class MainWindow
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            сОЗДАТЬToolStripMenuItem = new ToolStripMenuItem();
            пОСМОТРЕТЬToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            button3 = new Button();
            refresh = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { сОЗДАТЬToolStripMenuItem, пОСМОТРЕТЬToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1653, 40);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // сОЗДАТЬToolStripMenuItem
            // 
            сОЗДАТЬToolStripMenuItem.Name = "сОЗДАТЬToolStripMenuItem";
            сОЗДАТЬToolStripMenuItem.Size = new Size(139, 36);
            сОЗДАТЬToolStripMenuItem.Text = "СОЗДАТЬ";
            сОЗДАТЬToolStripMenuItem.Click += сОЗДАТЬToolStripMenuItem_Click;
            // 
            // пОСМОТРЕТЬToolStripMenuItem
            // 
            пОСМОТРЕТЬToolStripMenuItem.Name = "пОСМОТРЕТЬToolStripMenuItem";
            пОСМОТРЕТЬToolStripMenuItem.Size = new Size(189, 36);
            пОСМОТРЕТЬToolStripMenuItem.Text = "ПОСМОТРЕТЬ";
            пОСМОТРЕТЬToolStripMenuItem.Click += пОСМОТРЕТЬToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 25F, FontStyle.Bold);
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(821, 82);
            label1.TabIndex = 2;
            label1.Text = "Спортивные соревнования";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(1560, 693);
            dataGridView1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(40, 125);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(164, 39);
            dateTimePicker1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(255, 125);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(162, 39);
            dateTimePicker2.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(436, 125);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 6;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1450, 125);
            button3.Name = "button3";
            button3.Size = new Size(150, 46);
            button3.TabIndex = 8;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // refresh
            // 
            refresh.BackgroundImage = (Image)resources.GetObject("refresh.BackgroundImage");
            refresh.BackgroundImageLayout = ImageLayout.Zoom;
            refresh.Location = new Point(1375, 117);
            refresh.Name = "refresh";
            refresh.Size = new Size(58, 62);
            refresh.TabIndex = 7;
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 940);
            Controls.Add(button3);
            Controls.Add(refresh);
            Controls.Add(button1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            Text = "MainWindow";
            Load += MainWindow_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem сОЗДАТЬToolStripMenuItem;
        private ToolStripMenuItem пОСМОТРЕТЬToolStripMenuItem;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private Button button3;
        private Button refresh;
    }
}