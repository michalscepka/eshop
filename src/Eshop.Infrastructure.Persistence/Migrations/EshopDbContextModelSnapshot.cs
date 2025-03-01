﻿// <auto-generated />
using System;
using Eshop.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Eshop.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(EshopDbContext))]
    partial class EshopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Eshop.Infrastructure.Persistence.Models.ProductModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ImgUri")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("11111111-1111-1111-1111-111111111111"),
                            CreatedAt = new DateTime(2024, 2, 25, 12, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Product 1 description",
                            ImgUri = "https://example.com/product1.png",
                            Name = "Product 1",
                            Price = 10m
                        },
                        new
                        {
                            Id = new Guid("22222222-2222-2222-2222-222222222222"),
                            CreatedAt = new DateTime(2024, 2, 26, 14, 30, 0, 0, DateTimeKind.Utc),
                            Description = "A high-quality product for everyday use.",
                            ImgUri = "https://example.com/product2.png",
                            Name = "Product 2",
                            Price = 15.50m
                        },
                        new
                        {
                            Id = new Guid("33333333-3333-3333-3333-333333333333"),
                            CreatedAt = new DateTime(2024, 2, 27, 9, 15, 0, 0, DateTimeKind.Utc),
                            Description = "A budget-friendly product with great features.",
                            ImgUri = "https://example.com/product3.png",
                            Name = "Product 3",
                            Price = 7.99m
                        },
                        new
                        {
                            Id = new Guid("44444444-4444-4444-4444-444444444444"),
                            CreatedAt = new DateTime(2024, 2, 28, 16, 45, 0, 0, DateTimeKind.Utc),
                            Description = "A premium product with top-tier performance.",
                            ImgUri = "https://example.com/product4.png",
                            Name = "Product 4",
                            Price = 25m
                        },
                        new
                        {
                            Id = new Guid("55555555-5555-5555-5555-555555555555"),
                            CreatedAt = new DateTime(2024, 2, 29, 11, 0, 0, 0, DateTimeKind.Utc),
                            Description = "A stylish and durable product for modern users.",
                            ImgUri = "https://example.com/product5.png",
                            Name = "Product 5",
                            Price = 12.75m
                        },
                        new
                        {
                            Id = new Guid("66666666-6666-6666-6666-666666666666"),
                            CreatedAt = new DateTime(2024, 3, 1, 10, 15, 0, 0, DateTimeKind.Utc),
                            Description = "A compact and lightweight product, ideal for travel.",
                            ImgUri = "https://example.com/product6.png",
                            Name = "Product 6",
                            Price = 19.99m
                        },
                        new
                        {
                            Id = new Guid("77777777-7777-7777-7777-777777777777"),
                            CreatedAt = new DateTime(2024, 3, 2, 13, 20, 0, 0, DateTimeKind.Utc),
                            Description = "An eco-friendly product made from sustainable materials.",
                            ImgUri = "https://example.com/product7.png",
                            Name = "Product 7",
                            Price = 8.49m
                        },
                        new
                        {
                            Id = new Guid("88888888-8888-8888-8888-888888888888"),
                            CreatedAt = new DateTime(2024, 3, 3, 17, 10, 0, 0, DateTimeKind.Utc),
                            Description = "A luxury product for those who appreciate fine quality.",
                            ImgUri = "https://example.com/product8.png",
                            Name = "Product 8",
                            Price = 30.00m
                        },
                        new
                        {
                            Id = new Guid("99999999-9999-9999-9999-999999999999"),
                            CreatedAt = new DateTime(2024, 3, 4, 8, 30, 0, 0, DateTimeKind.Utc),
                            Description = "An affordable and practical product for daily needs.",
                            ImgUri = "https://example.com/product9.png",
                            Name = "Product 9",
                            Price = 5.99m
                        },
                        new
                        {
                            Id = new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                            CreatedAt = new DateTime(2024, 3, 5, 15, 45, 0, 0, DateTimeKind.Utc),
                            Description = "A well-designed product with ergonomic features.",
                            ImgUri = "https://example.com/product10.png",
                            Name = "Product 10",
                            Price = 22.50m
                        },
                        new
                        {
                            Id = new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"),
                            CreatedAt = new DateTime(2024, 3, 6, 12, 10, 0, 0, DateTimeKind.Utc),
                            Description = "A durable and reliable product for long-term use.",
                            ImgUri = "https://example.com/product11.png",
                            Name = "Product 11",
                            Price = 14.00m
                        },
                        new
                        {
                            Id = new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                            CreatedAt = new DateTime(2024, 3, 7, 14, 30, 0, 0, DateTimeKind.Utc),
                            Description = "A colorful and fun product for all ages.",
                            ImgUri = "https://example.com/product12.png",
                            Name = "Product 12",
                            Price = 9.99m
                        },
                        new
                        {
                            Id = new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                            CreatedAt = new DateTime(2024, 3, 8, 16, 45, 0, 0, DateTimeKind.Utc),
                            Description = "A cutting-edge product with the latest technology.",
                            ImgUri = "https://example.com/product13.png",
                            Name = "Product 13",
                            Price = 28.00m
                        },
                        new
                        {
                            Id = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                            CreatedAt = new DateTime(2024, 3, 9, 10, 0, 0, 0, DateTimeKind.Utc),
                            Description = "A simple but effective product for everyday use.",
                            ImgUri = "https://example.com/product14.png",
                            Name = "Product 14",
                            Price = 6.50m
                        },
                        new
                        {
                            Id = new Guid("ffffffff-ffff-ffff-ffff-ffffffffffff"),
                            CreatedAt = new DateTime(2024, 3, 10, 9, 45, 0, 0, DateTimeKind.Utc),
                            Description = "A sleek and modern product for a contemporary lifestyle.",
                            ImgUri = "https://example.com/product15.png",
                            Name = "Product 15",
                            Price = 18.75m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
