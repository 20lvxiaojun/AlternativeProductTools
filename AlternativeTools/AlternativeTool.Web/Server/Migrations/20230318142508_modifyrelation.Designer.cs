﻿// <auto-generated />
using System;
using AlternativeTool.Web.Server.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AlternativeTool.Web.Server.Migrations
{
    [DbContext(typeof(DBProductContext))]
    [Migration("20230318142508_modifyrelation")]
    partial class modifyrelation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AlternativeTool.Web.Server.Entities.CompetitiveProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("CompetitiveProducts");
                });

            modelBuilder.Entity("AlternativeTool.Web.Server.Entities.MiddelTable", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("CompetitiveId")
                        .HasColumnType("int");

                    b.Property<int?>("CompetitiveProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductId", "CompetitiveId");

                    b.HasIndex("CompetitiveProductId");

                    b.ToTable("MiddelTable");
                });

            modelBuilder.Entity("AlternativeTool.Web.Server.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompetitiveProductId")
                        .HasColumnType("int");

                    b.Property<string>("Describe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompetitiveProductId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("AlternativeTool.Web.Server.Entities.CompetitiveProduct", b =>
                {
                    b.HasOne("AlternativeTool.Web.Server.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("AlternativeTool.Web.Server.Entities.MiddelTable", b =>
                {
                    b.HasOne("AlternativeTool.Web.Server.Entities.CompetitiveProduct", "CompetitiveProduct")
                        .WithMany("Products")
                        .HasForeignKey("CompetitiveProductId");

                    b.HasOne("AlternativeTool.Web.Server.Entities.Product", "Product")
                        .WithMany("CompetitiveProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompetitiveProduct");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("AlternativeTool.Web.Server.Entities.Product", b =>
                {
                    b.HasOne("AlternativeTool.Web.Server.Entities.CompetitiveProduct", null)
                        .WithMany()
                        .HasForeignKey("CompetitiveProductId");
                });

            modelBuilder.Entity("AlternativeTool.Web.Server.Entities.CompetitiveProduct", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("AlternativeTool.Web.Server.Entities.Product", b =>
                {
                    b.Navigation("CompetitiveProducts");
                });
#pragma warning restore 612, 618
        }
    }
}