using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ITMO.CourseCS.FormsApp.Ex03._4
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            
        }

            
        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            Person p = new Person(userControlRegForm1.PersonName, userControlRegForm1.PersonSurname, userControlRegForm1.Birthday, userControlRegForm1.EMail, userControlRegForm1.FavoriteBook);
            richTextBoxInfo.Visible = true;
            richTextBoxInfo.Text = "Приветствуем в клубе любителей чтения! \n\nВаши данные: " + p.ToString();
        }
    }
}

