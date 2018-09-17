using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace todoList.Models
{
	public class Tache
	{
		public int ID { get; set; }

		public string Nom { get;set;}

		public string Description { get; set; }

		public DateTime? DateFin { get; set; }

		public bool Statut { get; set; }

		public int? Priorite { get; set; }

		public int CategorieID { get; set; }

		[ForeignKey("CategorieID")]
		public Categorie Categorie { get; set; }
	}
}