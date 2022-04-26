﻿// <auto-generated />
using System;
using EF_2504.DAL.Concrete.ADO.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF_2504.DAL.Migrations
{
    [DbContext(typeof(BookAppDbContext))]
    partial class BookAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF_2504.DAL.Entities.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AuthorCreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 4, 26, 19, 23, 38, 629, DateTimeKind.Local).AddTicks(3449));

                    b.Property<string>("AuthorFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorCreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AuthorFirstName = "Burak",
                            AuthorLastName = "Korkmaz"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorCreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AuthorFirstName = "Ali",
                            AuthorLastName = "Dal"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorCreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AuthorFirstName = "İsmail",
                            AuthorLastName = "Sesiçok"
                        });
                });

            modelBuilder.Entity("EF_2504.DAL.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BookCreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 4, 26, 19, 23, 38, 638, DateTimeKind.Local).AddTicks(4180));

                    b.Property<string>("BookImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BookPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            BookCreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BookImageUrl = "https://cdn.dsmcdn.com/mnresize/500/-/ty106/product/media/images/20210418/22/81095313/14988871/1/1_org.jpg",
                            BookName = "Sefiller",
                            BookPrice = 120m
                        },
                        new
                        {
                            BookId = 2,
                            BookCreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BookImageUrl = "https://i.dr.com.tr/cache/600x600-0/originals/0000000186269-1.jpg",
                            BookName = "Kaşağı",
                            BookPrice = 90m
                        },
                        new
                        {
                            BookId = 3,
                            BookCreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BookImageUrl = "https://www.tdk.com.tr/images_buyuk/f14/A-dan-Z-ye-PHP_8614_1.jpg",
                            BookName = "A'dan Z'ye PHP",
                            BookPrice = 190m
                        });
                });

            modelBuilder.Entity("EF_2504.DAL.Entities.BookAuthor", b =>
                {
                    b.Property<int>("BookAuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasKey("BookAuthorId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("BookAuthor");

                    b.HasData(
                        new
                        {
                            BookAuthorId = 1,
                            AuthorId = 1,
                            BookId = 1
                        },
                        new
                        {
                            BookAuthorId = 2,
                            AuthorId = 2,
                            BookId = 2
                        },
                        new
                        {
                            BookAuthorId = 3,
                            AuthorId = 3,
                            BookId = 3
                        });
                });

            modelBuilder.Entity("EF_2504.DAL.Entities.BookDetail", b =>
                {
                    b.Property<int>("BookDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookDetailCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookDetailCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookDetailIsbn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("0000-0000-0000");

                    b.Property<int>("BookDetailYear")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2022);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasKey("BookDetailId");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.ToTable("BookDetails");

                    b.HasData(
                        new
                        {
                            BookDetailId = 1,
                            BookDetailCity = "Istanbul",
                            BookDetailYear = 0,
                            BookId = 1
                        },
                        new
                        {
                            BookDetailId = 2,
                            BookDetailCity = "Ankara",
                            BookDetailYear = 0,
                            BookId = 2
                        },
                        new
                        {
                            BookDetailId = 3,
                            BookDetailCity = "Izmir",
                            BookDetailYear = 0,
                            BookId = 3
                        });
                });

            modelBuilder.Entity("EF_2504.DAL.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryDescription = "Roman türü kitaplar",
                            CategoryName = "Roman"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryDescription = "Yönetim türü kitaplar",
                            CategoryName = "Yönetim"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryDescription = "Bilişim türü kitaplar",
                            CategoryName = "Bilişim"
                        });
                });

            modelBuilder.Entity("EF_2504.DAL.Entities.Book", b =>
                {
                    b.HasOne("EF_2504.DAL.Entities.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EF_2504.DAL.Entities.BookAuthor", b =>
                {
                    b.HasOne("EF_2504.DAL.Entities.Author", "Author")
                        .WithMany("BookAuthor")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_2504.DAL.Entities.Book", "Book")
                        .WithMany("BookAuthor")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("EF_2504.DAL.Entities.BookDetail", b =>
                {
                    b.HasOne("EF_2504.DAL.Entities.Book", "Book")
                        .WithOne("BookDetail")
                        .HasForeignKey("EF_2504.DAL.Entities.BookDetail", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("EF_2504.DAL.Entities.Author", b =>
                {
                    b.Navigation("BookAuthor");
                });

            modelBuilder.Entity("EF_2504.DAL.Entities.Book", b =>
                {
                    b.Navigation("BookAuthor");

                    b.Navigation("BookDetail");
                });

            modelBuilder.Entity("EF_2504.DAL.Entities.Category", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
