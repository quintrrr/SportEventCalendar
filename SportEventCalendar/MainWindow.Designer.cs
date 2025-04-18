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
            windowName.Location = new Point(13, 8);
            windowName.Margin = new Padding(2, 0, 2, 0);
            windowName.Name = "windowName";
            windowName.Size = new Size(417, 41);
            windowName.TabIndex = 2;
            windowName.Text = "Спортивные соревнования";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView.GridColor = SystemColors.GrayText;
            dataGridView.Location = new Point(25, 159);
            dataGridView.Margin = new Padding(2, 1, 2, 1);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 82;
            dataGridView.Size = new Size(960, 241);
            dataGridView.TabIndex = 3;
            dataGridView.CellClick += dataGridView1_CellClick_1;
            // 
            // startDate
            // 
            startDate.CalendarTrailingForeColor = Color.Silver;
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Location = new Point(22, 37);
            startDate.Margin = new Padding(2, 1, 2, 1);
            startDate.Name = "startDate";
            startDate.Size = new Size(102, 22);
            startDate.TabIndex = 4;
            // 
            // finishDate
            // 
            finishDate.CalendarTrailingForeColor = Color.Silver;
            finishDate.Format = DateTimePickerFormat.Short;
            finishDate.Location = new Point(158, 37);
            finishDate.Margin = new Padding(2, 1, 2, 1);
            finishDate.Name = "finishDate";
            finishDate.Size = new Size(101, 22);
            finishDate.TabIndex = 5;
            // 
            // applyButton
            // 
            applyButton.FlatAppearance.BorderColor = Color.Silver;
            applyButton.FlatStyle = FlatStyle.Flat;
            applyButton.Location = new Point(292, 34);
            applyButton.Margin = new Padding(2, 1, 2, 1);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(117, 26);
            applyButton.TabIndex = 6;
            applyButton.Text = "Применить";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += ApplyButton_Click;
            // 
            // addButtom
            // 
            addButtom.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addButtom.FlatAppearance.BorderColor = Color.Silver;
            addButtom.FlatStyle = FlatStyle.Flat;
            addButtom.Location = new Point(13, 13);
            addButtom.Margin = new Padding(2, 1, 2, 1);
            addButtom.Name = "addButtom";
            addButtom.Size = new Size(145, 26);
            addButtom.TabIndex = 8;
            addButtom.Text = "Добавить";
            addButtom.UseVisualStyleBackColor = true;
            addButtom.Click += AddButtom_Click;
            // 
            // sportSelector
            // 
            sportSelector.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sportSelector.BackColor = Color.White;
            sportSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            sportSelector.FormattingEnabled = true;
            sportSelector.Location = new Point(14, 37);
            sportSelector.Margin = new Padding(2, 1, 2, 1);
            sportSelector.Name = "sportSelector";
            sportSelector.Size = new Size(292, 22);
            sportSelector.TabIndex = 9;
            sportSelector.SelectedIndexChanged += sportSelector_SelectedIndexChanged;
            // 
            // reportButtom
            // 
            reportButtom.FlatAppearance.BorderColor = Color.Silver;
            reportButtom.FlatStyle = FlatStyle.Flat;
            reportButtom.Location = new Point(13, 41);
            reportButtom.Margin = new Padding(2, 1, 2, 1);
            reportButtom.Name = "reportButtom";
            reportButtom.Size = new Size(145, 24);
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
            dataSelectorGroupBox.Controls.Add(finishDate);
            dataSelectorGroupBox.Controls.Add(applyButton);
            dataSelectorGroupBox.Controls.Add(label7);
            dataSelectorGroupBox.Controls.Add(startDate);
            dataSelectorGroupBox.Location = new Point(25, 62);
            dataSelectorGroupBox.Margin = new Padding(2, 1, 2, 1);
            dataSelectorGroupBox.Name = "dataSelectorGroupBox";
            dataSelectorGroupBox.Padding = new Padding(2, 1, 2, 1);
            dataSelectorGroupBox.Size = new Size(433, 89);
            dataSelectorGroupBox.TabIndex = 11;
            dataSelectorGroupBox.TabStop = false;
            dataSelectorGroupBox.Text = "Выбор даты";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(132, 40);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(19, 14);
            label7.TabIndex = 49;
            label7.Text = "—";
            // 
            // sportSelectorGroupBox
            // 
            sportSelectorGroupBox.Controls.Add(sportSelector);
            sportSelectorGroupBox.Location = new Point(482, 62);
            sportSelectorGroupBox.Margin = new Padding(2, 1, 2, 1);
            sportSelectorGroupBox.Name = "sportSelectorGroupBox";
            sportSelectorGroupBox.Padding = new Padding(2, 1, 2, 1);
            sportSelectorGroupBox.Size = new Size(321, 89);
            sportSelectorGroupBox.TabIndex = 12;
            sportSelectorGroupBox.TabStop = false;
            sportSelectorGroupBox.Text = "Выбор спорта ";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(13, 67);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(145, 24);
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
            buttonsPanel.Location = new Point(827, 56);
            buttonsPanel.Margin = new Padding(2, 1, 2, 1);
            buttonsPanel.Name = "buttonsPanel";
            buttonsPanel.Size = new Size(173, 94);
            buttonsPanel.TabIndex = 15;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1023, 426);
            Controls.Add(dataGridView);
            Controls.Add(dataSelectorGroupBox);
            Controls.Add(windowName);
            Controls.Add(sportSelectorGroupBox);
            Controls.Add(buttonsPanel);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 1, 2, 1);
            MinimumSize = new Size(1039, 465);
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