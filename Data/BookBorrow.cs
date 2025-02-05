using System.ComponentModel.DataAnnotations;

namespace librarymsApp.Data{

    public class BookBorrow{

        [Key]
        public int BorrowId {get;set;}
        public int BookId {get;set;}
        public Book Book {get;set;}=null!;
        public int MemberId {get;set;}
        public Member Member {get;set;}=null!;
        public DateTime BorrowDate {get;set;}
    }
}