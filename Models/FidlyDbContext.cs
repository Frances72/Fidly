using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Fidly.Models;

public partial class FidlyDbContext : DbContext
{
     //models to add to db
    public DbSet<Customers> Customers { get; set; }
    public DbSet<MembershipType> MembershipType { get; set; }
    public DbSet<Genre> Genre { get; set; }
    public DbSet<Movie> Movie { get; set; }
       
    public FidlyDbContext()
    {  

    }

    public FidlyDbContext(DbContextOptions<FidlyDbContext> options)
        : base(options)
    {
        
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\TRAININGDB;Initial Catalog=FidlyDb;Integrated Security= true;Encrypt=false;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

     modelBuilder.Entity<MembershipType>().HasData(
        new MembershipType(){Id = 1, SignUpFee = 0,DurationInMonths = 0, DiscountRate = 0 , MembershipName = "None"},
        new MembershipType(){Id = 2, SignUpFee = 30,DurationInMonths = 1, DiscountRate = 10, MembershipName = "Monthly"},
        new MembershipType(){Id = 3, SignUpFee = 90,DurationInMonths = 3, DiscountRate = 015, MembershipName = "Quaterly"},
        new MembershipType(){Id = 4, SignUpFee = 300,DurationInMonths = 12, DiscountRate = 20, MembershipName = "Annually"});
       
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

   
}
