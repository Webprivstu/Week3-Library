using Library;
using System.ComponentModel.DataAnnotations;


class Program
{

    static void Main(string[] args)
    {
        
        // lists to store books and members

        List<Book> books = new List<Book>();
        List<Members> members = new List<Members>();

        // create book object

        books.Add(new Book("C# beginners", "Bill Gates", "12345678"));

        //create book 1 object

        books.Add(new Book("C# Methods and Classes", "Microsoft", "55667788"));



        //Output book information to the console
        Console.WriteLine("Current Books");
        //book.DisplayInfo();
        //book1.DisplayInfo();

        //create member object 
        members.Add(new Members(1, "John Smith", "1 High Street", 0790090090));
        //create member object 1
        members.Add(new Members(2, "Mary Jones", "102 Garden Road", 0790345666));

        //member display info
        Console.WriteLine("Current library members");
        //member.DisplayInfo();
        //member1.DisplayInfo();
        foreach (Members member in members)
        {
            member.DisplayInfo();

        }

        foreach (Book book in books)
        {
            book.DisplayInfo();
        }

    }

}




