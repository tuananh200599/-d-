﻿// <auto-generated />
using System;
using Ktra.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ktra.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201105033545_kt")]
    partial class kt
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ktra.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PostsId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PostsId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Re",
                            Title = "Rau"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Tuoi",
                            Title = "Ca"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Ngon",
                            Title = "Thit"
                        });
                });

            modelBuilder.Entity("Ktra.Models.Posts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TagsId")
                        .HasColumnType("int");

                    b.Property<string>("Tittle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TagsId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("Ktra.Models.PostsTag", b =>
                {
                    b.Property<int>("PostsId")
                        .HasColumnType("int");

                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.HasKey("PostsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("PostsTag");
                });

            modelBuilder.Entity("Ktra.Models.Tags", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Thom",
                            Title = "Gao"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Ngon",
                            Title = "My"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Bo",
                            Title = "Lua My"
                        });
                });

            modelBuilder.Entity("Ktra.Models.Categories", b =>
                {
                    b.HasOne("Ktra.Models.Posts", "Posts")
                        .WithMany("Categories")
                        .HasForeignKey("PostsId");
                });

            modelBuilder.Entity("Ktra.Models.Posts", b =>
                {
                    b.HasOne("Ktra.Models.Tags", "Tags")
                        .WithMany("Posts")
                        .HasForeignKey("TagsId");
                });

            modelBuilder.Entity("Ktra.Models.PostsTag", b =>
                {
                    b.HasOne("Ktra.Models.Posts", "Posts")
                        .WithMany()
                        .HasForeignKey("PostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ktra.Models.Tags", "Tags")
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
