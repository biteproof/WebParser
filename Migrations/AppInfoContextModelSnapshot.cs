﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebParserTestApp2.Model;

namespace WebParserTestApp2.Migrations
{
    [DbContext(typeof(AppInfoContext))]
    partial class AppInfoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("WebParserTestApp2.Model.AppInfoDb", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IconLink")
                        .HasColumnType("TEXT");

                    b.Property<string>("Link")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Rating")
                        .HasColumnType("TEXT");

                    b.Property<string>("ScreenshotsSum")
                        .HasColumnType("TEXT");

                    b.Property<string>("SearchQuery")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("AppInfoDb");
                });

            modelBuilder.Entity("WebParserTestApp2.Model.MainTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("SearchQuery")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MainTable");
                });
#pragma warning restore 612, 618
        }
    }
}