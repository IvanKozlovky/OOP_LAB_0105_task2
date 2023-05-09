using System;

interface Printable
{
    void Print();
}

class Book : Printable
{
    public string Title { get; set; }

    public Book(string title)
    {
        Title = title;
    }

    public void Print()
    {
        Console.WriteLine($"Книга: {Title}");
    }

    public static void PrintBooks(Printable[] printables)
    {
        Console.WriteLine("Книги:");
        foreach (var printable in printables)
        {
            if (printable is Book book)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}

class Magazine : Printable
{
    public string Title { get; set; }

    public Magazine(string title)
    {
        Title = title;
    }

    public void Print()
    {
        Console.WriteLine($"Журнал: {Title}");
    }

    public static void PrintMagazines(Printable[] printables)
    {
        Console.WriteLine("Журнали:");
        foreach (var printable in printables)
        {
            if (printable is Magazine magazine)
            {
                Console.WriteLine(magazine.Title);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Printable[] printables = new Printable[]
        {
            new Book("Вій"),
            new Book("Майстер і Маргарита"),
            new Magazine("Forbes"),
            new Magazine("National Geographic"),
            new Book("1984"),
            new Magazine("Time")
        };

        Console.WriteLine("Всі об'єкти:");
        foreach (var printable in printables)
        {
            printable.Print();
        }
        Console.WriteLine();

        Book.PrintBooks(printables);
        Console.WriteLine();

        Magazine.PrintMagazines(printables);

        Console.ReadLine();
    }
}
