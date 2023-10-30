using System;

namespace additionallyhomework3
{
    partial class Form1
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
            label1 = new Label();
            LastNameTextBox = new TextBox();
            label2 = new Label();
            FirstNameTextBox = new TextBox();
            MiddleNameTextBox = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            FemaleRadioButton = new RadioButton();
            MaleRadioButton = new RadioButton();
            BirthDateTimePicker = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            MaritalStatusComboBox = new ComboBox();
            AdditionalInfoTextBox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 15);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "ведите фамилию";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(313, 15);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(125, 27);
            LastNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 62);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 2;
            label2.Text = "Ведите имя";
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(313, 59);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(125, 27);
            FirstNameTextBox.TabIndex = 3;
            // 
            // MiddleNameTextBox
            // 
            MiddleNameTextBox.Location = new Point(313, 109);
            MiddleNameTextBox.Name = "MiddleNameTextBox";
            MiddleNameTextBox.Size = new Size(125, 27);
            MiddleNameTextBox.TabIndex = 4;
            MiddleNameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 109);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 5;
            label3.Text = "Ведите отчество";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FemaleRadioButton);
            groupBox1.Controls.Add(MaleRadioButton);
            groupBox1.Location = new Point(273, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(277, 125);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // FemaleRadioButton
            // 
            FemaleRadioButton.AutoSize = true;
            FemaleRadioButton.Location = new Point(85, 56);
            FemaleRadioButton.Name = "FemaleRadioButton";
            FemaleRadioButton.Size = new Size(92, 24);
            FemaleRadioButton.TabIndex = 1;
            FemaleRadioButton.Text = "Женский";
            FemaleRadioButton.UseVisualStyleBackColor = true;
            FemaleRadioButton.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Checked = true;
            MaleRadioButton.Location = new Point(86, 26);
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Size = new Size(91, 24);
            MaleRadioButton.TabIndex = 0;
            MaleRadioButton.TabStop = true;
            MaleRadioButton.Text = "мужской";
            MaleRadioButton.UseVisualStyleBackColor = true;
            MaleRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // BirthDateTimePicker
            // 
            BirthDateTimePicker.Location = new Point(188, 259);
            BirthDateTimePicker.Name = "BirthDateTimePicker";
            BirthDateTimePicker.Size = new Size(250, 27);
            BirthDateTimePicker.TabIndex = 2;
            BirthDateTimePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 266);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 7;
            label4.Text = "Введите дату рождения";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 160);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 8;
            label5.Text = "выберите пол";
            // 
            // MaritalStatusComboBox
            // 
            MaritalStatusComboBox.FormattingEnabled = true;
            MaritalStatusComboBox.Items.AddRange(new object[] { "женат/замужем", "не женат/не замужем" });
            MaritalStatusComboBox.Location = new Point(287, 292);
            MaritalStatusComboBox.Name = "MaritalStatusComboBox";
            MaritalStatusComboBox.Size = new Size(151, 28);
            MaritalStatusComboBox.TabIndex = 9;
            MaritalStatusComboBox.SelectedIndexChanged += MaritalStatusComboBox_SelectedIndexChanged;
            // 
            // AdditionalInfoTextBox
            // 
            AdditionalInfoTextBox.Location = new Point(313, 326);
            AdditionalInfoTextBox.Name = "AdditionalInfoTextBox";
            AdditionalInfoTextBox.Size = new Size(125, 27);
            AdditionalInfoTextBox.TabIndex = 10;
            AdditionalInfoTextBox.TextChanged += textBox1_TextChanged_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 329);
            label6.Name = "label6";
            label6.Size = new Size(222, 20);
            label6.TabIndex = 11;
            label6.Text = "Дополнительная информация";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(112, 295);
            label7.Name = "label7";
            label7.Size = new Size(164, 20);
            label7.TabIndex = 12;
            label7.Text = "Семейное положение";
            // 
            // button1
            // 
            button1.Location = new Point(324, 372);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 433);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(AdditionalInfoTextBox);
            Controls.Add(MaritalStatusComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(BirthDateTimePicker);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(MiddleNameTextBox);
            Controls.Add(FirstNameTextBox);
            Controls.Add(label2);
            Controls.Add(LastNameTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void MaritalStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private DateTimePicker GetDateTimePicker1()
        {
            return dateTimePicker1;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e, DateTimePicker dateTimePicker1)
        {
            DateTimePicker datePicker = (DateTimePicker)sender; // Cast sender to DateTimePicker
            DateTime selectedDate = datePicker.Value;

            // Now, you can work with the selected date
            // For example, display it in a MessageBox
            MessageBox.Show("Selected Date: " + selectedDate.ToShortDateString());
        }

    
        
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private TextBox LastNameTextBox;
        private Label label2;
        private TextBox FirstNameTextBox;
        private TextBox MiddleNameTextBox;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton FemaleRadioButton;
        private RadioButton MaleRadioButton;
        private DateTimePicker BirthDateTimePicker;
        private Label label4;
        private Label label5;
        private ComboBox MaritalStatusComboBox;
        private TextBox AdditionalInfoTextBox;
        private Label label6;
        private Label label7;
        private Button button1;
        private DateTimePicker dateTimePicker1;
    }
}