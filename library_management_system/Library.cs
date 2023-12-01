namespace library_management_system
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public void AddMember(Member member)
        {
            members.Add(member);
        }

        public void LendBook(Book book, Member member, ILoanPolicy loanPolicy)
        {
            loanPolicy.ApplyLoanPolicy(book, member);
            member.AddBook(book);
            Console.WriteLine($"\nÖdünç işlemi:");
            member.Print();

        }

        public void ReturnBook(Book book, Member member)
        {
            Console.WriteLine($"\nİade işlemi:");
            member.Print();
            member.RemoveBook(book);
        }
    }


}