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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEventCreationWindow));
            windowName = new Label();
            newEventName = new TextBox();
            NewEventDescription = new TextBox();
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
            resources.ApplyResources(windowName, "windowName");
            windowName.Name = "windowName";
            // 
            // newEventName
            // 
            resources.ApplyResources(newEventName, "newEventName");
            newEventName.BorderStyle = BorderStyle.None;
            newEventName.Name = "newEventName";
            newEventName.TabStop = false;
            // 
            // NewEventDescription
            // 
            resources.ApplyResources(NewEventDescription, "NewEventDescription");
            NewEventDescription.BackColor = Color.White;
            NewEventDescription.BorderStyle = BorderStyle.None;
            NewEventDescription.Name = "NewEventDescription";
            NewEventDescription.TabStop = false;
            // 
            // startDate
            // 
            resources.ApplyResources(startDate, "startDate");
            startDate.Format = DateTimePickerFormat.Short;
            startDate.Name = "startDate";
            startDate.TabStop = false;
            // 
            // finishDate
            // 
            resources.ApplyResources(finishDate, "finishDate");
            finishDate.Format = DateTimePickerFormat.Short;
            finishDate.Name = "finishDate";
            finishDate.TabStop = false;
            // 
            // sportSelector
            // 
            resources.ApplyResources(sportSelector, "sportSelector");
            sportSelector.BackColor = Color.White;
            sportSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            sportSelector.Name = "sportSelector";
            sportSelector.SelectedIndexChanged += sportSelector_SelectedIndexChanged;
            // 
            // pictureBox
            // 
            resources.ApplyResources(pictureBox, "pictureBox");
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Name = "pictureBox";
            pictureBox.TabStop = false;
            // 
            // create_button
            // 
            resources.ApplyResources(create_button, "create_button");
            create_button.FlatAppearance.BorderColor = Color.Silver;
            create_button.Name = "create_button";
            create_button.UseVisualStyleBackColor = true;
            create_button.Click += create_button_Click;
            // 
            // canсel
            // 
            resources.ApplyResources(canсel, "canсel");
            canсel.FlatAppearance.BorderColor = Color.Silver;
            canсel.Name = "canсel";
            canсel.UseVisualStyleBackColor = true;
            canсel.Click += cancel_Click;
            // 
            // imageButton
            // 
            resources.ApplyResources(imageButton, "imageButton");
            imageButton.FlatAppearance.BorderColor = Color.Silver;
            imageButton.Name = "imageButton";
            imageButton.UseVisualStyleBackColor = true;
            imageButton.Click += imageButton_Click;
            // 
            // openFileDialog
            // 
            resources.ApplyResources(openFileDialog, "openFileDialog");
            // 
            // timePicker
            // 
            resources.ApplyResources(timePicker, "timePicker");
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.TabStop = false;
            // 
            // teamSelectorCheckBox
            // 
            resources.ApplyResources(teamSelectorCheckBox, "teamSelectorCheckBox");
            teamSelectorCheckBox.BorderStyle = BorderStyle.None;
            teamSelectorCheckBox.CheckOnClick = true;
            teamSelectorCheckBox.FormattingEnabled = true;
            teamSelectorCheckBox.Name = "teamSelectorCheckBox";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(finishDate);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(startDate);
            groupBox1.Controls.Add(timePicker);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Controls.Add(teamSelectorCheckBox);
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            resources.ApplyResources(groupBox3, "groupBox3");
            groupBox3.Controls.Add(sportSelector);
            groupBox3.Name = "groupBox3";
            groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            resources.ApplyResources(groupBox4, "groupBox4");
            groupBox4.Controls.Add(newEventName);
            groupBox4.ForeColor = SystemColors.ControlDarkDark;
            groupBox4.Name = "groupBox4";
            groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            resources.ApplyResources(groupBox5, "groupBox5");
            groupBox5.BackColor = Color.White;
            groupBox5.Controls.Add(NewEventDescription);
            groupBox5.ForeColor = SystemColors.ControlDarkDark;
            groupBox5.Name = "groupBox5";
            groupBox5.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(groupBox4);
            panel1.Controls.Add(groupBox5);
            panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Controls.Add(groupBox1);
            panel2.Controls.Add(groupBox2);
            panel2.Name = "panel2";
            // 
            // panel3
            // 
            resources.ApplyResources(panel3, "panel3");
            panel3.Controls.Add(groupBox3);
            panel3.Name = "panel3";
            // 
            // panel4
            // 
            resources.ApplyResources(panel4, "panel4");
            panel4.Controls.Add(pictureBox);
            panel4.Controls.Add(imageButton);
            panel4.Name = "panel4";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel3, 1, 1);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // NewEventCreationWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(canсel);
            Controls.Add(create_button);
            Controls.Add(windowName);
            Name = "NewEventCreationWindow";
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
        private TextBox NewEventDescription;
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
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
