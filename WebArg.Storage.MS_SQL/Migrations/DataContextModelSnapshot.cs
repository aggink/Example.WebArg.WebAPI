﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebArg.Storage.Database;

#nullable disable

namespace WebArg.Storage.MS_SQL.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebArg.Storage.Models.Master", b =>
                {
                    b.Property<Guid>("IsnNode")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IsnNode");

                    b.ToTable("Masters");
                });

            modelBuilder.Entity("WebArg.Storage.Models.MasterPerson", b =>
                {
                    b.Property<Guid>("IsnMaster")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IsnPerson")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IsnMaster", "IsnPerson");

                    b.HasIndex("IsnPerson");

                    b.HasIndex("IsnMaster", "IsnPerson");

                    b.ToTable("MastersPersons");
                });

            modelBuilder.Entity("WebArg.Storage.Models.Person", b =>
                {
                    b.Property<Guid>("IsnNode")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IsnStudio")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LastVisit")
                        .HasMaxLength(100)
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IsnNode");

                    b.HasIndex("IsnStudio");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("WebArg.Storage.Models.Studio", b =>
                {
                    b.Property<Guid>("IsnNode")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IsnNode");

                    b.ToTable("Studios");
                });

            modelBuilder.Entity("WebArg.Storage.Models.StudioMaster", b =>
                {
                    b.Property<Guid>("IsnStudio")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IsnMaster")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IsnStudio", "IsnMaster");

                    b.HasIndex("IsnMaster");

                    b.HasIndex("IsnStudio", "IsnMaster");

                    b.ToTable("StudiosMasters");
                });

            modelBuilder.Entity("WebArg.Storage.Models.MasterPerson", b =>
                {
                    b.HasOne("WebArg.Storage.Models.Master", "Master")
                        .WithMany("MasterPersons")
                        .HasForeignKey("IsnMaster")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebArg.Storage.Models.Person", "Person")
                        .WithMany("PersonMasters")
                        .HasForeignKey("IsnPerson")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Master");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("WebArg.Storage.Models.Person", b =>
                {
                    b.HasOne("WebArg.Storage.Models.Studio", "Studio")
                        .WithMany("Persons")
                        .HasForeignKey("IsnStudio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("WebArg.Storage.Models.StudioMaster", b =>
                {
                    b.HasOne("WebArg.Storage.Models.Master", "Master")
                        .WithMany("MasterStudios")
                        .HasForeignKey("IsnMaster")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebArg.Storage.Models.Studio", "Studio")
                        .WithMany("StudioMasters")
                        .HasForeignKey("IsnStudio")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Master");

                    b.Navigation("Studio");
                });

            modelBuilder.Entity("WebArg.Storage.Models.Master", b =>
                {
                    b.Navigation("MasterPersons");

                    b.Navigation("MasterStudios");
                });

            modelBuilder.Entity("WebArg.Storage.Models.Person", b =>
                {
                    b.Navigation("PersonMasters");
                });

            modelBuilder.Entity("WebArg.Storage.Models.Studio", b =>
                {
                    b.Navigation("Persons");

                    b.Navigation("StudioMasters");
                });
#pragma warning restore 612, 618
        }
    }
}