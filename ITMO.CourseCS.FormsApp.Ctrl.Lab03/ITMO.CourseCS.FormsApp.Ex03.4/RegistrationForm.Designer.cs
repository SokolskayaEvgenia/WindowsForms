
namespace ITMO.CourseCS.FormsApp.Ex03._4
{
    partial class RegistrationForm
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
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.userControlRegForm1 = new ITMO.CourseCS.FormsApp.Ex03._4.UserControlRegForm();
            this.SuspendLayout();
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistration.Location = new System.Drawing.Point(36, 427);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(390, 60);
            this.buttonRegistration.TabIndex = 1;
            this.buttonRegistration.Text = "Регистрация";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Location = new System.Drawing.Point(36, 525);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(390, 160);
            this.richTextBoxInfo.TabIndex = 2;
            this.richTextBoxInfo.Text = "";
            this.richTextBoxInfo.Visible = false;
            // 
            // userControlRegForm1
            // 
            this.userControlRegForm1.BackColor = System.Drawing.SystemColors.Control;
            this.userControlRegForm1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.userControlRegForm1.Birthday = new System.DateTime(2020, 12, 4, 20, 30, 55, 989);
            this.userControlRegForm1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControlRegForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRegForm1.EMail = "";
            this.userControlRegForm1.FavoriteBook = "";
            this.userControlRegForm1.Location = new System.Drawing.Point(0, 0);
            this.userControlRegForm1.Name = "userControlRegForm1";
            this.userControlRegForm1.PersonName = "";
            this.userControlRegForm1.PersonSurname = "";
            this.userControlRegForm1.Size = new System.Drawing.Size(463, 705);
            this.userControlRegForm1.TabIndex = 3;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 705);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.userControlRegForm1);
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.Text = "Регистрационная карточка";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private UserControlRegForm userControlRegForm1;
    }
}

