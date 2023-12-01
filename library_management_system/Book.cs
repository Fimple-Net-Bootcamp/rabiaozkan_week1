namespace library_management_system
{
    public class Book : WrittenWork, IPrintable
    {
        private static int lastBookID = 0;
        public int BookID { get; private set; }

        public Book()
        {
            BookID = ++lastBookID;
        }

        public void Print()
        {
            Console.WriteLine($"Book: {Title}, Author: {Author}, Publication Year: {PublicationYear}, Book ID: {BookID}");
        }
    }
}