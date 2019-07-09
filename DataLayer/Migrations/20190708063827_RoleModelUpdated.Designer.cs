﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataLayer.Migrations
{
    [DbContext(typeof(HospitalityContext))]
    [Migration("20190708063827_RoleModelUpdated")]
    partial class RoleModelUpdated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DomainModels.Hotel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("DomainModels.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Duration");

                    b.Property<string>("RoleName");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DomainModels.RoleStaff", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("StaffId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("StaffId");

                    b.ToTable("RolesStaffSet");
                });

            modelBuilder.Entity("DomainModels.Staff", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("HotelId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("StaffSet");
                });

            modelBuilder.Entity("DomainModels.RoleStaff", b =>
                {
                    b.HasOne("DomainModels.Role", "Role")
                        .WithMany("RoleStaff")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("DomainModels.Staff", "Staff")
                        .WithMany("RoleStaff")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("DomainModels.Staff", b =>
                {
                    b.HasOne("DomainModels.Hotel", "Hotel")
                        .WithMany("Staff")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
