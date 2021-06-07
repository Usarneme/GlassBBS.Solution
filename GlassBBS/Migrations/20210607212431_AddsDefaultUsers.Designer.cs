﻿// <auto-generated />
using GlassBBS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GlassBBS.Migrations
{
    [DbContext(typeof(GlassBBSContext))]
    [Migration("20210607212431_AddsDefaultUsers")]
    partial class AddsDefaultUsers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GlassBBS.Models.Board", b =>
                {
                    b.Property<string>("BoardId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("BoardId");

                    b.ToTable("Boards");

                    b.HasData(
                        new
                        {
                            BoardId = "0a825328-bfd4-421d-8d68-afe78178e388",
                            Description = "Information regarding various residency opportunities.",
                            Name = "Residencies"
                        },
                        new
                        {
                            BoardId = "6c4428ba-9edb-4733-b982-b02420e53634",
                            Description = "A selection of educational workshop offerings.",
                            Name = "Workshops"
                        },
                        new
                        {
                            BoardId = "a5c08454-6ac6-41c1-a754-21fa1cfd9486",
                            Description = "A list of institutions offering higher-ed degrees in the field.",
                            Name = "Education"
                        },
                        new
                        {
                            BoardId = "bde4dbe9-9b24-44fd-bcff-c085a06bc69e",
                            Description = "Scholarship info for workshops and universities.",
                            Name = "Scholarships"
                        },
                        new
                        {
                            BoardId = "4a6f4771-9bb0-471d-b335-17bdcfde6d9a",
                            Description = "View selected works/exhibitions by various artists",
                            Name = "Exhibitions"
                        },
                        new
                        {
                            BoardId = "ab498cf9-cc76-4075-aae5-a6ae90f70b58",
                            Description = "Find relevant job info within the field.",
                            Name = "Jobs"
                        });
                });

            modelBuilder.Entity("GlassBBS.Models.BoardPost", b =>
                {
                    b.Property<string>("BoardPostId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("BoardId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("BoardUserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("PostId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("BoardPostId");

                    b.HasIndex("BoardId");

                    b.HasIndex("BoardUserId");

                    b.HasIndex("PostId");

                    b.ToTable("BoardPosts");
                });

            modelBuilder.Entity("GlassBBS.Models.BoardUser", b =>
                {
                    b.Property<string>("BoardUserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("BoardUserId");

                    b.ToTable("BoardUser");

                    b.HasData(
                        new
                        {
                            BoardUserId = "f041cf14-4587-46af-b20c-c6514ed97185",
                            Name = "Max"
                        },
                        new
                        {
                            BoardUserId = "7bb5cdb8-c18a-49cb-8dda-354ef8885a4b",
                            Name = "Tom"
                        });
                });

            modelBuilder.Entity("GlassBBS.Models.Post", b =>
                {
                    b.Property<string>("PostId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Body")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PostAuthorBoardUserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("PostId");

                    b.HasIndex("PostAuthorBoardUserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("GlassBBS.Models.PostReply", b =>
                {
                    b.Property<string>("PostReplyId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("BoardUserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("PostId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("ReplyId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("PostReplyId");

                    b.HasIndex("BoardUserId");

                    b.HasIndex("PostId");

                    b.HasIndex("ReplyId");

                    b.ToTable("PostReplies");
                });

            modelBuilder.Entity("GlassBBS.Models.Reply", b =>
                {
                    b.Property<string>("ReplyId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.Property<string>("Body")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("ReplyAuthorBoardUserId")
                        .HasColumnType("varchar(255) CHARACTER SET utf8mb4");

                    b.HasKey("ReplyId");

                    b.HasIndex("ReplyAuthorBoardUserId");

                    b.ToTable("Replies");
                });

            modelBuilder.Entity("GlassBBS.Models.BoardPost", b =>
                {
                    b.HasOne("GlassBBS.Models.Board", "Board")
                        .WithMany("BoardPosts")
                        .HasForeignKey("BoardId");

                    b.HasOne("GlassBBS.Models.BoardUser", null)
                        .WithMany("BoardPosts")
                        .HasForeignKey("BoardUserId");

                    b.HasOne("GlassBBS.Models.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId");

                    b.Navigation("Board");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("GlassBBS.Models.Post", b =>
                {
                    b.HasOne("GlassBBS.Models.BoardUser", "PostAuthor")
                        .WithMany()
                        .HasForeignKey("PostAuthorBoardUserId");

                    b.Navigation("PostAuthor");
                });

            modelBuilder.Entity("GlassBBS.Models.PostReply", b =>
                {
                    b.HasOne("GlassBBS.Models.BoardUser", null)
                        .WithMany("PostReplies")
                        .HasForeignKey("BoardUserId");

                    b.HasOne("GlassBBS.Models.Post", "Post")
                        .WithMany("PostReplies")
                        .HasForeignKey("PostId");

                    b.HasOne("GlassBBS.Models.Reply", "Reply")
                        .WithMany()
                        .HasForeignKey("ReplyId");

                    b.Navigation("Post");

                    b.Navigation("Reply");
                });

            modelBuilder.Entity("GlassBBS.Models.Reply", b =>
                {
                    b.HasOne("GlassBBS.Models.BoardUser", "ReplyAuthor")
                        .WithMany()
                        .HasForeignKey("ReplyAuthorBoardUserId");

                    b.Navigation("ReplyAuthor");
                });

            modelBuilder.Entity("GlassBBS.Models.Board", b =>
                {
                    b.Navigation("BoardPosts");
                });

            modelBuilder.Entity("GlassBBS.Models.BoardUser", b =>
                {
                    b.Navigation("BoardPosts");

                    b.Navigation("PostReplies");
                });

            modelBuilder.Entity("GlassBBS.Models.Post", b =>
                {
                    b.Navigation("PostReplies");
                });
#pragma warning restore 612, 618
        }
    }
}
