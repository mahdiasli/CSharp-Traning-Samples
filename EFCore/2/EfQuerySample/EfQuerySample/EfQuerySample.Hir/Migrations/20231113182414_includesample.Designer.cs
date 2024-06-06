﻿// <auto-generated />
using System;
using EfQuerySample.Hir;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfQuerySample.Hir.Migrations
{
    [DbContext(typeof(EmpContext))]
    [Migration("20231113182414_includesample")]
    partial class includesample
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EfQuerySample.Hir.Employe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Employes");
                });

            modelBuilder.Entity("EfQuerySample.Hir.Type01", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Type01s");
                });

            modelBuilder.Entity("EfQuerySample.Hir.Type02", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type01Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Type01Id");

                    b.ToTable("Type02s");
                });

            modelBuilder.Entity("EfQuerySample.Hir.Type03", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type02Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Type02Id");

                    b.ToTable("Type03s");
                });

            modelBuilder.Entity("EfQuerySample.Hir.Employe", b =>
                {
                    b.HasOne("EfQuerySample.Hir.Employe", "parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.Navigation("parent");
                });

            modelBuilder.Entity("EfQuerySample.Hir.Type02", b =>
                {
                    b.HasOne("EfQuerySample.Hir.Type01", "Type01")
                        .WithMany("Type02")
                        .HasForeignKey("Type01Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type01");
                });

            modelBuilder.Entity("EfQuerySample.Hir.Type03", b =>
                {
                    b.HasOne("EfQuerySample.Hir.Type02", "Type02")
                        .WithMany("Type03")
                        .HasForeignKey("Type02Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type02");
                });

            modelBuilder.Entity("EfQuerySample.Hir.Employe", b =>
                {
                    b.Navigation("Children");
                });

            modelBuilder.Entity("EfQuerySample.Hir.Type01", b =>
                {
                    b.Navigation("Type02");
                });

            modelBuilder.Entity("EfQuerySample.Hir.Type02", b =>
                {
                    b.Navigation("Type03");
                });
#pragma warning restore 612, 618
        }
    }
}
