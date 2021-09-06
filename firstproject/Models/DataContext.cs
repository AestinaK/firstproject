using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace firstproject.Models
{
	public class DataContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json");

			var configuration = builder.Build();
			optionsBuilder.UseMySql(configuration
				["ConnectionStrings:DefaultConnection"]);

		}

		//Need to register your models here
		public DbSet<Addpg> pgs { get; set; }
		public DbSet<Signin> Signins { get; set; }
		public DbSet<Login> login { get; set; }




	}
}
