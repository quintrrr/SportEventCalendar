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
            reportButtom = new Button();
            saveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // windowName
            // 
            windowName.AutoSize = true;
            windowName.Font = new Font("Calibri", 25F, FontStyle.Bold);
            windowName.Location = new Point(11, 23);
            windowName.Margin = new Padding(4, 0, 4, 0);
            windowName.Name = "windowName";
            windowName.Size = new Size(821, 82);
            windowName.TabIndex = 2;
            windowName.Text = "Спортивные соревнования";
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.Control;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(41, 192);
            dataGridView.Margin = new Padding(4, 2, 4, 2);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 82;
            dataGridView.Size = new Size(1560, 693);
            dataGridView.TabIndex = 3;
            dataGridView.CellClick += dataGridView1_CellClick_1;
            // 
            // startDate
            // 
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(41, 126);
            startDate.Margin = new Padding(4, 2, 4, 2);
            startDate.Name = "startDate";
            startDate.Size = new Size(164, 39);
            startDate.TabIndex = 4;
            // 
            // finishDate
            // 
            finishDate.Format = DateTimePickerFormat.Short;
            finishDate.Location = new Point(238, 126);
            finishDate.Margin = new Padding(4, 2, 4, 2);
            finishDate.Name = "finishDate";
            finishDate.Size = new Size(162, 39);
            finishDate.TabIndex = 5;
            // 
            // applyButton
            // 
            applyButton.Location = new Point(446, 124);
            applyButton.Margin = new Padding(4, 2, 4, 2);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(189, 47);
            applyButton.TabIndex = 6;
            applyButton.Text = "Применить";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += ApplyButton_Click;
            // 
            // addButtom
            // 
            addButtom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addButtom.Location = new Point(1436, 124);
            addButtom.Margin = new Padding(4, 2, 4, 2);
            addButtom.Name = "addButtom";
            addButtom.Size = new Size(163, 47);
            addButtom.TabIndex = 8;
            addButtom.Text = "+ Добавить";
            addButtom.UseVisualStyleBackColor = true;
            addButtom.Click += AddButtom_Click;
            // 
            // sportSelector
            // 
            sportSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            sportSelector.FormattingEnabled = true;
            sportSelector.Location = new Point(786, 128);
            sportSelector.Margin = new Padding(4, 2, 4, 2);
            sportSelector.Name = "sportSelector";
            sportSelector.Size = new Size(314, 40);
            sportSelector.TabIndex = 9;
            sportSelector.SelectedIndexChanged += sportSelector_SelectedIndexChanged;
            // 
            // reportButtom
            // 
            reportButtom.Location = new Point(1267, 124);
            reportButtom.Margin = new Padding(4, 2, 4, 2);
            reportButtom.Name = "reportButtom";
            reportButtom.Size = new Size(150, 47);
            reportButtom.TabIndex = 10;
            reportButtom.Text = "Отчёт";
            reportButtom.UseVisualStyleBackColor = true;
            reportButtom.Click += reportButtom_Click;
            // 
            // saveFileDialog
            // 
            saveFileDialog.Title = "Сохранить отчёт";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 941);
            Controls.Add(reportButtom);
            Controls.Add(sportSelector);
            Controls.Add(addButtom);
            Controls.Add(applyButton);
            Controls.Add(finishDate);
            Controls.Add(startDate);
            Controls.Add(dataGridView);
            Controls.Add(windowName);
            Margin = new Padding(4, 2, 4, 2);
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
        private Button reportButtom;
        private SaveFileDialog saveFileDialog;
    }
}