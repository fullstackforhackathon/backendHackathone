﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backendHackathone.DAL.Contexts;

namespace backendHackathone.DAL.Migrations
{
    [DbContext(typeof(EntityContext))]
    partial class EntityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("backendHackathone.Core.Entities.BusinessEntityType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("BusinessEntityTypes");
                });

            modelBuilder.Entity("backendHackathone.Core.Entities.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Fields");
                });

            modelBuilder.Entity("backendHackathone.Core.Entities.FieldValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BusinessEntityId");

                    b.Property<int>("FieldId");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.ToTable("FieldValues");
                });

            modelBuilder.Entity("backendHackathone.Core.Entities.PowerLine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommissioningYear");

                    b.Property<string>("DispatchNumber");

                    b.Property<double>("Length");

                    b.Property<double>("LengthByChain");

                    b.Property<string>("LineMark");

                    b.Property<string>("Name");

                    b.Property<int>("Number");

                    b.Property<int>("NumberOfChains");

                    b.Property<double>("SummaryLength");

                    b.Property<double>("SummaryLengthByChain");

                    b.Property<string>("TechnicalStatus");

                    b.Property<int>("Voltage");

                    b.HasKey("Id");

                    b.ToTable("PowerLinesData");
                });

            modelBuilder.Entity("backendHackathone.PresentLayer.Entities.AgeRange", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConfigurationId");

                    b.Property<int>("EndAge");

                    b.Property<int>("StartAge");

                    b.HasKey("Id");

                    b.ToTable("AgeRanges");
                });

            modelBuilder.Entity("backendHackathone.PresentLayer.Entities.Configuration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Configurations");
                });

            modelBuilder.Entity("backendHackathone.PresentLayer.Entities.FieldsMappingRules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConfigurationId");

                    b.Property<bool>("IsVisible");

                    b.Property<int?>("OriginFieldId");

                    b.Property<int?>("SourceFieldId");

                    b.HasKey("Id");

                    b.HasIndex("OriginFieldId");

                    b.HasIndex("SourceFieldId");

                    b.ToTable("FieldsMappingRules");
                });

            modelBuilder.Entity("backendHackathone.PresentLayer.Entities.SubmissionScope", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName");

                    b.Property<DateTime>("Date");

                    b.Property<string>("FilialName");

                    b.Property<int>("ReportId");

                    b.HasKey("Id");

                    b.ToTable("SubmissionScopes");
                });

            modelBuilder.Entity("backendHackathone.Core.Entities.FieldValue", b =>
                {
                    b.HasOne("backendHackathone.Core.Entities.Field", "Field")
                        .WithMany()
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("backendHackathone.PresentLayer.Entities.FieldsMappingRules", b =>
                {
                    b.HasOne("backendHackathone.Core.Entities.Field", "OriginField")
                        .WithMany()
                        .HasForeignKey("OriginFieldId");

                    b.HasOne("backendHackathone.Core.Entities.Field", "SourceField")
                        .WithMany()
                        .HasForeignKey("SourceFieldId");
                });
#pragma warning restore 612, 618
        }
    }
}
