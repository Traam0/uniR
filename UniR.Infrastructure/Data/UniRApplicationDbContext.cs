using Microsoft.EntityFrameworkCore;
using UniR.Contracts.Interfaces;
using UniR.Domain.Entities;
using UniR.Domain.Entities.Baas;

namespace UniR.Infrastructure.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options), IApplicationDbContext
{
    // ====================================
    // Entities Related To Bass Solution
    // ====================================
    public DbSet<User> Users { get; set; }
    public DbSet<App> UserApps { get; set; }
    public DbSet<AppSubscription> AppSubscriptions { get; set; }
    public DbSet<SubscriptionTier> SubscriptionTiers { get; set; }
    public DbSet<SubscriptionFeature> SubscriptionFeatures { get; set; }

    // ====================================
    // Entities Related To Bass App Users
    // ====================================
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Parent> Parents { get; set; }
    public DbSet<RolePreset> RolePresets { get; set; }
    public DbSet<RolePresetPermissions> PresetPermissions { get; set; }

    // ====================================
    // Entities Related To Bass Academics
    // ====================================
    public DbSet<AcademicProgram> Programs { get; set; }
    public DbSet<Branch> Branches { get; set; }
    public DbSet<BranchGrade> BranchGrades { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Subject> Subjects { get; set; }

    // ====================================
    // Entities Related To Bass pedagogical
    // ====================================
    public DbSet<Enrolment> Enrolments { get; set; }
    public DbSet<Exam> Exams { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(typeof(InfrastructureMarker).Assembly);
    }
}