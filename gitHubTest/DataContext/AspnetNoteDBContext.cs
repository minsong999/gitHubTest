using gitHubTest.Models;
using Microsoft.EntityFrameworkCore;

namespace gitHubTest.DataContext
{
    public class AspnetNoteDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        
        public DbSet<Note> Notes { get; set; }

        //connetion 만드는 방법
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=myDataBase;User Id=myUsername;Password = myPassword;"); //connetion string값을 그대로 서버에 보내기 위해서 @를 꼭 앞에 붙여주자
        }
    }
}
