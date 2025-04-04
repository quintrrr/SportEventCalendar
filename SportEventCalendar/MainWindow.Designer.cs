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
            windowName = new Label();
            dataGridView = new DataGridView();
            startDate = new DateTimePicker();
            finishDate = new DateTimePicker();
            applyButton = new Button();
            addButtom = new Button();
            sportSelector = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // windowName
            // 
            windowName.AutoSize = true;
            windowName.Font = new Font("Calibri", 25F, FontStyle.Bold);
            windowName.Location = new Point(12, 24);
            windowName.Name = "windowName";
            windowName.Size = new Size(821, 82);
            windowName.TabIndex = 2;
            windowName.Text = "Спортивные соревнования";
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(40, 193);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 82;
            dataGridView.Size = new Size(1560, 693);
            dataGridView.TabIndex = 3;
            dataGridView.CellClick += dataGridView1_CellClick_1;
            // 
            // startDateTimePicker
            // 
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(40, 125);
            startDate.Name = "startDateTimePicker";
            startDate.Size = new Size(164, 39);
            startDate.TabIndex = 4;
            // 
            // finishDateTimePicker2
            // 
            finishDate.Format = DateTimePickerFormat.Short;
            finishDate.Location = new Point(238, 125);
            finishDate.Name = "finishDateTimePicker2";
            finishDate.Size = new Size(162, 39);
            finishDate.TabIndex = 5;
            // 
            // applyButton
            // 
            applyButton.Location = new Point(445, 123);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(189, 46);
            applyButton.TabIndex = 6;
            applyButton.Text = "Применить";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += ApplyButton_Click;
            // 
            // addButtom
            // 
            addButtom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addButtom.Location = new Point(1392, 123);
            addButtom.Name = "addButtom";
            addButtom.Size = new Size(208, 46);
            addButtom.TabIndex = 8;
            addButtom.Text = "+ Добавить";
            addButtom.UseVisualStyleBackColor = true;
            addButtom.Click += AddButtom_Click;
            // 
            // sportSelector
            // 
            sportSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            sportSelector.FormattingEnabled = true;
            sportSelector.Location = new Point(827, 127);
            sportSelector.Name = "sportSelector";
            sportSelector.Size = new Size(315, 40);
            sportSelector.TabIndex = 9;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 940);
            Controls.Add(sportSelector);
            Controls.Add(addButtom);
            Controls.Add(applyButton);
            Controls.Add(finishDate);
            Controls.Add(startDate);
            Controls.Add(dataGridView);
            Controls.Add(windowName);
            Name = "MainWindow";
            Text = "Main";
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label windowName;
        private DataGridView dataGridView;
        private DateTimePicker startDate;
        private DateTimePicker finishDate;
        private Button applyButton;
        private Button addButtom;
        private ComboBox sportSelector;
    }
}