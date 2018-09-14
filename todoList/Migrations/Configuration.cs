using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Migrations;
using System.Web;
using todoList.Data;

namespace todoList.Migrations
{
	public class Configuration : DbMigrationsConfiguration<TodoDbContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled = false;
		}
	}
}