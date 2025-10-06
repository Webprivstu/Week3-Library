using Library;


class Program
{

    static void Main(string[] args)
    {

        //book object

        Book book = new Book("C# beginners", "Bill Gates", "12345678");

        //book 1 object

        Book book1 = new Book("C# Methods and Classes", "Microsoft", "55667788");



        //Output book information to the console
        Console.WriteLine("Current Books");
        book.DisplayInfo();
        book1.DisplayInfo();

        //member object 
        Members member = new Members(1, "John Smith", "1 High Street", 0790090090);
        //member object 1
        Members member1 = new Members(2, "Mary Jones", "102 Garden Road", 0790345666);

        //member display info
        Console.WriteLine("Current library members");
        member.DisplayInfo();
        member1.DisplayInfo();

    }

}




