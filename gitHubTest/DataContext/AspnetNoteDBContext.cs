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
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=AspnetNoteDb;User Id=server_minseong;Password=sa1234;");
            //connetion string값을 그대로 서버에 보내기 위해서 @를 꼭 앞에 붙여주자
            //Microsoft.EntityFrameworkCore 누겟패키지 추가
            //보기 - other - 패키지 관리자 콘솔창 추가

            //db와 연결해주는 마이그레이션 클래스파일을 만들어주는 명령어
            //add-migration migration이름명

            //db를 실제로 업데이트 시키는 명령어
            //update-database
        }
    }
}
