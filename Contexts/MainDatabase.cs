using System;
using Microsoft.EntityFrameworkCore;

namespace GameAPI.Contexts
{
	public class MainDatabase : DbContext
	{
		protected readonly IConfiguration Configuration;

		public MainDatabase(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
			=> options.UseNpgsql(Configuration.GetConnectionString("GameApiDatabase"));

		public DbSet<User> Users { get; set; }
		public DbSet<Word> Words { get; set; }
	}
}

