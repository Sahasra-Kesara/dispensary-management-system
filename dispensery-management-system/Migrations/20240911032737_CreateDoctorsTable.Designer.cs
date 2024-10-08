﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dispensery_management_system.Services;

#nullable disable

namespace dispensery_management_system.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240911032737_CreateDoctorsTable")]
    partial class CreateDoctorsTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("dispensery_management_system.Models.Doctor", b =>
                {
                    b.Property<string>("DoctorID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("ConsultationFee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ExperienceYears")
                        .HasColumnType("int");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DoctorID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("dispensery_management_system.Models.Patient", b =>
                {
                    b.Property<string>("PatientID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AllergyInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodGroup")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalHistory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("PatientID");

                    b.HasIndex("UserID")
                        .IsUnique();

                    b.ToTable("Patient");
                });

            modelBuilder.Entity("dispensery_management_system.Models.UserProfile", b =>
                {
                    b.Property<string>("UserID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("UserProfiles");
                });

            modelBuilder.Entity("dispensery_management_system.Models.Doctor", b =>
                {
                    b.HasOne("dispensery_management_system.Models.UserProfile", "UserProfile")
                        .WithOne("Doctor")
                        .HasForeignKey("dispensery_management_system.Models.Doctor", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("dispensery_management_system.Models.Patient", b =>
                {
                    b.HasOne("dispensery_management_system.Models.UserProfile", "UserProfile")
                        .WithOne("Patient")
                        .HasForeignKey("dispensery_management_system.Models.Patient", "UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UserProfile");
                });

            modelBuilder.Entity("dispensery_management_system.Models.UserProfile", b =>
                {
                    b.Navigation("Doctor")
                        .IsRequired();

                    b.Navigation("Patient")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
