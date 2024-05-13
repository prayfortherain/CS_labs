using System;
interface IPublisher
{
    string Title { get; set; }
    string Author { get; set; }
}

interface IBook : IPublisher
{
    string PublicationDate { get; set; }
    int PageCount { get; set; }
}
class Book : IBook
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string PublicationDate { get; set; }
    public int PageCount { get; set; }
}
interface IUser
{
    string Username { get; set; }
    string Password { get; set; }
}
class User : IUser
{
    public string Username { get; set; }
    public string Password { get; set; }
}
class UserBook : IBook, IUser
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string PublicationDate { get; set; }
    public int PageCount { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public void BuyBook()
    {
        Console.WriteLine($"{Username} купил книгу '{Title}' автора {Author}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book
        {
            Title = "Название книги 1",
            Author = "Автор книги 1",
            PublicationDate = "04.03.1993",
            PageCount = 200
        };

        Book book2 = new Book
        {
            Title = "Название книги 2",
            Author = "Автор книги 2",
            PublicationDate = "19.04.1991",
            PageCount = 150
        };
        User user1 = new User
        {
            Username = "user1",
            Password = "password1"
        };

        User user2 = new User
        {
            Username = "user2",
            Password = "password2"
        };
        UserBook userBook = new UserBook
        {
            Title = "Название книги 3",
            Author = "Автор книги 3",
            PublicationDate = "03.08.2005",
            PageCount = 180,
            Username = "user3",
            Password = "password3"
        };
        userBook.BuyBook();

        IPublisher ipu = new Book();

    }
}
