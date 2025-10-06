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

    //Book Constructor 
    public Book(string bookTitle, string bookAuthor, string bookISBN)
    {

        this.Title = bookTitle;
        this.Author = bookAuthor;    
        this.ISBN = bookISBN;   

    }

    static void Main(string[] args)
    {

        //book object

        Book book = new Book("C# beginners", "Bill Gates","12345678" );

        //book 1 object

        Book book1 = new Book("C# Methods and Classes", "Microsoft", "55667788");



        //Output book information to the console
        book.DisplayInfo();
        book1.DisplayInfo();

    }

}


