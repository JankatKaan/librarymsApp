using Microsoft.EntityFrameworkCore;

namespace librarymsApp.Data{
    
    // Veritabanı bağlantısını sağlayan sınıf
    public class DataContext : DbContext{

        public DataContext(DbContextOptions<DataContext>options):base(options){}

        public DbSet<Book> Books => Set<Book>();
        public DbSet<BookBorrow> BookBorrows => Set<BookBorrow>();
        public DbSet<Member> Members => Set<Member>();
    }
}