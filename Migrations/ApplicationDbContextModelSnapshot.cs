﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VetCare_BackEnd.Data;

#nullable disable

namespace VetCare_BackEnd.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("VetCare_BackEnd.Models.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AppointmentTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("Available")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Description")
                        .HasMaxLength(260)
                        .HasColumnType("varchar(260)");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("appointments");
                });

            modelBuilder.Entity("VetCare_BackEnd.Models.AppointmentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("appointmentTypes");
                });

            modelBuilder.Entity("VetCare_BackEnd.Models.DocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("documentTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Cédula de Ciudadanía"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Tarjeta de Identidad"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Pasaporte"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Número de Identificación Tributaria"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cédula de Extranjería"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Registro Civil"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Permiso Especial de Permanencia"
                        });
                });

            modelBuilder.Entity("VetCare_BackEnd.Models.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("BirthDate")
                        .HasMaxLength(10)
                        .HasColumnType("date");

                    b.Property<string>("Breed")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("pets");
                });

            modelBuilder.Entity("VetCare_BackEnd.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = 2,
                            Name = "User"
                        });
                });

            modelBuilder.Entity("VetCare_BackEnd.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly?>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<int>("DocumentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateOnly(2023, 10, 6),
                            DocumentNumber = "p63r9ekxnn",
                            DocumentTypeId = 1,
                            Email = "Eleonore.Mosciski@yahoo.com",
                            LastName = "Cummings",
                            Name = "Myles",
                            Password = "j4Rikt4gLK",
                            PhoneNumber = "404 229 49 47",
                            RoleId = 4
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateOnly(2024, 2, 5),
                            DocumentNumber = "9ed5076f7u",
                            DocumentTypeId = 5,
                            Email = "Savanah_Marquardt@yahoo.com",
                            LastName = "Lemke",
                            Name = "Wendy",
                            Password = "Y8dO6RM4zl",
                            PhoneNumber = "634 059 53 74",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateOnly(2024, 6, 7),
                            DocumentNumber = "74si1odva8",
                            DocumentTypeId = 3,
                            Email = "Claude.Lesch66@gmail.com",
                            LastName = "Koss",
                            Name = "Ben",
                            Password = "5tS6Q0_loz",
                            PhoneNumber = "105 526 93 41",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateOnly(2024, 2, 13),
                            DocumentNumber = "ccgfu51fl6",
                            DocumentTypeId = 1,
                            Email = "Felicita_Wunsch69@hotmail.com",
                            LastName = "Kihn",
                            Name = "Afton",
                            Password = "ZhxFy0U9Uk",
                            PhoneNumber = "578 385 94 00",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 5,
                            BirthDate = new DateOnly(2023, 12, 14),
                            DocumentNumber = "c8qfsvfzmf",
                            DocumentTypeId = 5,
                            Email = "Rachel99@hotmail.com",
                            LastName = "Kuhn",
                            Name = "Imelda",
                            Password = "BJOLyCy2Ec",
                            PhoneNumber = "787 950 50 06",
                            RoleId = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
