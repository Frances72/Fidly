﻿// <auto-generated />
using Fidly.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fidly.Migrations
{
    [DbContext(typeof(FidlyDbContext))]
    [Migration("20221220141412_UpdateCusstomerDOB")]
    partial class UpdateCusstomerDOB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fidly.Models.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DOB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSubscribedToNewsletter")
                        .HasColumnType("bit");

                    b.Property<byte>("MembershipTypeId")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("MembershipTypeId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DOB = "05/20/1999",
                            IsSubscribedToNewsletter = true,
                            MembershipTypeId = (byte)2,
                            Name = "Jane Ruby"
                        },
                        new
                        {
                            Id = 2,
                            DOB = "06/21/1998",
                            IsSubscribedToNewsletter = true,
                            MembershipTypeId = (byte)2,
                            Name = "Peter Pan"
                        },
                        new
                        {
                            Id = 3,
                            DOB = "07/22/1987",
                            IsSubscribedToNewsletter = false,
                            MembershipTypeId = (byte)1,
                            Name = "Stew Peters"
                        },
                        new
                        {
                            Id = 4,
                            DOB = "08/09/1972",
                            IsSubscribedToNewsletter = true,
                            MembershipTypeId = (byte)3,
                            Name = "Mark Snow"
                        },
                        new
                        {
                            Id = 5,
                            DOB = "09/10/1980",
                            IsSubscribedToNewsletter = true,
                            MembershipTypeId = (byte)1,
                            Name = "Allen Key"
                        });
                });

            modelBuilder.Entity("Fidly.Models.MembershipType", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint");

                    b.Property<byte>("DiscountRate")
                        .HasColumnType("tinyint");

                    b.Property<byte>("DurationInMonths")
                        .HasColumnType("tinyint");

                    b.Property<string>("MembershipName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("SignUpFee")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("MembershipType");

                    b.HasData(
                        new
                        {
                            Id = (byte)1,
                            DiscountRate = (byte)0,
                            DurationInMonths = (byte)0,
                            MembershipName = "None",
                            SignUpFee = (short)0
                        },
                        new
                        {
                            Id = (byte)2,
                            DiscountRate = (byte)10,
                            DurationInMonths = (byte)1,
                            MembershipName = "Monthly",
                            SignUpFee = (short)30
                        },
                        new
                        {
                            Id = (byte)3,
                            DiscountRate = (byte)15,
                            DurationInMonths = (byte)3,
                            MembershipName = "Quaterly",
                            SignUpFee = (short)90
                        },
                        new
                        {
                            Id = (byte)4,
                            DiscountRate = (byte)20,
                            DurationInMonths = (byte)12,
                            MembershipName = "Annually",
                            SignUpFee = (short)300
                        });
                });

            modelBuilder.Entity("Fidly.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("Fidly.Models.Customers", b =>
                {
                    b.HasOne("Fidly.Models.MembershipType", "MembershipType")
                        .WithMany()
                        .HasForeignKey("MembershipTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MembershipType");
                });
#pragma warning restore 612, 618
        }
    }
}
