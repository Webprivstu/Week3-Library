class Book ()
{
    //variable list

    string Title;
    string Author;
    string ISBN;

    void DisplayInfo() //display info 
    {

        Console.WriteLine($"Book Title: {Title}");
        Console.WriteLine($"Book Author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine();

    }

    static void Main(string[] args)
    {

        //book object

        Book book = new Book();

        book.Title = "C# beginners";
        book.Author = "BillGates";
        book.ISBN = "1234578";

        //book 1 object

        Book book1 = new Book();

        book1.Title = "C# Methods and Classes";
        book1.Author = "Microsoft";
        book1.ISBN = "55667788";

        //Output book information to the console
        book.DisplayInfo();
        book1.DisplayInfo();

    }

}


