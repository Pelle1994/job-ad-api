﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServiceHeroWebApi.Data;

namespace ServiceHeroWebApi.Migrations
{
    [DbContext(typeof(AdContext))]
    [Migration("20211018172341_Inital")]
    partial class Inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ServiceHeroWebApi.Models.JobAd", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("applicationDetails_email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("applicationDetails_url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("descriptionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("duration_concept_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("duration_label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employer_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employer_organization_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employer_workplace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("headline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("occupationGroup_concept_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("occupationGroup_label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("occupation_concept_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("occupation_label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("publication_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("workingHoursType_label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("workplaceAddress_city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("workplaceAddress_postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("workplaceAddress_street_address")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("JobAds");
                });
#pragma warning restore 612, 618
        }
    }
}
