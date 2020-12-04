using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ITMO.CourseCS.FormsApp.Ex03._4
{
    public partial class UserControlRegForm : UserControl
    {
        public UserControlRegForm()
        {
            InitializeComponent();
        }

        public string PersonSurname
        {
            get { return textBoxSurname.Text; }
            set { textBoxSurname.Text = value; }
        }

        public string PersonName
        {
            get { return textBoxName.Text; }
            set { textBoxName.Text = value; }
        }

        public DateTime Birthday
        {
            get { return dateTimePickerBirthday.Value; }
            set { dateTimePickerBirthday.Value = value; }
        }

        public string EMail
        {
            get { return textBoxEMail.Text; }
            set { textBoxEMail.Text = value; }
        }

        public string FavoriteBook
        {
            get { return textBoxFavBook.Text; }
            set { textBoxFavBook.Text = value; }

        }



        private void dateTimePickerBirthday_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePickerBirthday.Value < DateTime.Now)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Выбранная дата не может быть больше текущей");
            }

        }

        public bool ValidEmailAddress(string emailAddress, out string errorMessage)
        {
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    errorMessage = "";
                    return true;
                }
            }
            errorMessage = "Адрес электронной почты должен иметь действительный формат\n" + "Например, 'someone@example.com'";
            return false;
        }

        private void textBoxEMail_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            if (!ValidEmailAddress(textBoxEMail.Text, out errorMsg))
            {
                e.Cancel = true;
                textBoxEMail.Select(0, textBoxEMail.Text.Length);
                this.errorProvider1.SetError(textBoxEMail, errorMsg);

            }
            else
            {
                             
                this.errorProvider1.SetError(textBoxEMail, "");
            }
        }

        private void textBoxSurname_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxSurname.Text == "")
            {
                e.Cancel = true;
                MessageBox.Show("Поле не может быть пустым!");
            }
            else
            {
                foreach (char c in textBoxSurname.Text)
                    if (char.IsDigit(c))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Поле Фамилия не может содержать цифры!");
                    }
                    else
                        e.Cancel = false;
            }
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxName.Text == "")
            {
                e.Cancel = true;
                MessageBox.Show("Поле не может быть пустым!");
            }
            else
            {
                foreach (char c in textBoxName.Text)
                    if (char.IsDigit(c))
                    {
                        e.Cancel = true;
                        MessageBox.Show("Поле Имя не может содержать цифры!");
                    }
                    else
                        e.Cancel = false;
            }
        }
    }


}
