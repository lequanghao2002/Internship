﻿// <auto-generated />
using System;
using BNI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BNI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240320031722_foreign key user role")]
    partial class foreignkeyuserrole
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BNI.Models.Domain.AddtionalInformation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("BusinessHours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Condition_1")
                        .HasColumnType("bit");

                    b.Property<bool>("Condition_2")
                        .HasColumnType("bit");

                    b.Property<string>("Condition_3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Condition_4")
                        .HasColumnType("bit");

                    b.Property<bool>("Condition_5")
                        .HasColumnType("bit");

                    b.Property<string>("Condition_6")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Condition_7")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Condition_8")
                        .HasColumnType("bit");

                    b.Property<string>("Field")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InceptionDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("AddtionalInformation");
                });

            modelBuilder.Entity("BNI.Models.Domain.Business_Sector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Business_Sector");
                });

            modelBuilder.Entity("BNI.Models.Domain.Business_Support", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEOName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Category_SupportId")
                        .HasColumnType("int");

                    b.Property<int>("Category_Support_Id")
                        .HasColumnType("int");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<int>("Member_Id")
                        .HasColumnType("int");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QRCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Category_SupportId");

                    b.HasIndex("MemberID");

                    b.ToTable("Business_Support");
                });

            modelBuilder.Entity("BNI.Models.Domain.Category_Support", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category_Support");
                });

            modelBuilder.Entity("BNI.Models.Domain.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentID")
                        .HasColumnType("int");

                    b.Property<int>("Posts_ID")
                        .HasColumnType("int");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("updateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("Posts_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("BNI.Models.Domain.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CompanyAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("MemberOfCSJ")
                        .HasColumnType("bit");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlatformId")
                        .HasColumnType("int");

                    b.Property<int>("Platform_Id")
                        .HasColumnType("int");

                    b.Property<bool>("SupportInformation")
                        .HasColumnType("bit");

                    b.Property<string>("YearExperience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Platform_Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("BNI.Models.Domain.Events", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Header")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title_1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title_2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("BNI.Models.Domain.EventsRegister", b =>
                {
                    b.Property<int>("Event_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Cancel")
                        .HasColumnType("bit");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.HasKey("Event_ID");

                    b.HasIndex("User_ID");

                    b.ToTable("EventsRegister");
                });

            modelBuilder.Entity("BNI.Models.Domain.Logo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Logo");
                });

            modelBuilder.Entity("BNI.Models.Domain.Member", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("AdditionalInformation_ID")
                        .HasColumnType("int");

                    b.Property<string>("Address_1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address_2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingCompany")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BillingEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BusinessSector_ID")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Introducer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MembershipTerm_ID")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pronoun")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReferenceInformation_ID")
                        .HasColumnType("int");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AdditionalInformation_ID")
                        .IsUnique();

                    b.HasIndex("BusinessSector_ID")
                        .IsUnique();

                    b.HasIndex("MembershipTerm_ID")
                        .IsUnique();

                    b.HasIndex("ReferenceInformation_ID")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Member");
                });

            modelBuilder.Entity("BNI.Models.Domain.Membership_Term", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("CoC")
                        .HasColumnType("bit");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Member_Id")
                        .HasColumnType("int");

                    b.Property<string>("PayerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Membership_Term");
                });

            modelBuilder.Entity("BNI.Models.Domain.Platform", b =>
                {
                    b.Property<int>("Platform_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Platform_Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Platform_Id");

                    b.ToTable("Platform");
                });

            modelBuilder.Entity("BNI.Models.Domain.Posts", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Member_ID")
                        .HasColumnType("int");

                    b.Property<int>("PostsCategory_ID")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("View")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("Member_ID");

                    b.HasIndex("PostsCategory_ID");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("BNI.Models.Domain.PostsCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PostsCategory");
                });

            modelBuilder.Entity("BNI.Models.Domain.Reference_Information", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Reference_1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reference_2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reference_Information");
                });

            modelBuilder.Entity("BNI.Models.Domain.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            ID = 2,
                            Name = "User"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Member"
                        });
                });

            modelBuilder.Entity("BNI.Models.Domain.Step", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Business_SupportId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MemberID")
                        .HasColumnType("int");

                    b.Property<int>("Member_Id")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Business_SupportId");

                    b.HasIndex("MemberID");

                    b.ToTable("Step");
                });

            modelBuilder.Entity("BNI.Models.Domain.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<int>("Role_Id")
                        .HasColumnType("int");

                    b.Property<string>("VAT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BNI.Models.Domain.Business_Support", b =>
                {
                    b.HasOne("BNI.Models.Domain.Category_Support", "Category_Support")
                        .WithMany()
                        .HasForeignKey("Category_SupportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BNI.Models.Domain.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category_Support");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("BNI.Models.Domain.Comment", b =>
                {
                    b.HasOne("BNI.Models.Domain.Posts", "Posts")
                        .WithMany("Comments")
                        .HasForeignKey("Posts_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BNI.Models.Domain.User", "User")
                        .WithMany("Comments")
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Posts");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BNI.Models.Domain.Contact", b =>
                {
                    b.HasOne("BNI.Models.Domain.Platform", "Platform")
                        .WithMany()
                        .HasForeignKey("Platform_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Platform");
                });

            modelBuilder.Entity("BNI.Models.Domain.EventsRegister", b =>
                {
                    b.HasOne("BNI.Models.Domain.Events", "Events")
                        .WithMany("EventsRegister")
                        .HasForeignKey("Event_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BNI.Models.Domain.User", "User")
                        .WithMany("EventsRegister")
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Events");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BNI.Models.Domain.Member", b =>
                {
                    b.HasOne("BNI.Models.Domain.AddtionalInformation", "AddtionalInformation")
                        .WithOne("Member")
                        .HasForeignKey("BNI.Models.Domain.Member", "AdditionalInformation_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BNI.Models.Domain.Business_Sector", "Business_Sector")
                        .WithOne("Member")
                        .HasForeignKey("BNI.Models.Domain.Member", "BusinessSector_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BNI.Models.Domain.Membership_Term", "Membership_Term")
                        .WithOne("Member")
                        .HasForeignKey("BNI.Models.Domain.Member", "MembershipTerm_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BNI.Models.Domain.Reference_Information", "Reference_Information")
                        .WithOne("Member")
                        .HasForeignKey("BNI.Models.Domain.Member", "ReferenceInformation_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BNI.Models.Domain.User", "User")
                        .WithOne("Member")
                        .HasForeignKey("BNI.Models.Domain.Member", "UserId");

                    b.Navigation("AddtionalInformation");

                    b.Navigation("Business_Sector");

                    b.Navigation("Membership_Term");

                    b.Navigation("Reference_Information");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BNI.Models.Domain.Posts", b =>
                {
                    b.HasOne("BNI.Models.Domain.Member", "Member")
                        .WithMany()
                        .HasForeignKey("Member_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BNI.Models.Domain.PostsCategory", "PostsCategory")
                        .WithMany("Posts")
                        .HasForeignKey("PostsCategory_ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");

                    b.Navigation("PostsCategory");
                });

            modelBuilder.Entity("BNI.Models.Domain.Step", b =>
                {
                    b.HasOne("BNI.Models.Domain.Business_Support", null)
                        .WithMany("Steps")
                        .HasForeignKey("Business_SupportId");

                    b.HasOne("BNI.Models.Domain.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Member");
                });

            modelBuilder.Entity("BNI.Models.Domain.User", b =>
                {
                    b.HasOne("BNI.Models.Domain.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BNI.Models.Domain.AddtionalInformation", b =>
                {
                    b.Navigation("Member")
                        .IsRequired();
                });

            modelBuilder.Entity("BNI.Models.Domain.Business_Sector", b =>
                {
                    b.Navigation("Member")
                        .IsRequired();
                });

            modelBuilder.Entity("BNI.Models.Domain.Business_Support", b =>
                {
                    b.Navigation("Steps");
                });

            modelBuilder.Entity("BNI.Models.Domain.Events", b =>
                {
                    b.Navigation("EventsRegister");
                });

            modelBuilder.Entity("BNI.Models.Domain.Membership_Term", b =>
                {
                    b.Navigation("Member")
                        .IsRequired();
                });

            modelBuilder.Entity("BNI.Models.Domain.Posts", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("BNI.Models.Domain.PostsCategory", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("BNI.Models.Domain.Reference_Information", b =>
                {
                    b.Navigation("Member")
                        .IsRequired();
                });

            modelBuilder.Entity("BNI.Models.Domain.Role", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("BNI.Models.Domain.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("EventsRegister");

                    b.Navigation("Member");
                });
#pragma warning restore 612, 618
        }
    }
}
