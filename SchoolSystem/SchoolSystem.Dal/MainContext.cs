﻿using Microsoft.EntityFrameworkCore;
using SchoolSystem.Dal.Entities;
using SchoolSystem.Dal.EntityConfiguration;

namespace SchoolSystem.Dal;

public class MainContext : DbContext
{
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<ClassRoom> ClassRooms { get; set; }
    public DbSet<ClassRoomStudent> ClassRoomStudents { get; set; }
    public DbSet<ClassRoomTeacher> ClassRoomTeachers { get; set; }
    public DbSet<TeacherStudent> TeacherStudents { get; set; }

    public MainContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new TeacherStudentConfiguration());
        modelBuilder.ApplyConfiguration(new TeacherConfiguration());
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new ClassRoomTeacherConfiguration());
        modelBuilder.ApplyConfiguration(new ClassRoomStudentConfiguration());
        modelBuilder.ApplyConfiguration(new ClassRoomConfiguration());

        base.OnModelCreating(modelBuilder);
    }

}
