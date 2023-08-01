using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using ScoreCardPlus.Models;
using System.Reflection.Metadata;

namespace ScoreCardPlus
{
    public class ScoreCardDBContext : DbContext
    {

        public DbSet<ScoreCard> ScoreCards { get; set; }
        
        
        public string DbPath { get; }

        public ScoreCardDBContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "scorecards.db");
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        // stored in AppData, hidden
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

    
        

    }
}
