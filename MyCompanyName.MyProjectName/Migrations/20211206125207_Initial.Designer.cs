﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyCompanyName.MyProjectName.EfCore;
using Volo.Abp.EntityFrameworkCore;

#nullable disable

namespace MyCompanyName.MyProjectName.Migrations
{
    [DbContext(typeof(MyProjectNameDbContext))]
    [Migration("20211206125207_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("_Abp_DatabaseProvider", EfCoreDatabaseProvider.Sqlite)
                .HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("MyCompanyName.MyProjectName.Domain.Todos.Todo", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Todos", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
