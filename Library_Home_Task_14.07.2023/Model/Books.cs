using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Library_Home_Task_14._07._2023.Model
{
    internal class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Publisher { get; set; }
        public int Pages { get; set; }
        public string Author { get; set; }

        public Books() { }

        public Books(int id, string name, string category, string publisher, int pages, string author)
        {
            Id = id;
            Name = name;
            Category = category;
            Publisher = publisher;
            Pages = pages;
            Author = author;
        }
        public Books(string name, string category, string publisher, int pages, string author)
        {
            Name = name;
            Category = category;
            Publisher = publisher;
            Pages = pages;
            Author = author;
        }
        public override string ToString()
        {
            return $"Id: {Id},\t Name: {Name},\t Category: {Category},\t Publisher: {Publisher},\t Pages: {Pages},\t Author: {Author}";
        }
    }
}
