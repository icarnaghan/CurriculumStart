﻿// <auto-generated />
using System;
using CurriculumStart.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CurriculumStart.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190705131555_AddedFollowEntity")]
    partial class AddedFollowEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("CurriculumStart.API.Models.Element", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("SetId");

                    b.HasKey("Id");

                    b.HasIndex("SetId");

                    b.ToTable("Elements");
                });

            modelBuilder.Entity("CurriculumStart.API.Models.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int?>("ElementId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ElementId");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("CurriculumStart.API.Models.Map", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("GradeLower");

                    b.Property<string>("GradeUpper");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Subject");

                    b.HasKey("Id");

                    b.ToTable("Maps");
                });

            modelBuilder.Entity("CurriculumStart.API.Models.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("Duration");

                    b.Property<int?>("MapId");

                    b.Property<string>("Name");

                    b.Property<int>("Order");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("MapId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("CurriculumStart.API.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<bool>("IsMain");

                    b.Property<string>("PublicId");

                    b.Property<string>("Url");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("CurriculumStart.API.Models.Set", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ModuleId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("Sets");
                });

            modelBuilder.Entity("CurriculumStart.API.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Expertise");

                    b.Property<string>("Gender");

                    b.Property<string>("Interests");

                    b.Property<string>("Introduction");

                    b.Property<string>("KnownAs");

                    b.Property<DateTime>("LastActive");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CurriculumStart.API.Models.UserFollow", b =>
                {
                    b.Property<int>("FollowerId");

                    b.Property<int>("FolloweeId");

                    b.HasKey("FollowerId", "FolloweeId");

                    b.HasIndex("FolloweeId");

                    b.ToTable("UserFollows");
                });

            modelBuilder.Entity("CurriculumStart.API.Models.UserMap", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("MapId");

                    b.HasKey("UserId", "MapId");

                    b.HasIndex("MapId");

                    b.ToTable("UserMaps");
                });

            modelBuilder.Entity("CurriculumStart.API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("CurriculumStart.API.Models.Element", b =>
                {
                    b.HasOne("CurriculumStart.API.Models.Set", "Set")
                        .WithMany()
                        .HasForeignKey("SetId");
                });

            modelBuilder.Entity("CurriculumStart.API.Models.Field", b =>
                {
                    b.HasOne("CurriculumStart.API.Models.Element", "Element")
                        .WithMany()
                        .HasForeignKey("ElementId");
                });

            modelBuilder.Entity("CurriculumStart.API.Models.Module", b =>
                {
                    b.HasOne("CurriculumStart.API.Models.Map", "Map")
                        .WithMany()
                        .HasForeignKey("MapId");
                });

            modelBuilder.Entity("CurriculumStart.API.Models.Photo", b =>
                {
                    b.HasOne("CurriculumStart.API.Models.User", "User")
                        .WithMany("Photos")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CurriculumStart.API.Models.Set", b =>
                {
                    b.HasOne("CurriculumStart.API.Models.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId");
                });

            modelBuilder.Entity("CurriculumStart.API.Models.UserFollow", b =>
                {
                    b.HasOne("CurriculumStart.API.Models.User", "Followee")
                        .WithMany("Followers")
                        .HasForeignKey("FolloweeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("CurriculumStart.API.Models.User", "Follower")
                        .WithMany("Followees")
                        .HasForeignKey("FollowerId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("CurriculumStart.API.Models.UserMap", b =>
                {
                    b.HasOne("CurriculumStart.API.Models.Map", "Maps")
                        .WithMany("UserMaps")
                        .HasForeignKey("MapId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CurriculumStart.API.Models.User", "Users")
                        .WithMany("UserMaps")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
