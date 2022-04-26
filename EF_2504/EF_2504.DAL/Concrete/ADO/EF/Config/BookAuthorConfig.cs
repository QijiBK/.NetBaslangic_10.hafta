using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EF_2504.DAL.Entities;



namespace EF_2504.DAL.Concrete.ADO.EF.Config
{
    public class BookAuthorConfig : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasKey(ba => ba.BookAuthorId);
            builder.HasOne(ba =>ba.Book).WithMany(b=>b.BookAuthor).HasForeignKey(ba=>ba.BookId);
            builder.HasOne(ba =>ba.Author).WithMany(a=>a.BookAuthor).HasForeignKey(ba=>ba.AuthorId);


            builder.HasData(
                new BookAuthor { BookAuthorId =1,AuthorId=1,BookId=1},
                new BookAuthor { BookAuthorId =2,AuthorId=2,BookId=2},
                new BookAuthor { BookAuthorId =3,AuthorId=3,BookId=3}


                );
                
        }
    }
}
