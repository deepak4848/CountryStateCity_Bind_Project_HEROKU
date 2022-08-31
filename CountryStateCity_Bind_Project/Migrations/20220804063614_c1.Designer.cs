﻿// <auto-generated />
using CountryStateCity_Bind_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CountryStateCity_Bind_Project.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20220804063614_c1")]
    partial class c1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CountryStateCity_Bind_Project.Models.TblCity", b =>
                {
                    b.Property<int>("DId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DId"), 1L, 1);

                    b.Property<string>("DName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SId")
                        .HasColumnType("int");

                    b.HasKey("DId");

                    b.ToTable("tblCitys");
                });

            modelBuilder.Entity("CountryStateCity_Bind_Project.Models.TblCountry", b =>
                {
                    b.Property<int>("CId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CId"), 1L, 1);

                    b.Property<string>("CName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CId");

                    b.ToTable("tblCountries");
                });

            modelBuilder.Entity("CountryStateCity_Bind_Project.Models.TblState", b =>
                {
                    b.Property<int>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SId"), 1L, 1);

                    b.Property<int>("CId")
                        .HasColumnType("int");

                    b.Property<string>("SName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SId");

                    b.ToTable("tblStates");
                });

            modelBuilder.Entity("CountryStateCity_Bind_Project.Models.User", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_Id"), 1L, 1);

                    b.Property<int>("User_City")
                        .HasColumnType("int");

                    b.Property<int>("User_Country")
                        .HasColumnType("int");

                    b.Property<string>("User_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User_State")
                        .HasColumnType("int");

                    b.HasKey("User_Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}