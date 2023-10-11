using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Hary Porter", "JK Rowling", 400);

            Console.WriteLine(book1.title);
            Console.ReadLine();
        }
    }
}

    //classes are for creating more complex data types, eg a book can have a title,
    //and pages whihc are different data types combined

    class Book
{
    public string title;
    public string auther;
    public int pages;

    //this method belw is called a constructor, it is calles by default when a Book object is created

    public Book(string aTitle, string aAuther, int aPages)
    {
        title = aTitle;
        auther = aAuther;
        pages = aPages;
    }
}
