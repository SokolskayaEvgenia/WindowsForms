
namespace ITMO.CourseCS.FormsApp.Ex04._2
{
    partial class PersonList
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewEmployees = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonViewList = new System.Windows.Forms.Button();
            this.richTextBoxViewList = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // listViewEmployees
            // 
            this.listViewEmployees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderSurname,
            this.columnHeaderAge});
            this.listViewEmployees.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewEmployees.HideSelection = false;
            this.listViewEmployees.Location = new System.Drawing.Point(0, 0);
            this.listViewEmployees.Name = "listViewEmployees";
            this.listViewEmployees.Size = new System.Drawing.Size(514, 181);
            this.listViewEmployees.TabIndex = 0;
            this.listViewEmployees.UseCompatibleStateImageBehavior = false;
            this.listViewEmployees.View = System.Windows.Forms.View.Details;
            this.listViewEmployees.VirtualMode = true;
            this.listViewEmployees.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.listViewEmployees_RetrieveVirtualItem);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Имя";
            this.columnHeaderName.Width = 120;
            // 
            // columnHeaderSurname
            // 
            this.columnHeaderSurname.Text = "Фамилия";
            this.columnHeaderSurname.Width = 200;
            // 
            // columnHeaderAge
            // 
            this.columnHeaderAge.Text = "Возраст";
            this.columnHeaderAge.Width = 80;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(37, 209);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 40);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(307, 209);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(160, 40);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonViewList
            // 
            this.buttonViewList.Location = new System.Drawing.Point(37, 271);
            this.buttonViewList.Name = "buttonViewList";
            this.buttonViewList.Size = new System.Drawing.Size(430, 40);
            this.buttonViewList.TabIndex = 3;
            this.buttonViewList.Text = "Просмотреть список";
            this.buttonViewList.UseVisualStyleBackColor = true;
            this.buttonViewList.Click += new System.EventHandler(this.buttonViewList_Click);
            // 
            // richTextBoxViewList
            // 
            this.richTextBoxViewList.Location = new System.Drawing.Point(37, 317);
            this.richTextBoxViewList.Name = "richTextBoxViewList";
            this.richTextBoxViewList.Size = new System.Drawing.Size(430, 207);
            this.richTextBoxViewList.TabIndex = 4;
            this.richTextBoxViewList.Text = "";
            // 
            // PersonList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 536);
            this.Controls.Add(this.richTextBoxViewList);
            this.Controls.Add(this.buttonViewList);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PersonList";
            this.Text = "Список сотрудников";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewEmployees;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderSurname;
        private System.Windows.Forms.ColumnHeader columnHeaderAge;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonViewList;
        private System.Windows.Forms.RichTextBox richTextBoxViewList;
    }
}

