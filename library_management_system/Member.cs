namespace library_management_system
{
    public class Member : IPrintable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int MembershipNumber { get; set; }
        public List<Book> BorrowedBooks { get; private set; }

        public Member()
        {
            BorrowedBooks = new List<Book>();
        }

        public void Print()
        {
            Console.WriteLine($"Member: {FirstName} {LastName}, Membership Number: {MembershipNumber}");
            foreach (var book in BorrowedBooks)
            {
                book.Print();
            }
        }

        public void AddBook(Book book)
        {
            BorrowedBooks.Add(book);
        }

        public void RemoveBook(Book book)
        {
            BorrowedBooks.Remove(book);
        }
    }

}
