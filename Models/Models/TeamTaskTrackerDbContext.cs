using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Models.Models;

public partial class TeamTaskTrackerDbContext : DbContext
{
    public TeamTaskTrackerDbContext()
    {
    }

    public TeamTaskTrackerDbContext(DbContextOptions<TeamTaskTrackerDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Project> Projects { get; set; }

    public virtual DbSet<ProjectAssignment> ProjectAssignments { get; set; }

    public virtual DbSet<Task> Tasks { get; set; }

    public virtual DbSet<TeamMember> TeamMembers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=TeamTaskTrackerDB;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Project>(entity =>
        {
            entity.HasKey(e => e.ProjectId).HasName("PK__Projects__761ABED0C0714860");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.ProjectName).HasMaxLength(255);
            entity.Property(e => e.StartDate).HasColumnType("date");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<ProjectAssignment>(entity =>
        {
            entity.HasKey(e => e.AssignmentId).HasName("PK__ProjectA__32499E5753367FDA");

            entity.Property(e => e.AssignmentId).HasColumnName("AssignmentID");
            entity.Property(e => e.AssignmentDate).HasColumnType("date");
            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

            entity.HasOne(d => d.Member).WithMany(p => p.ProjectAssignments)
                .HasForeignKey(d => d.MemberId)
                .HasConstraintName("FK__ProjectAs__Membe__29572725");

            entity.HasOne(d => d.Project).WithMany(p => p.ProjectAssignments)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("FK__ProjectAs__Proje__286302EC");
        });

        modelBuilder.Entity<Task>(entity =>
        {
            entity.HasKey(e => e.TaskId).HasName("PK__Tasks__7C6949D1D130340C");

            entity.Property(e => e.TaskId).HasColumnName("TaskID");
            entity.Property(e => e.DueDate).HasColumnType("date");
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Title).HasMaxLength(255);

            entity.HasOne(d => d.AssignedToNavigation).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.AssignedTo)
                .HasConstraintName("FK__Tasks__AssignedT__2D27B809");

            entity.HasOne(d => d.Project).WithMany(p => p.Tasks)
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("FK__Tasks__ProjectID__2C3393D0");
        });

        modelBuilder.Entity<TeamMember>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__TeamMemb__0CF04B38510B8ADF");

            entity.Property(e => e.MemberId).HasColumnName("MemberID");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Role).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
