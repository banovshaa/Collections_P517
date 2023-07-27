using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Library
{
    public List<Book> books = new List<Book>();
    public void AddBook(string title, string author, int year)
    {
        Book book = new Book(title, author, year);
        books.Add(book);
        Console.WriteLine("Book added successfully");
        //Console.WriteLine("Kitabin adini daxil edin:");
        //string title = Console.ReadLine();
        //Console.WriteLine("Kitabin authorunun daxil edin:");
        //string author = Console.ReadLine();
        //Console.WriteLine("Kitabin ilini daxil edin:");
        //int author = Console.ReadLine();
    }
    public void RemoveBook(int index)
    {
        if (index<books.Count && index>=0)
        {
            books.RemoveAt(index);
            Console.WriteLine("Book is removed");
        }
        else
        {
            Console.WriteLine("Incorrect index");
        }
    }
    public void DisplayBook()
    {
        Console.WriteLine("All books:");
       for (int i = 0; i < books.Count; i++)
        {
            Console.WriteLine(books[i]);
        }
    }
}

