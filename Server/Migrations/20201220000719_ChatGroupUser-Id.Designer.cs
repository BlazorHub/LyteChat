﻿// <auto-generated />
using System;
using LearnBlazor.Server.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LearnBlazor.Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201220000719_ChatGroupUser-Id")]
    partial class ChatGroupUserId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LearnBlazor.Server.Data.Models.ChatGroup", b =>
                {
                    b.Property<long>("ChatGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("ChatGroupName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ChatGroupId");

                    b.ToTable("ChatGroups");

                    b.HasData(
                        new
                        {
                            ChatGroupId = 1L,
                            ChatGroupName = "ALL_CHAT",
                            Uuid = new Guid("5c1a1888-c7f9-40aa-bbb1-ac4f11ec902f")
                        },
                        new
                        {
                            ChatGroupId = 2L,
                            ChatGroupName = "second chat group",
                            Uuid = new Guid("2af2ae5d-396c-40a8-ad97-f7e81d5fd6ef")
                        },
                        new
                        {
                            ChatGroupId = 3L,
                            ChatGroupName = "third chat group",
                            Uuid = new Guid("fa50df81-0158-4fda-9813-ddff9f70ba9e")
                        });
                });

            modelBuilder.Entity("LearnBlazor.Server.Data.Models.ChatGroupUser", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("ChatGroupId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "ChatGroupId");

                    b.HasIndex("ChatGroupId");

                    b.ToTable("ChatGroupUsers");

                    b.HasData(
                        new
                        {
                            UserId = 1L,
                            ChatGroupId = 1L,
                            Uuid = new Guid("3f1ac551-d124-4415-8f46-c19ab0742c62")
                        },
                        new
                        {
                            UserId = 1L,
                            ChatGroupId = 2L,
                            Uuid = new Guid("c4928118-7c7b-42ea-9db0-630e9b811e7f")
                        },
                        new
                        {
                            UserId = 1L,
                            ChatGroupId = 3L,
                            Uuid = new Guid("22b511f8-9674-4cd8-9246-0dcb3979cddc")
                        },
                        new
                        {
                            UserId = 2L,
                            ChatGroupId = 1L,
                            Uuid = new Guid("a878a7d0-3593-4f84-bd20-3c318fc07a83")
                        });
                });

            modelBuilder.Entity("LearnBlazor.Server.Data.Models.ChatMessage", b =>
                {
                    b.Property<long>("ChatMessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<long>("ChatGroupId")
                        .HasColumnType("bigint");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ChatMessageId");

                    b.HasIndex("ChatGroupId");

                    b.HasIndex("UserId");

                    b.ToTable("ChatMessages");

                    b.HasData(
                        new
                        {
                            ChatMessageId = 1L,
                            ChatGroupId = 1L,
                            Message = "first message",
                            UserId = 1L,
                            Uuid = new Guid("c1d3e679-91a2-4104-9257-1fff551cd8e8")
                        },
                        new
                        {
                            ChatMessageId = 2L,
                            ChatGroupId = 2L,
                            Message = "second message",
                            UserId = 2L,
                            Uuid = new Guid("d6ebf6d5-8c4b-4425-ba46-50aa7edd31b8")
                        });
                });

            modelBuilder.Entity("LearnBlazor.Server.Data.Models.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Uuid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1L,
                            Name = "Carson",
                            Uuid = new Guid("da42cf59-b564-40b5-8132-c658461ba2e2")
                        },
                        new
                        {
                            UserId = 2L,
                            Name = "Bob",
                            Uuid = new Guid("f0fa72be-4122-4a29-99a0-c4ec702a36cb")
                        },
                        new
                        {
                            UserId = 3L,
                            Name = "Anonymous",
                            Uuid = new Guid("492e1a7c-5863-4561-b2ef-ef3a530420a7")
                        });
                });

            modelBuilder.Entity("LearnBlazor.Server.Data.Models.ChatGroupUser", b =>
                {
                    b.HasOne("LearnBlazor.Server.Data.Models.ChatGroup", "ChatGroup")
                        .WithMany("ChatGroupUsers")
                        .HasForeignKey("ChatGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearnBlazor.Server.Data.Models.User", "User")
                        .WithMany("ChatGroupUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChatGroup");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LearnBlazor.Server.Data.Models.ChatMessage", b =>
                {
                    b.HasOne("LearnBlazor.Server.Data.Models.ChatGroup", "ChatGroup")
                        .WithMany("Messages")
                        .HasForeignKey("ChatGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearnBlazor.Server.Data.Models.User", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChatGroup");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LearnBlazor.Server.Data.Models.ChatGroup", b =>
                {
                    b.Navigation("ChatGroupUsers");

                    b.Navigation("Messages");
                });

            modelBuilder.Entity("LearnBlazor.Server.Data.Models.User", b =>
                {
                    b.Navigation("ChatGroupUsers");

                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}