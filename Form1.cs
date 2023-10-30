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
            string gender = MaleRadioButton.Checked ? "Мужской" : "Женский";
            string birthDate = BirthDateTimePicker.Value.ToShortDateString();
            string maritalStatus = MaritalStatusComboBox.SelectedItem?.ToString() ?? "";
            string additionalInfo = AdditionalInfoTextBox.Text;

            string userInfo = $"Фамилия: {lastName}\r\nИмя: {firstName}\r\nОтчество: {middleName}\r\nПол: {gender}\r\n" +
                             $"Год и дата рождения: {birthDate}\r\nСемейный статус: {maritalStatus}\r\n" +
                             $"Дополнительная информация: {additionalInfo}";

            string filePath = "user_info.txt";

            try
            {
                File.WriteAllText(filePath, userInfo);
                MessageBox.Show("Информация успешно сохранена в файл 'user_info.txt'", "Сохранение");
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при сохранении информации: " + ex.Message, "Ошибка");
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