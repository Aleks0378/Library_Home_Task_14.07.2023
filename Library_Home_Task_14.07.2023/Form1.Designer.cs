namespace Library_Home_Task_14._07._2023
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_category = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_publisher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_pages = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_autor = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.radioButton_autor = new System.Windows.Forms.RadioButton();
            this.radioButton_name = new System.Windows.Forms.RadioButton();
            this.radioButton_category = new System.Windows.Forms.RadioButton();
            this.radioButton_publisher = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.radioButton_cancel = new System.Windows.Forms.RadioButton();
            this.AllBooksShowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(422, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(648, 606);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(12, 103);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(290, 22);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название книги";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Категория";
            // 
            // textBox_category
            // 
            this.textBox_category.Location = new System.Drawing.Point(12, 165);
            this.textBox_category.Name = "textBox_category";
            this.textBox_category.Size = new System.Drawing.Size(290, 22);
            this.textBox_category.TabIndex = 3;
            this.textBox_category.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Издательство";
            // 
            // textBox_publisher
            // 
            this.textBox_publisher.Location = new System.Drawing.Point(12, 230);
            this.textBox_publisher.Name = "textBox_publisher";
            this.textBox_publisher.Size = new System.Drawing.Size(293, 22);
            this.textBox_publisher.TabIndex = 5;
            this.textBox_publisher.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Колличество страниц";
            // 
            // textBox_pages
            // 
            this.textBox_pages.Location = new System.Drawing.Point(12, 292);
            this.textBox_pages.Name = "textBox_pages";
            this.textBox_pages.Size = new System.Drawing.Size(150, 22);
            this.textBox_pages.TabIndex = 7;
            this.textBox_pages.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Автор";
            // 
            // textBox_autor
            // 
            this.textBox_autor.Location = new System.Drawing.Point(12, 351);
            this.textBox_autor.Name = "textBox_autor";
            this.textBox_autor.Size = new System.Drawing.Size(296, 22);
            this.textBox_autor.TabIndex = 9;
            this.textBox_autor.TextChanged += new System.EventHandler(this.textBox_name_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 414);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(88, 28);
            this.AddButton.TabIndex = 11;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(220, 414);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(88, 28);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(115, 414);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(88, 28);
            this.EditButton.TabIndex = 13;
            this.EditButton.Text = "Редакт";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(6, 21);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(88, 28);
            this.FindButton.TabIndex = 14;
            this.FindButton.Text = "Поиск";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // radioButton_autor
            // 
            this.radioButton_autor.AutoSize = true;
            this.radioButton_autor.Location = new System.Drawing.Point(126, 31);
            this.radioButton_autor.Name = "radioButton_autor";
            this.radioButton_autor.Size = new System.Drawing.Size(94, 20);
            this.radioButton_autor.TabIndex = 15;
            this.radioButton_autor.TabStop = true;
            this.radioButton_autor.Text = "по автору";
            this.radioButton_autor.UseVisualStyleBackColor = true;
            this.radioButton_autor.CheckedChanged += new System.EventHandler(this.radioButton_autor_CheckedChanged);
            // 
            // radioButton_name
            // 
            this.radioButton_name.AutoSize = true;
            this.radioButton_name.Location = new System.Drawing.Point(126, 57);
            this.radioButton_name.Name = "radioButton_name";
            this.radioButton_name.Size = new System.Drawing.Size(94, 20);
            this.radioButton_name.TabIndex = 16;
            this.radioButton_name.TabStop = true;
            this.radioButton_name.Text = "названию";
            this.radioButton_name.UseVisualStyleBackColor = true;
            this.radioButton_name.CheckedChanged += new System.EventHandler(this.radioButton_name_CheckedChanged);
            // 
            // radioButton_category
            // 
            this.radioButton_category.AutoSize = true;
            this.radioButton_category.Location = new System.Drawing.Point(235, 31);
            this.radioButton_category.Name = "radioButton_category";
            this.radioButton_category.Size = new System.Drawing.Size(96, 20);
            this.radioButton_category.TabIndex = 17;
            this.radioButton_category.TabStop = true;
            this.radioButton_category.Text = "категории";
            this.radioButton_category.UseVisualStyleBackColor = true;
            this.radioButton_category.CheckedChanged += new System.EventHandler(this.radioButton_category_CheckedChanged);
            // 
            // radioButton_publisher
            // 
            this.radioButton_publisher.AutoSize = true;
            this.radioButton_publisher.Location = new System.Drawing.Point(235, 57);
            this.radioButton_publisher.Name = "radioButton_publisher";
            this.radioButton_publisher.Size = new System.Drawing.Size(120, 20);
            this.radioButton_publisher.TabIndex = 18;
            this.radioButton_publisher.TabStop = true;
            this.radioButton_publisher.Text = "издательству";
            this.radioButton_publisher.UseVisualStyleBackColor = true;
            this.radioButton_publisher.CheckedChanged += new System.EventHandler(this.radioButton_publisher_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_cancel);
            this.groupBox1.Controls.Add(this.radioButton_publisher);
            this.groupBox1.Controls.Add(this.radioButton_category);
            this.groupBox1.Controls.Add(this.radioButton_name);
            this.groupBox1.Controls.Add(this.FindButton);
            this.groupBox1.Controls.Add(this.radioButton_autor);
            this.groupBox1.Location = new System.Drawing.Point(12, 488);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 86);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Id";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(12, 39);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(290, 22);
            this.textBox_Id.TabIndex = 20;
            // 
            // radioButton_cancel
            // 
            this.radioButton_cancel.AutoSize = true;
            this.radioButton_cancel.Location = new System.Drawing.Point(12, 55);
            this.radioButton_cancel.Name = "radioButton_cancel";
            this.radioButton_cancel.Size = new System.Drawing.Size(76, 20);
            this.radioButton_cancel.TabIndex = 19;
            this.radioButton_cancel.TabStop = true;
            this.radioButton_cancel.Text = "отмена";
            this.radioButton_cancel.UseVisualStyleBackColor = true;
            this.radioButton_cancel.CheckedChanged += new System.EventHandler(this.radioButton_cancel_CheckedChanged);
            // 
            // AllBooksShowButton
            // 
            this.AllBooksShowButton.Location = new System.Drawing.Point(12, 454);
            this.AllBooksShowButton.Name = "AllBooksShowButton";
            this.AllBooksShowButton.Size = new System.Drawing.Size(296, 28);
            this.AllBooksShowButton.TabIndex = 22;
            this.AllBooksShowButton.Text = "Показать все книги";
            this.AllBooksShowButton.UseVisualStyleBackColor = true;
            this.AllBooksShowButton.Click += new System.EventHandler(this.AllBooksShowButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 630);
            this.Controls.Add(this.AllBooksShowButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_autor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_pages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_publisher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_category);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_publisher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_pages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_autor;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.RadioButton radioButton_autor;
        private System.Windows.Forms.RadioButton radioButton_name;
        private System.Windows.Forms.RadioButton radioButton_category;
        private System.Windows.Forms.RadioButton radioButton_publisher;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.RadioButton radioButton_cancel;
        private System.Windows.Forms.Button AllBooksShowButton;
    }
}

