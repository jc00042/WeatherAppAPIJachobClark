using WeatherAppAPI.Entities;
using Microsoft.EntityFrameworkCore;

//This API done by Jachob Clark

namespace WeatherAppAPI.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options) 
        { }
        public DbSet<NewPlayer> NewPlayer {  get; set; }

        public DbSet<Team> Team { get; set; }

        public DbSet<Match> Match { get; set; }

        public DbSet<MatchResults> MatchResults { get; set; }
    }
}

