﻿// <auto-generated />
using System;
using HKQTravelling.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HKQTravelling.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HKQTravelling.Models.Booking", b =>
                {
                    b.Property<long>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("booking_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("BookingId"));

                    b.Property<DateTime?>("BookingDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("booking_date");

                    b.Property<long?>("TicketInfoId")
                        .HasColumnType("bigint")
                        .HasColumnName("ticket_info_id");

                    b.Property<long?>("TourId")
                        .IsRequired()
                        .HasColumnType("bigint")
                        .HasColumnName("tour_id");

                    b.Property<long?>("UserId")
                        .IsRequired()
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("BookingId");

                    b.HasIndex("TicketInfoId");

                    b.HasIndex("TourId");

                    b.HasIndex("UserId");

                    b.ToTable("bookings");
                });

            modelBuilder.Entity("HKQTravelling.Models.Discount", b =>
                {
                    b.Property<long>("Discount_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("dis_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Discount_Id"));

                    b.Property<DateTime>("CreationDateEnd")
                        .HasColumnType("datetime2")
                        .HasColumnName("dis_dateEnd");

                    b.Property<DateTime>("CreationDateStart")
                        .HasColumnType("datetime2")
                        .HasColumnName("dis_dateStart");

                    b.Property<string>("Discount_Name")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("dis_name");

                    b.Property<float>("Discount_percent")
                        .HasColumnType("real")
                        .HasColumnName("dis_per");

                    b.Property<int?>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.HasKey("Discount_Id");

                    b.HasIndex("Discount_Name")
                        .IsUnique();

                    b.ToTable("discount");
                });

            modelBuilder.Entity("HKQTravelling.Models.Feedback", b =>
                {
                    b.Property<long>("FeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("feedback_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("FeedbackId"));

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)")
                        .HasColumnName("comment");

                    b.Property<long?>("Like")
                        .HasColumnType("bigint")
                        .HasColumnName("like");

                    b.Property<long>("TourId")
                        .HasColumnType("bigint")
                        .HasColumnName("tour_id");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("FeedbackId");

                    b.HasIndex("TourId");

                    b.HasIndex("UserId");

                    b.ToTable("feedbacks");
                });

            modelBuilder.Entity("HKQTravelling.Models.Payment", b =>
                {
                    b.Property<long>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("payment_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PaymentId"));

                    b.Property<long?>("BookingId")
                        .IsRequired()
                        .HasColumnType("bigint")
                        .HasColumnName("booking_id");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("payment_date");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.HasKey("PaymentId");

                    b.HasIndex("BookingId");

                    b.ToTable("payments");
                });

            modelBuilder.Entity("HKQTravelling.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("role_name");

                    b.HasKey("RoleId");

                    b.HasIndex("RoleName")
                        .IsUnique();

                    b.ToTable("roles");
                });

            modelBuilder.Entity("HKQTravelling.Models.TicketInformation", b =>
                {
                    b.Property<long>("TicketInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ticket_info_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TicketInfoId"));

                    b.Property<int>("Adults_Number")
                        .HasColumnType("int")
                        .HasColumnName("adults_number");

                    b.Property<int>("Kid_Age")
                        .HasColumnType("int")
                        .HasColumnName("kid_age");

                    b.Property<int>("Kid_Number")
                        .HasColumnType("int")
                        .HasColumnName("kid_number");

                    b.Property<int?>("TicketTypeId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("ticket_type_id");

                    b.Property<long?>("UserId")
                        .IsRequired()
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.HasKey("TicketInfoId");

                    b.HasIndex("TicketTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("ticket_information");
                });

            modelBuilder.Entity("HKQTravelling.Models.TicketType", b =>
                {
                    b.Property<int>("TicketTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ticket_type_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketTypeId"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("type_name");

                    b.HasKey("TicketTypeId");

                    b.HasIndex("TypeName")
                        .IsUnique();

                    b.ToTable("ticket_types");
                });

            modelBuilder.Entity("HKQTravelling.Models.Tour", b =>
                {
                    b.Property<long>("TourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("tour_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TourId"));

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("creation_date");

                    b.Property<long>("Discount_Id")
                        .HasColumnType("bigint")
                        .HasColumnName("dis_id");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("end_date");

                    b.Property<string>("EndLocation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("end_location");

                    b.Property<int?>("Price")
                        .HasColumnType("int")
                        .HasColumnName("price");

                    b.Property<int?>("Remaining")
                        .HasColumnType("int")
                        .HasColumnName("remaining");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("start_date");

                    b.Property<string>("StartLocation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("start_location");

                    b.Property<int?>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<string>("TourName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("tour_name");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("update_date");

                    b.HasKey("TourId");

                    b.HasIndex("Discount_Id");

                    b.ToTable("tours");
                });

            modelBuilder.Entity("HKQTravelling.Models.TourDay", b =>
                {
                    b.Property<long>("TourDayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("tour_day_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TourDayId"));

                    b.Property<int?>("DayNumber")
                        .HasColumnType("int")
                        .HasColumnName("day_number");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("destination");

                    b.Property<DateTime?>("TimeSchedule")
                        .HasColumnType("datetime2")
                        .HasColumnName("time_schedule");

                    b.Property<long?>("TourId")
                        .IsRequired()
                        .HasColumnType("bigint")
                        .HasColumnName("tour_id");

                    b.HasKey("TourDayId");

                    b.HasIndex("TourId");

                    b.ToTable("tour_days");
                });

            modelBuilder.Entity("HKQTravelling.Models.TourImage", b =>
                {
                    b.Property<long>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("image_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ImageId"));

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("image_url");

                    b.Property<long?>("TourId")
                        .IsRequired()
                        .HasColumnType("bigint")
                        .HasColumnName("tour_id");

                    b.HasKey("ImageId");

                    b.HasIndex("TourId");

                    b.ToTable("tour_images");
                });

            modelBuilder.Entity("HKQTravelling.Models.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserId"));

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("creation_date");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("password");

                    b.Property<int?>("RoleId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<int?>("Status")
                        .HasColumnType("int")
                        .HasColumnName("status");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("update_date");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("username");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("users");
                });

            modelBuilder.Entity("HKQTravelling.Models.UserDetails", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint")
                        .HasColumnName("user_id");

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime2")
                        .HasColumnName("birthdate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("full_name");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("gender");

                    b.Property<string>("NI_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NI_number");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("phone_number");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("user_details");
                });

            modelBuilder.Entity("HKQTravelling.Models.Booking", b =>
                {
                    b.HasOne("HKQTravelling.Models.TicketInformation", "TicketInformation")
                        .WithMany()
                        .HasForeignKey("TicketInfoId");

                    b.HasOne("HKQTravelling.Models.Tour", "Tour")
                        .WithMany()
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HKQTravelling.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TicketInformation");

                    b.Navigation("Tour");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HKQTravelling.Models.Feedback", b =>
                {
                    b.HasOne("HKQTravelling.Models.Tour", "Tour")
                        .WithMany("Feedbacks")
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HKQTravelling.Models.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HKQTravelling.Models.Payment", b =>
                {
                    b.HasOne("HKQTravelling.Models.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("HKQTravelling.Models.TicketInformation", b =>
                {
                    b.HasOne("HKQTravelling.Models.TicketType", "TicketType")
                        .WithMany()
                        .HasForeignKey("TicketTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HKQTravelling.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TicketType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HKQTravelling.Models.Tour", b =>
                {
                    b.HasOne("HKQTravelling.Models.Discount", "Discount")
                        .WithMany()
                        .HasForeignKey("Discount_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discount");
                });

            modelBuilder.Entity("HKQTravelling.Models.TourDay", b =>
                {
                    b.HasOne("HKQTravelling.Models.Tour", "Tour")
                        .WithMany()
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("HKQTravelling.Models.TourImage", b =>
                {
                    b.HasOne("HKQTravelling.Models.Tour", "Tour")
                        .WithMany()
                        .HasForeignKey("TourId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tour");
                });

            modelBuilder.Entity("HKQTravelling.Models.User", b =>
                {
                    b.HasOne("HKQTravelling.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("HKQTravelling.Models.UserDetails", b =>
                {
                    b.HasOne("HKQTravelling.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("HKQTravelling.Models.Tour", b =>
                {
                    b.Navigation("Feedbacks");
                });

            modelBuilder.Entity("HKQTravelling.Models.User", b =>
                {
                    b.Navigation("Feedbacks");
                });
#pragma warning restore 612, 618
        }
    }
}
