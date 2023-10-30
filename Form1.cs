using System;
using System.Windows.Forms;

namespace additionallyhomework3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastName = LastNameTextBox.Text;
            string firstName = FirstNameTextBox.Text;
            string middleName = MiddleNameTextBox.Text;
            string gender = MaleRadioButton.Checked ? "�������" : "�������";
            string birthDate = BirthDateTimePicker.Value.ToShortDateString();
            string maritalStatus = MaritalStatusComboBox.SelectedItem?.ToString() ?? "";
            string additionalInfo = AdditionalInfoTextBox.Text;

            string userInfo = $"�������: {lastName}\r\n���: {firstName}\r\n��������: {middleName}\r\n���: {gender}\r\n" +
                             $"��� � ���� ��������: {birthDate}\r\n�������� ������: {maritalStatus}\r\n" +
                             $"�������������� ����������: {additionalInfo}";

            string filePath = "user_info.txt";

            try
            {
                File.WriteAllText(filePath, userInfo);
                MessageBox.Show("���������� ������� ��������� � ���� 'user_info.txt'", "����������");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("��������� ������ ��� ���������� ����������: " + ex.Message, "������");
            }
        }

        private void ClearFields()
        {
            LastNameTextBox.Clear();
            FirstNameTextBox.Clear();
            MiddleNameTextBox.Clear();
            MaleRadioButton.Checked = false;
            FemaleRadioButton.Checked = false;
            BirthDateTimePicker.Value = DateTime.Now;
            MaritalStatusComboBox.SelectedIndex = -1;
            AdditionalInfoTextBox.Clear();
        }
    }
}