using Microsoft.EntityFrameworkCore;
using UniR.Domain.Entities;
using UniR.Domain.Entities.Baas;
using UniR.Domain.Enums;

namespace UniR.Contracts.Interfaces;

public interface IApplicationDbContext
{
    // ====================================
    // Entities Related To Bass Solution
    // ====================================
    public DbSet<User> Users { get; }
    public DbSet<App> UserApps { get; }
    public DbSet<AppSubscription> AppSubscriptions { get; }
    public DbSet<SubscriptionTier>  SubscriptionTiers { get; }
    public DbSet<SubscriptionFeature>  SubscriptionFeatures { get; }
    
    // ====================================
    // Entities Related To Bass App Users
    // ====================================
    public DbSet<AppUser> AppUsers { get; }
    public DbSet<Student> Students { get; }
    public DbSet<Teacher> Teachers { get; }
    public DbSet<Parent>  Parents { get; }
    public DbSet<RolePreset>  RolePresets { get; }
    public DbSet<RolePresetPermissions> PresetPermissions { get; }
    
    // ====================================
    // Entities Related To Bass Academics
    // ====================================
    public DbSet<AcademicProgram> Programs { get; }
    public DbSet<Branch> Branches { get; }
    public DbSet<BranchGrade> BranchGrades { get; }
    public DbSet<Group> Groups { get; }
    public DbSet<Subject> Subjects { get; }
    
    // ====================================
    // Entities Related To Bass pedagogical
    // ====================================
    public DbSet<Enrolment> Enrolments { get; }
    public DbSet<Exam> Exams { get; }
}