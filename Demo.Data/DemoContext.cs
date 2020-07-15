
using Demo.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

namespace Demo.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options):base(options)
        {

        }
        //注释掉 并移动到DemoWeb这个项目中
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseLoggerFactory(ConsoleLoggerFactory)
        //        .EnableSensitiveDataLogging();//将参数输出到logging中
        //    optionsBuilder.UseSqlServer("Data Source=.;Database=TestBase;User ID=sa;Password=zhengqiang");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GamePlayer>().HasKey(x => new { x.PlayerId, x.GameId });//添加联合主键
            modelBuilder.Entity<Resume>().HasOne(x => x.Player).WithOne(x => x.Resume)//添加一对一关系 还有 外键
                .HasForeignKey<Resume>(x => x.PlayId);
        }
        //将sql 语句过滤然后输出到控制台
        public static readonly ILoggerFactory ConsoleLoggerFactory = LoggerFactory.Create(builder => {
            builder.AddFilter((category, level) =>
                category == DbLoggerCategory.Database.Command.Name && level == LogLevel.Information
            ).AddConsole();
          });
        public DbSet<Player> Player { get; set; }
        public DbSet<League> League { get; set; }
        public DbSet<Club> Club { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
