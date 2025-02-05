using System.ComponentModel.DataAnnotations;

namespace librarymsApp.Data{

    // Kitap modelini tanımlayan sınıf
    public class Book{

        [Key]
        public int BookId {get;set;}
        public string? Title {get;set;}
        public string? Author {get;set;}
        public string? Category {get;set;}
        public string? CoverImage {get;set;}
        public string? Description {get;set;}
        public DateTime PublicationYear {get;set;}
        public ICollection<BookBorrow>? BookBorrows {get;set;}
    }
}