﻿// <auto-generated />
using CC.Yi.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CC.Yi.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210405125343_rp1")]
    partial class rp1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("CC.Yi.Model.info_action", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("action_name")
                        .HasColumnType("TEXT");

                    b.Property<string>("icon")
                        .HasColumnType("TEXT");

                    b.Property<int>("is_delete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("router")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("info_action");
                });

            modelBuilder.Entity("CC.Yi.Model.info_role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("is_delete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("role_name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("info_role");
                });

            modelBuilder.Entity("CC.Yi.Model.info_user", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("is_delete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("password")
                        .HasColumnType("TEXT");

                    b.Property<string>("user_name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("info_user");
                });

            modelBuilder.Entity("info_actioninfo_role", b =>
                {
                    b.Property<int>("Info_ActionsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("info_RolesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Info_ActionsId", "info_RolesId");

                    b.HasIndex("info_RolesId");

                    b.ToTable("info_actioninfo_role");
                });

            modelBuilder.Entity("info_actioninfo_user", b =>
                {
                    b.Property<int>("Info_ActionsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Info_UsersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Info_ActionsId", "Info_UsersId");

                    b.HasIndex("Info_UsersId");

                    b.ToTable("info_actioninfo_user");
                });

            modelBuilder.Entity("info_roleinfo_user", b =>
                {
                    b.Property<int>("Info_RolesId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Info_UsersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Info_RolesId", "Info_UsersId");

                    b.HasIndex("Info_UsersId");

                    b.ToTable("info_roleinfo_user");
                });

            modelBuilder.Entity("info_actioninfo_role", b =>
                {
                    b.HasOne("CC.Yi.Model.info_action", null)
                        .WithMany()
                        .HasForeignKey("Info_ActionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CC.Yi.Model.info_role", null)
                        .WithMany()
                        .HasForeignKey("info_RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("info_actioninfo_user", b =>
                {
                    b.HasOne("CC.Yi.Model.info_action", null)
                        .WithMany()
                        .HasForeignKey("Info_ActionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CC.Yi.Model.info_user", null)
                        .WithMany()
                        .HasForeignKey("Info_UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("info_roleinfo_user", b =>
                {
                    b.HasOne("CC.Yi.Model.info_role", null)
                        .WithMany()
                        .HasForeignKey("Info_RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CC.Yi.Model.info_user", null)
                        .WithMany()
                        .HasForeignKey("Info_UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
