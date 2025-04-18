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
            resources.ApplyResources(windowName, "windowName");
            windowName.Name = "windowName";
            // 
            // dataGridView
            // 
            resources.ApplyResources(dataGridView, "dataGridView");
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView.GridColor = SystemColors.GrayText;
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.CellClick += dataGridView1_CellClick_1;
            // 
            // startDate
            // 
            resources.ApplyResources(startDate, "startDate");
            startDate.CalendarTrailingForeColor = Color.Silver;
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Name = "startDate";
            // 
            // finishDate
            // 
            resources.ApplyResources(finishDate, "finishDate");
            finishDate.CalendarTrailingForeColor = Color.Silver;
            finishDate.Format = DateTimePickerFormat.Short;
            finishDate.Name = "finishDate";
            // 
            // applyButton
            // 
            resources.ApplyResources(applyButton, "applyButton");
            applyButton.FlatAppearance.BorderColor = Color.Silver;
            applyButton.Name = "applyButton";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += ApplyButton_Click;
            // 
            // addButtom
            // 
            resources.ApplyResources(addButtom, "addButtom");
            addButtom.FlatAppearance.BorderColor = Color.Silver;
            addButtom.Name = "addButtom";
            addButtom.UseVisualStyleBackColor = true;
            addButtom.Click += AddButtom_Click;
            // 
            // sportSelector
            // 
            resources.ApplyResources(sportSelector, "sportSelector");
            sportSelector.BackColor = Color.White;
            sportSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            sportSelector.FormattingEnabled = true;
            sportSelector.Name = "sportSelector";
            sportSelector.SelectedIndexChanged += sportSelector_SelectedIndexChanged;
            // 
            // reportButtom
            // 
            resources.ApplyResources(reportButtom, "reportButtom");
            reportButtom.FlatAppearance.BorderColor = Color.Silver;
            reportButtom.Name = "reportButtom";
            reportButtom.UseVisualStyleBackColor = true;
            reportButtom.Click += reportButtom_Click_1;
            // 
            // saveFileDialog
            // 
            resources.ApplyResources(saveFileDialog, "saveFileDialog");
            // 
            // dataSelectorGroupBox
            // 
            resources.ApplyResources(dataSelectorGroupBox, "dataSelectorGroupBox");
            dataSelectorGroupBox.Controls.Add(finishDate);
            dataSelectorGroupBox.Controls.Add(applyButton);
            dataSelectorGroupBox.Controls.Add(label7);
            dataSelectorGroupBox.Controls.Add(startDate);
            dataSelectorGroupBox.Name = "dataSelectorGroupBox";
            dataSelectorGroupBox.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // sportSelectorGroupBox
            // 
            resources.ApplyResources(sportSelectorGroupBox, "sportSelectorGroupBox");
            sportSelectorGroupBox.Controls.Add(sportSelector);
            sportSelectorGroupBox.Name = "sportSelectorGroupBox";
            sportSelectorGroupBox.TabStop = false;
            // 
            // button1
            // 
            resources.ApplyResources(button1, "button1");
            button1.FlatAppearance.BorderColor = Color.Silver;
            button1.Name = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += reportButtom_Click;
            // 
            // buttonsPanel
            // 
            resources.ApplyResources(buttonsPanel, "buttonsPanel");
            buttonsPanel.Controls.Add(button1);
            buttonsPanel.Controls.Add(addButtom);
            buttonsPanel.Controls.Add(reportButtom);
            buttonsPanel.Name = "buttonsPanel";
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dataGridView);
            Controls.Add(dataSelectorGroupBox);
            Controls.Add(windowName);
            Controls.Add(sportSelectorGroupBox);
            Controls.Add(buttonsPanel);
            Name = "MainWindow";
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