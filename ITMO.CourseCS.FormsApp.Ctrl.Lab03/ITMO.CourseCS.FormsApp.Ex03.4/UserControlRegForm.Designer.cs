
namespace ITMO.CourseCS.FormsApp.Ex03._4
{
    partial class UserControlRegForm
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelEMail = new System.Windows.Forms.Label();
            this.labelFavBook = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.textBoxFavBook = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSurname.Location = new System.Drawing.Point(27, 36);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(87, 20);
            this.labelSurname.TabIndex = 0;
            this.labelSurname.Text = "Фамилия";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(27, 113);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Имя";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBirthday.Location = new System.Drawing.Point(27, 190);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(141, 20);
            this.labelBirthday.TabIndex = 1;
            this.labelBirthday.Text = "Дата рождения";
            // 
            // labelEMail
            // 
            this.labelEMail.AutoSize = true;
            this.labelEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEMail.Location = new System.Drawing.Point(27, 267);
            this.labelEMail.Name = "labelEMail";
            this.labelEMail.Size = new System.Drawing.Size(176, 20);
            this.labelEMail.TabIndex = 1;
            this.labelEMail.Text = "Электронная почта";
            // 
            // labelFavBook
            // 
            this.labelFavBook.AutoSize = true;
            this.labelFavBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFavBook.Location = new System.Drawing.Point(27, 344);
            this.labelFavBook.Name = "labelFavBook";
            this.labelFavBook.Size = new System.Drawing.Size(138, 20);
            this.labelFavBook.TabIndex = 1;
            this.labelFavBook.Text = "Любимая книга";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(34, 59);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(390, 26);
            this.textBoxSurname.TabIndex = 0;
            this.textBoxSurname.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSurname_Validating);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(34, 136);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(390, 26);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(34, 213);
            this.dateTimePickerBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBirthday.TabIndex = 3;
            this.dateTimePickerBirthday.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerBirthday_Validating);
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEMail.Location = new System.Drawing.Point(34, 290);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(390, 26);
            this.textBoxEMail.TabIndex = 4;
            this.textBoxEMail.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEMail_Validating);
            // 
            // textBoxFavBook
            // 
            this.textBoxFavBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFavBook.Location = new System.Drawing.Point(34, 367);
            this.textBoxFavBook.Name = "textBoxFavBook";
            this.textBoxFavBook.Size = new System.Drawing.Size(390, 26);
            this.textBoxFavBook.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UserControlRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.dateTimePickerBirthday);
            this.Controls.Add(this.textBoxFavBook);
            this.Controls.Add(this.textBoxEMail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelFavBook);
            this.Controls.Add(this.labelEMail);
            this.Controls.Add(this.labelBirthday);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSurname);
            this.DoubleBuffered = true;
            this.Name = "UserControlRegForm";
            this.Size = new System.Drawing.Size(463, 504);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Label labelEMail;
        private System.Windows.Forms.Label labelFavBook;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.TextBox textBoxEMail;
        private System.Windows.Forms.TextBox textBoxFavBook;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
