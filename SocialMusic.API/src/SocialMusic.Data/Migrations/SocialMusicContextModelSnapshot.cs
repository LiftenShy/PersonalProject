﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SocialMusic.Data;
using System;

namespace Data.Migrations
{
    [DbContext(typeof(SocialMusicContext))]
    partial class SocialMusicContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SocialMusic.Models.EntityModels.AuthModels.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("SocialMusic.Models.EntityModels.AuthModels.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginName");

                    b.Property<byte[]>("PasswordHash");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("SocialMusic.Models.EntityModels.AuthModels.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("RoleId");

                    b.Property<int>("UserId");

                    b.Property<int?>("UserProfilesId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserProfilesId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("SocialMusic.Models.EntityModels.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("SocialMusic.Models.EntityModels.AuthModels.UserRole", b =>
                {
                    b.HasOne("SocialMusic.Models.EntityModels.AuthModels.Role", "Roles")
                        .WithMany("UserRole")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SocialMusic.Models.EntityModels.AuthModels.UserProfile", "UserProfiles")
                        .WithMany("UserRole")
                        .HasForeignKey("UserProfilesId");
                });
#pragma warning restore 612, 618
        }
    }
}
