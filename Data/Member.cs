using System.ComponentModel.DataAnnotations;

namespace librarymsApp.Data{

    public class Member{

        [Key]
        public int MemberId {get;set;}
        public string? Name {get;set;}
        public string? Surname {get;set;}
        public string NameSurname{get{return this.Name + " " + this.Surname;}}
        public string? Email {get;set;}
        public string? Phone {get;set;}
        public ICollection<BookBorrow>? BookBorrows {get;set;}
    }
}