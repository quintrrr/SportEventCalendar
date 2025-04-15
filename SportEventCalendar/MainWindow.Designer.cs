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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            windowName = new Label();
            dataGridView = new DataGridView();
            startDate = new DateTimePicker();
            finishDate = new DateTimePicker();
            applyButton = new Button();
            addButtom = new Button();
            sportSelector = new ComboBox();
            reportButtom = new Button();
            saveFileDialog = new SaveFileDialog();
            dataSelectorGroupBox = new GroupBox();
            label7 = new Label();
            sportSelectorGroupBox = new GroupBox();
            button1 = new Button();
            buttonsPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            dataSelectorGroupBox.SuspendLayout();
            sportSelectorGroupBox.SuspendLayout();
            buttonsPanel.SuspendLayout();
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
            dataGridView.Location = new Point(41, 331);
            dataGridView.Margin = new Padding(4, 2, 4, 2);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 82;
            dataGridView.Size = new Size(1560, 568);
            dataGridView.TabIndex = 3;
            dataGridView.CellClick += dataGridView1_CellClick_1;
            // 
            // startDate
            // 
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(23, 70);
            startDate.Margin = new Padding(4, 2, 4, 2);
            startDate.Name = "startDate";
            startDate.Size = new Size(164, 39);
            startDate.TabIndex = 4;
            // 
            // finishDate
            // 
            finishDate.Format = DateTimePickerFormat.Short;
            finishDate.Location = new Point(226, 70);
            finishDate.Margin = new Padding(4, 2, 4, 2);
            finishDate.Name = "finishDate";
            finishDate.Size = new Size(162, 39);
            finishDate.TabIndex = 5;
            // 
            // applyButton
            // 
            applyButton.Location = new Point(475, 68);
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
            addButtom.Location = new Point(26, 17);
            addButtom.Margin = new Padding(4, 2, 4, 2);
            addButtom.Name = "addButtom";
            addButtom.Size = new Size(236, 47);
            addButtom.TabIndex = 8;
            addButtom.Text = "Добавить";
            addButtom.UseVisualStyleBackColor = true;
            addButtom.Click += AddButtom_Click;
            // 
            // sportSelector
            // 
            sportSelector.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sportSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            sportSelector.FormattingEnabled = true;
            sportSelector.Location = new Point(22, 75);
            sportSelector.Margin = new Padding(4, 2, 4, 2);
            sportSelector.Name = "sportSelector";
            sportSelector.Size = new Size(351, 40);
            sportSelector.TabIndex = 9;
            sportSelector.SelectedIndexChanged += sportSelector_SelectedIndexChanged;
            // 
            // reportButtom
            // 
            reportButtom.Location = new Point(26, 68);
            reportButtom.Margin = new Padding(4, 2, 4, 2);
            reportButtom.Name = "reportButtom";
            reportButtom.Size = new Size(236, 47);
            reportButtom.TabIndex = 10;
            reportButtom.Text = "Сброс фильтров";
            reportButtom.UseVisualStyleBackColor = true;
            reportButtom.Click += reportButtom_Click_1;
            // 
            // saveFileDialog
            // 
            saveFileDialog.Title = "Сохранить отчёт";
            // 
            // dataSelectorGroupBox
            // 
            dataSelectorGroupBox.Controls.Add(label7);
            dataSelectorGroupBox.Controls.Add(startDate);
            dataSelectorGroupBox.Controls.Add(finishDate);
            dataSelectorGroupBox.Controls.Add(applyButton);
            dataSelectorGroupBox.Location = new Point(41, 128);
            dataSelectorGroupBox.Name = "dataSelectorGroupBox";
            dataSelectorGroupBox.Size = new Size(703, 167);
            dataSelectorGroupBox.TabIndex = 11;
            dataSelectorGroupBox.TabStop = false;
            dataSelectorGroupBox.Text = "Выбор даты";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(188, 71);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(38, 32);
            label7.TabIndex = 49;
            label7.Text = "—";
            // 
            // sportSelectorGroupBox
            // 
            sportSelectorGroupBox.Anchor = AnchorStyles.Top;
            sportSelectorGroupBox.Controls.Add(sportSelector);
            sportSelectorGroupBox.Location = new Point(887, 128);
            sportSelectorGroupBox.Name = "sportSelectorGroupBox";
            sportSelectorGroupBox.Size = new Size(400, 167);
            sportSelectorGroupBox.TabIndex = 12;
            sportSelectorGroupBox.TabStop = false;
            sportSelectorGroupBox.Text = "Выбор спорта ";
            // 
            // button1
            // 
            button1.Location = new Point(26, 119);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(236, 47);
            button1.TabIndex = 14;
            button1.Text = "Отчёт";
            button1.UseVisualStyleBackColor = true;
            button1.Click += reportButtom_Click;
            // 
            // buttonsPanel
            // 
            buttonsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonsPanel.Controls.Add(button1);
            buttonsPanel.Controls.Add(addButtom);
            buttonsPanel.Controls.Add(reportButtom);
            buttonsPanel.Location = new Point(1320, 128);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(281, 184);
            buttonsPanel.TabIndex = 15;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1653, 941);
            Controls.Add(dataGridView);
            Controls.Add(dataSelectorGroupBox);
            Controls.Add(windowName);
            Controls.Add(sportSelectorGroupBox);
            Controls.Add(buttonsPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            MinimumSize = new Size(1679, 1012);
            Name = "MainWindow";
            Text = "SportMaster";
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            dataSelectorGroupBox.ResumeLayout(false);
            dataSelectorGroupBox.PerformLayout();
            sportSelectorGroupBox.ResumeLayout(false);
            buttonsPanel.ResumeLayout(false);
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
        private GroupBox dataSelectorGroupBox;
        private GroupBox sportSelectorGroupBox;
        private Label label7;
        private Panel buttonsPanel;
        private Button button1;
    }
}