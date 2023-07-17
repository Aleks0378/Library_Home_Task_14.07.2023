using Library_Home_Task_14._07._2023.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Home_Task_14._07._2023
{
    public partial class Form1 : Form
    {
        static MyContext cont = new MyContext();
        public Form1()
        {
            InitializeComponent();
            AddButton.Enabled = false;
            radioButton_cancel.Checked = true;
            using (cont = new MyContext())
            {
                dataGridView1.DataSource = cont.books.ToList();
            }
        }

        public void textBoxClear()
        {
            textBox_Id.Clear();
            textBox_autor.Clear();
            textBox_category.Clear();
            textBox_name.Clear();
            textBox_pages.Clear();
            textBox_publisher.Clear();
        }
        public void textBoxAllEnable()
        {
            textBox_name.Enabled = true;
            textBox_category.Enabled = true;
            textBox_publisher.Enabled = true;
            textBox_pages.Enabled = true;
            textBox_autor.Enabled = true;
        }
        public void textBoxAllDisable()
        {
            textBox_name.Enabled = false;
            textBox_category.Enabled = false;
            textBox_publisher.Enabled = false;
            textBox_pages.Enabled = false;
            textBox_autor.Enabled= false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            using (cont = new MyContext())
            {
                cont.AddBook(new Books(textBox_name.Text, textBox_category.Text, textBox_publisher.Text, Convert.ToInt32(textBox_pages.Text), textBox_autor.Text));
                cont.SaveChanges();
                dataGridView1.DataSource = cont.books.ToList();
                textBoxClear();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            using (cont=new MyContext())
            {
                cont.EditBook(new Books(Convert.ToInt32(textBox_Id.Text),textBox_name.Text, textBox_category.Text, textBox_publisher.Text, Convert.ToInt32(textBox_pages.Text), textBox_autor.Text));
                cont.SaveChanges();
                dataGridView1.DataSource = cont.books.ToList();
                textBoxClear();
                EditButton.Enabled = false;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (cont=new MyContext())
            {
                if (cont.DeleteBook(new Books(Convert.ToInt32(textBox_Id.Text), textBox_name.Text, textBox_category.Text, textBox_publisher.Text, Convert.ToInt32(textBox_pages.Text), textBox_autor.Text)))
                    MessageBox.Show("Книга удалена");
                else MessageBox.Show("Что-то пошло не так. Операция не выполнена!");
                cont.SaveChanges();
                dataGridView1.DataSource = cont.books.ToList();
                textBoxClear();
            }
        }



        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            if (radioButton_cancel.Checked) 
            {
                AddButton.Enabled = true;
            }           
        }

        private void radioButton_cancel_CheckedChanged(object sender, EventArgs e)
        {
            EditButton.Enabled = true;
            DeleteButton.Enabled = true;
            FindButton.Enabled = false;
            textBoxAllEnable();
        }

        private void radioButton_autor_CheckedChanged(object sender, EventArgs e)
        {
            textBoxClear();
            AddButton.Enabled= false;
            DeleteButton.Enabled= false;
            FindButton.Enabled= true;
            EditButton.Enabled= false;
            textBoxAllDisable();
            textBox_autor.Enabled = true;
        }

        private void radioButton_name_CheckedChanged(object sender, EventArgs e)
        {
            textBoxClear();
            AddButton.Enabled = false;
            DeleteButton.Enabled = false;
            FindButton.Enabled = true;
            EditButton.Enabled = false;
            textBoxAllDisable();
            textBox_name.Enabled = true;
        }

        private void radioButton_category_CheckedChanged(object sender, EventArgs e)
        {
            textBoxClear();
            AddButton.Enabled = false;
            DeleteButton.Enabled = false;
            FindButton.Enabled = true;
            EditButton.Enabled = false;
            textBoxAllDisable();
            textBox_category.Enabled = true;
        }

        private void radioButton_publisher_CheckedChanged(object sender, EventArgs e)
        {
            textBoxClear();
            AddButton.Enabled = false;
            DeleteButton.Enabled = false;
            FindButton.Enabled = true;
            EditButton.Enabled = false;
            textBoxAllDisable();
            textBox_publisher.Enabled = true;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            using (cont = new MyContext())
            {
                List<Books> FoundBook = null;
                if (textBox_name.Text != " " && textBox_name.Text.Length != 0)
                    foreach (var b in cont.books)
                        if (b.Name == textBox_name.Text)
                            FoundBook.Add(b);
                if (textBox_category.Text != " " && textBox_category.Text.Length != 0)
                    foreach (var b in cont.books)
                        if (b.Category == textBox_category.Text)
                            FoundBook.Add(b);
                if (textBox_autor.Text != " " && textBox_autor.Text.Length != 0)
                    foreach (var b in cont.books)
                        if (b.Author == textBox_autor.Text)
                            FoundBook.Add(b);
                if (textBox_publisher.Text != " " && textBox_publisher.Text.Length != 0)
                    foreach (var b in cont.books)
                        if (b.Publisher == textBox_publisher.Text)
                            FoundBook.Add(b);
                if (FoundBook == null)
                {
                    MessageBox.Show("There is no such book in the library!");
                    dataGridView1.DataSource = cont.books.ToList();
                }
                else
                    cont.SaveChanges();
                dataGridView1.DataSource = FoundBook;
            }

            //string str = null;
            //if (textBox_name!=null) str= textBox_name.Text;
            //if (textBox_category!=null) str= textBox_category.Text;
            //if (textBox_publisher!=null) str= textBox_publisher.Text;
            //if (textBox_autor!=null) str= textBox_autor.Text;
            //using (cont = new MyContext())
            //{
            //    dataGridView1.DataSource = cont.FindBook(str);
            //}
            textBoxClear();
            radioButton_cancel.Checked = true;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            using (cont = new MyContext())
            {
                Books book = cont.books.Find(dataGridView1[0, e.RowIndex].Value);
                switch (e.ColumnIndex)
                {
                    case 0:
                        dataGridView1.DataSource = cont.books.ToList();
                        break;
                    case 1:
                        book.Name = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                        break;
                    case 2:
                        book.Category = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                        break;
                    case 3:
                        book.Publisher = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                        break;
                    case 4:
                        book.Pages = Int32.Parse(dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString());
                        break;
                    case 5:
                        book.Author = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                        break;
                }
                cont.SaveChanges();
                //dataGridView1.DataSource = cont.books.ToList();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButton_cancel.Checked)
            {
                using (cont = new MyContext())
                {
                    Books book = cont.books.Find(dataGridView1[0, e.RowIndex].Value);
                    //MessageBox.Show(book.ToString());
                    textBox_Id.Text = Convert.ToString(book.Id);
                    textBox_name.Text = book.Name;
                    textBox_category.Text = book.Category;
                    textBox_pages.Text = Convert.ToString(book.Pages);
                    textBox_publisher.Text = book.Publisher;
                    textBox_autor.Text = book.Author;
                    EditButton.Enabled = true;
                }
            }            
        }

        private void AllBooksShowButton_Click(object sender, EventArgs e)
        {
            using (cont = new MyContext())
            {
                dataGridView1.DataSource = cont.books.ToList();
            }
        }
    }
}
