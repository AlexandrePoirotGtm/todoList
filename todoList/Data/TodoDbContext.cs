using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using todoList.Models;

namespace todoList.Data
{
	public class TodoDbContext : DbContext
	{
		public TodoDbContext() : base("TodoListConnectionString")
		{
		}

		public DbSet<Categorie> Categories { get; set; }

		public System.Data.Entity.DbSet<todoList.Models.Tache> Taches { get; set; }
	}
}