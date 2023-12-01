using System;

namespace library_management_system
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Kitaplar oluşturuluyor
            Book book1 = new Book { Title = "1984", Author = "George Orwell", PublicationYear = 1949 };
            Book book2 = new Book { Title = "Bülbülü Öldürmek", Author = "Harper Lee", PublicationYear = 1960 };
            Book book3 = new Book { Title = "Yabacı", Author = "Albert Camus", PublicationYear = 1942 };

            // Kitaplar kütüphaneye ekleniyor
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            // Üye oluşturuluyor
            Member member1 = new Member { FirstName = "Rabia", LastName = "Ozkan", MembershipNumber = 1 };
            Member member2 = new Member { FirstName = "Murat", LastName = "Genç", MembershipNumber = 2 };

            // Üye kütüphaneye ekleniyor
            library.AddMember(member1);
            library.AddMember(member2);

            // Kitap ödünç veriliyor
            library.LendBook(book1, member1, new ShortTermLoanPolicy());
            library.LendBook(book2, member2, new LongTermLoanPolicy());


            // Kitap iade ediliyor
            library.ReturnBook(book1, member1);

        }
    }
}
