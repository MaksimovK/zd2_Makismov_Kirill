namespace zd2_Makismov_Kirill
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dt_PhoneBook = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bt_rebutPoisk = new System.Windows.Forms.Button();
            this.bt_Poisk = new System.Windows.Forms.Button();
            this.tb_PoiskName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_PhoneContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_NameContact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_AddContact = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tb_NameContactForDelete = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_DeletContact = new System.Windows.Forms.Button();
            this.bt_saveContactForFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_PhoneBook)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_PhoneBook
            // 
            this.dt_PhoneBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_PhoneBook.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dt_PhoneBook.Location = new System.Drawing.Point(0, 283);
            this.dt_PhoneBook.Name = "dt_PhoneBook";
            this.dt_PhoneBook.Size = new System.Drawing.Size(800, 167);
            this.dt_PhoneBook.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 236);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bt_rebutPoisk);
            this.tabPage1.Controls.Add(this.bt_Poisk);
            this.tabPage1.Controls.Add(this.tb_PoiskName);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Поиск ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bt_rebutPoisk
            // 
            this.bt_rebutPoisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_rebutPoisk.Location = new System.Drawing.Point(6, 52);
            this.bt_rebutPoisk.Name = "bt_rebutPoisk";
            this.bt_rebutPoisk.Size = new System.Drawing.Size(153, 31);
            this.bt_rebutPoisk.TabIndex = 3;
            this.bt_rebutPoisk.Text = "Отменить поиск";
            this.bt_rebutPoisk.UseVisualStyleBackColor = true;
            this.bt_rebutPoisk.Click += new System.EventHandler(this.bt_rebutPoisk_Click);
            // 
            // bt_Poisk
            // 
            this.bt_Poisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Poisk.Location = new System.Drawing.Point(201, 52);
            this.bt_Poisk.Name = "bt_Poisk";
            this.bt_Poisk.Size = new System.Drawing.Size(134, 31);
            this.bt_Poisk.TabIndex = 2;
            this.bt_Poisk.Text = "Найти";
            this.bt_Poisk.UseVisualStyleBackColor = true;
            this.bt_Poisk.Click += new System.EventHandler(this.bt_Poisk_Click);
            // 
            // tb_PoiskName
            // 
            this.tb_PoiskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_PoiskName.Location = new System.Drawing.Point(201, 14);
            this.tb_PoiskName.Name = "tb_PoiskName";
            this.tb_PoiskName.Size = new System.Drawing.Size(134, 26);
            this.tb_PoiskName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите Имя контакта:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tb_PhoneContact);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tb_NameContact);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.bt_AddContact);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавить";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_PhoneContact
            // 
            this.tb_PhoneContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_PhoneContact.Location = new System.Drawing.Point(34, 90);
            this.tb_PhoneContact.Name = "tb_PhoneContact";
            this.tb_PhoneContact.Size = new System.Drawing.Size(134, 26);
            this.tb_PhoneContact.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(34, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Введите номер телефона";
            // 
            // tb_NameContact
            // 
            this.tb_NameContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_NameContact.Location = new System.Drawing.Point(34, 37);
            this.tb_NameContact.Name = "tb_NameContact";
            this.tb_NameContact.Size = new System.Drawing.Size(134, 26);
            this.tb_NameContact.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Введите Имя и Фамилию контакта:";
            // 
            // bt_AddContact
            // 
            this.bt_AddContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_AddContact.Location = new System.Drawing.Point(34, 157);
            this.bt_AddContact.Name = "bt_AddContact";
            this.bt_AddContact.Size = new System.Drawing.Size(121, 36);
            this.bt_AddContact.TabIndex = 0;
            this.bt_AddContact.Text = "Добавить";
            this.bt_AddContact.UseVisualStyleBackColor = true;
            this.bt_AddContact.Click += new System.EventHandler(this.bt_AddContact_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tb_NameContactForDelete);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.bt_DeletContact);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 210);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Удалить";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tb_NameContactForDelete
            // 
            this.tb_NameContactForDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_NameContactForDelete.Location = new System.Drawing.Point(22, 36);
            this.tb_NameContactForDelete.Name = "tb_NameContactForDelete";
            this.tb_NameContactForDelete.Size = new System.Drawing.Size(134, 26);
            this.tb_NameContactForDelete.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Введите Имя и Фамилию контакта:";
            // 
            // bt_DeletContact
            // 
            this.bt_DeletContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_DeletContact.Location = new System.Drawing.Point(22, 156);
            this.bt_DeletContact.Name = "bt_DeletContact";
            this.bt_DeletContact.Size = new System.Drawing.Size(121, 36);
            this.bt_DeletContact.TabIndex = 4;
            this.bt_DeletContact.Text = "Удалить";
            this.bt_DeletContact.UseVisualStyleBackColor = true;
            this.bt_DeletContact.Click += new System.EventHandler(this.bt_DeletContact_Click);
            // 
            // bt_saveContactForFile
            // 
            this.bt_saveContactForFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_saveContactForFile.Location = new System.Drawing.Point(16, 254);
            this.bt_saveContactForFile.Name = "bt_saveContactForFile";
            this.bt_saveContactForFile.Size = new System.Drawing.Size(159, 23);
            this.bt_saveContactForFile.TabIndex = 0;
            this.bt_saveContactForFile.Text = "Сохранить базу";
            this.bt_saveContactForFile.UseVisualStyleBackColor = true;
            this.bt_saveContactForFile.Click += new System.EventHandler(this.bt_saveContactForFile_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите Имя контакта:";
            // 
            // bt_Exit
            // 
            this.bt_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Exit.Location = new System.Drawing.Point(625, 250);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(159, 23);
            this.bt_Exit.TabIndex = 2;
            this.bt_Exit.Text = "Выйти";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.bt_saveContactForFile);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dt_PhoneBook);
            this.Name = "Form1";
            this.Text = "Телефонная книга";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dt_PhoneBook)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bt_Exit;

        private System.Windows.Forms.Button bt_saveContactForFile;

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tb_NameContactForDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_DeletContact;

        private System.Windows.Forms.TextBox tb_PhoneContact;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox tb_NameContact;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button bt_AddContact;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button bt_rebutPoisk;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_PoiskName;
        private System.Windows.Forms.Button bt_Poisk;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        private System.Windows.Forms.DataGridView dt_PhoneBook;

        #endregion
    }
}