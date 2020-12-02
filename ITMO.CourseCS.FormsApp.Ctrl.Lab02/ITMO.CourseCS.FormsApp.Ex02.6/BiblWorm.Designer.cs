
namespace ITMO.CourseCS.FormsApp.Ex02._6
{
    partial class BiblWorm
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
            this.tabControlLib = new System.Windows.Forms.TabControl();
            this.tabPageBooks = new System.Windows.Forms.TabPage();
            this.numericUpDownUseTerm = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownInvNumber = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYear = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPages = new System.Windows.Forms.NumericUpDown();
            this.textBoxPublishing = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.checkBoxReturn = new System.Windows.Forms.CheckBox();
            this.checkBoxAvailability = new System.Windows.Forms.CheckBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelUseTerm = new System.Windows.Forms.Label();
            this.labelInvNumber = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelPages = new System.Windows.Forms.Label();
            this.labelPublishing = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.tabPageMagazine = new System.Windows.Forms.TabPage();
            this.numericUpDownYearM = new System.Windows.Forms.NumericUpDown();
            this.checkBoxSubs = new System.Windows.Forms.CheckBox();
            this.numericUpDownInvNumberM = new System.Windows.Forms.NumericUpDown();
            this.checkBoxAvailabilityM = new System.Windows.Forms.CheckBox();
            this.buttonAddM = new System.Windows.Forms.Button();
            this.labelInvNumberM = new System.Windows.Forms.Label();
            this.numericUpDownNumberM = new System.Windows.Forms.NumericUpDown();
            this.labelYearM = new System.Windows.Forms.Label();
            this.labelNumberM = new System.Windows.Forms.Label();
            this.labelVol = new System.Windows.Forms.Label();
            this.textBoxTitleM = new System.Windows.Forms.TextBox();
            this.labelTitleM = new System.Windows.Forms.Label();
            this.richTextBoxItemInfo = new System.Windows.Forms.RichTextBox();
            this.buttonView = new System.Windows.Forms.Button();
            this.checkBoxSort = new System.Windows.Forms.CheckBox();
            this.textBoxVol = new System.Windows.Forms.TextBox();
            this.tabControlLib.SuspendLayout();
            this.tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUseTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInvNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPages)).BeginInit();
            this.tabPageMagazine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInvNumberM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberM)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlLib
            // 
            this.tabControlLib.Controls.Add(this.tabPageBooks);
            this.tabControlLib.Controls.Add(this.tabPageMagazine);
            this.tabControlLib.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControlLib.Location = new System.Drawing.Point(0, 0);
            this.tabControlLib.Name = "tabControlLib";
            this.tabControlLib.SelectedIndex = 0;
            this.tabControlLib.Size = new System.Drawing.Size(335, 404);
            this.tabControlLib.TabIndex = 0;
            // 
            // tabPageBooks
            // 
            this.tabPageBooks.Controls.Add(this.numericUpDownUseTerm);
            this.tabPageBooks.Controls.Add(this.numericUpDownInvNumber);
            this.tabPageBooks.Controls.Add(this.numericUpDownYear);
            this.tabPageBooks.Controls.Add(this.numericUpDownPages);
            this.tabPageBooks.Controls.Add(this.textBoxPublishing);
            this.tabPageBooks.Controls.Add(this.textBoxTitle);
            this.tabPageBooks.Controls.Add(this.textBoxAuthor);
            this.tabPageBooks.Controls.Add(this.checkBoxReturn);
            this.tabPageBooks.Controls.Add(this.checkBoxAvailability);
            this.tabPageBooks.Controls.Add(this.buttonAdd);
            this.tabPageBooks.Controls.Add(this.labelUseTerm);
            this.tabPageBooks.Controls.Add(this.labelInvNumber);
            this.tabPageBooks.Controls.Add(this.labelYear);
            this.tabPageBooks.Controls.Add(this.labelPages);
            this.tabPageBooks.Controls.Add(this.labelPublishing);
            this.tabPageBooks.Controls.Add(this.labelName);
            this.tabPageBooks.Controls.Add(this.labelAuthor);
            this.tabPageBooks.Location = new System.Drawing.Point(4, 25);
            this.tabPageBooks.Name = "tabPageBooks";
            this.tabPageBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBooks.Size = new System.Drawing.Size(327, 375);
            this.tabPageBooks.TabIndex = 0;
            this.tabPageBooks.Text = "Книги";
            this.tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // numericUpDownUseTerm
            // 
            this.numericUpDownUseTerm.Location = new System.Drawing.Point(153, 243);
            this.numericUpDownUseTerm.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownUseTerm.Name = "numericUpDownUseTerm";
            this.numericUpDownUseTerm.Size = new System.Drawing.Size(157, 22);
            this.numericUpDownUseTerm.TabIndex = 6;
            // 
            // numericUpDownInvNumber
            // 
            this.numericUpDownInvNumber.Location = new System.Drawing.Point(132, 205);
            this.numericUpDownInvNumber.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownInvNumber.Name = "numericUpDownInvNumber";
            this.numericUpDownInvNumber.Size = new System.Drawing.Size(178, 22);
            this.numericUpDownInvNumber.TabIndex = 5;
            // 
            // numericUpDownYear
            // 
            this.numericUpDownYear.Location = new System.Drawing.Point(132, 167);
            this.numericUpDownYear.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDownYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownYear.Name = "numericUpDownYear";
            this.numericUpDownYear.Size = new System.Drawing.Size(178, 22);
            this.numericUpDownYear.TabIndex = 4;
            this.numericUpDownYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // numericUpDownPages
            // 
            this.numericUpDownPages.Location = new System.Drawing.Point(132, 129);
            this.numericUpDownPages.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDownPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPages.Name = "numericUpDownPages";
            this.numericUpDownPages.Size = new System.Drawing.Size(178, 22);
            this.numericUpDownPages.TabIndex = 3;
            this.numericUpDownPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxPublishing
            // 
            this.textBoxPublishing.Location = new System.Drawing.Point(114, 90);
            this.textBoxPublishing.Name = "textBoxPublishing";
            this.textBoxPublishing.Size = new System.Drawing.Size(196, 22);
            this.textBoxPublishing.TabIndex = 2;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(114, 52);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(196, 22);
            this.textBoxTitle.TabIndex = 1;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(114, 14);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(196, 22);
            this.textBoxAuthor.TabIndex = 0;
            // 
            // checkBoxReturn
            // 
            this.checkBoxReturn.AutoSize = true;
            this.checkBoxReturn.Location = new System.Drawing.Point(153, 289);
            this.checkBoxReturn.Name = "checkBoxReturn";
            this.checkBoxReturn.Size = new System.Drawing.Size(157, 21);
            this.checkBoxReturn.TabIndex = 8;
            this.checkBoxReturn.Text = "Возвращено в срок";
            this.checkBoxReturn.UseVisualStyleBackColor = true;
            // 
            // checkBoxAvailability
            // 
            this.checkBoxAvailability.AutoSize = true;
            this.checkBoxAvailability.Location = new System.Drawing.Point(20, 289);
            this.checkBoxAvailability.Name = "checkBoxAvailability";
            this.checkBoxAvailability.Size = new System.Drawing.Size(88, 21);
            this.checkBoxAvailability.TabIndex = 7;
            this.checkBoxAvailability.Text = "Наличие";
            this.checkBoxAvailability.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 325);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(304, 41);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelUseTerm
            // 
            this.labelUseTerm.AutoSize = true;
            this.labelUseTerm.Location = new System.Drawing.Point(8, 245);
            this.labelUseTerm.Name = "labelUseTerm";
            this.labelUseTerm.Size = new System.Drawing.Size(144, 17);
            this.labelUseTerm.TabIndex = 0;
            this.labelUseTerm.Text = "Срок использования";
            // 
            // labelInvNumber
            // 
            this.labelInvNumber.AutoSize = true;
            this.labelInvNumber.Location = new System.Drawing.Point(8, 207);
            this.labelInvNumber.Name = "labelInvNumber";
            this.labelInvNumber.Size = new System.Drawing.Size(123, 17);
            this.labelInvNumber.TabIndex = 0;
            this.labelInvNumber.Text = "Интвентарный №";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(8, 169);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(91, 17);
            this.labelYear.TabIndex = 0;
            this.labelYear.Text = "Год издания";
            // 
            // labelPages
            // 
            this.labelPages.AutoSize = true;
            this.labelPages.Location = new System.Drawing.Point(8, 131);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(64, 17);
            this.labelPages.TabIndex = 0;
            this.labelPages.Text = "Страниц";
            // 
            // labelPublishing
            // 
            this.labelPublishing.AutoSize = true;
            this.labelPublishing.Location = new System.Drawing.Point(8, 93);
            this.labelPublishing.Name = "labelPublishing";
            this.labelPublishing.Size = new System.Drawing.Size(100, 17);
            this.labelPublishing.TabIndex = 0;
            this.labelPublishing.Text = "Издательство";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 55);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(72, 17);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Название";
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(8, 17);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(47, 17);
            this.labelAuthor.TabIndex = 0;
            this.labelAuthor.Text = "Автор";
            // 
            // tabPageMagazine
            // 
            this.tabPageMagazine.Controls.Add(this.numericUpDownYearM);
            this.tabPageMagazine.Controls.Add(this.checkBoxSubs);
            this.tabPageMagazine.Controls.Add(this.numericUpDownInvNumberM);
            this.tabPageMagazine.Controls.Add(this.checkBoxAvailabilityM);
            this.tabPageMagazine.Controls.Add(this.buttonAddM);
            this.tabPageMagazine.Controls.Add(this.labelInvNumberM);
            this.tabPageMagazine.Controls.Add(this.numericUpDownNumberM);
            this.tabPageMagazine.Controls.Add(this.labelYearM);
            this.tabPageMagazine.Controls.Add(this.labelNumberM);
            this.tabPageMagazine.Controls.Add(this.labelVol);
            this.tabPageMagazine.Controls.Add(this.textBoxVol);
            this.tabPageMagazine.Controls.Add(this.textBoxTitleM);
            this.tabPageMagazine.Controls.Add(this.labelTitleM);
            this.tabPageMagazine.Location = new System.Drawing.Point(4, 25);
            this.tabPageMagazine.Name = "tabPageMagazine";
            this.tabPageMagazine.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMagazine.Size = new System.Drawing.Size(327, 375);
            this.tabPageMagazine.TabIndex = 1;
            this.tabPageMagazine.Text = "Журналы";
            this.tabPageMagazine.UseVisualStyleBackColor = true;
            // 
            // numericUpDownYearM
            // 
            this.numericUpDownYearM.Location = new System.Drawing.Point(114, 122);
            this.numericUpDownYearM.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDownYearM.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownYearM.Name = "numericUpDownYearM";
            this.numericUpDownYearM.Size = new System.Drawing.Size(196, 22);
            this.numericUpDownYearM.TabIndex = 19;
            this.numericUpDownYearM.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // checkBoxSubs
            // 
            this.checkBoxSubs.AutoSize = true;
            this.checkBoxSubs.Location = new System.Drawing.Point(20, 273);
            this.checkBoxSubs.Name = "checkBoxSubs";
            this.checkBoxSubs.Size = new System.Drawing.Size(94, 21);
            this.checkBoxSubs.TabIndex = 18;
            this.checkBoxSubs.Text = "Подписка";
            this.checkBoxSubs.UseVisualStyleBackColor = true;
            // 
            // numericUpDownInvNumberM
            // 
            this.numericUpDownInvNumberM.Location = new System.Drawing.Point(132, 158);
            this.numericUpDownInvNumberM.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.numericUpDownInvNumberM.Name = "numericUpDownInvNumberM";
            this.numericUpDownInvNumberM.Size = new System.Drawing.Size(178, 22);
            this.numericUpDownInvNumberM.TabIndex = 12;
            // 
            // checkBoxAvailabilityM
            // 
            this.checkBoxAvailabilityM.AutoSize = true;
            this.checkBoxAvailabilityM.Location = new System.Drawing.Point(20, 246);
            this.checkBoxAvailabilityM.Name = "checkBoxAvailabilityM";
            this.checkBoxAvailabilityM.Size = new System.Drawing.Size(88, 21);
            this.checkBoxAvailabilityM.TabIndex = 14;
            this.checkBoxAvailabilityM.Text = "Наличие";
            this.checkBoxAvailabilityM.UseVisualStyleBackColor = true;
            // 
            // buttonAddM
            // 
            this.buttonAddM.Location = new System.Drawing.Point(6, 327);
            this.buttonAddM.Name = "buttonAddM";
            this.buttonAddM.Size = new System.Drawing.Size(304, 41);
            this.buttonAddM.TabIndex = 16;
            this.buttonAddM.Text = "Добавить";
            this.buttonAddM.UseVisualStyleBackColor = true;
            this.buttonAddM.Click += new System.EventHandler(this.buttonAddM_Click);
            // 
            // labelInvNumberM
            // 
            this.labelInvNumberM.AutoSize = true;
            this.labelInvNumberM.Location = new System.Drawing.Point(8, 160);
            this.labelInvNumberM.Name = "labelInvNumberM";
            this.labelInvNumberM.Size = new System.Drawing.Size(123, 17);
            this.labelInvNumberM.TabIndex = 11;
            this.labelInvNumberM.Text = "Интвентарный №";
            // 
            // numericUpDownNumberM
            // 
            this.numericUpDownNumberM.Location = new System.Drawing.Point(114, 86);
            this.numericUpDownNumberM.Maximum = new decimal(new int[] {
            366,
            0,
            0,
            0});
            this.numericUpDownNumberM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberM.Name = "numericUpDownNumberM";
            this.numericUpDownNumberM.Size = new System.Drawing.Size(196, 22);
            this.numericUpDownNumberM.TabIndex = 7;
            this.numericUpDownNumberM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelYearM
            // 
            this.labelYearM.AutoSize = true;
            this.labelYearM.Location = new System.Drawing.Point(8, 124);
            this.labelYearM.Name = "labelYearM";
            this.labelYearM.Size = new System.Drawing.Size(90, 17);
            this.labelYearM.TabIndex = 6;
            this.labelYearM.Text = "Год выпуска";
            // 
            // labelNumberM
            // 
            this.labelNumberM.AutoSize = true;
            this.labelNumberM.Location = new System.Drawing.Point(8, 88);
            this.labelNumberM.Name = "labelNumberM";
            this.labelNumberM.Size = new System.Drawing.Size(51, 17);
            this.labelNumberM.TabIndex = 6;
            this.labelNumberM.Text = "Номер";
            // 
            // labelVol
            // 
            this.labelVol.AutoSize = true;
            this.labelVol.Location = new System.Drawing.Point(8, 52);
            this.labelVol.Name = "labelVol";
            this.labelVol.Size = new System.Drawing.Size(34, 17);
            this.labelVol.TabIndex = 6;
            this.labelVol.Text = "Том";
            // 
            // textBoxTitleM
            // 
            this.textBoxTitleM.Location = new System.Drawing.Point(114, 13);
            this.textBoxTitleM.Name = "textBoxTitleM";
            this.textBoxTitleM.Size = new System.Drawing.Size(196, 22);
            this.textBoxTitleM.TabIndex = 5;
            // 
            // labelTitleM
            // 
            this.labelTitleM.AutoSize = true;
            this.labelTitleM.Location = new System.Drawing.Point(8, 16);
            this.labelTitleM.Name = "labelTitleM";
            this.labelTitleM.Size = new System.Drawing.Size(72, 17);
            this.labelTitleM.TabIndex = 3;
            this.labelTitleM.Text = "Название";
            // 
            // richTextBoxItemInfo
            // 
            this.richTextBoxItemInfo.Location = new System.Drawing.Point(341, 25);
            this.richTextBoxItemInfo.Name = "richTextBoxItemInfo";
            this.richTextBoxItemInfo.Size = new System.Drawing.Size(380, 327);
            this.richTextBoxItemInfo.TabIndex = 12;
            this.richTextBoxItemInfo.Text = "";
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(341, 366);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(113, 25);
            this.buttonView.TabIndex = 10;
            this.buttonView.Text = "Просмотреть";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // checkBoxSort
            // 
            this.checkBoxSort.AutoSize = true;
            this.checkBoxSort.Location = new System.Drawing.Point(481, 370);
            this.checkBoxSort.Name = "checkBoxSort";
            this.checkBoxSort.Size = new System.Drawing.Size(251, 21);
            this.checkBoxSort.TabIndex = 11;
            this.checkBoxSort.Text = "Сортировать по инвентарному №";
            this.checkBoxSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSort.UseVisualStyleBackColor = true;
            // 
            // textBoxVol
            // 
            this.textBoxVol.Location = new System.Drawing.Point(114, 49);
            this.textBoxVol.Name = "textBoxVol";
            this.textBoxVol.Size = new System.Drawing.Size(196, 22);
            this.textBoxVol.TabIndex = 5;
            // 
            // BiblWorm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 404);
            this.Controls.Add(this.checkBoxSort);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.richTextBoxItemInfo);
            this.Controls.Add(this.tabControlLib);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "BiblWorm";
            this.Text = "Библиотека";
            this.tabControlLib.ResumeLayout(false);
            this.tabPageBooks.ResumeLayout(false);
            this.tabPageBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUseTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInvNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPages)).EndInit();
            this.tabPageMagazine.ResumeLayout(false);
            this.tabPageMagazine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInvNumberM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlLib;
        private System.Windows.Forms.TabPage tabPageBooks;
        private System.Windows.Forms.NumericUpDown numericUpDownUseTerm;
        private System.Windows.Forms.NumericUpDown numericUpDownInvNumber;
        private System.Windows.Forms.NumericUpDown numericUpDownYear;
        private System.Windows.Forms.NumericUpDown numericUpDownPages;
        private System.Windows.Forms.TextBox textBoxPublishing;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.CheckBox checkBoxReturn;
        private System.Windows.Forms.CheckBox checkBoxAvailability;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelUseTerm;
        private System.Windows.Forms.Label labelInvNumber;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelPages;
        private System.Windows.Forms.Label labelPublishing;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.TabPage tabPageMagazine;
        private System.Windows.Forms.RichTextBox richTextBoxItemInfo;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.CheckBox checkBoxSort;
        private System.Windows.Forms.TextBox textBoxTitleM;
        private System.Windows.Forms.Label labelTitleM;
        private System.Windows.Forms.Label labelVol;
        private System.Windows.Forms.CheckBox checkBoxSubs;
        private System.Windows.Forms.NumericUpDown numericUpDownInvNumberM;
        private System.Windows.Forms.CheckBox checkBoxAvailabilityM;
        private System.Windows.Forms.Button buttonAddM;
        private System.Windows.Forms.Label labelInvNumberM;
        private System.Windows.Forms.Label labelYearM;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberM;
        private System.Windows.Forms.Label labelNumberM;
        private System.Windows.Forms.NumericUpDown numericUpDownYearM;
        private System.Windows.Forms.TextBox textBoxVol;
    }
}

