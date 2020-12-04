using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CourseCS.FormsApp.Ex04._2
{
    public partial class PersonList : Form
    {
        public PersonList()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            pers.Add(p);
            listViewEmployees.VirtualListSize = pers.Count;
            listViewEmployees.Invalidate();
            //ListViewItem newItem = listViewEmployees.Items.Add(editForm.FirstName);
            //newItem.SubItems.Add(editForm.LastName);
            //newItem.SubItems.Add(editForm.Age.ToString());
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            //if (listViewEmployees.SelectedItems.Count == 0)
            //    return;
            //ListViewItem item = listViewEmployees.SelectedItems[0];

            //EditPersonForm editForm = new EditPersonForm();
            //editForm.FirstName = item.Text;
            //editForm.LastName = item.SubItems[1].Text;
            //editForm.Age = Convert.ToInt32(item.SubItems[2].Text);

            //if (editForm.ShowDialog() != DialogResult.OK)
            //    return;
            //item.Text = editForm.FirstName;
            //item.SubItems[1].Text = editForm.LastName;
            //item.SubItems[2].Text = editForm.Age.ToString();

               if (listViewEmployees.SelectedIndices.Count == 0)
                    return;
                Person p = pers[listViewEmployees.SelectedIndices[0]];
                EditPersonForm editForm = new EditPersonForm(p);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                listViewEmployees.Invalidate();
                }
            

        }

        List<Person> pers = new List<Person>();

        private void listViewEmployees_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            {
                if (e.ItemIndex >= 0 && e.ItemIndex < pers.Count)
                {
                    e.Item = new ListViewItem(pers[e.ItemIndex].FirstName);
                    e.Item.SubItems.Add(pers[e.ItemIndex].LastName);
                    e.Item.SubItems.Add(pers[e.ItemIndex].Age.ToString());
                }
            }
        }

        private void buttonViewList_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Person item in pers)
            {
                sb.Append("\nСотрудник: \n" + item.ToString());
            }
            richTextBoxViewList.Text = sb.ToString();
        }
    }
}
