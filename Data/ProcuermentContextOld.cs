// using Microsoft.EntityFrameworkCore;

// namespace Procuerment.Data
// {
//     public class ProcuermentContext : DbContext
//     {
//         public ProcuermentContext(DbContextOptions<ProcuermentContext> opt) : base(opt)
//         {

//         }
//         protected override void OnModelCreating(ModelBuilder modelBuilder)
//         {
//             modelBuilder.Entity<Models.UserRoleMapping>()
//                 .HasOne<Models.Role>()
//                 .WithMany()
//                 .HasForeignKey(p => p.RoleId);

//             modelBuilder.Entity<Models.UserRoleMapping>()
//                .HasOne<Models.UserInfo>()
//                .WithMany()
//                .HasForeignKey(p => p.UserId);
//         }
//         public DbSet<Models.Procuerment> Procuerment { set; get; }
//         public DbSet<Models.UserInfo> UserInfo { set; get; }
//         public DbSet<Models.UserRoleMapping> UserRoleMapping { set; get; }
//         public DbSet<Models.Role> Role { set; get; }


//     }
// }