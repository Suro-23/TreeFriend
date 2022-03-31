using Microsoft.EntityFrameworkCore;
using TreeFriend.Models.Entity;

namespace TreeFriend.Models {
    public class TreeFriendDbContext: DbContext {
        public TreeFriendDbContext(DbContextOptions<TreeFriendDbContext> options) : base(options) {

        }

        //思雯&凱琳的登入頁面
        public DbSet<User> users { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Hashtag> hashtags { get; set; }
        public DbSet<UserDetail> usersDetail { get; set; }
        public DbSet<PersonalPost> personalPosts { get; set; }
        public DbSet<PersonalPostMessage> personalPostMessages { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            //指定日期使用SQL getdate() 自動取得當前時間
            modelBuilder.Entity<User>()
                .Property(u => u.CreateDate)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,4)");

            modelBuilder.Entity<Product>()
                .Property(p => p.StarDate)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<UserDetail>()
                .Property(u => u.UpdateTime)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<PersonalPost>()
                .Property(p => p.CreateDate)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity <PersonalPostMessage>()
                .Property(p => p.CreateDate)
                .HasDefaultValueSql("getdate()");

            //modelBuilder.Entity<PersonalPostMessage>()
            //    .HasOne(p => p.User).WithMany()
            //    .HasForeignKey(t => t.UserId)
            //    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
