namespace GA_Class_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exploring Constructors in C#");

            // Creating instances using different constructors
            Book book1 = new Book("1984", "George Orwell");
            Console.WriteLine($"Book 1: Title = {book1.Title}, Author = {book1.Author}");

            Book book2 = new Book("The Hobbit");
            Console.WriteLine($"Book 2: Title = {book2.Title}, Author = {book2.Author}");
        }
    }
}
