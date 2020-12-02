using MyClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace ITMO.CourseCS.FormsApp.Ex02._6
{
    public partial class BiblWorm : Form
    {
        public BiblWorm()
        {
            InitializeComponent();
        }

        public string Author // автор
        {
            get
            { return textBoxAuthor.Text; }
            set
            { textBoxAuthor.Text = value; }
        }
        public string Title // Название
        {
            get
            {
                if (tabControlLib.SelectedTab == tabPageBooks)
                    return textBoxTitle.Text;
                else
                    return textBoxTitleM.Text;
            }
            set
            {
                if (tabControlLib.SelectedTab == tabPageBooks)
                    textBoxTitle.Text = value;
                else
                    textBoxTitleM.Text = value;
            }
        }

        public string Volume
        {
            get { return textBoxVol.Text; }
            set { textBoxVol.Text = value; }
        }

        public int Number
        {
            get { return (int)numericUpDownNumberM.Value; }
            set { numericUpDownNumberM.Value = value; }
        }
        public string Publisher // Издательство
        {
            get { return textBoxPublishing.Text; }
            set { textBoxPublishing.Text = value; }
        }
        public int Page // Количество страниц
        {
            get { return (int)numericUpDownPages.Value; }
            set { numericUpDownPages.Value = value; }
        }
        public int Year // Год издания
        {
            get
            {
                if (tabControlLib.SelectedTab == tabPageBooks)
                    return (int)numericUpDownYear.Value;
                else
                    return (int)numericUpDownYearM.Value;
            }
            set
            {
                if (tabControlLib.SelectedTab == tabPageBooks)
                    numericUpDownYear.Value = value;
                else
                    numericUpDownYearM.Value = value;
            }
        }
        public int InvNumber // Инвентарный номер
        {
            get
            {
                if (tabControlLib.SelectedTab == tabPageBooks)
                    return (int)numericUpDownInvNumber.Value;
                else
                    return (int)numericUpDownInvNumberM.Value;
            }
            set
            {
                if (tabControlLib.SelectedTab == tabPageBooks)
                    numericUpDownInvNumber.Value = value;
                else
                    numericUpDownInvNumberM.Value = value;
            }
        }
        public bool Existence // Наличие
        {
            get
            {
                if (tabControlLib.SelectedTab == tabPageBooks)
                    return checkBoxAvailability.Checked;
                else
                    return checkBoxAvailabilityM.Checked;
            }
            set
            {
                if (tabControlLib.SelectedTab == tabPageBooks)
                    checkBoxAvailability.Checked = value;
                else
                    checkBoxAvailabilityM.Checked = value;
            }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBoxSort.Checked; }
            set { checkBoxSort.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBoxReturn.Checked; }
            set { checkBoxReturn.Checked = value; }
        }
        public int PeriodUse // Срок использования
        {
            get { return (int)numericUpDownUseTerm.Value; }
            set { numericUpDownUseTerm.Value = value; }
        }

        public bool Subs
        {
            get { return checkBoxSubs.Checked; }
            set { checkBoxSubs.Checked = value; }
        }

        List<Item> its = new List<Item>();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, Publisher, Page, Year, InvNumber, Existence);
            if (ReturnTime)
                b.ReturnSrok();
            b.PriceBook(PeriodUse);
            its.Add(b);
            Author = Title = Publisher = "";
            Page = 1;
            InvNumber = PeriodUse = 0;
            Year = 1900;
            Existence = ReturnTime = false;
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            if (SortInvNumber)
                its.Sort();
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }
            richTextBoxItemInfo.Text = sb.ToString();
        }

        private void buttonAddM_Click(object sender, EventArgs e)
        {
            Magazine m = new Magazine(Title, Volume, Number, Year, InvNumber, Existence);
            if (Subs)
                m.Subs();
            its.Add(m);
            Volume = Title = "";
            Number = 1;
            InvNumber = 0;
            Year = 1900;
            Existence = Subs = false;
        }
    }
}
