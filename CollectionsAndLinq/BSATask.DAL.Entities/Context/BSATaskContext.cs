using BASTask.DAL.Entities;
using Bogus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = BASTask.DAL.Entities.Task;

namespace BSATask.DAL.Context
{
    public class BSATaskContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Project> Projects { get; set; }

        private int TOTAL_COUNT = 20;
        private Random _rnd = new Random();

        public BSATaskContext(DbContextOptions<BSATaskContext> options) : base(options) 
        {
            Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<User>().HasMany(t => t.Tasks).WithOne(u => u.User).HasForeignKey(p => p.PerformerId);
            modelBuilder.Entity<User>().HasMany(p => p.Projects).WithOne(u => u.User).HasForeignKey(k => k.AuthorId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Team>().HasMany(u => u.Users).WithOne(t => t.Team).HasForeignKey(k => k.TeamId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Team>().HasMany(p => p.Projects).WithOne(t => t.Team).HasForeignKey(k => k.TeamId);
            modelBuilder.Entity<Project>().HasMany(t => t.Tasks).WithOne(u => u.Project).HasForeignKey(p => p.ProjectId);

            var teams = GenerateRandomTeams();
            var users = GenerateRandomUsers(teams);
            var projects = GenerateRandomProjects(teams, users);
            var tasks = GenerateRandomTasks(projects, users);

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Team>().HasData(teams);
            modelBuilder.Entity<Task>().HasData(tasks);
            modelBuilder.Entity<Project>().HasData(projects);
        }


        private ICollection<Team> GenerateRandomTeams()
        {
            int teamId = 1;

            var fakeTeams = new Faker<Team>()
                    .RuleFor(k => k.Id, f => teamId++)
                    .RuleFor(n => n.Name, f => f.Name.FullName())
                    .RuleFor(t => t.CreatedAt, f => f.Date.Between(DateTime.UtcNow.AddYears(-10), DateTime.UtcNow));
            return fakeTeams.Generate(TOTAL_COUNT);
        }
        private ICollection<User> GenerateRandomUsers(ICollection<Team> teams)
        {
            int userId = 1;

            var fakeUsers = new Faker<User>()
                    .RuleFor(k => k.Id, f => userId++)
                    .RuleFor(t => t.TeamId, f => f.PickRandom(teams).Id)
                    .RuleFor(n => n.FirstName, f => f.Name.FirstName())
                    .RuleFor(n => n.LastName, f => f.Name.LastName())
                    .RuleFor(m => m.Email, f => f.Internet.Email())
                    .RuleFor(b => b.BirthDay, f => f.Date.Between(DateTime.UtcNow.AddYears(-30), DateTime.UtcNow))
                    .RuleFor(r => r.RegisteredAt, f => f.Date.Between(DateTime.UtcNow.AddYears(-10), DateTime.UtcNow));
            return fakeUsers.Generate(TOTAL_COUNT);
        }
        private ICollection<Project> GenerateRandomProjects(ICollection<Team> teams, ICollection<User> users)
        {
            int projectId = 1;

            var fakeProjects = new Faker<Project>()
                    .RuleFor(k => k.Id, f => projectId++)
                    .RuleFor(u => u.AuthorId, f => f.PickRandom(users).Id)
                    .RuleFor(t => t.TeamId, f => f.PickRandom(teams).Id)
                    .RuleFor(n => n.Name, f => f.Name.FullName())
                    .RuleFor(d => d.Description, f => f.Lorem.Text())
                    .RuleFor(b => b.CreatedAt, f => f.Date.Between(DateTime.UtcNow.AddYears(-10), DateTime.UtcNow))
                    .RuleFor(r => r.Deadline, f => f.Date.Between(DateTime.UtcNow.AddYears(-5), DateTime.MaxValue));
            return fakeProjects.Generate(TOTAL_COUNT);
        }

        private ICollection<Task> GenerateRandomTasks(ICollection<Project> projects, ICollection<User> users)
        {
            var taskId = 1;

            var fakeTasks = new Faker<Task>()
                      .RuleFor(k => k.Id, f => taskId++)
                      .RuleFor(p => p.PerformerId, f => f.PickRandom(users).Id)
                      .RuleFor(p => p.ProjectId, f => f.PickRandom(projects).Id)
                      .RuleFor(n => n.Name, f => f.Name.FullName())
                      .RuleFor(d => d.Description, f => f.Lorem.Text())
                      .RuleFor(s => s.State, f => (TaskState)_rnd.Next(0, 3))
                      .RuleFor(b => b.CreatedAt, f => f.Date.Between(DateTime.UtcNow.AddYears(-10), DateTime.UtcNow))
                      .RuleFor(c => c.FinishedAt, f => f.Date.Between(DateTime.UtcNow.AddYears(-1), DateTime.MaxValue));
            return fakeTasks.Generate(TOTAL_COUNT);

        }
    }
}
