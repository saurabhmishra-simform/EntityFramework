﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OneToOneDemoCodeFirst.Models;

#nullable disable

namespace OneToOneDemoCodeFirst.Migrations
{
    [DbContext(typeof(AuthorContext))]
    [Migration("20230511113913_AuthorMigration")]
    partial class AuthorMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("OneToOneDemoCodeFirst.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("OneToOneDemoCodeFirst.Models.AuthorBio", b =>
                {
                    b.Property<int>("AuthorBioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorBioId"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Biography")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlaceofBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorBioId");

                    b.HasIndex("AuthorId")
                        .IsUnique();

                    b.ToTable("AuthorBios");
                });

            modelBuilder.Entity("OneToOneDemoCodeFirst.Models.AuthorBio", b =>
                {
                    b.HasOne("OneToOneDemoCodeFirst.Models.Author", "Author")
                        .WithOne("Bio")
                        .HasForeignKey("OneToOneDemoCodeFirst.Models.AuthorBio", "AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("OneToOneDemoCodeFirst.Models.Author", b =>
                {
                    b.Navigation("Bio");
                });
#pragma warning restore 612, 618
        }
    }
}
