﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyApi.Data;

namespace MyApi.Migrations
{
    [DbContext(typeof(ProjectCon))]
    partial class ProjectConModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyApi.Data.BlogPost", b =>
                {
                    b.Property<string>("Slug")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("PostDescription");

                    b.Property<string>("PostFooter");

                    b.Property<string>("PostTitle");

                    b.HasKey("Slug");

                    b.ToTable("BlogPosts");
                });

            modelBuilder.Entity("MyApi.Data.Tag", b =>
                {
                    b.Property<string>("TagSlug")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BlogPostSlug");

                    b.HasKey("TagSlug");

                    b.HasIndex("BlogPostSlug");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("MyApi.Data.Tag", b =>
                {
                    b.HasOne("MyApi.Data.BlogPost")
                        .WithMany("Tags")
                        .HasForeignKey("BlogPostSlug");
                });
#pragma warning restore 612, 618
        }
    }
}
